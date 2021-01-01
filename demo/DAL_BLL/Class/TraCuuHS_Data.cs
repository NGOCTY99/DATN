using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL.Class
{
    public class TraCuuHS_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public TraCuuHS_Data()
        {

        }
        // load ds tất cả các hs lên dgv (Phân lớp)
        public dynamic loadDSHS()
        {
            var dl = from k in db.KHOILOPs
                     from l in db.LOPs
                     from n in db.NAMHOCs
                     from h in db.HOCSINHs
                     from p in db.PHANLOPs
                     where p.MaHocSinh == h.MaHocSinh &&
                           p.MaNamHoc == n.MaNamHoc &&
                           p.MaKhoiLop == k.MaKhoiLop &&
                           p.MaLop == l.MaLop
                     select new
                     {
                         h.MaHocSinh,
                         h.HoTen,
                         h.NgaySinh,
                         l.TenLop,
                         k.TenKhoiLop,
                         n.TenNamHoc,
                         h.NoiSinh
                     };
            return dl;
        }
        // tra cứu dựa vào textbox tìm kiếm 
        public dynamic traCuu(string s)
        {
            var result = from k in db.KHOILOPs
                         from l in db.LOPs
                         from n in db.NAMHOCs
                         from h in db.HOCSINHs
                         from p in db.PHANLOPs
                         where (h.MaHocSinh.StartsWith(s) ||
                         h.HoTen.StartsWith(s) ||
                         h.MaHocSinh.Contains(s) ||
                         h.HoTen.Contains(s)) &&
                         p.MaHocSinh == h.MaHocSinh &&
                         p.MaNamHoc == n.MaNamHoc &&
                         p.MaKhoiLop == k.MaKhoiLop &&
                         p.MaLop == l.MaLop
                         select new
                         {
                             h.MaHocSinh,
                             h.HoTen,
                             h.NgaySinh,
                             l.TenLop,
                             k.TenKhoiLop,
                             n.TenNamHoc,
                             h.NoiSinh
                         };
            return result;
        }
        //Load cbo Năm học
        public dynamic loadCBO_NamHoc()
        {
            return from nh in db.NAMHOCs select nh;
        }
        //load cbo Khoi Lop
        public dynamic loadcboKhoiLop()
        {
            return from k in db.KHOILOPs select k;
        }
        //Load combobox lớp học theo mã khối và năm học
        public dynamic loadcboLopHoc(string makhoi, string namhoc)
        {
            return from l in db.LOPs
                   where l.MaKhoiLop == makhoi &&
                         l.MaNamHoc == namhoc
                   select new { l.TenLop, l.MaLop };
        }
    }
}
