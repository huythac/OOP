using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOOP.Class
{

        public class DanhSachChuyenDi
        {
            private List<ChuyenDi> danhSachChuyenDi;

            public DanhSachChuyenDi()
            {
                danhSachChuyenDi = new List<ChuyenDi>();
                KhoiTaoChuyenDiMau();
            }

            public List<ChuyenDi> LayDanhSachChuyenDi()
            {
                return danhSachChuyenDi;
            }

            public ChuyenDi TimChuyenDiTheoId(int idChuyenDi)
            {
                return danhSachChuyenDi.Find(chuyenDi => chuyenDi.Id == idChuyenDi);
            }

            private void KhoiTaoChuyenDiMau()
            {
                danhSachChuyenDi.Add(new ChuyenDi(1, LoaiChuyenDi.UEHFood, "Cách bạn 1.2km (Dự kiến 5 phút)", "Ký túc xá A3", "Cổng trường UEH", "Khoảng cách 8km (Dự kiến 20 phút)", 122000, 22000));

            }
        }

        public class ChuyenDi
        {
            public int Id { get; private set; }
            public LoaiChuyenDi LoaiChuyenDi { get; private set; }
            public string KhoangCachDenDiemDi { get; private set; }
            public string DiemDi { get; private set; }
            public string KhoangCachDenDiemDen { get; private set; }
            public string DiemDen { get; private set; }
            public int DoanhThu { get; private set; }
            public int ThuNhap { get; private set; }

            public ChuyenDi(int id, LoaiChuyenDi loaiChuyenDi, string khoangCachDenDiemDi, string diemDi, string khoangCachDenDiemDen, string diemDen, int doanhThu, int thuNhap)
            {
                Id = id;
                LoaiChuyenDi = loaiChuyenDi;
                KhoangCachDenDiemDi = khoangCachDenDiemDi;
                DiemDi = diemDi;
                KhoangCachDenDiemDen = khoangCachDenDiemDen;
                DiemDen = diemDen;
                DoanhThu = doanhThu;
                ThuNhap = thuNhap;
            }
        }

        public enum LoaiChuyenDi
        {
            UEHFood,
            UEHThing,
            UEHXThing,
            UEHTrip
        }
    }
