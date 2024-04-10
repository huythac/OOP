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
            label1.Font = new Font("SF Pro Display", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 111, 51);
            label1.Location = new Point(12, 155);
            label1.Name = "label1";
            label1.Size = new Size(258, 61);
            label1.TabIndex = 3;
            label1.Text = "Nhập OTP";
            // 
            // statusBar
            // 
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(-5, -1);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(573, 84);
            statusBar.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 246);
            label2.Name = "label2";
            label2.Size = new Size(502, 32);
            label2.TabIndex = 5;
            label2.Text = " Đã gủi OTP đến số điện thoại 012345678 ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 290);
            label3.Name = "label3";
            label3.Size = new Size(263, 32);
            label3.TabIndex = 6;
            label3.Text = "để xác nhận tài khoản";
            // 
            // tbxEnterOTP
            // 
            tbxEnterOTP.BackColor = Color.WhiteSmoke;
            tbxEnterOTP.BorderStyle = BorderStyle.FixedSingle;
            tbxEnterOTP.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxEnterOTP.Location = new Point(22, 351);
            tbxEnterOTP.Multiline = true;
            tbxEnterOTP.Name = "tbxEnterOTP";
            tbxEnterOTP.Size = new Size(510, 72);
            tbxEnterOTP.TabIndex = 7;
            // 
            // panelNumberKey
            // 
            panelNumberKey.BackgroundImage = Properties.Resources.NumericKeyboard1;
            panelNumberKey.Location = new Point(-4, 748);
            panelNumberKey.Name = "panelNumberKey";
            panelNumberKey.Size = new Size(566, 453);
            panelNumberKey.TabIndex = 8;
            // 
            // btnStartNow
            // 
            btnStartNow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStartNow.BackColor = Color.FromArgb(0, 94, 104);
            btnStartNow.FlatStyle = FlatStyle.Flat;
            btnStartNow.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartNow.ForeColor = Color.White;
            btnStartNow.Location = new Point(22, 649);
            btnStartNow.Name = "btnStartNow";
            btnStartNow.Size = new Size(510, 80);
            btnStartNow.TabIndex = 9;
            btnStartNow.Text = "Xác nhận";
            btnStartNow.UseVisualStyleBackColor = false;
            // 
            // formOTP
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(561, 1202);
            Controls.Add(btnStartNow);
            Controls.Add(panelNumberKey);
            Controls.Add(tbxEnterOTP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(statusBar);
            Controls.Add(label1);
            Name = "formOTP";
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