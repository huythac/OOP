namespace ProjectOOP
{
    partial class formCompleted
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
            pbox = new PictureBox();
            panelNotification = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnCompleted = new Button();
            statusBar = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbox).BeginInit();
            panelNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbox
            // 
            pbox.BackColor = Color.Transparent;
            pbox.Image = Properties.Resources.Navigation_icon___small;
            pbox.Location = new Point(156, 226);
            pbox.Name = "pbox";
            pbox.Size = new Size(100, 100);
            pbox.TabIndex = 16;
            pbox.TabStop = false;
            // 
            // panelNotification
            // 
            panelNotification.BackColor = Color.White;
            panelNotification.Controls.Add(pictureBox1);
            panelNotification.Controls.Add(label1);
            panelNotification.Location = new Point(26, 372);
            panelNotification.Name = "panelNotification";
            panelNotification.Size = new Size(510, 458);
            panelNotification.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.iconSuccess;
            pictureBox1.Location = new Point(171, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 152);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 22);
            label1.Name = "label1";
            label1.Size = new Size(442, 106);
            label1.TabIndex = 18;
            label1.Text = "Chúc mừng bạn đã hoàn thành đơn hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.homeIndicator1;
            panel2.Location = new Point(-4, 1150);
            panel2.Name = "panel2";
            panel2.Size = new Size(572, 50);
            panel2.TabIndex = 38;
            // 
            // btnCompleted
            // 
            btnCompleted.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCompleted.BackColor = Color.FromArgb(0, 94, 104);
            btnCompleted.FlatStyle = FlatStyle.Flat;
            btnCompleted.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompleted.ForeColor = Color.White;
            btnCompleted.Location = new Point(26, 933);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(510, 80);
            btnCompleted.TabIndex = 39;
            btnCompleted.Text = "Hoàn tất đơn hàng";
            btnCompleted.UseVisualStyleBackColor = false;
            btnCompleted.Click += btnSuccess_Click;
            // 
            // statusBar
            // 
            statusBar.BackColor = Color.Transparent;
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(-4, -2);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(573, 84);
            statusBar.TabIndex = 15;
            // 
            // formCompleted
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.NewMap1;
            ClientSize = new Size(561, 1202);
            Controls.Add(btnCompleted);
            Controls.Add(panel2);
            Controls.Add(panelNotification);
            Controls.Add(pbox);
            Controls.Add(statusBar);
            Name = "formCompleted";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formCompletedcs";
            Load += formCompleted_Load;
            ((System.ComponentModel.ISupportInitialize)pbox).EndInit();
            panelNotification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbox;
        private Panel panelNotification;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnCompleted;
        private Panel statusBar;
    }
}