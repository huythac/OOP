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
    public partial class formCompleted : Form
    {
        public formCompleted()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void lblDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            Hide();
            new formHome().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formCompleted_Load(object sender, EventArgs e)
        {

        }
    }
}
