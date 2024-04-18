using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;

namespace ProjectOOP.Class
{
    public class DangKy
    {
        public Action<ThongTinTaiKhoan> AccountCreated { get; internal set; }

        public bool AddNewAccount(ThongTinTaiKhoan newAccount)
        {
            foreach (ThongTinTaiKhoan taiKhoan in DanhSachTaiKhoan.Instance.ListTaiKhoan)
            {
                if (taiKhoan.PhoneNumber == newAccount.PhoneNumber)
                {
                    return false;
                }
            }
            DanhSachTaiKhoan.Instance.ListTaiKhoan.Add(newAccount);

            // Kiểm tra kết quả trả về của AddNewAccount
            if (SaveAccountToFile(newAccount))
            {
                AccountCreated?.Invoke(newAccount);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool SaveAccountToFile(ThongTinTaiKhoan account)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(account);
                string filePath = @"D:\Đồ án OOP\accounts.txt"; 

                // Ghi JSON vào file
                File.AppendAllText(filePath, jsonString + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi lưu tài khoản vào file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<string> GetSelectedServices(CheckedListBox checkedListBoxDichVu)
        {
            List<string> selectedServices = new List<string>();
            if (checkedListBoxDichVu != null)
            {
                foreach (object item in checkedListBoxDichVu.CheckedItems)
                {
                    selectedServices.Add(item.ToString());
                }
            }
            return selectedServices;
        }

        public void SignUp(TextBox txtSoDienThoai, TextBox txtMatKhau, TextBox txtXacNhanMatKhau, TextBox txtHo, TextBox txtTen, CheckedListBox checkedListBoxDichVu, Form form)
        {
            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không trùng khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Concatenate Ho and Ten to form FullName
            string fullName = $"{txtHo.Text} {txtTen.Text}";

            ThongTinTaiKhoan newAccount = new ThongTinTaiKhoan(fullName, txtSoDienThoai.Text, txtMatKhau.Text);
            newAccount.SelectedServices = GetSelectedServices(checkedListBoxDichVu);

            bool accountCreated = AddNewAccount(newAccount);

            if (accountCreated)
            {
                MessageBox.Show("Tài khoản đã được tạo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formSignIn signInForm = new formSignIn();
                signInForm.Show();
                form.Hide();
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void SignUp(TextBox txtSoDienThoai, TextBox txtMatKhau, TextBox txtXacNhanMatKhau, TextBox txtHo, TextBox txtTen, formSignUp g)
        {
            throw new NotImplementedException();
        }
    }
}
