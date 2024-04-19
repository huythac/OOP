﻿namespace ProjectOOP
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
            btnSignIn = new Button();
            SuspendLayout();
            // 
            // splashImage
            // 
            splashImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            splashImage.BackgroundImage = Properties.Resources.SplashImage_Indicator;
            splashImage.Location = new Point(0, -1);
            splashImage.Margin = new Padding(2);
            splashImage.Name = "splashImage";
            splashImage.Size = new Size(421, 531);
            splashImage.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 111, 51);
            label1.Location = new Point(11, 532);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(418, 42);
            label1.TabIndex = 2;
            label1.Text = "Lái xe và kiếm tiền với ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(241, 111, 51);
            label2.Location = new Point(11, 578);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(227, 42);
            label2.TabIndex = 3;
            label2.Text = "UEH Driver.";
            // 
            // btnStartNow
            // 
            btnStartNow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStartNow.BackColor = Color.FromArgb(0, 94, 104);
            btnStartNow.FlatStyle = FlatStyle.Flat;
            btnStartNow.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartNow.ForeColor = Color.White;
            btnStartNow.Location = new Point(201, 637);
            btnStartNow.Margin = new Padding(2);
            btnStartNow.Name = "btnStartNow";
            btnStartNow.Size = new Size(208, 53);
            btnStartNow.TabIndex = 4;
            btnStartNow.Text = "Đăng nhập";
            btnStartNow.UseVisualStyleBackColor = false;
            btnStartNow.Click += btnStartNow_Click;
            // 
            // homeIndicator
            // 
            homeIndicator.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            homeIndicator.BackgroundImage = Properties.Resources.homeIndicator;
            homeIndicator.Location = new Point(-6, 826);
            homeIndicator.Margin = new Padding(2);
            homeIndicator.Name = "homeIndicator";
            homeIndicator.Size = new Size(433, 32);
            homeIndicator.TabIndex = 5;
            // 
            // btnSignIn
            // 
            btnSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSignIn.BackColor = Color.FromArgb(230, 239, 240);
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.ForeColor = Color.FromArgb(0, 94, 104);
            btnSignIn.Location = new Point(11, 637);
            btnSignIn.Margin = new Padding(2);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(186, 53);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Đăng ký";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // formSplash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 758);
            Controls.Add(btnSignIn);
            Controls.Add(homeIndicator);
            Controls.Add(btnStartNow);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(splashImage);
            Margin = new Padding(2);
            Name = "formSplash";
            Text = "formSplash";
            WindowState = FormWindowState.Minimized;
            Load += formSplash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel splashImage;
        private Label label1;
        private Label label2;
        private Button btnStartNow;
        private Panel homeIndicator;
        private Button btnSignIn;
    }
}