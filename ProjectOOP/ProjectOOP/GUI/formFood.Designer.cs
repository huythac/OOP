namespace ProjectOOP
{
    partial class formFood
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnTuChoi = new Button();
            btnNhan = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnChiTiet = new Button();
            lblLocationTo = new Label();
            lblLocationFrom = new Label();
            label1 = new Label();
            lblTypeProduct = new Label();
            lstProducts = new ListView();
            clnSTT = new ColumnHeader();
            clnName = new ColumnHeader();
            clnTypeProduct = new ColumnHeader();
            timer1 = new System.Windows.Forms.Timer(components);
            statusBar = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTuChoi
            // 
            btnTuChoi.BackColor = Color.Red;
            btnTuChoi.FlatStyle = FlatStyle.Flat;
            btnTuChoi.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTuChoi.ForeColor = SystemColors.Control;
            btnTuChoi.Location = new Point(363, -3);
            btnTuChoi.Margin = new Padding(4);
            btnTuChoi.Name = "btnTuChoi";
            btnTuChoi.Size = new Size(197, 60);
            btnTuChoi.TabIndex = 0;
            btnTuChoi.Text = "Từ chối";
            btnTuChoi.UseVisualStyleBackColor = false;
            btnTuChoi.Click += btnTuChoi_Click;
            // 
            // btnNhan
            // 
            btnNhan.BackColor = Color.FromArgb(0, 94, 114);
            btnNhan.FlatStyle = FlatStyle.Flat;
            btnNhan.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhan.ForeColor = SystemColors.Control;
            btnNhan.Location = new Point(25, 410);
            btnNhan.Margin = new Padding(4);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(510, 80);
            btnNhan.TabIndex = 1;
            btnNhan.Text = "Nhận chuyến";
            btnNhan.UseVisualStyleBackColor = false;
            btnNhan.Click += btnNhan_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnChiTiet);
            panel1.Controls.Add(lblLocationTo);
            panel1.Controls.Add(lblLocationFrom);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTypeProduct);
            panel1.Controls.Add(btnTuChoi);
            panel1.Controls.Add(btnNhan);
            panel1.Location = new Point(0, 530);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 676);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.homeIndicator1;
            panel2.Location = new Point(-6, 624);
            panel2.Name = "panel2";
            panel2.Size = new Size(572, 50);
            panel2.TabIndex = 40;
            // 
            // btnChiTiet
            // 
            btnChiTiet.BackColor = Color.WhiteSmoke;
            btnChiTiet.FlatStyle = FlatStyle.Flat;
            btnChiTiet.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChiTiet.ForeColor = Color.Black;
            btnChiTiet.Location = new Point(25, 514);
            btnChiTiet.Margin = new Padding(4);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(510, 80);
            btnChiTiet.TabIndex = 7;
            btnChiTiet.Text = "Chi tiết chuyến đi";
            btnChiTiet.UseVisualStyleBackColor = false;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // lblLocationTo
            // 
            lblLocationTo.BackColor = Color.White;
            lblLocationTo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblLocationTo.Location = new Point(25, 254);
            lblLocationTo.Margin = new Padding(4, 0, 4, 0);
            lblLocationTo.Name = "lblLocationTo";
            lblLocationTo.Size = new Size(510, 94);
            lblLocationTo.TabIndex = 6;
            // 
            // lblLocationFrom
            // 
            lblLocationFrom.BackColor = Color.White;
            lblLocationFrom.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblLocationFrom.Location = new Point(25, 119);
            lblLocationFrom.Margin = new Padding(4, 0, 4, 0);
            lblLocationFrom.Name = "lblLocationFrom";
            lblLocationFrom.Size = new Size(510, 80);
            lblLocationFrom.TabIndex = 6;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 94, 114);
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(4, 4);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 60);
            label1.TabIndex = 4;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTypeProduct
            // 
            lblTypeProduct.AutoSize = true;
            lblTypeProduct.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTypeProduct.Location = new Point(10, 18);
            lblTypeProduct.Margin = new Padding(4, 0, 4, 0);
            lblTypeProduct.Name = "lblTypeProduct";
            lblTypeProduct.Size = new Size(0, 32);
            lblTypeProduct.TabIndex = 3;
            // 
            // lstProducts
            // 
            lstProducts.Columns.AddRange(new ColumnHeader[] { clnSTT, clnName, clnTypeProduct });
            lstProducts.FullRowSelect = true;
            lstProducts.GridLines = true;
            lstProducts.Location = new Point(10, 117);
            lstProducts.Margin = new Padding(4);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(550, 402);
            lstProducts.TabIndex = 4;
            lstProducts.UseCompatibleStateImageBehavior = false;
            lstProducts.View = View.Details;
            lstProducts.SelectedIndexChanged += lstProducts_SelectedIndexChanged;
            // 
            // clnSTT
            // 
            clnSTT.Text = "STT";
            clnSTT.Width = 20;
            // 
            // clnName
            // 
            clnName.Text = "Tên Hàng";
            clnName.Width = 50;
            // 
            // clnTypeProduct
            // 
            clnTypeProduct.Text = "Loại Đơn";
            clnTypeProduct.Width = 50;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // statusBar
            // 
            statusBar.BackColor = Color.Transparent;
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(-5, -1);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(573, 84);
            statusBar.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 90);
            label2.Name = "label2";
            label2.Size = new Size(134, 33);
            label2.TabIndex = 41;
            label2.Text = "Điểm đón";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 214);
            label3.Name = "label3";
            label3.Size = new Size(133, 33);
            label3.TabIndex = 42;
            label3.Text = "Điểm đến";
            // 
            // formFood
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(561, 1202);
            Controls.Add(statusBar);
            Controls.Add(lstProducts);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "formFood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formFood";
            Load += formFood_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTuChoi;
        private Button btnNhan;
        private Panel panel1;
        private Label label1;
        private Label lblTypeProduct;
        private Label lblLocationFrom;
        private Label lblLocationTo;
        private Button btnChiTiet;
        private ListView lstProducts;
        private ColumnHeader clnSTT;
        private ColumnHeader clnName;
        private ColumnHeader clnTypeProduct;
        private System.Windows.Forms.Timer timer1;
        private Panel statusBar;
        private Panel panel2;
        private Label label2;
        private Label label3;
    }
}