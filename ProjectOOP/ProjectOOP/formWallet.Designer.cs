namespace ProjectOOP
{
    partial class formWallet
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
            label1 = new Label();
            btnBack = new Button();
            pboxQR = new PictureBox();
            panel1 = new Panel();
            lblBankNumber = new Label();
            lblSoTk = new Label();
            indicator = new Panel();
            ((System.ComponentModel.ISupportInitialize)pboxQR).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // statusBar
            // 
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(0, 0);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(573, 84);
            statusBar.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 111, 51);
            label1.Location = new Point(29, 181);
            label1.Name = "label1";
            label1.Size = new Size(405, 50);
            label1.TabIndex = 21;
            label1.Text = "Tài khoản thanh toán";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.Transparent;
            btnBack.Image = Properties.Resources.iconArrow;
            btnBack.Location = new Point(29, 85);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(72, 72);
            btnBack.TabIndex = 20;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pboxQR
            // 
            pboxQR.BackColor = Color.Transparent;
            pboxQR.Image = Properties.Resources.QR;
            pboxQR.Location = new Point(65, 271);
            pboxQR.Name = "pboxQR";
            pboxQR.Size = new Size(423, 423);
            pboxQR.TabIndex = 22;
            pboxQR.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 239, 240);
            panel1.Controls.Add(lblBankNumber);
            panel1.Location = new Point(29, 775);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 74);
            panel1.TabIndex = 23;
            // 
            // lblBankNumber
            // 
            lblBankNumber.AutoSize = true;
            lblBankNumber.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBankNumber.ForeColor = Color.FromArgb(0, 94, 104);
            lblBankNumber.Location = new Point(127, 21);
            lblBankNumber.Name = "lblBankNumber";
            lblBankNumber.Size = new Size(228, 33);
            lblBankNumber.TabIndex = 24;
            lblBankNumber.Text = "0123 4567 8910";
            // 
            // lblSoTk
            // 
            lblSoTk.AutoSize = true;
            lblSoTk.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoTk.ForeColor = Color.FromArgb(0, 94, 104);
            lblSoTk.Location = new Point(189, 728);
            lblSoTk.Name = "lblSoTk";
            lblSoTk.Size = new Size(167, 33);
            lblSoTk.TabIndex = 25;
            lblSoTk.Text = "Số tài khoản";
            // 
            // indicator
            // 
            indicator.BackgroundImage = Properties.Resources.homeIndicator1;
            indicator.Location = new Point(-5, 1150);
            indicator.Name = "indicator";
            indicator.Size = new Size(573, 50);
            indicator.TabIndex = 26;
            // 
            // formWallet
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(561, 1202);
            Controls.Add(indicator);
            Controls.Add(lblSoTk);
            Controls.Add(panel1);
            Controls.Add(pboxQR);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(statusBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "formWallet";
            Text = "formWallet";
            ((System.ComponentModel.ISupportInitialize)pboxQR).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel statusBar;
        private Label label1;
        private Button btnBack;
        private PictureBox pboxQR;
        private Panel panel1;
        private Label lblBankNumber;
        private Label lblSoTk;
        private Panel indicator;
    }
}