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
            btnTuChoi = new Button();
            btnNhan = new Button();
            panel1 = new Panel();
            btnChiTiet = new Button();
            lblLocationTo = new Label();
            lblLocationFrom = new Label();
            label1 = new Label();
            lblTypeProduct = new Label();
            lstProducts = new ListView();
            clnSTT = new ColumnHeader();
            clnName = new ColumnHeader();
            clnTypeProduct = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTuChoi
            // 
            btnTuChoi.BackColor = Color.Red;
            btnTuChoi.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTuChoi.ForeColor = SystemColors.Control;
            btnTuChoi.Location = new Point(270, 3);
            btnTuChoi.Name = "btnTuChoi";
            btnTuChoi.Size = new Size(105, 53);
            btnTuChoi.TabIndex = 0;
            btnTuChoi.Text = "Từ chối";
            btnTuChoi.UseVisualStyleBackColor = false;
            btnTuChoi.Click += btnTuChoi_Click;
            // 
            // btnNhan
            // 
            btnNhan.BackColor = Color.FromArgb(0, 94, 114);
            btnNhan.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhan.ForeColor = SystemColors.Control;
            btnNhan.Location = new Point(39, 238);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(280, 64);
            btnNhan.TabIndex = 1;
            btnNhan.Text = "Nhận chuyến";
            btnNhan.UseVisualStyleBackColor = false;
            btnNhan.Click += btnNhan_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnChiTiet);
            panel1.Controls.Add(lblLocationTo);
            panel1.Controls.Add(lblLocationFrom);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTypeProduct);
            panel1.Controls.Add(btnTuChoi);
            panel1.Controls.Add(btnNhan);
            panel1.Location = new Point(0, 353);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 386);
            panel1.TabIndex = 3;
            // 
            // btnChiTiet
            // 
            btnChiTiet.BackColor = SystemColors.ActiveBorder;
            btnChiTiet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChiTiet.ForeColor = SystemColors.Control;
            btnChiTiet.Location = new Point(39, 308);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(280, 64);
            btnChiTiet.TabIndex = 7;
            btnChiTiet.Text = "Chi tiết chuyến đi";
            btnChiTiet.UseVisualStyleBackColor = false;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // lblLocationTo
            // 
            lblLocationTo.BackColor = SystemColors.ActiveCaption;
            lblLocationTo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblLocationTo.Location = new Point(27, 149);
            lblLocationTo.Name = "lblLocationTo";
            lblLocationTo.Size = new Size(302, 61);
            lblLocationTo.TabIndex = 6;
            // 
            // lblLocationFrom
            // 
            lblLocationFrom.BackColor = SystemColors.ActiveCaption;
            lblLocationFrom.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblLocationFrom.Location = new Point(27, 71);
            lblLocationFrom.Name = "lblLocationFrom";
            lblLocationFrom.Size = new Size(302, 61);
            lblLocationFrom.TabIndex = 6;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 94, 114);
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(122, 40);
            label1.TabIndex = 4;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTypeProduct
            // 
            lblTypeProduct.AutoSize = true;
            lblTypeProduct.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTypeProduct.Location = new Point(7, 12);
            lblTypeProduct.Name = "lblTypeProduct";
            lblTypeProduct.Size = new Size(0, 25);
            lblTypeProduct.TabIndex = 3;
            // 
            // lstProducts
            // 
            lstProducts.Columns.AddRange(new ColumnHeader[] { clnSTT, clnName, clnTypeProduct });
            lstProducts.FullRowSelect = true;
            lstProducts.GridLines = true;
            lstProducts.Location = new Point(7, 9);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(368, 338);
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
            // formFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 740);
            Controls.Add(lstProducts);
            Controls.Add(panel1);
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
    }
}