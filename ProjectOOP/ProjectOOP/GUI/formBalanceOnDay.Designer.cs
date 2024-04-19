namespace ProjectOOP
{
    partial class formBalancefortheday
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
            btnBack = new Button();
            label10 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblTime = new Label();
            lblAllOrder = new Label();
            lblPoint = new Label();
            DividerLine = new Panel();
            lblPricexThing = new Label();
            lablel9 = new Label();
            lblTotal = new Label();
            label17 = new Label();
            lblPriceTrip = new Label();
            label11 = new Label();
            lblDay = new Label();
            indicator = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            label7 = new Label();
            label8 = new Label();
            lblPriceThing = new Label();
            lblPriceFood = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.Transparent;
            btnBack.Image = Properties.Resources.iconArrow;
            btnBack.Location = new Point(19, 57);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 48);
            btnBack.TabIndex = 17;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(0, 0);
            label10.Margin = new Padding(2);
            label10.Name = "label10";
            label10.Size = new Size(382, 56);
            label10.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 111, 51);
            label1.Location = new Point(19, 121);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 36);
            label1.TabIndex = 19;
            label1.Text = "Số dư và thu nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 94, 104);
            label2.Location = new Point(16, 399);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 29);
            label2.TabIndex = 23;
            label2.Text = "Thu nhập: ";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 94, 104);
            label3.Location = new Point(142, 399);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 29);
            label3.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(21, 233);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 25;
            label4.Text = "Trực tuyến";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(21, 276);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 26;
            label5.Text = "Chuyến đi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(19, 330);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(133, 25);
            label6.TabIndex = 27;
            label6.Text = "Điểm thưởng";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.Black;
            lblTime.Location = new Point(298, 233);
            lblTime.Margin = new Padding(2, 0, 2, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(67, 25);
            lblTime.TabIndex = 28;
            lblTime.Text = "00:00";
            // 
            // lblAllOrder
            // 
            lblAllOrder.BackColor = Color.Silver;
            lblAllOrder.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAllOrder.ForeColor = Color.Black;
            lblAllOrder.Location = new Point(327, 260);
            lblAllOrder.Margin = new Padding(2, 0, 2, 0);
            lblAllOrder.Name = "lblAllOrder";
            lblAllOrder.Size = new Size(36, 49);
            lblAllOrder.TabIndex = 29;
            // 
            // lblPoint
            // 
            lblPoint.BackColor = Color.Silver;
            lblPoint.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPoint.ForeColor = Color.Black;
            lblPoint.Location = new Point(327, 319);
            lblPoint.Margin = new Padding(2, 0, 2, 0);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(36, 49);
            lblPoint.TabIndex = 30;
            // 
            // DividerLine
            // 
            DividerLine.BackColor = Color.WhiteSmoke;
            DividerLine.Location = new Point(-3, 373);
            DividerLine.Margin = new Padding(2);
            DividerLine.Name = "DividerLine";
            DividerLine.Size = new Size(382, 8);
            DividerLine.TabIndex = 31;
            // 
            // lblPricexThing
            // 
            lblPricexThing.BackColor = Color.Silver;
            lblPricexThing.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPricexThing.ForeColor = Color.Black;
            lblPricexThing.Location = new Point(256, 525);
            lblPricexThing.Margin = new Padding(2, 0, 2, 0);
            lblPricexThing.Name = "lblPricexThing";
            lblPricexThing.Size = new Size(107, 25);
            lblPricexThing.TabIndex = 37;
            lblPricexThing.Click += label12_Click;
            // 
            // lablel9
            // 
            lablel9.AutoSize = true;
            lablel9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lablel9.ForeColor = Color.Black;
            lablel9.Location = new Point(19, 525);
            lablel9.Margin = new Padding(2, 0, 2, 0);
            lablel9.Name = "lablel9";
            lablel9.Size = new Size(128, 25);
            lablel9.TabIndex = 34;
            lablel9.Text = "UEH xThing";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Microsoft Sans Serif", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(0, 94, 104);
            lblTotal.Location = new Point(113, 204);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(149, 29);
            lblTotal.TabIndex = 33;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(0, 94, 104);
            label17.Location = new Point(21, 204);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(88, 29);
            label17.TabIndex = 32;
            label17.Text = "Số dư:";
            // 
            // lblPriceTrip
            // 
            lblPriceTrip.BackColor = Color.Silver;
            lblPriceTrip.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPriceTrip.ForeColor = Color.Black;
            lblPriceTrip.Location = new Point(256, 564);
            lblPriceTrip.Margin = new Padding(2, 0, 2, 0);
            lblPriceTrip.Name = "lblPriceTrip";
            lblPriceTrip.Size = new Size(107, 25);
            lblPriceTrip.TabIndex = 38;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(19, 564);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 25);
            label11.TabIndex = 39;
            label11.Text = "UEH Trip";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Microsoft Sans Serif", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay.ForeColor = Color.Black;
            lblDay.Location = new Point(19, 166);
            lblDay.Margin = new Padding(2, 0, 2, 0);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(257, 29);
            lblDay.TabIndex = 40;
            lblDay.Text = "Chủ nhật, 21/04/2024";
            // 
            // indicator
            // 
            indicator.BackgroundImage = Properties.Resources.homeIndicator1;
            indicator.Location = new Point(-4, 769);
            indicator.Margin = new Padding(2);
            indicator.Name = "indicator";
            indicator.Size = new Size(382, 33);
            indicator.TabIndex = 41;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(19, 441);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(111, 25);
            label7.TabIndex = 42;
            label7.Text = "UEH Food";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(19, 483);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(117, 25);
            label8.TabIndex = 43;
            label8.Text = "UEH Thing";
            // 
            // lblPriceThing
            // 
            lblPriceThing.BackColor = Color.Silver;
            lblPriceThing.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPriceThing.ForeColor = Color.Black;
            lblPriceThing.Location = new Point(256, 483);
            lblPriceThing.Margin = new Padding(2, 0, 2, 0);
            lblPriceThing.Name = "lblPriceThing";
            lblPriceThing.Size = new Size(107, 25);
            lblPriceThing.TabIndex = 44;
            // 
            // lblPriceFood
            // 
            lblPriceFood.BackColor = Color.Silver;
            lblPriceFood.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPriceFood.ForeColor = Color.Black;
            lblPriceFood.Location = new Point(256, 441);
            lblPriceFood.Margin = new Padding(2, 0, 2, 0);
            lblPriceFood.Name = "lblPriceFood";
            lblPriceFood.Size = new Size(107, 25);
            lblPriceFood.TabIndex = 45;
            // 
            // formBalancefortheday
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(374, 703);
            Controls.Add(lblPriceFood);
            Controls.Add(lblPriceThing);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(indicator);
            Controls.Add(lblDay);
            Controls.Add(label11);
            Controls.Add(lblPriceTrip);
            Controls.Add(lblPricexThing);
            Controls.Add(lablel9);
            Controls.Add(lblTotal);
            Controls.Add(label17);
            Controls.Add(DividerLine);
            Controls.Add(lblPoint);
            Controls.Add(lblAllOrder);
            Controls.Add(lblTime);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(btnBack);
            Margin = new Padding(2);
            Name = "formBalancefortheday";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formBalanceOnDay";
            Load += formBalancefortheday_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Panel label10;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblTime;
        private Label lblAllOrder;
        private Label lblPoint;
        private Panel DividerLine;
        private Label lblPricexThing;
        private Label lablel9;
        private Label lblTotal;
        private Label label17;
        private Label lblPriceTrip;
        private Label label11;
        private Label lblDay;
        private Panel indicator;
        private System.Windows.Forms.Timer timer1;
        private Label label7;
        private Label label8;
        private Label lblPriceThing;
        private Label lblPriceFood;
    }
}