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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectOOP
{
    public partial class formContinue : Form
    {
        Manager manager = new Manager();
        Products product = new Products();
        Data data = new Data();
        public formContinue()
        {
            InitializeComponent();
        }

        public formContinue(Products pr)
        {
            InitializeComponent();
            product = pr;
        }

        private void formContinue_Load(object sender, EventArgs e)
        {

        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            data.WriteCompileInfo(@"C:\Users\ACER\Downloads\Order.txt", product);
            new formNav().ShowDialog();
        }
    }
}
