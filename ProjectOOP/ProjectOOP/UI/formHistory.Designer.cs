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
            ListViewGroup listViewGroup2 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "" }, -1, Color.Empty, Color.Empty, new Font("SF Pro Display", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point));
            indicator = new Panel();
            statusBar = new Panel();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txtId = new TextBox();
            btnSearch = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // indicator
            // 
            indicator.BackgroundImage = Properties.Resources.homeIndicator1;
            indicator.Location = new Point(-5, 1150);
            indicator.Name = "indicator";
            indicator.Size = new Size(573, 50);
            indicator.TabIndex = 28;
            // 
            // statusBar
            // 
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(0, 0);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(573, 84);
            statusBar.TabIndex = 20;
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
            btnBack.TabIndex = 29;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.iconMagnifying_glass;
            pictureBox1.Location = new Point(13, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 43);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(29, 251);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 64);
            panel1.TabIndex = 31;
            // 
            // txtId
            // 
            txtId.BackColor = Color.WhiteSmoke;
            txtId.BorderStyle = BorderStyle.None;
            txtId.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(66, 16);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(296, 36);
            txtId.TabIndex = 32;
            txtId.Text = "   Nhập ID đơn hàng";
            txtId.MouseClick += txtId_MouseClick;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(0, 94, 104);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(409, 251);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 64);
            btnSearch.TabIndex = 31;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            listView1.Groups.AddRange(new ListViewGroup[] { listViewGroup2 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView1.Location = new Point(29, 335);
            listView1.Name = "listView1";
            listView1.Size = new Size(508, 782);
            listView1.TabIndex = 32;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 111, 51);
            label1.Location = new Point(29, 181);
            label1.Name = "label1";
            label1.Size = new Size(337, 50);
            label1.TabIndex = 33;
            label1.Text = "Lịch sử đơn hàng";
            // 
            // formHistory
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(561, 1202);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(btnSearch);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(statusBar);
            Controls.Add(indicator);
            Name = "formHistory";
            Text = "formHistory";
            Load += formHistory_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel indicator;
        private Panel statusBar;
        private Button btnBack;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnSearch;
        private TextBox txtId;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Label label1;
    }
}