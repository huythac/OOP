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
            statusBar = new Panel();
            pbox = new PictureBox();
            panelNotification = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnCompleted = new Button();
            ((System.ComponentModel.ISupportInitialize)pbox).BeginInit();
            panelNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // statusBar
            // 
            statusBar.BackColor = Color.Transparent;
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(-3, -1);
            statusBar.Margin = new Padding(2);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(382, 56);
            statusBar.TabIndex = 15;
            // 
            // pbox
            // 
            pbox.BackColor = Color.Transparent;
            pbox.Location = new Point(104, 151);
            pbox.Margin = new Padding(2);
            pbox.Name = "pbox";
            pbox.Size = new Size(67, 67);
            pbox.TabIndex = 16;
            pbox.TabStop = false;
            // 
            // panelNotification
            // 
            panelNotification.BackColor = Color.White;
            panelNotification.Controls.Add(pictureBox1);
            panelNotification.Controls.Add(label1);
            panelNotification.Location = new Point(17, 248);
            panelNotification.Margin = new Padding(2);
            panelNotification.Name = "panelNotification";
            panelNotification.Size = new Size(340, 305);
            panelNotification.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(114, 95);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 101);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(295, 71);
            label1.TabIndex = 18;
            label1.Text = "Chúc mừng bạn đã hoàn thành đơn hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.homeIndicator1;
            panel2.Location = new Point(-3, 767);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 33);
            panel2.TabIndex = 38;
            // 
            // btnCompleted
            // 
            btnCompleted.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCompleted.BackColor = Color.FromArgb(0, 94, 104);
            btnCompleted.FlatStyle = FlatStyle.Flat;
            btnCompleted.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompleted.ForeColor = Color.White;
            btnCompleted.Location = new Point(17, 622);
            btnCompleted.Margin = new Padding(2);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(340, 53);
            btnCompleted.TabIndex = 39;
            btnCompleted.Text = "Hoàn tất đơn hàng";
            btnCompleted.UseVisualStyleBackColor = false;
            btnCompleted.Click += btnSuccess_Click;
            // 
            // formCompleted
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 703);
            Controls.Add(btnCompleted);
            Controls.Add(panel2);
            Controls.Add(panelNotification);
            Controls.Add(pbox);
            Controls.Add(statusBar);
            Margin = new Padding(2);
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

        private Panel statusBar;
        private PictureBox pbox;
        private Panel panelNotification;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnCompleted;
    }
}