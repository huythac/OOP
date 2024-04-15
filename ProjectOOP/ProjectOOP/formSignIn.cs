using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOOP.Class;

namespace ProjectOOP
{
    public partial class formSignIn : Form
    {
        List<ThongTinTaiKhoan> listTaiKhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;

        public delegate void AccountCreatedEventHandler(ThongTinTaiKhoan newAccount);

        public formSignIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        internal static void ShowDiaLog()
        {
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.SignIn( txtPhoneNumber, txtPassword, this);
        }



        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void formSignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new formSplash().Show();
            this.Hide();
        }
    }
}
