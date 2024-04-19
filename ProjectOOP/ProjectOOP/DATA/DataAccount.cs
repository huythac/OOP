using ProjectOOP.Class;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjectOOP.DA
{
    public class DataAccount
    {
        public static string filePathAccount = @"D:\C#\Develop Desktop Applications\FinalProject\OOP\ProjectOOP\ProjectOOP\DA\Account.txt";
        public static void CreateDataAccount(string filePathAccount)
        {
            ThongTinTaiKhoan thongtintaikhoan = new ThongTinTaiKhoan("Pham Thanh Dat", "0948744100", "1234");
            try
            {
                // Serialize ThongTinTaiKhoan object to JSON
                string json = JsonSerializer.Serialize(thongtintaikhoan);

                // Open or create the file using FileStream
                using (FileStream fs = new FileStream(filePathAccount, FileMode.Create))
                {
                    // Convert JSON string to bytes
                    byte[] jsonData = new UTF8Encoding(true).GetBytes(json);

                    // Write JSON data to the file
                    fs.Write(jsonData, 0, jsonData.Length);

                    Console.WriteLine("Account data saved to file successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
