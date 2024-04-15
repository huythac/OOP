namespace ProjectOOP
{
    partial class formContinue
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
            btnBatDau = new Button();
            btnChiTiet = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBatDau
            // 
            btnBatDau.BackColor = Color.FromArgb(0, 94, 114);
            btnBatDau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBatDau.ForeColor = SystemColors.Control;
            btnBatDau.Location = new Point(49, 287);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(280, 47);
            btnBatDau.TabIndex = 0;
            btnBatDau.Text = "Bắt đầu";
            btnBatDau.UseVisualStyleBackColor = false;
            // 
            // btnChiTiet
            // 
            btnChiTiet.BackColor = SystemColors.ActiveBorder;
            btnChiTiet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChiTiet.ForeColor = SystemColors.Control;
            btnChiTiet.Location = new Point(49, 340);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(280, 47);
            btnChiTiet.TabIndex = 1;
            btnChiTiet.Text = "Chi tiết chuyến đi";
            btnChiTiet.UseVisualStyleBackColor = false;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBatDau);
            panel1.Controls.Add(btnChiTiet);
            panel1.Location = new Point(2, 343);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 394);
            panel1.TabIndex = 2;
            // 
            // formContinue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 740);
            Controls.Add(panel1);
            Name = "formContinue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formContinue";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBatDau;
        private Button btnChiTiet;
        private Panel panel1;
    }
}