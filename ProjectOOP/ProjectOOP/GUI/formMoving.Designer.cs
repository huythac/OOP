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
            panel1 = new Panel();
            btnSuccess = new Button();
            lblTypeProduct = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSuccess);
            panel1.Controls.Add(lblTypeProduct);
            panel1.Location = new Point(2, 381);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 318);
            panel1.TabIndex = 0;
            // 
            // btnSuccess
            // 
            btnSuccess.BackColor = Color.FromArgb(0, 94, 114);
            btnSuccess.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuccess.ForeColor = Color.White;
            btnSuccess.Location = new Point(67, 225);
            btnSuccess.Name = "btnSuccess";
            btnSuccess.Size = new Size(225, 65);
            btnSuccess.TabIndex = 1;
            btnSuccess.Text = "HOÀN TẤT";
            btnSuccess.UseVisualStyleBackColor = false;
            btnSuccess.Click += btnSuccess_Click_1;
            // 
            // lblTypeProduct
            // 
            lblTypeProduct.BackColor = Color.FromArgb(0, 94, 114);
            lblTypeProduct.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTypeProduct.ForeColor = Color.White;
            lblTypeProduct.Location = new Point(3, 10);
            lblTypeProduct.Name = "lblTypeProduct";
            lblTypeProduct.Size = new Size(122, 40);
            lblTypeProduct.TabIndex = 0;
            lblTypeProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formMoving
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 703);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "formMoving";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formMoving";
            Load += formMoving_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTypeProduct;
        private Button btnSuccess;
    }
}