using ProjectOOP.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void formHome_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formNav().ShowDialog();
        }
        private void Lock()
        {
            if (GlobalData.IsInTrip)
            GlobalData.CurrentTripTime++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Lock();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Hide();
            new formFood().ShowDialog();
            Close();
            GlobalData.IsInTrip = true;
        }
    }
}
