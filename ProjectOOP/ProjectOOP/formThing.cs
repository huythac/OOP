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
    public partial class formPeople : Form
    {
        public formPeople()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            new formNav().Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            new formContinueThing().Show();
            this.Hide();
        }

        private void formPeople_Load(object sender, EventArgs e)
        {

        }
    }
}
