namespace ProjectOOP
{
    partial class formCompleted
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
            pbox = new PictureBox();
            panelNotification = new Panel();
            lblTienDoanhThu = new Label();
            lblTienThuNhap = new Label();
            lblDoanhThu = new Label();
            lblThuNhap = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnCompleted = new Button();
            ((System.ComponentModel.ISupportInitialize)pbox).BeginInit();
            panelNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pbox
            // 
            pbox.BackColor = Color.Transparent;
            pbox.Image = Properties.Resources.Navigation_icon___small;
            pbox.Location = new Point(156, 227);
            pbox.Name = "pbox";
            pbox.Size = new Size(100, 100);
            pbox.TabIndex = 16;
            pbox.TabStop = false;
            // 
            // panelNotification
            // 
            panelNotification.BackColor = Color.White;
            panelNotification.Controls.Add(lblTienDoanhThu);
            panelNotification.Controls.Add(lblTienThuNhap);
            panelNotification.Controls.Add(lblDoanhThu);
            panelNotification.Controls.Add(lblThuNhap);
            panelNotification.Controls.Add(pictureBox1);
            panelNotification.Controls.Add(label1);
            panelNotification.Location = new Point(26, 372);
            panelNotification.Name = "panelNotification";
            panelNotification.Size = new Size(510, 457);
            panelNotification.TabIndex = 17;
            // 
            // lblTienDoanhThu
            // 
            lblTienDoanhThu.AutoSize = true;
            lblTienDoanhThu.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTienDoanhThu.ForeColor = Color.FromArgb(241, 111, 51);
            lblTienDoanhThu.Location = new Point(245, 384);
            lblTienDoanhThu.Name = "lblTienDoanhThu";
            lblTienDoanhThu.Size = new Size(145, 33);
            lblTienDoanhThu.TabIndex = 23;
            lblTienDoanhThu.Text = "+20.000đ";
            // 
            // lblTienThuNhap
            // 
            lblTienThuNhap.AutoSize = true;
            lblTienThuNhap.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTienThuNhap.ForeColor = Color.FromArgb(241, 111, 51);
            lblTienThuNhap.Location = new Point(245, 337);
            lblTienThuNhap.Name = "lblTienThuNhap";
            lblTienThuNhap.Size = new Size(157, 33);
            lblTienThuNhap.TabIndex = 22;
            lblTienThuNhap.Text = "+120.000đ";
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.AutoSize = true;
            lblDoanhThu.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDoanhThu.Location = new Point(90, 384);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(158, 33);
            lblDoanhThu.TabIndex = 21;
            lblDoanhThu.Text = "Doanh thu: ";
            lblDoanhThu.Click += lblDoanhThu_Click;
            // 
            // lblThuNhap
            // 
            lblThuNhap.AutoSize = true;
            lblThuNhap.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblThuNhap.Location = new Point(101, 337);
            lblThuNhap.Name = "lblThuNhap";
            lblThuNhap.Size = new Size(146, 33);
            lblThuNhap.TabIndex = 20;
            lblThuNhap.Text = "Thu nhập: ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.iconSuccess;
            pictureBox1.Location = new Point(171, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 151);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Font = new Font("SF Pro Display", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 22);
            label1.Name = "label1";
            label1.Size = new Size(443, 106);
            label1.TabIndex = 18;
            label1.Text = "Chúc mừng bạn đã hoàn thành đơn hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.homeIndicator1;
            panel2.Location = new Point(-4, 1151);
            panel2.Name = "panel2";
            panel2.Size = new Size(572, 50);
            panel2.TabIndex = 38;
            // 
            // btnCompleted
            // 
            btnCompleted.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCompleted.BackColor = Color.FromArgb(0, 94, 104);
            btnCompleted.FlatStyle = FlatStyle.Flat;
            btnCompleted.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompleted.ForeColor = Color.White;
            btnCompleted.Location = new Point(26, 1036);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(510, 80);
            btnCompleted.TabIndex = 39;
            btnCompleted.Text = "Hoàn tất đơn hàng";
            btnCompleted.UseVisualStyleBackColor = false;
            btnCompleted.Click += btnCompleted_Click;
            // 
            // formCompleted
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MạpUpdate;
            ClientSize = new Size(561, 1202);
            Controls.Add(btnCompleted);
            Controls.Add(panel2);
            Controls.Add(panelNotification);
            Controls.Add(pbox);
            Controls.Add(statusBar);
            Name = "formCompleted";
            Text = "formCompletedcs";
            ((System.ComponentModel.ISupportInitialize)pbox).EndInit();
            panelNotification.ResumeLayout(false);
            panelNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel statusBar;
        private PictureBox pbox;
        private Panel panelNotification;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblThuNhap;
        private Label lblTienDoanhThu;
        private Label lblTienThuNhap;
        private Label lblDoanhThu;
        private Panel panel2;
        private Button btnCompleted;
    }
}