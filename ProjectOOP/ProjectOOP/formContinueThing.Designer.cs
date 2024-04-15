namespace ProjectOOP
{
    partial class formContinueThing
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
            statusBar = new Panel();
            pictureBox1 = new PictureBox();
            pbox = new PictureBox();
            indicator = new Panel();
            lblType = new Label();
            panel2 = new Panel();
            lblThoiGianDon = new Label();
            lblThoiGianDi = new Label();
            lblDiemDi = new Label();
            lblDiemDen = new Label();
            pictureBox2 = new PictureBox();
            btnOrderDetails = new Button();
            btnStartTrip = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // statusBar
            // 
            statusBar.BackColor = Color.Transparent;
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(-5, -1);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(573, 84);
            statusBar.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Derect;
            pictureBox1.Location = new Point(74, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 291);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pbox
            // 
            pbox.BackColor = Color.Transparent;
            pbox.Image = Properties.Resources.Navigation_icon___small;
            pbox.Location = new Point(74, 304);
            pbox.Name = "pbox";
            pbox.Size = new Size(100, 100);
            pbox.TabIndex = 17;
            pbox.TabStop = false;
            // 
            // indicator
            // 
            indicator.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            indicator.BackColor = Color.Transparent;
            indicator.BackgroundImage = Properties.Resources.homeIndicator1;
            indicator.Location = new Point(-1, 686);
            indicator.Name = "indicator";
            indicator.Size = new Size(573, 50);
            indicator.TabIndex = 28;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.BackColor = Color.FromArgb(0, 94, 104);
            lblType.BorderStyle = BorderStyle.FixedSingle;
            lblType.Font = new Font("Segoe UI Semibold", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.ForeColor = Color.White;
            lblType.ImageAlign = ContentAlignment.MiddleLeft;
            lblType.Location = new Point(31, 30);
            lblType.Margin = new Padding(0);
            lblType.Name = "lblType";
            lblType.Padding = new Padding(8, 6, 8, 6);
            lblType.Size = new Size(165, 51);
            lblType.TabIndex = 30;
            lblType.Text = "UEH Thing";
            lblType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblDiemDen);
            panel2.Controls.Add(lblDiemDi);
            panel2.Controls.Add(lblThoiGianDi);
            panel2.Controls.Add(lblThoiGianDon);
            panel2.Location = new Point(31, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(510, 335);
            panel2.TabIndex = 33;
            // 
            // lblThoiGianDon
            // 
            lblThoiGianDon.AutoSize = true;
            lblThoiGianDon.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblThoiGianDon.Location = new Point(49, 26);
            lblThoiGianDon.Name = "lblThoiGianDon";
            lblThoiGianDon.Size = new Size(318, 33);
            lblThoiGianDon.TabIndex = 0;
            lblThoiGianDon.Text = "4 phút (cách đây 500m)";
            // 
            // lblThoiGianDi
            // 
            lblThoiGianDi.AutoSize = true;
            lblThoiGianDi.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblThoiGianDi.Location = new Point(49, 199);
            lblThoiGianDi.Name = "lblThoiGianDi";
            lblThoiGianDi.Size = new Size(365, 33);
            lblThoiGianDi.TabIndex = 1;
            lblThoiGianDi.Text = "25 phút (quãng đường 8km)";
            // 
            // lblDiemDi
            // 
            lblDiemDi.AutoSize = true;
            lblDiemDi.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiemDi.Location = new Point(49, 70);
            lblDiemDi.Name = "lblDiemDi";
            lblDiemDi.Size = new Size(416, 64);
            lblDiemDi.TabIndex = 2;
            lblDiemDi.Text = "279 Nguyễn Tri Phương, Phường 5, \nQuận 10";
            // 
            // lblDiemDen
            // 
            lblDiemDen.AutoSize = true;
            lblDiemDen.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiemDen.Location = new Point(49, 244);
            lblDiemDen.Name = "lblDiemDen";
            lblDiemDen.Size = new Size(432, 32);
            lblDiemDen.TabIndex = 3;
            lblDiemDen.Text = "15, xã Phong Phú, huyện Bình Chánh";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.LineNew;
            pictureBox2.Location = new Point(17, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 206);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnOrderDetails
            // 
            btnOrderDetails.BackColor = Color.FromArgb(230, 239, 240);
            btnOrderDetails.FlatStyle = FlatStyle.Flat;
            btnOrderDetails.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrderDetails.ForeColor = Color.FromArgb(0, 94, 104);
            btnOrderDetails.Location = new Point(31, 580);
            btnOrderDetails.Name = "btnOrderDetails";
            btnOrderDetails.Size = new Size(510, 80);
            btnOrderDetails.TabIndex = 34;
            btnOrderDetails.Text = "Chi tiết đơn hàng";
            btnOrderDetails.UseVisualStyleBackColor = false;
            // 
            // btnStartTrip
            // 
            btnStartTrip.BackColor = Color.FromArgb(0, 94, 104);
            btnStartTrip.FlatStyle = FlatStyle.Flat;
            btnStartTrip.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartTrip.ForeColor = Color.White;
            btnStartTrip.Location = new Point(31, 479);
            btnStartTrip.Name = "btnStartTrip";
            btnStartTrip.Size = new Size(510, 80);
            btnStartTrip.TabIndex = 35;
            btnStartTrip.Text = "Bắt đầu chuyến đi";
            btnStartTrip.UseVisualStyleBackColor = false;
            btnStartTrip.Click += btnStartTrip_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnStartTrip);
            panel1.Controls.Add(lblType);
            panel1.Controls.Add(indicator);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnOrderDetails);
            panel1.Location = new Point(-5, 466);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 745);
            panel1.TabIndex = 36;
            // 
            // formContinueThing
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.MạpUpdate;
            ClientSize = new Size(561, 1202);
            Controls.Add(panel1);
            Controls.Add(pbox);
            Controls.Add(pictureBox1);
            Controls.Add(statusBar);
            Name = "formContinueThing";
            Text = "formContinuePeople";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel statusBar;
        private PictureBox pictureBox1;
        private PictureBox pbox;
        private Panel indicator;
        private Label lblType;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label lblDiemDen;
        private Label lblDiemDi;
        private Label lblThoiGianDi;
        private Label lblThoiGianDon;
        private Button btnOrderDetails;
        private Button btnStartTrip;
        private Panel panel1;
    }
}