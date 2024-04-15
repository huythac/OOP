namespace ProjectOOP
{
    partial class formOTP
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
            label1 = new Label();
            statusBar = new Panel();
            label2 = new Label();
            label3 = new Label();
            tbxEnterOTP = new TextBox();
            panelNumberKey = new Panel();
            btnStartNow = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 111, 51);
            label1.Location = new Point(8, 103);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 42);
            label1.TabIndex = 3;
            label1.Text = "Nhập OTP";
            // 
            // statusBar
            // 
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(-3, -1);
            statusBar.Margin = new Padding(2, 2, 2, 2);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(382, 56);
            statusBar.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 164);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(365, 24);
            label2.TabIndex = 5;
            label2.Text = " Đã gủi OTP đến số điện thoại 012345678 ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 193);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(196, 24);
            label3.TabIndex = 6;
            label3.Text = "để xác nhận tài khoản";
            // 
            // tbxEnterOTP
            // 
            tbxEnterOTP.BackColor = Color.WhiteSmoke;
            tbxEnterOTP.BorderStyle = BorderStyle.FixedSingle;
            tbxEnterOTP.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxEnterOTP.Location = new Point(15, 234);
            tbxEnterOTP.Margin = new Padding(2, 2, 2, 2);
            tbxEnterOTP.Multiline = true;
            tbxEnterOTP.Name = "tbxEnterOTP";
            tbxEnterOTP.Size = new Size(341, 49);
            tbxEnterOTP.TabIndex = 7;
            // 
            // panelNumberKey
            // 
            panelNumberKey.BackgroundImage = Properties.Resources.NumericKeyboard1;
            panelNumberKey.Location = new Point(-3, 499);
            panelNumberKey.Margin = new Padding(2, 2, 2, 2);
            panelNumberKey.Name = "panelNumberKey";
            panelNumberKey.Size = new Size(377, 302);
            panelNumberKey.TabIndex = 8;
            // 
            // btnStartNow
            // 
            btnStartNow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStartNow.BackColor = Color.FromArgb(0, 94, 104);
            btnStartNow.FlatStyle = FlatStyle.Flat;
            btnStartNow.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartNow.ForeColor = Color.White;
            btnStartNow.Location = new Point(15, 433);
            btnStartNow.Margin = new Padding(2, 2, 2, 2);
            btnStartNow.Name = "btnStartNow";
            btnStartNow.Size = new Size(340, 53);
            btnStartNow.TabIndex = 9;
            btnStartNow.Text = "Xác nhận";
            btnStartNow.UseVisualStyleBackColor = false;
            // 
            // formOTP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(374, 703);
            Controls.Add(btnStartNow);
            Controls.Add(panelNumberKey);
            Controls.Add(tbxEnterOTP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(statusBar);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "formOTP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formOTP";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel statusBar;
        private Label label2;
        private Label label3;
        private TextBox tbxEnterOTP;
        private Panel panelNumberKey;
        private Button btnStartNow;
    }
}