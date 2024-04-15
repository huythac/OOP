using ProjectOOP.Class;
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
    public partial class formBalancefortheday : Form
    {
        public formBalancefortheday()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void formBalancefortheday_Load(object sender, EventArgs e)
        {
            PerformToDay();
            Lock();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new formNav().Show();
            this.Hide();
        }
        private void PerformToDay()
        {

            DateTime now = DateTime.Now;

            string formattedDateTime = now.ToString("dddd, dd/MM/yyyy");
            lblDay.Text = formattedDateTime;
        }
        private void Lock()
        {
            if (!GlobalData.IsInTrip) return;
            int second = GlobalData.CurrentTripTime;
            lblTime.Text = $"{second / 60:00}:{second % 60:00}";
            GlobalData.CurrentTripTime++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Lock();
        }
        public void StartClock()
        {
        }
    }
}
