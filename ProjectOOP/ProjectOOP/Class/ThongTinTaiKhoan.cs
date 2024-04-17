using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

            PhoneNumber = phoneNumber;
            Password = password;
            SelectedServices = new List<string>();
        }
    }
}
