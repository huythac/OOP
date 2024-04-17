namespace ProjectOOP
{
    partial class formMoving
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lblDerectionDetails = new Label();
            indicator = new Panel();
            lblDerection = new Label();
            btnSuccess = new Button();
            btnOrderDetails = new Button();
            lblType = new Label();
            btnReject = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Derection_with_AR_Version2;
            pictureBox1.Location = new Point(-5, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(567, 791);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblDerectionDetails);
            panel1.Controls.Add(indicator);
            panel1.Controls.Add(lblDerection);
            panel1.Controls.Add(btnSuccess);
            panel1.Controls.Add(btnOrderDetails);
            panel1.Controls.Add(lblType);
            panel1.Controls.Add(btnReject);
            panel1.Location = new Point(-7, 687);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 518);
            panel1.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.homeIndicator1;
            panel2.Location = new Point(1, 467);
            panel2.Name = "panel2";
            panel2.Size = new Size(572, 50);
            panel2.TabIndex = 37;
            // 
            // lblDerectionDetails
            // 
            lblDerectionDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDerectionDetails.AutoSize = true;
            lblDerectionDetails.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            lblDerectionDetails.Location = new Point(30, 170);
            lblDerectionDetails.Name = "lblDerectionDetails";
            lblDerectionDetails.Size = new Size(413, 64);
            lblDerectionDetails.TabIndex = 3;
            lblDerectionDetails.Text = "162 Nguyễn Tri Phương, Phường 5, \nQuận 10";
            // 
            // indicator
            // 
            indicator.BackgroundImage = Properties.Resources.homeIndicator1;
            indicator.Location = new Point(-2, 662);
            indicator.Name = "indicator";
            indicator.Size = new Size(573, 50);
            indicator.TabIndex = 36;
            // 
            // lblDerection
            // 
            lblDerection.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDerection.AutoSize = true;
            lblDerection.Font = new Font("SF Pro Display", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point);
            lblDerection.Location = new Point(30, 90);
            lblDerection.Name = "lblDerection";
            lblDerection.Size = new Size(400, 57);
            lblDerection.TabIndex = 1;
            lblDerection.Text = "500m nữa rẽ phải";
            // 
            // btnSuccess
            // 
            btnSuccess.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSuccess.BackColor = Color.FromArgb(0, 94, 104);
            btnSuccess.FlatStyle = FlatStyle.Flat;
            btnSuccess.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuccess.ForeColor = Color.White;
            btnSuccess.Location = new Point(30, 272);
            btnSuccess.Name = "btnSuccess";
            btnSuccess.Size = new Size(510, 80);
            btnSuccess.TabIndex = 35;
            btnSuccess.Text = "Hoàn tất chuyến đi";
            btnSuccess.UseVisualStyleBackColor = false;
            btnSuccess.Click += btnSuccess_Click;
            // 
            // btnOrderDetails
            // 
            btnOrderDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOrderDetails.BackColor = Color.FromArgb(230, 239, 240);
            btnOrderDetails.FlatStyle = FlatStyle.Flat;
            btnOrderDetails.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrderDetails.ForeColor = Color.FromArgb(0, 94, 104);
            btnOrderDetails.Location = new Point(30, 378);
            btnOrderDetails.Name = "btnOrderDetails";
            btnOrderDetails.Size = new Size(507, 80);
            btnOrderDetails.TabIndex = 34;
            btnOrderDetails.Text = "Chi tiết đơn hàng";
            btnOrderDetails.UseVisualStyleBackColor = false;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.BackColor = Color.FromArgb(0, 94, 104);
            lblType.BorderStyle = BorderStyle.FixedSingle;
            lblType.Font = new Font("Segoe UI Semibold", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.ForeColor = Color.White;
            lblType.ImageAlign = ContentAlignment.MiddleLeft;
            lblType.Location = new Point(30, 19);
            lblType.Margin = new Padding(0);
            lblType.Name = "lblType";
            lblType.Padding = new Padding(8, 6, 8, 6);
            lblType.Size = new Size(165, 51);
            lblType.TabIndex = 30;
            lblType.Text = "UEH Thing";
            lblType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnReject
            // 
            btnReject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReject.BackColor = Color.FromArgb(255, 192, 192);
            btnReject.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnReject.ForeColor = Color.Red;
            btnReject.Location = new Point(1124, 0);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(183, 70);
            btnReject.TabIndex = 30;
            btnReject.Text = "Từ chối";
            btnReject.UseVisualStyleBackColor = false;
            // 
            // formMoving
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 1202);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "formMoving";
            Text = "formMoving";
            Load += formMoving_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnSuccess;
        private Button btnOrderDetails;
        private Label lblType;
        private Button btnReject;
        private Label lblDerectionDetails;
        private Panel indicator;
        private Label lblDerection;
        private Panel panel2;
    }
}