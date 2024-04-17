namespace ProjectOOP
{
    partial class formInfoAccount
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
            background = new Panel();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblNameVehicle = new Label();
            lblCarCode = new Label();
            lblSoChuyenDi = new Label();
            lblLuotDanhGia = new Label();
            lblNam = new Label();
            lbllblChuyenDi = new Label();
            lblDanhGia = new Label();
            lblSoNam = new Label();
            btnLogout = new Button();
            indicator = new Panel();
            background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // background
            // 
            background.BackgroundImage = Properties.Resources.backgroundNew;
            background.Controls.Add(btnBack);
            background.Controls.Add(pictureBox1);
            background.Location = new Point(0, 0);
            background.Name = "background";
            background.Size = new Size(562, 409);
            background.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.ForeColor = Color.Transparent;
            btnBack.Image = Properties.Resources.iconArrow;
            btnBack.Location = new Point(29, 73);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(72, 72);
            btnBack.TabIndex = 16;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.LargeAvatar;
            pictureBox1.Location = new Point(206, 274);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 132);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(0, 94, 104);
            lblTitle.Location = new Point(108, 449);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 50);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Phạm Thành Đạt";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblNameVehicle
            // 
            lblNameVehicle.AutoSize = true;
            lblNameVehicle.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameVehicle.ForeColor = Color.Black;
            lblNameVehicle.Location = new Point(47, 512);
            lblNameVehicle.Name = "lblNameVehicle";
            lblNameVehicle.Size = new Size(458, 33);
            lblNameVehicle.TabIndex = 5;
            lblNameVehicle.Text = "Phương tiện: Bugatti La Voatio Noire";
            // 
            // lblCarCode
            // 
            lblCarCode.AutoSize = true;
            lblCarCode.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCarCode.ForeColor = Color.Black;
            lblCarCode.Location = new Point(130, 559);
            lblCarCode.Name = "lblCarCode";
            lblCarCode.Size = new Size(268, 33);
            lblCarCode.TabIndex = 6;
            lblCarCode.Text = "Biển số xe: 51-9999";
            // 
            // lblSoChuyenDi
            // 
            lblSoChuyenDi.AutoSize = true;
            lblSoChuyenDi.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoChuyenDi.ForeColor = Color.FromArgb(241, 111, 51);
            lblSoChuyenDi.Location = new Point(493, 625);
            lblSoChuyenDi.Name = "lblSoChuyenDi";
            lblSoChuyenDi.Size = new Size(33, 33);
            lblSoChuyenDi.TabIndex = 7;
            lblSoChuyenDi.Text = "0";
            // 
            // lblLuotDanhGia
            // 
            lblLuotDanhGia.AutoSize = true;
            lblLuotDanhGia.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLuotDanhGia.ForeColor = Color.FromArgb(241, 111, 51);
            lblLuotDanhGia.Location = new Point(469, 677);
            lblLuotDanhGia.Name = "lblLuotDanhGia";
            lblLuotDanhGia.Size = new Size(57, 33);
            lblLuotDanhGia.TabIndex = 8;
            lblLuotDanhGia.Text = "5.0";
            lblLuotDanhGia.Click += label2_Click;
            // 
            // lblNam
            // 
            lblNam.AutoSize = true;
            lblNam.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNam.ForeColor = Color.FromArgb(241, 111, 51);
            lblNam.Location = new Point(494, 725);
            lblNam.Name = "lblNam";
            lblNam.Size = new Size(32, 33);
            lblNam.TabIndex = 9;
            lblNam.Text = "2";
            // 
            // lbllblChuyenDi
            // 
            lbllblChuyenDi.AutoSize = true;
            lbllblChuyenDi.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbllblChuyenDi.ForeColor = Color.FromArgb(241, 111, 51);
            lbllblChuyenDi.Location = new Point(29, 625);
            lbllblChuyenDi.Name = "lbllblChuyenDi";
            lbllblChuyenDi.Size = new Size(142, 33);
            lbllblChuyenDi.TabIndex = 10;
            lbllblChuyenDi.Text = "Chuyến đi";
            // 
            // lblDanhGia
            // 
            lblDanhGia.AutoSize = true;
            lblDanhGia.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDanhGia.ForeColor = Color.FromArgb(241, 111, 51);
            lblDanhGia.Location = new Point(29, 677);
            lblDanhGia.Name = "lblDanhGia";
            lblDanhGia.Size = new Size(125, 33);
            lblDanhGia.TabIndex = 11;
            lblDanhGia.Text = "Đánh giá";
            // 
            // lblSoNam
            // 
            lblSoNam.AutoSize = true;
            lblSoNam.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoNam.ForeColor = Color.FromArgb(241, 111, 51);
            lblSoNam.Location = new Point(29, 725);
            lblSoNam.Name = "lblSoNam";
            lblSoNam.Size = new Size(181, 33);
            lblSoNam.TabIndex = 12;
            lblSoNam.Text = "Ngày bắt đầu";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(26, 1042);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(510, 80);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // indicator
            // 
            indicator.BackgroundImage = Properties.Resources.homeIndicator1;
            indicator.Location = new Point(-5, 1150);
            indicator.Name = "indicator";
            indicator.Size = new Size(573, 50);
            indicator.TabIndex = 27;
            // 
            // formInfoAccount
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(561, 1202);
            Controls.Add(indicator);
            Controls.Add(btnLogout);
            Controls.Add(lblSoNam);
            Controls.Add(lblDanhGia);
            Controls.Add(lbllblChuyenDi);
            Controls.Add(lblNam);
            Controls.Add(lblLuotDanhGia);
            Controls.Add(lblSoChuyenDi);
            Controls.Add(lblCarCode);
            Controls.Add(lblNameVehicle);
            Controls.Add(lblTitle);
            Controls.Add(background);
            Name = "formInfoAccount";
            Text = "formInfoAccount";
            Load += formInfoAccount_Load;
            background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel background;
        private Label lblTitle;
        private Label lblNameVehicle;
        private Label lblCarCode;
        private Label lblSoChuyenDi;
        private Label lblLuotDanhGia;
        private Label lblNam;
        private Label lbllblChuyenDi;
        private Label lblDanhGia;
        private Label lblSoNam;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private Button btnBack;
        private Panel indicator;
    }
}