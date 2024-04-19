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
            Close();
        }

        private void btnThuNhapSoDu_Click(object sender, EventArgs e)
        {
            Hide();
            new formBalancefortheday().ShowDialog();
            Close();
        }

        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {

            this.Hide();
            new formInfoAccount().Show();
            Close();
        }

        private void btnLichSuChuyenDi_Click(object sender, EventArgs e)
        {

            this.Hide();
            new formHistory().Show();
            Close();
        }

        private void formNav_Load(object sender, EventArgs e)
        {

        }

        private void btnTaiKhoanThanhToan_Click(object sender, EventArgs e)
        {
            Hide();
            new formWallet().ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new formHome().ShowDialog();
            Close();
        }
    }
}
