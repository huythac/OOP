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
    public partial class formMoving : Form
    {
        Products product = new Products();
        Data data = new Data();
        public formMoving()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public formMoving(Products pr)
        {
            InitializeComponent();
            product = pr;
        }
        private void formMoving_Load(object sender, EventArgs e)
        {
            lblTypeProduct.Text = "UEH " + product.Type;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSuccess_Click_1(object sender, EventArgs e)
        {
            data.WriteCompileInfo(@"FilePathOrder.txt", product);

            Hide();
            new formCompleted().ShowDialog();

        }
    }
}

