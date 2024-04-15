using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;

namespace ProjectOOP
{
    public partial class formFood : Form
    {
        Data data = new Data();
        Products products = new Products();
        Random random = new Random();
        public formFood()
        {
            InitializeComponent();

        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            randomTypeProduct();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            Hide();
            new formContinue().ShowDialog();
            Close();
        }
        private int randomTypeProduct()
        {
            int typeProduct = random.Next(1, 4);
            if (typeProduct == 1)
                label1.Text = "UEH Food";
            else if (typeProduct == 2)
                label1.Text = "UEH Thing";
            else if (typeProduct == 3)
                label1.Text = "UEH Trip";
            else
                label1.Text = "UEH xThing";

            return typeProduct;
        }
        private void formFood_Load(object sender, EventArgs e)
        {
            randomTypeProduct();
            products = data.Deserialize(randomTypeProduct());
            lblLocationFrom.Text = products.LocationFrom;
            lblLocationTo.Text = products.LocationTo;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            if (randomTypeProduct() == 1)
            {

            }
            else if(randomTypeProduct() == 2)
            {
                lblGia.Text = products.Price.ToString() + ",000";
            }
            else if(randomTypeProduct() == 3)
            {
                lblGia.Text = products.Price.ToString() + ",000";
            }
        }
    }
}
