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
            label2 = new Label();
            lblLocationFrom = new Label();
            panelThongTinDon = new Panel();
            lstHangHoa = new ListView();
            clnTenHang = new ColumnHeader();
            clnSoLuong = new ColumnHeader();
            clnDonGia = new ColumnHeader();
            clnTong = new ColumnHeader();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panelDiaChi.SuspendLayout();
            panelThongTinDon.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.Image = Properties.Resources.iconArrow;
            btnBack.Location = new Point(11, 11);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 48);
            btnBack.TabIndex = 18;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.Location = new Point(64, 11);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(194, 48);
            lblTieuDe.TabIndex = 19;
            lblTieuDe.Text = "Chi tiết chuyến đi";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDiaChi
            // 
            panelDiaChi.Controls.Add(label2);
            panelDiaChi.Controls.Add(lblLocationFrom);
            panelDiaChi.Location = new Point(4, 115);
            panelDiaChi.Name = "panelDiaChi";
            panelDiaChi.Size = new Size(367, 194);
            panelDiaChi.TabIndex = 20;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 93);
            label2.Name = "label2";
            label2.Size = new Size(350, 69);
            label2.TabIndex = 1;
            // 
            // lblLocationFrom
            // 
            lblLocationFrom.BackColor = SystemColors.ActiveBorder;
            lblLocationFrom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLocationFrom.Location = new Point(8, 10);
            lblLocationFrom.Name = "lblLocationFrom";
            lblLocationFrom.Size = new Size(350, 69);
            lblLocationFrom.TabIndex = 0;
            // 
            // panelThongTinDon
            // 
            panelThongTinDon.Controls.Add(lstHangHoa);
            panelThongTinDon.Controls.Add(label1);
            panelThongTinDon.Location = new Point(4, 355);
            panelThongTinDon.Name = "panelThongTinDon";
            panelThongTinDon.Size = new Size(367, 268);
            panelThongTinDon.TabIndex = 21;
            // 
            // lstHangHoa
            // 
            lstHangHoa.Columns.AddRange(new ColumnHeader[] { clnTenHang, clnSoLuong, clnDonGia, clnTong });
            lstHangHoa.Location = new Point(3, 7);
            lstHangHoa.Name = "lstHangHoa";
            lstHangHoa.Size = new Size(361, 193);
            lstHangHoa.TabIndex = 3;
            lstHangHoa.UseCompatibleStateImageBehavior = false;
            lstHangHoa.View = View.Details;
            // 
            // clnTenHang
            // 
            clnTenHang.Text = "Tên Hàng";
            clnTenHang.Width = 80;
            // 
            // clnSoLuong
            // 
            clnSoLuong.Text = "Số Lượng";
            // 
            // clnDonGia
            // 
            clnDonGia.Text = "Đơn Giá";
            // 
            // clnTong
            // 
            clnTong.Text = "Tổng";
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
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 79);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 22;
            label3.Text = "Địa chỉ ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 327);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 23;
            label4.Text = "Chi tiết đơn hàng";
            // 
            // formChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 703);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panelThongTinDon);
            Controls.Add(panelDiaChi);
            Controls.Add(lblTieuDe);
            Controls.Add(btnBack);
            Name = "formChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formChiTiet";
            Load += formChiTiet_Load;
            panelDiaChi.ResumeLayout(false);
            panelThongTinDon.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
        private Panel panelDiaChi;
        private Label lblLocationFrom;
        private Panel panelThongTinDon;
        private Label label2;
        private Label lblTieuDe;
        private Label label3;
        private Label label4;
        private ListView lstHangHoa;
        private ColumnHeader clnTenHang;
        private ColumnHeader clnSoLuong;
        private ColumnHeader clnDonGia;
        private ColumnHeader clnTong;
    }
}