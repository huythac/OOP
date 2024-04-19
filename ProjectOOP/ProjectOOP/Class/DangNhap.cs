using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOOP_DangNhap;
using ProjectOOP.Class;
using ProjectOOP;

namespace ProjectOOP_DangNhap
{
    public class DangNhap
    {
        public DangNhap() { }   
        public delegate void AccountCreatedEventHandler(ThongTinTaiKhoan newAccount);
        public event AccountCreatedEventHandler AccountCreated;

        private bool KiemTraDangNhap(string fullName, string phoneNumber, string password)
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

        public void SignIn(TextBox txtFullName, TextBox txtPhoneNumber, TextBox txtPassword, Form form)
        {
            string fullName = txtFullName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;

            if (KiemTraDangNhap(fullName, phoneNumber, password))
            {
                formHome fHome = new formHome();
                fHome.Show();
                form.Hide();
               AccountCreated?.Invoke(new ThongTinTaiKhoan(fullName,phoneNumber, password));
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Vui lòng đăng nhập lại");
                txtPhoneNumber.Focus();
            }
        }
    }
}
