using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ProjectOOP.Class
{
    public class ThongTinTaiKhoan
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public List<string> SelectedServices { get; set; }

        public ThongTinTaiKhoan(string fullName, string phoneNumber, string password)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Password = password;
            SelectedServices = new List<string>();
        }

        // Phương thức để lưu thông tin người dùng vào một file txt
        public void SaveToFile(string filePath)
        {
            // Serialize đối tượng thành JSON
            string jsonString = JsonSerializer.Serialize(this);

            // Ghi JSON vào file
            File.WriteAllText(filePath, jsonString);
        }

        // Phương thức để đọc thông tin người dùng từ một file txt và khôi phục thành đối tượng
        public static ThongTinTaiKhoan LoadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                // Đọc JSON từ file
                string jsonString = File.ReadAllText(filePath);

                // Deserialize JSON thành đối tượng
                return JsonSerializer.Deserialize<ThongTinTaiKhoan>(jsonString);
            }
            else
            {
                // Trong trường hợp file không tồn tại, trả về null
                return null;
            }
        }



    }
}
