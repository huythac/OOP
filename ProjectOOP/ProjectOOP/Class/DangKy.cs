using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            AccountCreated?.Invoke(newAccount);
            return true;
        }

        public List<string> GetSelectedServices(CheckedListBox checkedListBoxDichVu)
        {
            List<string> selectedServices = new List<string>();
            foreach (object item in checkedListBoxDichVu.CheckedItems)
            {
                selectedServices.Add(item.ToString());
            }
            return selectedServices;
        }

        public void SignUp( TextBox txtSoDienThoai, TextBox txtMatKhau, TextBox txtXacNhanMatKhau, TextBox txtHo, TextBox txtTen, CheckedListBox checkedListBoxDichVu, Form form)
        {
           
            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không trùng khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ThongTinTaiKhoan newAccount = new ThongTinTaiKhoan(txtSoDienThoai.Text, txtMatKhau.Text);
            newAccount.FullName = txtHo.Text + " " + txtTen.Text;

            // Sử dụng phương thức GetSelectedServices
            newAccount.SelectedServices = GetSelectedServices(checkedListBoxDichVu);

            bool accountCreated = AddNewAccount(newAccount);

            if (accountCreated)
            {
                MessageBox.Show("Tài khoản đã được tạo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị form đăng nhập
                formSignIn signInForm = new formSignIn();
                signInForm.Show();
                form.Hide();
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
