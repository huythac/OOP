namespace ProjectOOP
{
    partial class formChiTiet
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
            btnBack = new Button();
            lblTieuDe = new Label();
            panelDiaChi = new Panel();
            lblLocationTo = new Label();
            lblLocationFrom = new Label();
            lstHangHoa = new ListView();
            clnTenHang = new ColumnHeader();
            clnChiTiet = new ColumnHeader();
            clnThanhTien = new ColumnHeader();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            statusBar = new Panel();
            panel2 = new Panel();
            panelDiaChi.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.Image = Properties.Resources.iconArrow;
            btnBack.Location = new Point(12, 139);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(72, 72);
            btnBack.TabIndex = 18;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.Location = new Point(92, 139);
            lblTieuDe.Margin = new Padding(4, 0, 4, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(363, 72);
            lblTieuDe.TabIndex = 19;
            lblTieuDe.Text = "Chi tiết chuyến đi";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDiaChi
            // 
            panelDiaChi.Controls.Add(lblLocationTo);
            panelDiaChi.Controls.Add(lblLocationFrom);
            panelDiaChi.Location = new Point(2, 318);
            panelDiaChi.Margin = new Padding(4, 4, 4, 4);
            panelDiaChi.Name = "panelDiaChi";
            panelDiaChi.Size = new Size(550, 291);
            panelDiaChi.TabIndex = 20;
            // 
            // lblLocationTo
            // 
            lblLocationTo.BackColor = Color.White;
            lblLocationTo.Font = new Font("SF Pro Display", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblLocationTo.Location = new Point(10, 155);
            lblLocationTo.Margin = new Padding(4, 0, 4, 0);
            lblLocationTo.Name = "lblLocationTo";
            lblLocationTo.Size = new Size(525, 104);
            lblLocationTo.TabIndex = 1;
            lblLocationTo.Click += label2_Click;
            // 
            // lblLocationFrom
            // 
            lblLocationFrom.BackColor = Color.White;
            lblLocationFrom.Font = new Font("SF Pro Display", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblLocationFrom.Location = new Point(10, 30);
            lblLocationFrom.Margin = new Padding(4, 0, 4, 0);
            lblLocationFrom.Name = "lblLocationFrom";
            lblLocationFrom.Size = new Size(525, 104);
            lblLocationFrom.TabIndex = 0;
            // 
            // lstHangHoa
            // 
            lstHangHoa.Location = new Point(0, 0);
            lstHangHoa.Name = "lstHangHoa";
            lstHangHoa.Size = new Size(121, 97);
            lstHangHoa.TabIndex = 0;
            lstHangHoa.UseCompatibleStateImageBehavior = false;
            // 
            // clnTenHang
            // 
            clnTenHang.Text = "Tên Hàng";
            clnTenHang.Width = 80;
            // 
            // clnChiTiet
            // 
            clnChiTiet.Text = "Chi Tiết";
            // 
            // clnThanhTien
            // 
            clnThanhTien.Text = "Thành Tiền";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(350, 238);
            label1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 264);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 44);
            label3.TabIndex = 22;
            label3.Text = "Địa chỉ ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Display", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 636);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(299, 44);
            label4.TabIndex = 23;
            label4.Text = "Chi tiết đơn hàng";
            // 
            // statusBar
            // 
            statusBar.BackColor = Color.Transparent;
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(-6, -2);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(573, 84);
            statusBar.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.homeIndicator1;
            panel2.Location = new Point(-8, 1152);
            panel2.Name = "panel2";
            panel2.Size = new Size(572, 50);
            panel2.TabIndex = 39;
            // 
            // formChiTiet
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(561, 1202);
            Controls.Add(panel2);
            Controls.Add(statusBar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panelDiaChi);
            Controls.Add(lblTieuDe);
            Controls.Add(btnBack);
            Margin = new Padding(4, 4, 4, 4);
            Name = "formChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formChiTiet";
            Load += formChiTiet_Load;
            panelDiaChi.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
        private Panel panelDiaChi;
        private Label lblLocationFrom;
        private Label lblLocationTo;
        private Label lblTieuDe;
        private Label label3;
        private Label label4;
        private ListView lstHangHoa;
        private ColumnHeader clnTenHang;
        private ColumnHeader clnChiTiet;
        private ColumnHeader clnThanhTien;
        private Panel statusBar;
        private Panel panel2;
    }
}