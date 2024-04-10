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
            // btnStartNow
            // 
            btnStartNow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStartNow.BackColor = Color.FromArgb(0, 94, 104);
            btnStartNow.FlatStyle = FlatStyle.Flat;
            btnStartNow.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartNow.ForeColor = Color.White;
            btnStartNow.Location = new Point(25, 1015);
            btnStartNow.Name = "btnStartNow";
            btnStartNow.Size = new Size(510, 80);
            btnStartNow.TabIndex = 8;
            btnStartNow.Text = "Bắt đầu";
            btnStartNow.UseVisualStyleBackColor = false;
            // 
            // btnOption
            // 
            btnOption.Image = Properties.Resources.iconOption;
            btnOption.Location = new Point(25, 924);
            btnOption.Name = "btnOption";
            btnOption.Size = new Size(72, 72);
            btnOption.TabIndex = 9;
            btnOption.UseVisualStyleBackColor = true;
            // 
            // btnMessage
            // 
            btnMessage.Image = Properties.Resources.iconMessage;
            btnMessage.Location = new Point(463, 924);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(72, 72);
            btnMessage.TabIndex = 10;
            btnMessage.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Image = Properties.Resources.iconMenu;
            btnMenu.Location = new Point(25, 88);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(72, 72);
            btnMenu.TabIndex = 11;
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.IconSearch;
            btnSearch.Location = new Point(463, 88);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(72, 72);
            btnSearch.TabIndex = 12;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MapHomepage;
            ClientSize = new Size(561, 1202);
            Controls.Add(btnSearch);
            Controls.Add(btnMenu);
            Controls.Add(btnMessage);
            Controls.Add(btnOption);
            Controls.Add(btnStartNow);
            Controls.Add(panel1);
            Name = "formHome";
            Text = "formHome";
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