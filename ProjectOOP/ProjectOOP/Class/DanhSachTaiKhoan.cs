using System;
using System.Collections.Generic;
using System.Linq;
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
            set => instance = value;
        }

        List<ThongTinTaiKhoan> listTaiKhoan;

        public List<ThongTinTaiKhoan> ListTaiKhoan
        {
            get { return listTaiKhoan; }
            set { listTaiKhoan = value; }
        }

        // Khởi tạo một danh sách tài khoản
        private DanhSachTaiKhoan()
        {
            listTaiKhoan = new List<ThongTinTaiKhoan>();
            listTaiKhoan.Add(new ThongTinTaiKhoan("0948744101", "5678"));
            listTaiKhoan.Add(new ThongTinTaiKhoan("0948744102", "8910"));
        }
    }
}

