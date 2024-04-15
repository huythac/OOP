namespace ProjectOOP
{
    partial class formHome
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            btnStart = new Button();
            btnMenu = new Button();
            pbox = new PictureBox();
            statusBar = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, 1116);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 92);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(143, 26);
            label1.Name = "label1";
            label1.Size = new Size(273, 32);
            label1.TabIndex = 0;
            label1.Text = "Bạn đang ngoại tuyến";
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStart.BackColor = Color.FromArgb(0, 94, 104);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(25, 1015);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(510, 80);
            btnStart.TabIndex = 8;
            btnStart.Text = "Bắt đầu";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnMenu
            // 
            btnMenu.Image = Properties.Resources.iconMenu;
            btnMenu.Location = new Point(25, 88);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(72, 72);
            btnMenu.TabIndex = 11;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pbox
            // 
            pbox.BackColor = Color.Transparent;
            pbox.Image = Properties.Resources.Navigation_icon___small;
            pbox.Location = new Point(188, 627);
            pbox.Name = "pbox";
            pbox.Size = new Size(100, 100);
            pbox.TabIndex = 13;
            pbox.TabStop = false;
            // 
            // statusBar
            // 
            statusBar.BackColor = Color.Transparent;
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(-5, -1);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(573, 84);
            statusBar.TabIndex = 14;
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MạpUpdate;
            ClientSize = new Size(561, 1202);
            Controls.Add(statusBar);
            Controls.Add(pbox);
            Controls.Add(btnMenu);
            Controls.Add(btnStart);
            Controls.Add(panel1);
            Name = "formHome";
            Text = "formHome";
            Load += formHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnStart;
        private Button btnMenu;
        private PictureBox pbox;
        private Panel statusBar;
        private System.Windows.Forms.Timer timer1;
    }
}