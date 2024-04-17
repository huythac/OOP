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
            clnTong = new ColumnHeader();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panelDiaChi.SuspendLayout();
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
            btnBack.Click += btnBack_Click;
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
            panelDiaChi.Controls.Add(lblLocationTo);
            panelDiaChi.Controls.Add(lblLocationFrom);
            panelDiaChi.Location = new Point(4, 115);
            panelDiaChi.Name = "panelDiaChi";
            panelDiaChi.Size = new Size(367, 194);
            panelDiaChi.TabIndex = 20;
            // 
            // lblLocationTo
            // 
            lblLocationTo.BackColor = SystemColors.ActiveBorder;
            lblLocationTo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLocationTo.Location = new Point(8, 93);
            lblLocationTo.Name = "lblLocationTo";
            lblLocationTo.Size = new Size(350, 69);
            lblLocationTo.TabIndex = 1;
            lblLocationTo.Click += label2_Click;
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
            Controls.Add(panelDiaChi);
            Controls.Add(lblTieuDe);
            Controls.Add(btnBack);
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
        private ColumnHeader clnTong;
    }
}