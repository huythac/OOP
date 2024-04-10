namespace ProjectOOP
{
    partial class formStart
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
            lblTitle = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxEnterphone = new TextBox();
            btnStartNow = new Button();
            label4 = new Label();
            btnGoogle = new Button();
            btnApple = new Button();
            btnFacebook = new Button();
            indicator = new Panel();
            SuspendLayout();
            // 
            // statusBar
            // 
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(-5, -1);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(573, 84);
            statusBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("SF Pro Display", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(241, 111, 51);
            lblTitle.Location = new Point(12, 155);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(310, 61);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Bắt đầu nào!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 231);
            label2.Name = "label2";
            label2.Size = new Size(528, 32);
            label2.TabIndex = 4;
            label2.Text = "Nhập số điện thoại của bạn. Chúng tôi sẽ gửi ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 275);
            label3.Name = "label3";
            label3.Size = new Size(319, 32);
            label3.TabIndex = 5;
            label3.Text = "cho bạn mã xác nhận OTP.";
            // 
            // tbxEnterphone
            // 
            tbxEnterphone.BackColor = Color.WhiteSmoke;
            tbxEnterphone.BorderStyle = BorderStyle.FixedSingle;
            tbxEnterphone.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxEnterphone.Location = new Point(21, 354);
            tbxEnterphone.Multiline = true;
            tbxEnterphone.Name = "tbxEnterphone";
            tbxEnterphone.Size = new Size(510, 72);
            tbxEnterphone.TabIndex = 6;
            tbxEnterphone.Text = "+ 84 948 744 123";
            // 
            // btnStartNow
            // 
            btnStartNow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStartNow.BackColor = Color.FromArgb(0, 94, 104);
            btnStartNow.FlatStyle = FlatStyle.Flat;
            btnStartNow.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartNow.ForeColor = Color.White;
            btnStartNow.Location = new Point(21, 458);
            btnStartNow.Name = "btnStartNow";
            btnStartNow.Size = new Size(510, 80);
            btnStartNow.TabIndex = 7;
            btnStartNow.Text = "Bắt đầu ngay!";
            btnStartNow.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(235, 576);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 8;
            label4.Text = "hoặc";
            // 
            // btnGoogle
            // 
            btnGoogle.Font = new Font("SF Pro Display", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoogle.ForeColor = Color.DimGray;
            btnGoogle.Image = Properties.Resources.flat_color_icons_google;
            btnGoogle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGoogle.Location = new Point(21, 634);
            btnGoogle.Name = "btnGoogle";
            btnGoogle.Padding = new Padding(110, 0, 110, 0);
            btnGoogle.Size = new Size(510, 80);
            btnGoogle.TabIndex = 9;
            btnGoogle.Text = "Đăng nhập với Google";
            btnGoogle.TextAlign = ContentAlignment.MiddleRight;
            btnGoogle.UseVisualStyleBackColor = true;
            // 
            // btnApple
            // 
            btnApple.Font = new Font("SF Pro Display", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnApple.ForeColor = Color.DimGray;
            btnApple.Image = Properties.Resources.uim_apple;
            btnApple.ImageAlign = ContentAlignment.MiddleLeft;
            btnApple.Location = new Point(21, 734);
            btnApple.Name = "btnApple";
            btnApple.Padding = new Padding(110, 0, 125, 0);
            btnApple.Size = new Size(510, 80);
            btnApple.TabIndex = 10;
            btnApple.Text = "Đăng nhập với Apple";
            btnApple.TextAlign = ContentAlignment.MiddleRight;
            btnApple.UseVisualStyleBackColor = true;
            // 
            // btnFacebook
            // 
            btnFacebook.Font = new Font("SF Pro Display", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnFacebook.ForeColor = Color.DimGray;
            btnFacebook.Image = Properties.Resources.logos_facebook;
            btnFacebook.ImageAlign = ContentAlignment.MiddleLeft;
            btnFacebook.Location = new Point(21, 835);
            btnFacebook.Name = "btnFacebook";
            btnFacebook.Padding = new Padding(90, 0, 100, 0);
            btnFacebook.Size = new Size(510, 80);
            btnFacebook.TabIndex = 11;
            btnFacebook.Text = "Đăng nhập với Facebook";
            btnFacebook.TextAlign = ContentAlignment.MiddleRight;
            btnFacebook.UseVisualStyleBackColor = true;
            // 
            // indicator
            // 
            indicator.BackgroundImage = Properties.Resources.homeIndicator1;
            indicator.Location = new Point(-5, 1150);
            indicator.Name = "indicator";
            indicator.Size = new Size(573, 50);
            indicator.TabIndex = 12;
            // 
            // formStart
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(561, 1202);
            Controls.Add(indicator);
            Controls.Add(btnFacebook);
            Controls.Add(btnApple);
            Controls.Add(btnGoogle);
            Controls.Add(label4);
            Controls.Add(btnStartNow);
            Controls.Add(tbxEnterphone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(statusBar);
            Name = "formStart";
            Text = "formStart";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel statusBar;
        private Label lblTitle;
        private Label label2;
        private Label label3;
        private TextBox tbxEnterphone;
        private Button btnStartNow;
        private Label label4;
        private Button btnGoogle;
        private Button btnApple;
        private Button btnFacebook;
        private Panel indicator;
    }
}