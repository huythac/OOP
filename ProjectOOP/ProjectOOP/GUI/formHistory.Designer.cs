namespace ProjectOOP
{
    partial class formHistory
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
            indicator = new Panel();
            btnBack = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            statusBar = new Panel();
            SuspendLayout();
            // 
            // indicator
            // 
            indicator.BackgroundImage = Properties.Resources.homeIndicator1;
            indicator.Location = new Point(-4, 1150);
            indicator.Name = "indicator";
            indicator.Size = new Size(573, 50);
            indicator.TabIndex = 28;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.Transparent;
            btnBack.Image = Properties.Resources.iconArrow;
            btnBack.Location = new Point(28, 106);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(72, 72);
            btnBack.TabIndex = 29;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 111, 51);
            label1.Location = new Point(106, 118);
            label1.Name = "label1";
            label1.Size = new Size(387, 57);
            label1.TabIndex = 33;
            label1.Text = "Lịch sử đơn hàng";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Food", "Thing", "xThing", "Trip" });
            comboBox1.Location = new Point(28, 264);
            comboBox1.Margin = new Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(499, 40);
            comboBox1.TabIndex = 34;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(0, 322);
            flowLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(561, 732);
            flowLayoutPanel1.TabIndex = 35;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // statusBar
            // 
            statusBar.BackColor = Color.Transparent;
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(-6, -3);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(573, 84);
            statusBar.TabIndex = 26;
            // 
            // formHistory
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(561, 1202);
            Controls.Add(statusBar);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(indicator);
            Name = "formHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formHistory";
            Load += formHistory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel indicator;
        private Button btnBack;
        private Label label1;
        private ComboBox comboBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private Panel statusBar;
    }
}