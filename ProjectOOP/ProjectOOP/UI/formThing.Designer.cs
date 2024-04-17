namespace ProjectOOP
{
    partial class formPeople
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
            btnMenu = new Button();
            pbox = new PictureBox();
            pictureBox1 = new PictureBox();
            indicator = new Panel();
            panel = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lblDiemDen = new Label();
            lblDiemDi = new Label();
            lblThoiGianDi = new Label();
            lblThoiGianDon = new Label();
            lblPrice = new Label();
            lblType = new Label();
            btnConfirm = new Button();
            btnReject = new Button();
            statusBar = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Image = Properties.Resources.iconMenu;
            btnMenu.Location = new Point(25, 88);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(72, 72);
            btnMenu.TabIndex = 12;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pbox
            // 
            pbox.BackColor = Color.Transparent;
            pbox.Image = Properties.Resources.Navigation_icon___small;
            pbox.Location = new Point(150, 234);
            pbox.Name = "pbox";
            pbox.Size = new Size(100, 100);
            pbox.TabIndex = 14;
            pbox.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Destination;
            pictureBox1.Location = new Point(310, 189);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 115);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // indicator
            // 
            indicator.BackColor = Color.White;
            indicator.BackgroundImage = Properties.Resources.homeIndicator1;
            indicator.Location = new Point(-5, 1152);
            indicator.Name = "indicator";
            indicator.Size = new Size(573, 50);
            indicator.TabIndex = 27;
            // 
            // panel
            // 
            panel.BackColor = Color.White;
            panel.Controls.Add(panel2);
            panel.Controls.Add(lblPrice);
            panel.Controls.Add(lblType);
            panel.Controls.Add(btnConfirm);
            panel.Controls.Add(btnReject);
            panel.Location = new Point(-5, 527);
            panel.Name = "panel";
            panel.Size = new Size(570, 628);
            panel.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblDiemDen);
            panel2.Controls.Add(lblDiemDi);
            panel2.Controls.Add(lblThoiGianDi);
            panel2.Controls.Add(lblThoiGianDon);
            panel2.Location = new Point(30, 187);
            panel2.Name = "panel2";
            panel2.Size = new Size(510, 335);
            panel2.TabIndex = 33;
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
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("SF Pro Display", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.FromArgb(241, 111, 51);
            lblPrice.Location = new Point(30, 95);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(278, 67);
            lblPrice.TabIndex = 32;
            lblPrice.Text = "120.000đ";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.BackColor = Color.FromArgb(0, 94, 104);
            lblType.BorderStyle = BorderStyle.FixedSingle;
            lblType.Font = new Font("Segoe UI Semibold", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.ForeColor = Color.White;
            lblType.ImageAlign = ContentAlignment.MiddleLeft;
            lblType.Location = new Point(30, 19);
            lblType.Margin = new Padding(0);
            lblType.Name = "lblType";
            lblType.Padding = new Padding(8, 6, 8, 6);
            lblType.Size = new Size(165, 51);
            lblType.TabIndex = 30;
            lblType.Text = "UEH Thing";
            lblType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnConfirm.BackColor = Color.FromArgb(0, 94, 104);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(30, 539);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(510, 80);
            btnConfirm.TabIndex = 31;
            btnConfirm.Text = "Nhận chuyến";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnReject
            // 
            btnReject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReject.BackColor = Color.FromArgb(255, 192, 192);
            btnReject.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnReject.ForeColor = Color.Red;
            btnReject.Location = new Point(384, 0);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(183, 70);
            btnReject.TabIndex = 30;
            btnReject.Text = "Từ chối";
            btnReject.UseVisualStyleBackColor = false;
            // 
            // statusBar
            // 
            statusBar.BackColor = Color.Transparent;
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(-5, -1);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(573, 84);
            statusBar.TabIndex = 29;
            // 
            // formPeople
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MạpUpdate;
            ClientSize = new Size(561, 1202);
            Controls.Add(statusBar);
            Controls.Add(panel);
            Controls.Add(indicator);
            Controls.Add(pictureBox1);
            Controls.Add(pbox);
            Controls.Add(btnMenu);
            Name = "formPeople";
            Text = "formPeople";
            Load += formPeople_Load;
            ((System.ComponentModel.ISupportInitialize)pbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private PictureBox pbox;
        private PictureBox pictureBox1;
        private Panel indicator;
        private Panel panel;
        private Button btnReject;
        private Panel statusBar;
        private Label lblType;
        private Button btnConfirm;
        private Label lblPrice;
        private Panel panel2;
        private Label lblThoiGianDi;
        private Label lblThoiGianDon;
        private Label lblDiemDen;
        private Label lblDiemDi;
        private PictureBox pictureBox2;
    }
}