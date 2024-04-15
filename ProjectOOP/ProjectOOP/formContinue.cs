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
    public partial class formContinue : Form
    {
        public formContinue()
        {
            InitializeComponent();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            Hide();
            new formChiTiet().ShowDialog();
            Close();
        }
    }
}
