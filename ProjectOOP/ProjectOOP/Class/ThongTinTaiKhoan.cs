using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.Class
{
    public class ThongTinTaiKhoan:Person
    {
        public override string FullName { get; set; }
        public override string PhoneNumber { get; set; }
        public override string Password { get; set; }
        public override List<string> SelectedServices { get; set; }

        public ThongTinTaiKhoan(string fullName, string phoneNumber, string password)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Password = password;
            SelectedServices = new List<string>();
        }
    }
}
