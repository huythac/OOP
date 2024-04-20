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
            indicator = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSuccess);
            panel1.Controls.Add(lblTypeProduct);
            panel1.Location = new Point(-4, 740);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 466);
            panel1.TabIndex = 0;
            // 
            // btnSuccess
            // 
            btnSuccess.BackColor = Color.FromArgb(0, 94, 114);
            btnSuccess.FlatStyle = FlatStyle.Flat;
            btnSuccess.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuccess.ForeColor = Color.White;
            btnSuccess.Location = new Point(33, 302);
            btnSuccess.Margin = new Padding(4, 4, 4, 4);
            btnSuccess.Name = "btnSuccess";
            btnSuccess.Size = new Size(510, 80);
            btnSuccess.TabIndex = 1;
            btnSuccess.Text = "Hoàn tất đơn hàng";
            btnSuccess.UseVisualStyleBackColor = false;
            btnSuccess.Click += btnSuccess_Click_1;
            // 
            // lblTypeProduct
            // 
            lblTypeProduct.BackColor = Color.FromArgb(0, 94, 114);
            lblTypeProduct.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTypeProduct.ForeColor = Color.White;
            lblTypeProduct.Location = new Point(0, 0);
            lblTypeProduct.Margin = new Padding(4, 0, 4, 0);
            lblTypeProduct.Name = "lblTypeProduct";
            lblTypeProduct.Size = new Size(183, 60);
            lblTypeProduct.TabIndex = 0;
            lblTypeProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // indicator
            // 
            indicator.BackgroundImage = Properties.Resources.homeIndicator1;
            indicator.Location = new Point(-4, 1153);
            indicator.Name = "indicator";
            indicator.Size = new Size(573, 50);
            indicator.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 106);
            label1.Name = "label1";
            label1.Size = new Size(347, 50);
            label1.TabIndex = 2;
            label1.Text = "Đi thẳng 2km nữa";
            // 
            // label2
            // 
            label2.Font = new Font("SF Pro Display", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 167);
            label2.Name = "label2";
            label2.Size = new Size(510, 92);
            label2.TabIndex = 3;
            label2.Text = "279 Nguyễn Tri Phương, Phường 5 Quận 10";
            // 
            // formMoving
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Derection_with_AR_Version2;
            ClientSize = new Size(561, 1202);
            Controls.Add(indicator);
            Controls.Add(panel1);
            Name = "formMoving";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formMoving";
            WindowState = FormWindowState.Minimized;
            Load += formMoving_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTypeProduct;
        private Button btnSuccess;
        private Label label1;
        private Panel indicator;
        private Label label2;
    }
}