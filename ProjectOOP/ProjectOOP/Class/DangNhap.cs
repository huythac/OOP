using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using ProjectOOP;
using ProjectOOP.Class;

namespace ProjectOOP_DangNhap
{
    public class DangNhap
    {
        public DangNhap() { }

        public delegate void AccountCreatedEventHandler(ThongTinTaiKhoan newAccount);
        public event AccountCreatedEventHandler AccountCreated;

        private List<ThongTinTaiKhoan> LoadAccountsFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true // Cho phép phân tích cú pháp không phân biệt chữ hoa/chữ thường
                    };
                    return JsonSerializer.Deserialize<List<ThongTinTaiKhoan>>(json, options);
                }
                else
                {
                    MessageBox.Show("File không tồn tại!");
                    return null;
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Lỗi phân tích cú pháp JSON: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi tải tài khoản từ file: {ex.Message}");
                return null;
            }
        }

        public static bool KiemTraDangNhapFromJson(string phoneNumber, string password)
        {
            string filePath = @"D:\Đồ án OOP\accounts.txt"; // Đường dẫn đến tệp JSON

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true // Cho phép phân tích cú pháp không phân biệt chữ hoa/chữ thường
                    };
                    List<ThongTinTaiKhoan> listTaiKhoan = JsonSerializer.Deserialize<List<ThongTinTaiKhoan>>(json, options);

                    // Kiểm tra thông tin đăng nhập
                    foreach (ThongTinTaiKhoan taiKhoan in listTaiKhoan)
                    {
                        if (phoneNumber == taiKhoan.PhoneNumber && password == taiKhoan.Password)
                        {
                            return true;
                        }
                    }
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Lỗi phân tích cú pháp JSON: {ex.Message}");
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi tải tài khoản từ file: {ex.Message}");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("File không tồn tại!");
                return false;
            }

            return false;
        }

        public void SignIn(TextBox txtFullName, TextBox txtPhoneNumber, TextBox txtPassword, Form form)
        {
            string fullName = txtFullName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;

            if (KiemTraDangNhapFromJson(phoneNumber, password))
            {
                formHome fHome = new formHome();
                fHome.Show();
                form.Hide();
                AccountCreated?.Invoke(new ThongTinTaiKhoan(fullName, phoneNumber, password));
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Vui lòng đăng nhập lại");
                txtPhoneNumber.Focus();
            }
        }
    }
}
