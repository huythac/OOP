using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOOP.Class;
//using ProjectOOP.DATA;

namespace ProjectOOP
{
    public partial class formChiTiet : Form
    {
        Data data = new Data();
        Products products = new Products();
        Manager manager = new Manager();
        public formChiTiet()
        {
            InitializeComponent();
        }
        public formChiTiet(Products products)
        {
            InitializeComponent();
            loadListView(products);
        }
        private void formChiTiet_Load(object sender, EventArgs e)
        {
            
        }

        private void loadListView(Products products)
        {
            ListView lstHangHoa = new ListView();
            Panel panelThongTinDonHang = new Panel();


            panelThongTinDonHang.Location = new Point(4, 355);
            panelThongTinDonHang.Name = "panelThongTinDon";
            panelThongTinDonHang.AutoSize = false;
            panelThongTinDonHang.Size = new Size(368, 209);
            panelThongTinDonHang.TabIndex = 21;


            // Thêm ListView vào Panel
            panelThongTinDonHang.Controls.Add(lstHangHoa);
            panelThongTinDonHang.Controls.Add(label1);
            // 
            // lstHangHoa
            // 
            lstHangHoa.Columns.AddRange(new ColumnHeader[] { clnTenHang, clnChiTiet, clnThanhTien });
            lstHangHoa.Location = new Point(3, 7);
            lstHangHoa.Name = "lstHangHoa";
            lstHangHoa.Size = new Size(361, 193);
            lstHangHoa.Columns[0].Width = (int)(lstHangHoa.Width * 0.25);
            lstHangHoa.Columns[1].Width = (int)(lstHangHoa.Width * 0.5);
            lstHangHoa.Columns[2].Width = (int)(lstHangHoa.Width * 0.25);
            lstHangHoa.TabIndex = 3;
            lstHangHoa.UseCompatibleStateImageBehavior = false;
            lstHangHoa.View = View.Details;

            // Thêm Panel vào Form
            Controls.Add(panelThongTinDonHang);
            //Tải dữ liệu vào ListView
            ListViewItem item = lstHangHoa.Items.Add(products.ProductName);
            item.SubItems.Add(products.Note);
            item.SubItems.Add(products.Price.ToString());

            lblLocationFrom.Text=products.LocationFrom.ToString();
            lblLocationTo.Text=products.LocationTo.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new formFood().ShowDialog();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
