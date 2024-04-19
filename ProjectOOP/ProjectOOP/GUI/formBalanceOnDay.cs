using ProjectOOP.Class;
using ProjectOOP.DATA;
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
        string fileOrder = @"FilePathOrder.txt";// Đường dẫn tới tệp tin lưu thông tin biên dịch
        Data data = new Data();
        List<Label> labels = new List<Label>();
        
        public formBalancefortheday()
        {
            InitializeComponent();
            timer1.Start();
            Lock();

        }
        private void formBalancefortheday_Load(object sender, EventArgs e)
        {
            
            PerformToDay();
            LoadHistory(fileOrder);
        }
        public void LoadHistory(string fileOrder)
        {
            int x = data.ReadFile(fileOrder);
            lblAllOrder.Text = x.ToString();
            lblPoint.Text = (data.ReadFile(fileOrder) * 5).ToString();
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            for (int i = 0; i<x; i++)
            {

                Products pr=data.Deserialize(i,fileOrder);
                switch(pr.Type)
                {
                    case "Food":
                        a += pr.Price;
                        break;
                    case "Thing":
                        b += pr.Price;
                        break;
                    case "xThing":
                        c += pr.Price;
                        break;
                    case "Trip":
                        d += pr.Price;
                        break;
                }
            }
            lblPriceFood.Text = a.ToString()  +",000đ";
            lblPriceThing.Text = b.ToString() + ",000đ";
            lblPricexThing.Text = c.ToString() + ",000đ";
            lblPriceTrip.Text = d.ToString() + ",000đ";
            label3.Text=(a+b+c+d).ToString() + ",000đ";
            lblTotal.Text = ((a + b + c + d) * 0.8).ToString() + ",000đ";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide();
            new formNav().ShowDialog();
            Close();
        }
        private void PerformToDay()
        {

            DateTime now = DateTime.Now;

            string formattedDateTime = now.ToString("dddd, dd/MM/yyyy");
            lblDay.Text = formattedDateTime;
        }
        private void Lock()
        {
            int second = GlobalData.CurrentTripTime;
            if (!GlobalData.IsInTrip) return;
            lblTime.Text = $"{second / 60:00}:{second % 60:00}";
            GlobalData.CurrentTripTime++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Lock();
            label10.Text = DateTime.Now.ToShortTimeString();
        }
        public void StartClock()
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
