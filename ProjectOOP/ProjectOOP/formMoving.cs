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
    public partial class formMoving : Form
    {
        public formMoving()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            new formCompleted().Show();
            this.Hide();
        }

        private void formMoving_Load(object sender, EventArgs e)
        {

        }
    }
}
