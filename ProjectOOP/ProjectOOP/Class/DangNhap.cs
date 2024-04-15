using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP.Class
{
    public class DangNhap
    {
        public delegate void AccountCreatedEventHandler(ThongTinTaiKhoan newAccount);
        public event AccountCreatedEventHandler AccountCreated;

        private bool KiemTraDangNhap(string phoneNumber, string password)
        {
            foreach (ThongTinTaiKhoan taiKhoan in DanhSachTaiKhoan.Instance.ListTaiKhoan)
            {
                if (phoneNumber == taiKhoan.PhoneNumber && password == taiKhoan.Password)
                {
                    return true;
                }
            }
            return false;
        }

        public void SignIn( TextBox txtPhoneNumber, TextBox txtPassword, Form form)
        {
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;

            if (KiemTraDangNhap(phoneNumber, password))
            {
                formHome fHome = new formHome();
                fHome.Show();
                form.Hide();

                // Raise the event
                AccountCreated?.Invoke(new ThongTinTaiKhoan(phoneNumber, password));
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Vui lòng đăng nhập lại");
                txtPhoneNumber.Focus();
            }
        }
    }
}
