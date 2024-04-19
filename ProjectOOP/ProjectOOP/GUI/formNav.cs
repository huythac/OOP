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
            new formHome().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new formBalancefortheday().ShowDialog();
            Close();
        }

        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            new formInfoAccount().Show();
            this.Hide();
        }

        private void btnLichSuChuyenDi_Click(object sender, EventArgs e)
        {
            new formHistory().Show();
            this.Hide();
        }

        private void formNav_Load(object sender, EventArgs e)
        {

        }

        private void btnTaiKhoanThanhToan_Click(object sender, EventArgs e)
        {
            
        }
    }
}
