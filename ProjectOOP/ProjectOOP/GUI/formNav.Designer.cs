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
            btnMessage = new Button();
            btnSearch = new Button();
            nav = new Panel();
            btnStartNow = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            panel1.Location = new Point(-4, 744);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 61);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(215, 24);
            label1.TabIndex = 0;
            label1.Text = "Bạn đang ngoại tuyến";
            // 
            // btnMessage
            // 
            btnMessage.Image = Properties.Resources.iconMessage;
            btnMessage.Location = new Point(309, 616);
            btnMessage.Margin = new Padding(2);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(48, 48);
            btnMessage.TabIndex = 11;
            btnMessage.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.IconSearch;
            btnSearch.Location = new Point(309, 59);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(48, 48);
            btnSearch.TabIndex = 13;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // nav
            // 
            nav.BackColor = Color.White;
            nav.Controls.Add(btnStartNow);
            nav.Controls.Add(button4);
            nav.Controls.Add(button3);
            nav.Controls.Add(button2);
            nav.Controls.Add(button1);
            nav.Controls.Add(btnThongTinTaiKhoan);
            nav.Controls.Add(pictureBox2);
            nav.Controls.Add(pictureBox1);
            nav.Controls.Add(lblRating);
            nav.Controls.Add(lblName);
            nav.Location = new Point(-4, 1);
            nav.Margin = new Padding(2);
            nav.Name = "nav";
            nav.Size = new Size(298, 802);
            nav.TabIndex = 14;
            // 
            // btnStartNow
            // 
            btnStartNow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStartNow.BackColor = Color.FromArgb(0, 94, 104);
            btnStartNow.FlatStyle = FlatStyle.Flat;
            btnStartNow.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartNow.ForeColor = Color.White;
            btnStartNow.Location = new Point(29, 717);
            btnStartNow.Margin = new Padding(2);
            btnStartNow.Name = "btnStartNow";
            btnStartNow.Size = new Size(239, 53);
            btnStartNow.TabIndex = 14;
            btnStartNow.Text = "Bắt đầu";
            btnStartNow.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Microsoft Sans Serif", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(241, 111, 51);
            button4.Location = new Point(2, 413);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Padding = new Padding(0, 0, 147, 0);
            button4.Size = new Size(296, 48);
            button4.TabIndex = 13;
            button4.Text = "Hộp thư";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Microsoft Sans Serif", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(241, 111, 51);
            button3.Location = new Point(2, 351);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Padding = new Padding(0, 0, 20, 0);
            button3.Size = new Size(296, 48);
            button3.TabIndex = 12;
            button3.Text = "Tài khoản thanh toán";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Microsoft Sans Serif", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(241, 111, 51);
            button2.Location = new Point(2, 291);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Padding = new Padding(0, 0, 47, 0);
            button2.Size = new Size(296, 48);
            button2.TabIndex = 11;
            button2.Text = "Số dư và thu nhập";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Microsoft Sans Serif", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(241, 111, 51);
            button1.Location = new Point(2, 230);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 0, 50, 0);
            button1.Size = new Size(296, 48);
            button1.TabIndex = 10;
            button1.Text = "Lịch sử chuyến đi";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnThongTinTaiKhoan
            // 
            btnThongTinTaiKhoan.BackColor = Color.White;
            btnThongTinTaiKhoan.Font = new Font("Microsoft Sans Serif", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnThongTinTaiKhoan.ForeColor = Color.FromArgb(241, 111, 51);
            btnThongTinTaiKhoan.Location = new Point(2, 170);
            btnThongTinTaiKhoan.Margin = new Padding(2);
            btnThongTinTaiKhoan.Name = "btnThongTinTaiKhoan";
            btnThongTinTaiKhoan.Padding = new Padding(0, 0, 40, 0);
            btnThongTinTaiKhoan.Size = new Size(296, 48);
            btnThongTinTaiKhoan.TabIndex = 9;
            btnThongTinTaiKhoan.Text = "Thông tin tài khoản";
            btnThongTinTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Avatar;
            pictureBox2.Location = new Point(29, 57);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 56);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconStar;
            pictureBox1.Location = new Point(95, 87);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Microsoft Sans Serif", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblRating.ForeColor = Color.FromArgb(64, 64, 64);
            lblRating.Location = new Point(118, 88);
            lblRating.Margin = new Padding(2, 0, 2, 0);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(49, 24);
            lblRating.TabIndex = 5;
            lblRating.Text = "4.95";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(241, 111, 51);
            lblName.Location = new Point(95, 57);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(132, 29);
            lblName.TabIndex = 4;
            lblName.Text = "Thành Đạt";
            // 
            // formNav
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MapHomepage1;
            ClientSize = new Size(374, 703);
            Controls.Add(nav);
            Controls.Add(btnSearch);
            Controls.Add(btnMessage);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "formNav";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnMessage;
        private Button btnSearch;
        private Panel nav;
        private Label lblName;
        private Label lblRating;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnThongTinTaiKhoan;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button btnStartNow;
    }
}