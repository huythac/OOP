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
            background.Margin = new Padding(2, 2, 2, 2);
            background.Name = "background";
            background.Size = new Size(375, 273);
            background.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Image = Properties.Resources.iconArrow;
            btnBack.Location = new Point(19, 49);
            btnBack.Margin = new Padding(2, 2, 2, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 48);
            btnBack.TabIndex = 16;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.LargeAvatar;
            pictureBox1.Location = new Point(137, 183);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 88);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(0, 94, 104);
            lblTitle.Location = new Point(71, 299);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(251, 36);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Phạm Thành Đạt";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblNameVehicle
            // 
            lblNameVehicle.AutoSize = true;
            lblNameVehicle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameVehicle.ForeColor = Color.Black;
            lblNameVehicle.Location = new Point(31, 341);
            lblNameVehicle.Margin = new Padding(2, 0, 2, 0);
            lblNameVehicle.Name = "lblNameVehicle";
            lblNameVehicle.Size = new Size(362, 25);
            lblNameVehicle.TabIndex = 5;
            lblNameVehicle.Text = "Phương tiện: Bugatti La Voatio Noire";
            // 
            // lblCarCode
            // 
            lblCarCode.AutoSize = true;
            lblCarCode.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCarCode.ForeColor = Color.Black;
            lblCarCode.Location = new Point(87, 373);
            lblCarCode.Margin = new Padding(2, 0, 2, 0);
            lblCarCode.Name = "lblCarCode";
            lblCarCode.Size = new Size(206, 25);
            lblCarCode.TabIndex = 6;
            lblCarCode.Text = "Biển số xe: 51-9999";
            // 
            // lblSoChuyenDi
            // 
            lblSoChuyenDi.AutoSize = true;
            lblSoChuyenDi.Font = new Font("Microsoft Sans Serif", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoChuyenDi.ForeColor = Color.FromArgb(241, 111, 51);
            lblSoChuyenDi.Location = new Point(25, 422);
            lblSoChuyenDi.Margin = new Padding(2, 0, 2, 0);
            lblSoChuyenDi.Name = "lblSoChuyenDi";
            lblSoChuyenDi.Size = new Size(78, 31);
            lblSoChuyenDi.TabIndex = 7;
            lblSoChuyenDi.Text = "2400";
            // 
            // lblLuotDanhGia
            // 
            lblLuotDanhGia.AutoSize = true;
            lblLuotDanhGia.Font = new Font("Microsoft Sans Serif", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            lblLuotDanhGia.ForeColor = Color.FromArgb(241, 111, 51);
            lblLuotDanhGia.Location = new Point(160, 422);
            lblLuotDanhGia.Margin = new Padding(2, 0, 2, 0);
            lblLuotDanhGia.Name = "lblLuotDanhGia";
            lblLuotDanhGia.Size = new Size(71, 31);
            lblLuotDanhGia.TabIndex = 8;
            lblLuotDanhGia.Text = "4.95";
            lblLuotDanhGia.Click += label2_Click;
            // 
            // lblNam
            // 
            lblNam.AutoSize = true;
            lblNam.Font = new Font("Microsoft Sans Serif", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            lblNam.ForeColor = Color.FromArgb(241, 111, 51);
            lblNam.Location = new Point(303, 422);
            lblNam.Margin = new Padding(2, 0, 2, 0);
            lblNam.Name = "lblNam";
            lblNam.Size = new Size(30, 31);
            lblNam.TabIndex = 9;
            lblNam.Text = "2";
            // 
            // lbllblChuyenDi
            // 
            lbllblChuyenDi.AutoSize = true;
            lbllblChuyenDi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbllblChuyenDi.ForeColor = Color.FromArgb(241, 111, 51);
            lbllblChuyenDi.Location = new Point(17, 451);
            lbllblChuyenDi.Margin = new Padding(2, 0, 2, 0);
            lbllblChuyenDi.Name = "lbllblChuyenDi";
            lbllblChuyenDi.Size = new Size(110, 25);
            lbllblChuyenDi.TabIndex = 10;
            lbllblChuyenDi.Text = "Chuyến đi";
            // 
            // lblDanhGia
            // 
            lblDanhGia.AutoSize = true;
            lblDanhGia.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDanhGia.ForeColor = Color.FromArgb(241, 111, 51);
            lblDanhGia.Location = new Point(153, 451);
            lblDanhGia.Margin = new Padding(2, 0, 2, 0);
            lblDanhGia.Name = "lblDanhGia";
            lblDanhGia.Size = new Size(98, 25);
            lblDanhGia.TabIndex = 11;
            lblDanhGia.Text = "Đánh giá";
            // 
            // lblSoNam
            // 
            lblSoNam.AutoSize = true;
            lblSoNam.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoNam.ForeColor = Color.FromArgb(241, 111, 51);
            lblSoNam.Location = new Point(296, 451);
            lblSoNam.Margin = new Padding(2, 0, 2, 0);
            lblSoNam.Name = "lblSoNam";
            lblSoNam.Size = new Size(56, 25);
            lblSoNam.TabIndex = 12;
            lblSoNam.Text = "Năm";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(17, 695);
            btnLogout.Margin = new Padding(2, 2, 2, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(340, 53);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // indicator
            // 
            indicator.BackgroundImage = Properties.Resources.homeIndicator1;
            indicator.Location = new Point(-3, 767);
            indicator.Margin = new Padding(2, 2, 2, 2);
            indicator.Name = "indicator";
            indicator.Size = new Size(382, 33);
            indicator.TabIndex = 27;
            // 
            // formInfoAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(374, 703);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "formInfoAccount";
            StartPosition = FormStartPosition.CenterScreen;
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