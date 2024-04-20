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
    public partial class formSignUp : Form
    {
 
        private ThongTinTaiKhoan userAccount;

        public Action<ThongTinTaiKhoan> AccountCreated { get; internal set; }

        public formSignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxDichVuDangKy_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBoxDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void txtTen_MouseClick(object sender, MouseEventArgs e)
        {
            txtTen.Clear();
        }

        private void txtHo_MouseClick(object sender, MouseEventArgs e)
        {
            txtHo.Clear();
        }

        private void txtSoDienThoai_MouseClick(object sender, MouseEventArgs e)
        {
            txtSoDienThoai.Clear();
        }

        private void txtMatKhau_MouseClick(object sender, MouseEventArgs e)
        {
            txtMatKhau.Clear();
        }

        private void formSignUp_Load(object sender, EventArgs e)
        {

        }

        private void txtXacNhanMatKhau_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtXacNhanMatKhau.Clear();
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            formSignUp g = new formSignUp();
            DangKy dangKy = new DangKy();
            dangKy.SignUp(txtSoDienThoai, txtMatKhau, txtXacNhanMatKhau, txtHo, txtTen,  checkedListBoxDichVu,g);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formSplash().Show();
        }
    }
}
