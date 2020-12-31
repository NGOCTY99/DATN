using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_BLL.Class
{
   public class PhanCong_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public PhanCong_Data()
        {

        }
        public void loadcboNamHoc(ComboBox cbb)
        {
            var p = from nh in db.NAMHOCs select nh;
            cbb.DataSource = p;
            
        }

        public void loadcboKhoiLop(ComboBox cbb)
        {
            var p = from k in db.KHOILOPs select k;
            cbb.DataSource = p;
            cbb.ValueMember = "MaKhoiLop";
            cbb.DisplayMember = "TenKhoiLop";
        }
        //Load combobox lớp học 
        public dynamic loadcboLopHoc(string makhoi, string namhoc)
        {
            return from l in db.LOPs
                   where l.MaKhoiLop == makhoi &&
                         l.MaNamHoc == namhoc
                   select new 
                   { 
                       l.TenLop,
                       l.MaLop
                   };
        }

        public void loadcboLopHoc1(ComboBox cbb, string makhoi)
        {
            var p = from l in db.LOPs
                    where l.MaKhoiLop == makhoi
                    select new { l.TenLop, l.MaLop };
            cbb.DataSource = p;
            cbb.ValueMember = "MaLop";
            cbb.DisplayMember = "TenLop";
        }
        //load cbo Môn học

        public void loadcboMonHoc(ComboBox cbb)
        {
            var p = from m in db.MONHOCs select m;
            cbb.DataSource = p;
            cbb.ValueMember = "MaMonHoc";
            cbb.DisplayMember = "TenMonHoc";

        }
        // lọc danh sách giáo viên chưa được phân công giảng dạy
        public dynamic loadGVMoi()
        {
            var pc = (from p1 in db.PHANCONGs
                      from p2 in db.GIAOVIENs
                      where p1.MaGiaoVien == p2.MaGiaoVien
                      select new
                      {
                          p1.MaGiaoVien,
                          p2.TenGiaoVien,
                          p2.DienThoai,
                          p1.MaMonHoc,
                      }).ToList();

            var pc1 = (from p1 in pc
                      from p2 in db.MONHOCs
                      where p1.MaMonHoc == p2.MaMonHoc
                      select new
                      {
                          p1.MaGiaoVien,
                          p1.TenGiaoVien,
                          p1.DienThoai,
                          p1.MaMonHoc,
                          p2.TenMonHoc,
                      }).ToList();

            var pc3 = (from p1 in db.GIAOVIENs
                       from p2 in db.MONHOCs
                       where p1.MaMonHoc == p2.MaMonHoc
                       select new
                       {
                           p1.MaGiaoVien,
                           p1.TenGiaoVien,
                           p1.DienThoai,
                           p1.MaMonHoc,
                           p2.TenMonHoc,
                       });

            var pc2 = pc3.Select(t => new
            {
                t.MaGiaoVien,
                t.TenGiaoVien,
                t.DienThoai,
                t.MaMonHoc,
                t.TenMonHoc
            }).Where(t => !pc1.Contains(t)) ;
            return pc2;
        }

        public dynamic locDLTheoDK(string manh, string malop, string mamh)
        {
            var dl = from n in db.NAMHOCs
                     from g in db.GIAOVIENs
                     from p in db.PHANCONGs
                     from l in db.LOPs
                     from m in db.MONHOCs
                     where n.MaNamHoc == manh &&
                           m.MaMonHoc == mamh &&
                           l.MaLop == malop &&
                           n.MaNamHoc == p.MaNamHoc &&
                           g.MaGiaoVien == p.MaGiaoVien &&
                           l.MaLop == p.MaLop &&
                           m.MaMonHoc == p.MaMonHoc
                     select new
                     {
                        g.MaGiaoVien,
                        g.TenGiaoVien,
                        m.TenMonHoc,
                        l.TenLop,
                        n.TenNamHoc
                     };
            return dl;
        }
        // thêm giáo viên vào bản phân công
        public void themGV_Day(string manamhoc, string malop, string mamon, string magv)
        {
            PHANCONG pc = new PHANCONG();
            pc.MaNamHoc = manamhoc;
            pc.MaLop = malop;
            pc.MaMonHoc = mamon;
            pc.MaGiaoVien = magv;
            db.PHANCONGs.InsertOnSubmit(pc);
            db.SubmitChanges();
        }
        public void xoaGV_Day(string magv)
        {
            PHANCONG p = db.PHANCONGs.Where(t => t.MaGiaoVien == magv).FirstOrDefault();
            db.PHANCONGs.DeleteOnSubmit(p);
            db.SubmitChanges();
        }
    }
}
