namespace ProjectOOP
{
    partial class formSplash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splashImage = new Panel();
            label1 = new Label();
            label2 = new Label();
            btnStartNow = new Button();
            homeIndicator = new Panel();
            SuspendLayout();
            // 
            // splashImage
            // 
            splashImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            splashImage.BackgroundImage = Properties.Resources.SplashImage_Indicator;
            splashImage.Location = new Point(0, -2);
            splashImage.Name = "splashImage";
            splashImage.Size = new Size(562, 847);
            splashImage.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 111, 51);
            label1.Location = new Point(25, 890);
            label1.Name = "label1";
            label1.Size = new Size(525, 61);
            label1.TabIndex = 2;
            label1.Text = "Lái xe và kiếm tiền với ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(241, 111, 51);
            label2.Location = new Point(25, 959);
            label2.Name = "label2";
            label2.Size = new Size(284, 61);
            label2.TabIndex = 3;
            label2.Text = "UEH Driver.";
            // 
            // btnStartNow
            // 
            btnStartNow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStartNow.BackColor = Color.FromArgb(0, 94, 104);
            btnStartNow.FlatStyle = FlatStyle.Flat;
            btnStartNow.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartNow.ForeColor = Color.White;
            btnStartNow.Location = new Point(25, 1057);
            btnStartNow.Name = "btnStartNow";
            btnStartNow.Size = new Size(510, 80);
            btnStartNow.TabIndex = 4;
            btnStartNow.Text = "Bắt đầu ngay!";
            btnStartNow.UseVisualStyleBackColor = false;
            // 
            // homeIndicator
            // 
            homeIndicator.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            homeIndicator.BackgroundImage = Properties.Resources.homeIndicator;
            homeIndicator.Location = new Point(-9, 1156);
            homeIndicator.Name = "homeIndicator";
            homeIndicator.Size = new Size(581, 48);
            homeIndicator.TabIndex = 5;
            // 
            // formSplash
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 1202);
            Controls.Add(homeIndicator);
            Controls.Add(btnStartNow);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(splashImage);
            Name = "formSplash";
            Text = "formSplash";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel splashImage;
        private Label label1;
        private Label label2;
        private Button btnStartNow;
        private Panel homeIndicator;
    }
}
