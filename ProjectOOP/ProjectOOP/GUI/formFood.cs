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
//using ProjectOOP.DATA;
using ProjectOOP.Class;

namespace ProjectOOP
{
    public partial class formFood : Form
    {
        Data data = new Data();
        Products products = new Products();
        Manager manager = new Manager();
        string compileInfoPath = @"FilePathProducts.txt";
        string fileOrder = @"FilePathOrder.txt";// Đường dẫn tới tệp tin lưu thông tin biên dịch
        public formFood()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            lblLocationFrom.Text = "";
            lblLocationTo.Text = "";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn muốn nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Hide();
                new formMoving(products).ShowDialog();
                Close();
            }

        }
        private void Location(int toaDo)
        {
            products = data.Deserialize(toaDo, compileInfoPath);
            lblLocationFrom.Text = products.LocationFrom;
            lblLocationTo.Text = products.LocationTo;
        }
        private int TypeProduct(int typeProduct)
        {
            if (typeProduct == 0)
                label1.Text = "UEH Food";
            else if (typeProduct == 1)
                label1.Text = "UEH Thing";
            else if (typeProduct == 2)
                label1.Text = "UEH xThing";
            else
                label1.Text = "UEH Trip";

            return typeProduct;
        }
        private void formFood_Load(object sender, EventArgs e)
        {
            lstProducts.Columns[0].Width = (int)(lstProducts.Width * 0.2);
            lstProducts.Columns[1].Width = (int)(lstProducts.Width * 0.5);
            lstProducts.Columns[2].Width = (int)(lstProducts.Width * 0.3);

            manager.GetProducts(lstProducts);
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            Hide();
            new formChiTiet(products).ShowDialog();
            Close();
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItems.Count > 0)
            {
                ListViewItem lst = lstProducts.SelectedItems[0];
                string title = lst.SubItems[1].Text;
                label1.Text = "UEH " + title;
                int index = int.Parse(lst.SubItems[0].Text);

                // Dựa vào giá trị của cột đầu tiên, cập nhật giá trị của Label LocationFrom và Label LocationTo
                switch (index)
                {
                    case 1:
                        TypeProduct(0);
                        lblLocationFrom.Text = "";
                        lblLocationTo.Text = "";
                        Location(0);
                        break;
                    case 2:
                        TypeProduct(1);
                        lblLocationFrom.Text = "";
                        lblLocationTo.Text = "";
                        Location(1);
                        break;
                    case 3:
                        TypeProduct(2);
                        lblLocationFrom.Text = "";
                        lblLocationTo.Text = "";
                        Location(2);
                        break;
                    default:
                        TypeProduct(3);
                        lblLocationFrom.Text = "";
                        lblLocationTo.Text = "";
                        Location(3);
                        break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text=DateTime.Now.ToLongDateString()+"\n"+DateTime.Now.ToLongTimeString();
        }
    }
}
