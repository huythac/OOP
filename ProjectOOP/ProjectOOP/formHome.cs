using ProjectOOP.Class;
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
        private formBalancefortheday balanceForm; 
        public formHome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            balanceForm = new formBalancefortheday(); 
        }

        private void formHome_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new formNav().Show();
            this.Hide();
        }
        private void Lock()
        {
            GlobalData.CurrentTripTime++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Lock();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            new formPeople().Show();
            this.Hide();
            GlobalData.IsInTrip = true;
        }
        }
    }
