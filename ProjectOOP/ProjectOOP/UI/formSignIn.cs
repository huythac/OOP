using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOOP.Class;
using ProjectOOP_DangNhap;


namespace ProjectOOP
{
    public partial class formSignIn : Form
    {
        public delegate void AccountLoggedInEventHandler(ThongTinTaiKhoan account); // Moved delegate here
        public event AccountLoggedInEventHandler AccountLoggedIn;

        private List<ThongTinTaiKhoan> listTaiKhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;

        public formSignIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;

            if (DangNhap.KiemTraDangNhap(phoneNumber, password)) // Use static method
            {
                ThongTinTaiKhoan loggedInAccount = new ThongTinTaiKhoan(null, phoneNumber, password); // Assuming fullName isn't required for login
                formHome fHome = new formHome();
                fHome.Show();
                this.Hide();
                AccountLoggedIn?.Invoke(loggedInAccount); // Call event if needed
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Vui lòng đăng nhập lại");
                txtPhoneNumber.Focus();
            }
        }
        public static class DangNhap // Made DangNhap static class
        {
            public static bool KiemTraDangNhap(string phoneNumber, string password)
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
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {

            new formHome().Show();
            this.Hide();
        }

        private void btnApple_Click(object sender, EventArgs e)
        {

            new formHome().Show();
            this.Hide();
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {

            new formHome().Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new formSplash().Show();
            this.Hide();
        }
    }
}
