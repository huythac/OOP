using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.Class
{
    public class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;
        public static DanhSachTaiKhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachTaiKhoan();
                return instance;
            }
        }

        List<ThongTinTaiKhoan> listTaiKhoan;

        public List<ThongTinTaiKhoan> ListTaiKhoan
        {
            get { return listTaiKhoan; }
            set { listTaiKhoan = value; }
        }

        private DanhSachTaiKhoan()
        {
            listTaiKhoan = new List<ThongTinTaiKhoan>();
            listTaiKhoan.Add(new ThongTinTaiKhoan("Vũ Trọng Tiến Phi", "0948744101", "5678"));
            listTaiKhoan.Add(new ThongTinTaiKhoan("Thạch Quốc Huy", "0912439709", "0109"));
            listTaiKhoan.Add(new ThongTinTaiKhoan("Phạm Thành Đạt", "0948744100", "1234"));
        }
    }
}

