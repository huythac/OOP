using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectOOP.Class;

namespace ProjectOOP.DATA
{
    public class GlobalData
    {
        public static int CurrentTripTime { get; set; }
        public static bool IsInTrip { get; set; }

        public List<ThongTinTaiKhoan> listAccount;
        public List<ThongTinTaiKhoan> GetCurrentAccount()
        {
            listAccount = new List<ThongTinTaiKhoan>();

            return null;
        }

    }
}
