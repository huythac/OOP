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
            panel1 = new Panel();
            label1 = new Label();
            btnStartNow = new Button();
            btnOption = new Button();
            btnMessage = new Button();
            btnMenu = new Button();
            btnSearch = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, 744);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 61);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(215, 24);
            label1.TabIndex = 0;
            label1.Text = "Bạn đang ngoại tuyến";
            // 
            // btnStartNow
            // 
            btnStartNow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStartNow.BackColor = Color.FromArgb(0, 94, 104);
            btnStartNow.FlatStyle = FlatStyle.Flat;
            btnStartNow.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartNow.ForeColor = Color.White;
            btnStartNow.Location = new Point(26, 639);
            btnStartNow.Margin = new Padding(2);
            btnStartNow.Name = "btnStartNow";
            btnStartNow.Size = new Size(280, 53);
            btnStartNow.TabIndex = 8;
            btnStartNow.Text = "Bắt đầu";
            btnStartNow.UseVisualStyleBackColor = false;
            btnStartNow.Click += btnStartNow_Click;
            // 
            // btnOption
            // 
            btnOption.Image = Properties.Resources.iconOption;
            btnOption.Location = new Point(26, 578);
            btnOption.Margin = new Padding(2);
            btnOption.Name = "btnOption";
            btnOption.Size = new Size(48, 48);
            btnOption.TabIndex = 9;
            btnOption.UseVisualStyleBackColor = true;
            // 
            // btnMessage
            // 
            btnMessage.Image = Properties.Resources.iconMessage;
            btnMessage.Location = new Point(318, 578);
            btnMessage.Margin = new Padding(2);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(48, 48);
            btnMessage.TabIndex = 10;
            btnMessage.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Image = Properties.Resources.iconMenu;
            btnMenu.Location = new Point(17, 59);
            btnMenu.Margin = new Padding(2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(48, 48);
            btnMenu.TabIndex = 11;
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.IconSearch;
            btnSearch.Location = new Point(309, 59);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(48, 48);
            btnSearch.TabIndex = 12;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MapHomepage;
            ClientSize = new Size(374, 703);
            Controls.Add(btnSearch);
            Controls.Add(btnMenu);
            Controls.Add(btnMessage);
            Controls.Add(btnOption);
            Controls.Add(btnStartNow);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "formHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formHome";
            Load += formHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnStartNow;
        private Button btnOption;
        private Button btnMessage;
        private Button btnMenu;
        private Button btnSearch;
    }
}