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
    public partial class formHistory : Form
    {
        Data data = new Data();
        string fileOrder = @"FilePathOrder.txt";
        public formHistory()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void formHistory_Load(object sender, EventArgs e)
        {
            LoadOrder(fileOrder);
        }
        public void LoadOrder(string fileOrder)
        {

            int x = data.ReadFile(fileOrder);
            for (int i = 0; i < x; i++)
            {
                Products pr = data.Deserialize(i, fileOrder);
                Panel panel2 = new Panel();
                Label lblLocationFrom = new Label();
                Label lblLocationTo = new Label();
                Button btnChiTiet = new Button();
                Button lblTypeProduct = new Button();
                // 
                // panel2
                // 
                panel2.Controls.Add(lblTypeProduct);
                panel2.Controls.Add(btnChiTiet);
                panel2.Controls.Add(lblLocationTo);
                panel2.Controls.Add(lblTypeProduct);
                panel2.Controls.Add(lblLocationFrom);
                panel2.BorderStyle = BorderStyle.FixedSingle;
                panel2.Location = new Point(3, 3);
                panel2.Name = "panel2";
                panel2.Size = new Size(347, 182);
                panel2.TabIndex = 0;
                // 
                // lblTypeProduct
                // 
                lblTypeProduct.BackColor = Color.Silver;
                lblTypeProduct.Location = new Point(4, 0);
                lblTypeProduct.Name = "lblTypeProduct";
                lblTypeProduct.Size = new Size(96, 25);
                lblTypeProduct.TabIndex = 0;
                lblTypeProduct.Text = pr.Type;
                // 
                // lblLocationFrom
                // 
                lblLocationFrom.BackColor = Color.Silver;
                lblLocationFrom.Location = new Point(27, 34);
                lblLocationFrom.Name = "lblLocationFrom";
                lblLocationFrom.Size = new Size(302, 43);
                lblLocationFrom.TabIndex = 1;
                lblLocationFrom.Text = pr.LocationFrom;
                // 
                // lblLocationTo
                // 
                lblLocationTo.BackColor = Color.Silver;
                lblLocationTo.Location = new Point(27, 86);
                lblLocationTo.Name = "lblLocationTo";
                lblLocationTo.Size = new Size(302, 43);
                lblLocationTo.TabIndex = 2;
                lblLocationTo.Text = pr.LocationTo;
                //
                // button 1
                //
                btnChiTiet.Location = new Point(210, 144);
                btnChiTiet.Name = "button1";
                btnChiTiet.Size = new Size(119, 29);
                btnChiTiet.TabIndex = 3;
                btnChiTiet.Text = "Chi Tiết";
                btnChiTiet.UseVisualStyleBackColor = true;
                // 
                // flowLayoutPanel1
                // 
                flowLayoutPanel1.Controls.Add(panel2);
            }


        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            new formNav().Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {

            }
        }
        public void LoadCombobox(Products pr)
        {
            Panel panel2 = new Panel();
            Label lblLocationFrom = new Label();
            Label lblLocationTo = new Label();
            Button btnChiTiet = new Button();
            Button lblTypeProduct = new Button();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTypeProduct);
            panel2.Controls.Add(btnChiTiet);
            panel2.Controls.Add(lblLocationTo);
            panel2.Controls.Add(lblTypeProduct);
            panel2.Controls.Add(lblLocationFrom);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 182);
            panel2.TabIndex = 0;
            // 
            // lblTypeProduct
            // 
            lblTypeProduct.BackColor = Color.Silver;
            lblTypeProduct.Location = new Point(4, 0);
            lblTypeProduct.Name = "lblTypeProduct";
            lblTypeProduct.Size = new Size(96, 25);
            lblTypeProduct.TabIndex = 0;
            lblTypeProduct.Text = pr.Type;
            // 
            // lblLocationFrom
            // 
            lblLocationFrom.BackColor = Color.Silver;
            lblLocationFrom.Location = new Point(27, 34);
            lblLocationFrom.Name = "lblLocationFrom";
            lblLocationFrom.Size = new Size(302, 43);
            lblLocationFrom.TabIndex = 1;
            lblLocationFrom.Text = pr.LocationFrom;
            // 
            // lblLocationTo
            // 
            lblLocationTo.BackColor = Color.Silver;
            lblLocationTo.Location = new Point(27, 86);
            lblLocationTo.Name = "lblLocationTo";
            lblLocationTo.Size = new Size(302, 43);
            lblLocationTo.TabIndex = 2;
            lblLocationTo.Text = pr.LocationTo;
            //
            // button 1
            //
            btnChiTiet.Location = new Point(210, 144);
            btnChiTiet.Name = "button1";
            btnChiTiet.Size = new Size(119, 29);
            btnChiTiet.TabIndex = 3;
            btnChiTiet.Text = "Chi Tiết";
            btnChiTiet.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            int x = data.ReadFile(fileOrder);

            for (int i = 0; i < x; i++)
            {
                Products pr = data.Deserialize(i, fileOrder);
                if (comboBox1.SelectedIndex == 0)
                {
                    switch (pr.Type)
                    {
                        case "Food":
                            LoadCombobox(pr); break;
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    switch (pr.Type)
                    {
                        case "Thing":
                            LoadCombobox(pr); break;
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    switch (pr.Type)
                    {
                        case "xThing":
                            LoadCombobox(pr); break;
                    }
                }
                else
                {
                    switch (pr.Type)
                    {
                        case "Trip":
                            LoadCombobox(pr); break;
                    }
                }
            }
        }
    }
}
