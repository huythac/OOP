namespace ProjectOOP
{
    partial class formSignUp
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
            label1 = new Label();
            label3 = new Label();
            btnBack = new Button();
            statusBar = new Panel();
            txtTen = new TextBox();
            txtHo = new TextBox();
            txtSoDienThoai = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            checkedListBoxDichVu = new CheckedListBox();
            groupBoxDichVuDangKy = new GroupBox();
            btnSignUp = new Button();
            indicator = new Panel();
            groupBoxDichVuDangKy.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(120, 98);
            label1.Name = "label1";
            label1.Size = new Size(359, 50);
            label1.TabIndex = 1;
            label1.Text = "Đăng ký tài xế mới";
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 179);
            label3.Name = "label3";
            label3.Size = new Size(507, 77);
            label3.TabIndex = 19;
            label3.Text = "Vui lòng cho chúng tôi biết thông tin về bạn";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
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
            btnBack.TabIndex = 20;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // statusBar
            // 
            statusBar.BackColor = Color.Transparent;
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(-5, -1);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(573, 84);
            statusBar.TabIndex = 21;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.WhiteSmoke;
            txtTen.BorderStyle = BorderStyle.None;
            txtTen.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTen.ImeMode = ImeMode.NoControl;
            txtTen.Location = new Point(26, 294);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(510, 72);
            txtTen.TabIndex = 22;
            txtTen.Text = "    Tên*";
            txtTen.MouseClick += txtTen_MouseClick;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // txtHo
            // 
            txtHo.BackColor = Color.WhiteSmoke;
            txtHo.BorderStyle = BorderStyle.None;
            txtHo.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtHo.Location = new Point(25, 390);
            txtHo.Multiline = true;
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(510, 72);
            txtHo.TabIndex = 23;
            txtHo.Text = "    Họ*";
            txtHo.MouseClick += txtHo_MouseClick;
            txtHo.TextChanged += txtHo_TextChanged;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BackColor = Color.WhiteSmoke;
            txtSoDienThoai.BorderStyle = BorderStyle.None;
            txtSoDienThoai.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoDienThoai.Location = new Point(25, 486);
            txtSoDienThoai.Multiline = true;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(510, 72);
            txtSoDienThoai.TabIndex = 24;
            txtSoDienThoai.Text = "   Số điện thoại*";
            txtSoDienThoai.MouseClick += txtSoDienThoai_MouseClick;
            txtSoDienThoai.TextChanged += txtSoDienThoai_TextChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.WhiteSmoke;
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(25, 584);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(510, 72);
            txtMatKhau.TabIndex = 25;
            txtMatKhau.Text = "   Mật khẩu*";
            txtMatKhau.MouseClick += txtMatKhau_MouseClick;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.BackColor = Color.WhiteSmoke;
            txtXacNhanMatKhau.BorderStyle = BorderStyle.None;
            txtXacNhanMatKhau.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtXacNhanMatKhau.Location = new Point(25, 679);
            txtXacNhanMatKhau.Multiline = true;
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(510, 72);
            txtXacNhanMatKhau.TabIndex = 26;
            txtXacNhanMatKhau.Text = "   Xác nhận lại mật khẩu*";
            txtXacNhanMatKhau.MouseClick += txtXacNhanMatKhau_MouseClick_1;
            txtXacNhanMatKhau.TextChanged += txtXacNhanMatKhau_TextChanged;
            // 
            // checkedListBoxDichVu
            // 
            checkedListBoxDichVu.BackColor = Color.White;
            checkedListBoxDichVu.Font = new Font("SF Pro Display", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBoxDichVu.FormattingEnabled = true;
            checkedListBoxDichVu.Items.AddRange(new object[] { "UEH Trip", "UEH Thing", "UEH XThing", "UEH Food" });
            checkedListBoxDichVu.Location = new Point(22, 54);
            checkedListBoxDichVu.Name = "checkedListBoxDichVu";
            checkedListBoxDichVu.Size = new Size(462, 148);
            checkedListBoxDichVu.TabIndex = 28;
            checkedListBoxDichVu.SelectedIndexChanged += checkedListBoxDichVu_SelectedIndexChanged;
            // 
            // groupBoxDichVuDangKy
            // 
            groupBoxDichVuDangKy.Controls.Add(checkedListBoxDichVu);
            groupBoxDichVuDangKy.Font = new Font("SF Pro Display", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxDichVuDangKy.Location = new Point(29, 777);
            groupBoxDichVuDangKy.Name = "groupBoxDichVuDangKy";
            groupBoxDichVuDangKy.Size = new Size(507, 224);
            groupBoxDichVuDangKy.TabIndex = 29;
            groupBoxDichVuDangKy.TabStop = false;
            groupBoxDichVuDangKy.Text = "Dịch vụ đăng ký";
            groupBoxDichVuDangKy.Enter += groupBoxDichVuDangKy_Enter;
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSignUp.BackColor = Color.FromArgb(0, 94, 104);
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(25, 1051);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(510, 80);
            btnSignUp.TabIndex = 30;
            btnSignUp.Text = "Đăng ký";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click_1;
            // 
            // indicator
            // 
            indicator.BackColor = Color.Transparent;
            indicator.BackgroundImage = Properties.Resources.homeIndicator1;
            indicator.Location = new Point(-8, 1157);
            indicator.Name = "indicator";
            indicator.Size = new Size(573, 50);
            indicator.TabIndex = 31;
            // 
            // formSignUp
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(561, 1202);
            Controls.Add(indicator);
            Controls.Add(btnSignUp);
            Controls.Add(groupBoxDichVuDangKy);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtHo);
            Controls.Add(txtTen);
            Controls.Add(statusBar);
            Controls.Add(btnBack);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "formSignUp";
            Text = "formSignUp";
            Load += formSignUp_Load;
            groupBoxDichVuDangKy.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Button btnBack;
        private Panel statusBar;
        private TextBox txtTen;
        private TextBox txtHo;
        private TextBox txtSoDienThoai;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMatKhau;
        private CheckedListBox checkedListBoxDichVu;
        private GroupBox groupBoxDichVuDangKy;
        private Button btnSignUp;
        private Panel indicator;
    }
}