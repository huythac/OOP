using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP
{
    public partial class formNav : Form
    {
        public formNav()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnStartNow_Click(object sender, EventArgs e)
        {

            this.Hide();
            new formHome().Show();
        }

        private void btnThuNhapSoDu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formBalancefortheday().ShowDialog();
        }

        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {

            this.Hide();
            new formInfoAccount().Show();
        }

        private void btnLichSuChuyenDi_Click(object sender, EventArgs e)
        {

            this.Hide();
            new formHistory().Show();

        }

        private void formNav_Load(object sender, EventArgs e)
        {

        }

        private void btnTaiKhoanThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formWallet().ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formHome().ShowDialog();
        }
    }
}
