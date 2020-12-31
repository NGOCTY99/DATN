using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_BLL.Class
{
    public class PhanLop_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();

        public PhanLop_Data()
        {
        }
        //public void locPhanLop(DataGridView dtgv)
        //{
        //    var pl = (from p1 in db.PHANLOPs
        //              select p1.MaHocSinh ).ToList();
        //    var pl2 = db.HOCSINHs.Select(t => t.MaHocSinh).Where(t => !pl.Contains(t));
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("Mã học sinh");
        //    dt.Columns.Add("Họ tên");
        //    foreach (var tt in pl2)
        //    {
        //        dt.Rows.Add(tt.Trim());
        //    }
        //    dtgv.DataSource = dt;

        //}


        public dynamic locPhanLop()
        {
            var pl = (from p1 in db.PHANLOPs
                      from p2 in db.HOCSINHs
                      where p1.MaHocSinh == p2.MaHocSinh
                      select new
                      {
                          p1.MaHocSinh,
                          p2.HoTen,
                          p2.NgaySinh,
                          p2.NoiSinh
                      }).ToList();
            var pl2 = db.HOCSINHs.Select(t => new
            {
                t.MaHocSinh,
                t.HoTen,
                t.NgaySinh,
                t.NoiSinh
            }).Where(t => !pl.Contains(t));
            return pl2;

        }

        public dynamic loadcboNamHoc()
        {
            return from nh in db.NAMHOCs select nh;
        }

        public dynamic loadcboKhoiLop()
        {
            return from k in db.KHOILOPs select k;
        }
        //Load combobox lớp học 
        public dynamic loadcboLopHoc(string makhoi, string namhoc)
        {
            return from l in db.LOPs
                   where l.MaKhoiLop == makhoi &&
                         l.MaNamHoc == namhoc
                   select new { l.TenLop, l.MaLop };
        }
        //Load datagridView 
        public dynamic loadDL(string makhoi, string malop, string manam)
        {
            var dl = from k in db.KHOILOPs
                     from l in db.LOPs
                     from n in db.NAMHOCs
                     from h in db.HOCSINHs
                     from p in db.PHANLOPs
                     where k.MaKhoiLop == makhoi &&
                           l.MaLop == malop &&
                           n.MaNamHoc == manam &&
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
            return dl;       
        }
        // Thêm HS mới vào lớp -- Phân lớp
        public void themHS_Lop(string manamhoc, string malop, string makhoi, string mahs)
        {
            PHANLOP pl = new PHANLOP();
            pl.MaNamHoc = manamhoc;
            pl.MaLop = malop;
            pl.MaKhoiLop = makhoi;
            pl.MaHocSinh = mahs;
            db.PHANLOPs.InsertOnSubmit(pl);
            db.SubmitChanges();
        }
        //Loại HS ra khỏi lớp
        // Xóa HS ra bảng phân lớp
        public void xoaHS_Lop(string mahs)
        {
            PHANLOP p = db.PHANLOPs.Where(t => t.MaHocSinh == mahs).FirstOrDefault();
            db.PHANLOPs.DeleteOnSubmit(p);
            db.SubmitChanges();
        }
    }
}
