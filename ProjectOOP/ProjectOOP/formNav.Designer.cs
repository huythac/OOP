namespace ProjectOOP
{
    partial class formNav
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
            panel1 = new Panel();
            label1 = new Label();
            nav = new Panel();
            btnStartNow = new Button();
            btnTaiKhoanThanhToan = new Button();
            btnThuNhapSoDu = new Button();
            btnLichSuChuyenDi = new Button();
            btnThongTinTaiKhoan = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblRating = new Label();
            lblName = new Label();
            panel1.SuspendLayout();
            nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, 1116);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 92);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(143, 26);
            label1.Name = "label1";
            label1.Size = new Size(273, 32);
            label1.TabIndex = 0;
            label1.Text = "Bạn đang ngoại tuyến";
            // 
            // nav
            // 
            nav.BackColor = Color.White;
            nav.Controls.Add(btnStartNow);
            nav.Controls.Add(btnTaiKhoanThanhToan);
            nav.Controls.Add(btnThuNhapSoDu);
            nav.Controls.Add(btnLichSuChuyenDi);
            nav.Controls.Add(btnThongTinTaiKhoan);
            nav.Controls.Add(pictureBox2);
            nav.Controls.Add(pictureBox1);
            nav.Controls.Add(lblRating);
            nav.Controls.Add(lblName);
            nav.Location = new Point(-6, 2);
            nav.Name = "nav";
            nav.Size = new Size(447, 1203);
            nav.TabIndex = 14;
            // 
            // btnStartNow
            // 
            btnStartNow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStartNow.BackColor = Color.FromArgb(230, 239, 240);
            btnStartNow.FlatStyle = FlatStyle.Flat;
            btnStartNow.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartNow.ForeColor = Color.FromArgb(0, 94, 104);
            btnStartNow.Location = new Point(44, 1076);
            btnStartNow.Name = "btnStartNow";
            btnStartNow.Size = new Size(359, 80);
            btnStartNow.TabIndex = 14;
            btnStartNow.Text = "Quay lại";
            btnStartNow.UseVisualStyleBackColor = false;
            btnStartNow.Click += btnStartNow_Click;
            // 
            // btnTaiKhoanThanhToan
            // 
            btnTaiKhoanThanhToan.BackColor = Color.Transparent;
            btnTaiKhoanThanhToan.Font = new Font("SF Pro Display", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaiKhoanThanhToan.ForeColor = Color.FromArgb(241, 111, 51);
            btnTaiKhoanThanhToan.Location = new Point(3, 526);
            btnTaiKhoanThanhToan.Name = "btnTaiKhoanThanhToan";
            btnTaiKhoanThanhToan.Padding = new Padding(0, 0, 30, 0);
            btnTaiKhoanThanhToan.Size = new Size(444, 72);
            btnTaiKhoanThanhToan.TabIndex = 12;
            btnTaiKhoanThanhToan.Text = "Tài khoản thanh toán";
            btnTaiKhoanThanhToan.UseVisualStyleBackColor = false;
            // 
            // btnThuNhapSoDu
            // 
            btnThuNhapSoDu.BackColor = Color.Transparent;
            btnThuNhapSoDu.Font = new Font("SF Pro Display", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnThuNhapSoDu.ForeColor = Color.FromArgb(241, 111, 51);
            btnThuNhapSoDu.Location = new Point(3, 436);
            btnThuNhapSoDu.Name = "btnThuNhapSoDu";
            btnThuNhapSoDu.Padding = new Padding(0, 0, 70, 0);
            btnThuNhapSoDu.Size = new Size(444, 72);
            btnThuNhapSoDu.TabIndex = 11;
            btnThuNhapSoDu.Text = "Số dư và thu nhập";
            btnThuNhapSoDu.UseVisualStyleBackColor = false;
            btnThuNhapSoDu.Click += button2_Click;
            // 
            // btnLichSuChuyenDi
            // 
            btnLichSuChuyenDi.BackColor = Color.Transparent;
            btnLichSuChuyenDi.Font = new Font("SF Pro Display", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnLichSuChuyenDi.ForeColor = Color.FromArgb(241, 111, 51);
            btnLichSuChuyenDi.Location = new Point(3, 345);
            btnLichSuChuyenDi.Name = "btnLichSuChuyenDi";
            btnLichSuChuyenDi.Padding = new Padding(0, 0, 75, 0);
            btnLichSuChuyenDi.Size = new Size(444, 72);
            btnLichSuChuyenDi.TabIndex = 10;
            btnLichSuChuyenDi.Text = "Lịch sử chuyến đi";
            btnLichSuChuyenDi.UseVisualStyleBackColor = false;
            btnLichSuChuyenDi.Click += btnLichSuChuyenDi_Click;
            // 
            // btnThongTinTaiKhoan
            // 
            btnThongTinTaiKhoan.BackColor = Color.Transparent;
            btnThongTinTaiKhoan.Font = new Font("SF Pro Display", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnThongTinTaiKhoan.ForeColor = Color.FromArgb(241, 111, 51);
            btnThongTinTaiKhoan.Location = new Point(3, 255);
            btnThongTinTaiKhoan.Name = "btnThongTinTaiKhoan";
            btnThongTinTaiKhoan.Padding = new Padding(0, 0, 60, 0);
            btnThongTinTaiKhoan.Size = new Size(444, 72);
            btnThongTinTaiKhoan.TabIndex = 9;
            btnThongTinTaiKhoan.Text = "Thông tin tài khoản";
            btnThongTinTaiKhoan.UseVisualStyleBackColor = false;
            btnThongTinTaiKhoan.Click += btnThongTinTaiKhoan_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Avatar;
            pictureBox2.Location = new Point(44, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 84);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconStar;
            pictureBox1.Location = new Point(143, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblRating.ForeColor = Color.FromArgb(64, 64, 64);
            lblRating.Location = new Point(177, 132);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(71, 32);
            lblRating.TabIndex = 5;
            lblRating.Text = "4.95";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("SF Pro Display", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(241, 111, 51);
            lblName.Location = new Point(143, 86);
            lblName.Name = "lblName";
            lblName.Size = new Size(171, 39);
            lblName.TabIndex = 4;
            lblName.Text = "Thành Đạt";
            // 
            // formNav
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MạpUpdate;
            ClientSize = new Size(561, 1202);
            Controls.Add(nav);
            Controls.Add(panel1);
            Name = "formNav";
            Text = "formNav";
            Load += formNav_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            nav.ResumeLayout(false);
            nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel nav;
        private Label lblName;
        private Label lblRating;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnThongTinTaiKhoan;
        private Button btnTaiKhoanThanhToan;
        private Button btnThuNhapSoDu;
        private Button btnLichSuChuyenDi;
        private Button btnStartNow;
    }
}