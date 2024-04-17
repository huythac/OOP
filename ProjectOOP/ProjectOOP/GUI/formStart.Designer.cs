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
            statusBar.Location = new Point(-3, -1);
            statusBar.Margin = new Padding(2, 2, 2, 2);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(382, 56);
            statusBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(241, 111, 51);
            lblTitle.Location = new Point(8, 103);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(242, 42);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Bắt đầu nào!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 154);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(394, 24);
            label2.TabIndex = 4;
            label2.Text = "Nhập số điện thoại của bạn. Chúng tôi sẽ gửi ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 183);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(242, 24);
            label3.TabIndex = 5;
            label3.Text = "cho bạn mã xác nhận OTP.";
            // 
            // tbxEnterphone
            // 
            tbxEnterphone.BackColor = Color.WhiteSmoke;
            tbxEnterphone.BorderStyle = BorderStyle.FixedSingle;
            tbxEnterphone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxEnterphone.Location = new Point(14, 236);
            tbxEnterphone.Margin = new Padding(2, 2, 2, 2);
            tbxEnterphone.Multiline = true;
            tbxEnterphone.Name = "tbxEnterphone";
            tbxEnterphone.Size = new Size(341, 49);
            tbxEnterphone.TabIndex = 6;
            tbxEnterphone.Text = "+ 84 948 744 123";
            // 
            // btnStartNow
            // 
            btnStartNow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStartNow.BackColor = Color.FromArgb(0, 94, 104);
            btnStartNow.FlatStyle = FlatStyle.Flat;
            btnStartNow.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartNow.ForeColor = Color.White;
            btnStartNow.Location = new Point(14, 305);
            btnStartNow.Margin = new Padding(2, 2, 2, 2);
            btnStartNow.Name = "btnStartNow";
            btnStartNow.Size = new Size(340, 53);
            btnStartNow.TabIndex = 7;
            btnStartNow.Text = "Bắt đầu ngay!";
            btnStartNow.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(157, 384);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 24);
            label4.TabIndex = 8;
            label4.Text = "hoặc";
            // 
            // btnGoogle
            // 
            btnGoogle.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoogle.ForeColor = Color.DimGray;
            btnGoogle.Image = Properties.Resources.flat_color_icons_google;
            btnGoogle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGoogle.Location = new Point(14, 423);
            btnGoogle.Margin = new Padding(2, 2, 2, 2);
            btnGoogle.Name = "btnGoogle";
            btnGoogle.Padding = new Padding(73, 0, 73, 0);
            btnGoogle.Size = new Size(340, 53);
            btnGoogle.TabIndex = 9;
            btnGoogle.Text = "Đăng nhập với Google";
            btnGoogle.TextAlign = ContentAlignment.MiddleRight;
            btnGoogle.UseVisualStyleBackColor = true;
            // 
            // btnApple
            // 
            btnApple.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnApple.ForeColor = Color.DimGray;
            btnApple.Image = Properties.Resources.uim_apple;
            btnApple.ImageAlign = ContentAlignment.MiddleLeft;
            btnApple.Location = new Point(14, 489);
            btnApple.Margin = new Padding(2, 2, 2, 2);
            btnApple.Name = "btnApple";
            btnApple.Padding = new Padding(73, 0, 83, 0);
            btnApple.Size = new Size(340, 53);
            btnApple.TabIndex = 10;
            btnApple.Text = "Đăng nhập với Apple";
            btnApple.TextAlign = ContentAlignment.MiddleRight;
            btnApple.UseVisualStyleBackColor = true;
            // 
            // btnFacebook
            // 
            btnFacebook.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnFacebook.ForeColor = Color.DimGray;
            btnFacebook.Image = Properties.Resources.logos_facebook;
            btnFacebook.ImageAlign = ContentAlignment.MiddleLeft;
            btnFacebook.Location = new Point(14, 557);
            btnFacebook.Margin = new Padding(2, 2, 2, 2);
            btnFacebook.Name = "btnFacebook";
            btnFacebook.Padding = new Padding(60, 0, 67, 0);
            btnFacebook.Size = new Size(340, 53);
            btnFacebook.TabIndex = 11;
            btnFacebook.Text = "Đăng nhập với Facebook";
            btnFacebook.TextAlign = ContentAlignment.MiddleRight;
            btnFacebook.UseVisualStyleBackColor = true;
            // 
            // indicator
            // 
            indicator.BackgroundImage = Properties.Resources.homeIndicator1;
            indicator.Location = new Point(-3, 767);
            indicator.Margin = new Padding(2, 2, 2, 2);
            indicator.Name = "indicator";
            indicator.Size = new Size(382, 33);
            indicator.TabIndex = 12;
            // 
            // formStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(374, 703);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "formStart";
            StartPosition = FormStartPosition.CenterScreen;
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