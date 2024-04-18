using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Import thư viện này để sử dụng StreamReader
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOOP.Class;
using ProjectOOP_DangNhap;

namespace ProjectOOP
{
    public partial class formSignIn : Form
    {
        private List<ThongTinTaiKhoan> listTaiKhoan; // Khởi tạo danh sách tài khoản
        private List<ThongTinTaiKhoan> globalThongTinTaiKhoan;
        public delegate void AccountLoggedInEventHandler(ThongTinTaiKhoan account);
        public event AccountLoggedInEventHandler AccountLoggedIn;
        public formSignIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            listTaiKhoan = new List<ThongTinTaiKhoan>(); // Khởi tạo danh sách tài khoản
            globalThongTinTaiKhoan = new List<ThongTinTaiKhoan>();

            // Gọi phương thức LoadAccountsFromFile với đúng đường dẫn tới file JSON
            string filePath = @"D:\Đồ án OOP\accounts.txt"; // Thay đổi đường dẫn đến file JSON của bạn
            LoadAccountsFromFile(filePath);
        }
        public List<ThongTinTaiKhoan> GlobalThongTinTaiKhoan()
        {
            return globalThongTinTaiKhoan;
        }

        // Phương thức để load danh sách tài khoản từ file JSON
        private void LoadAccountsFromFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                // Đọc từng dòng trong file
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Chuyển đổi từ JSON thành đối tượng Product
                    ThongTinTaiKhoan account = JsonSerializer.Deserialize<ThongTinTaiKhoan>(line);

                    // Thêm đối tượng vào danh sách
                    globalThongTinTaiKhoan.Add(account);
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;

            // Kiểm tra đăng nhập
            if (DangNhap.KiemTraDangNhapFromJson(phoneNumber, password))
            {
                // Use global list directly
                ThongTinTaiKhoan loggedInAccount = globalThongTinTaiKhoan.Find(taiKhoan => taiKhoan.PhoneNumber == phoneNumber && taiKhoan.Password == password);

                if (loggedInAccount != null)
                {
                    formHome fHome = new formHome();
                    fHome.Show();
                    this.Hide();
                    AccountLoggedIn?.Invoke(loggedInAccount);
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Vui lòng đăng nhập lại");
                txtPhoneNumber.Focus();
            }
        }
       

        private void btnGoogle_Click(object sender, EventArgs e)
        {

            new formHome().Show();
            this.Hide();
        }

        private void btnApple_Click(object sender, EventArgs e)
        {

            new formHome().Show();
            this.Hide();
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {

            new formHome().Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new formSplash().Show();
            this.Hide();
        }
    }
}
