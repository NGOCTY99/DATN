using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAL_BLL
{
    public class LopHoc_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public LopHoc_Data()
        {

        }

        public dynamic loadDataGridView(string idnv,string magv)
        {         
            if (idnv == "LND004")
            {
                var Lops = from l in db.LOPs
                           from k in db.KHOILOPs
                           from nh in db.NAMHOCs
                           from gv in db.GIAOVIENs
                           where l.MaKhoiLop == k.MaKhoiLop &&
                                 l.MaNamHoc == nh.MaNamHoc &&
                                 l.MaGiaoVien == gv.MaGiaoVien
                           select new
                           {
                               l.MaLop,
                               l.TenLop,
                               k.TenKhoiLop,
                               nh.TenNamHoc,
                               l.SiSo,
                               gv.TenGiaoVien
                           };

                return Lops;
            }
            else {
                var Lops = from l in db.LOPs
                           from k in db.KHOILOPs
                           from nh in db.NAMHOCs
                           from gv in db.GIAOVIENs
                           where l.MaKhoiLop == k.MaKhoiLop &&
                                 l.MaNamHoc == nh.MaNamHoc &&
                                 l.MaGiaoVien == gv.MaGiaoVien && 
                                 gv.MaGiaoVien==magv
                                 select new
                           {
                               l.MaLop,
                               l.TenLop,
                               k.TenKhoiLop,
                               nh.TenNamHoc,
                               l.SiSo,
                               gv.TenGiaoVien
                           };
                return Lops;
            }
            }



        
        public IQueryable<KHOILOP> loadKhoiLop(string id, string magv)
        {
            if (id == "LND004")
            {
                return from l in db.KHOILOPs select l;
            }
            else
            {
                var kltgv =  from l in db.LOPs
                             from k in db.KHOILOPs
                             from gv in db.GIAOVIENs
                             where l.MaKhoiLop == k.MaKhoiLop &&
                             l.MaGiaoVien == gv.MaGiaoVien &&
                             gv.MaGiaoVien == magv
                             select new
                             {
                                   l.MaLop,
                                   l.TenLop,
                             };
                return (IQueryable<KHOILOP>)kltgv;
            }    
        }

        public IQueryable<NAMHOC> loadNamHoc(string id, string magv)
        {
            if (id == "LND004")
            {
                return from nh in db.NAMHOCs select nh;
            }
            else
            {
                var kltgv = from l in db.LOPs
                            from nh in db.NAMHOCs
                            from gv in db.GIAOVIENs
                            where l.MaNamHoc==nh.MaNamHoc &&
                            l.MaGiaoVien == gv.MaGiaoVien &&
                            gv.MaGiaoVien == magv
                            select new
                            {
                                nh.MaNamHoc,
                                nh.TenNamHoc
                            };
                return (IQueryable<NAMHOC>)kltgv;
            }
        }
        public IQueryable<GIAOVIEN> loadGiaoVien(string id, string magv)
        {
            //if(id==")
            return from gv in db.GIAOVIENs select gv;
        }

        //CRUD lớp học

        public bool ktkc(string malop, string namhoc)
        {

            LOP l = db.LOPs.Where(t => t.MaLop == malop&& t.MaNamHoc==namhoc).FirstOrDefault();
            if (l == null)
            {
                return true; // mã ko trùng được thêm vào
            }
            else
            {
                return false;
            }
        }

        // thêm lớp học mới
        public void themLop(string malop, string tenlop, string makhoi, string manamhoc, int siso, string magv)
        {
            if (ktkc(malop,manamhoc) == true)
            {
                LOP lop = new LOP();
                lop.MaLop = malop;
                lop.TenLop = tenlop;
                lop.MaKhoiLop = makhoi;
                lop.MaNamHoc = manamhoc;
                lop.SiSo = siso;
                lop.MaGiaoVien = magv;
                db.LOPs.InsertOnSubmit(lop);
                db.SubmitChanges();
                MessageBox.Show("Thêm lớp thành công");
            }
            else
            {
                MessageBox.Show("Trùng lớp đã có");
            }
        }

        //Sửa lớp (sỉ số, GVCN)
        public void suaLop(string malop,string manamhoc,string tenlop, string magv)
        {
            if (ktkc(malop, manamhoc) == false)
            {
                LOP sualop = db.LOPs.Where(t => t.MaLop == malop).FirstOrDefault();
                sualop.TenLop = tenlop;
                sualop.MaGiaoVien = magv;
                db.SubmitChanges();
                MessageBox.Show("Cập nhật lớp thành công");
            }
            else
                MessageBox.Show("Cập nhật lớp thất bại");
        }

        // Lọc - tìm kiếm 
        // theo mã khối lớp
        public dynamic load_dgv_Theo_MaKhoiLop(string id,string magv,string makhoilop)
        {
            if (id == "LND004")
            {
                var Lops = from l in db.LOPs
                           from k in db.KHOILOPs
                           from nh in db.NAMHOCs
                           from gv in db.GIAOVIENs
                           where l.MaKhoiLop == k.MaKhoiLop &&
                                 l.MaNamHoc == nh.MaNamHoc &&
                                 l.MaGiaoVien == gv.MaGiaoVien &&
                                 l.MaKhoiLop == makhoilop
                           select new
                           {
                               l.MaLop,
                               l.TenLop,
                               k.TenKhoiLop,
                               nh.TenNamHoc,
                               l.SiSo,
                               gv.TenGiaoVien
                           };
                return Lops;
            }
            else
            {
                var Lops = from l in db.LOPs
                           from k in db.KHOILOPs
                           from nh in db.NAMHOCs
                           from gv in db.GIAOVIENs
                           where l.MaKhoiLop == k.MaKhoiLop &&
                                 l.MaNamHoc == nh.MaNamHoc &&
                                 l.MaGiaoVien == gv.MaGiaoVien &&
                                 l.MaKhoiLop == makhoilop &&
                                 gv.MaGiaoVien==magv
                           select new
                           {
                               l.MaLop,
                               l.TenLop,
                               k.TenKhoiLop,
                               nh.TenNamHoc,
                               l.SiSo,
                               gv.TenGiaoVien
                           };
                return Lops;
            }
        }
        //theo mã năm học
        public dynamic load_dgv_Theo_MaNamHoc(string id, string magv,string manh)
        {
            if (id == "LND004")
            {
                var nh = from l in db.LOPs
                         from k in db.KHOILOPs
                         from n in db.NAMHOCs
                         from gv in db.GIAOVIENs
                         where l.MaKhoiLop == k.MaKhoiLop &&
                               l.MaNamHoc == n.MaNamHoc &&
                               l.MaGiaoVien == gv.MaGiaoVien &&
                               l.MaNamHoc == manh
                         select new
                         {
                             l.MaLop,
                             l.TenLop,
                             k.TenKhoiLop,
                             n.TenNamHoc,
                             l.SiSo,
                             gv.TenGiaoVien
                         };
                return nh;
            }
            else
            {
                var nh = from l in db.LOPs
                         from k in db.KHOILOPs
                         from n in db.NAMHOCs
                         from gv in db.GIAOVIENs
                         where l.MaKhoiLop == k.MaKhoiLop &&
                               l.MaNamHoc == n.MaNamHoc &&
                               l.MaGiaoVien == gv.MaGiaoVien &&
                               l.MaNamHoc == manh && gv.MaGiaoVien==magv
                         select new
                         {
                             l.MaLop,
                             l.TenLop,
                             k.TenKhoiLop,
                             n.TenNamHoc,
                             l.SiSo,
                             gv.TenGiaoVien
                         };
                return nh;
            }    
        }
       
    }
}
