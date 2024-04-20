namespace ProjectOOP
{
    partial class formSignIn
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
            lbl1 = new Label();
            txtPhoneNumber = new TextBox();
            txtPassword = new TextBox();
            lblEnterPhone = new Label();
            label1 = new Label();
            btnDangNhap = new Button();
            indicator = new Panel();
            btnBack = new Button();
            SuspendLayout();
            // 
            // statusBar
            // 
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(-4, -2);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(573, 84);
            statusBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(241, 111, 51);
            lblTitle.Location = new Point(22, 176);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(323, 59);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Bắt đầu nào!";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Microsoft Sans Serif", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(22, 254);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(467, 31);
            lbl1.TabIndex = 5;
            lbl1.Text = "Đăng nhập để bắt đầu với UEH Driver";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.WhiteSmoke;
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPhoneNumber.Location = new Point(22, 380);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(510, 72);
            txtPhoneNumber.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(22, 531);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(510, 72);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.UseWaitCursor = true;
            // 
            // lblEnterPhone
            // 
            lblEnterPhone.AutoSize = true;
            lblEnterPhone.Font = new Font("Microsoft Sans Serif", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnterPhone.Location = new Point(22, 332);
            lblEnterPhone.Name = "lblEnterPhone";
            lblEnterPhone.Size = new Size(171, 31);
            lblEnterPhone.TabIndex = 9;
            lblEnterPhone.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 483);
            label1.Name = "label1";
            label1.Size = new Size(134, 31);
            label1.TabIndex = 10;
            label1.Text = "Password";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDangNhap.BackColor = Color.FromArgb(0, 94, 104);
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(22, 644);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(510, 80);
            btnDangNhap.TabIndex = 11;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // indicator
            // 
            indicator.BackgroundImage = Properties.Resources.homeIndicator1;
            indicator.Location = new Point(-10, 1152);
            indicator.Name = "indicator";
            indicator.Size = new Size(573, 50);
            indicator.TabIndex = 29;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.Transparent;
            btnBack.Image = Properties.Resources.iconArrow;
            btnBack.Location = new Point(28, 86);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(72, 72);
            btnBack.TabIndex = 30;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // formSignIn
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(561, 1202);
            Controls.Add(btnBack);
            Controls.Add(indicator);
            Controls.Add(btnDangNhap);
            Controls.Add(label1);
            Controls.Add(lblEnterPhone);
            Controls.Add(txtPassword);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lbl1);
            Controls.Add(lblTitle);
            Controls.Add(statusBar);
            Name = "formSignIn";
            Text = "DangNhap";
            Load += formSignIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel statusBar;
        private Label lblTitle;
        private Label lbl1;
        private TextBox txtPhoneNumber;
        private TextBox txtPassword;
        private Label lblEnterPhone;
        private Label label1;
        private Button btnDangNhap;
        private Panel indicator;
        private Button btnBack;
    }
}