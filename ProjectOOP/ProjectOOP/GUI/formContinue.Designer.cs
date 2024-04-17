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
            btnHoanTat = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnHoanTat
            // 
            btnHoanTat.BackColor = Color.FromArgb(0, 94, 114);
            btnHoanTat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHoanTat.ForeColor = SystemColors.Control;
            btnHoanTat.Location = new Point(56, 287);
            btnHoanTat.Name = "btnHoanTat";
            btnHoanTat.Size = new Size(280, 47);
            btnHoanTat.TabIndex = 0;
            btnHoanTat.Text = "Hoàn Tất ";
            btnHoanTat.UseVisualStyleBackColor = false;
            btnHoanTat.Click += btnHoanTat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHoanTat);
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
            Load += formContinue_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnHoanTat;
        private Panel panel1;
    }
}