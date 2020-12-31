using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL.Class
{
    public class Diem_Data
    {

        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public Diem_Data()
        {

        }

        public dynamic loadcboNamHoc()
        {
            return from nh in db.NAMHOCs select nh;
        }

        //Load combobox khối lớp
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
        // load combobox môn học
        public dynamic LoadMonHoc()
        {
            return from mh in db.MONHOCs select mh;
        }

        // load cbb học kỳ
        public dynamic LoadHocKy()
        {
            return from hk in db.HOCKies select hk;
        }
        //Load datagridView: hiện ds học sinh theo năm, khối, lớp
        public dynamic loadDLHS(string manam, string makhoi, string malop)
        {
            var dl = (from l in db.LOPs
                      from h in db.HOCSINHs
                      from p in db.PHANLOPs
                      where l.MaLop == malop &&
                            p.MaKhoiLop == makhoi &&
                            p.MaNamHoc == manam &&
                            h.MaHocSinh == p.MaHocSinh &&
                            p.MaLop == l.MaLop
                      select new
                      {
                          h.MaHocSinh,
                          h.HoTen,
                          h.NgaySinh,
                          l.TenLop
                      }).Distinct();
            return dl;
        }
        //Load datagridView theo từng môn học của học kỳ (DS HS đã có điểm)
        public dynamic loadDL(string malop, string mamh, string mahk)
        {
            var dl = (from l in db.LOPs
                      from mh in db.MONHOCs
                      from h in db.HOCSINHs
                      from p in db.PHANLOPs
                      from d in db.DIEMs
                      from hk in db.HOCKies
                      where l.MaLop == malop &&
                            mh.MaMonHoc == mamh &&
                            hk.MaHocKy == mahk &&
                            h.MaHocSinh == p.MaHocSinh &&
                            p.MaHocSinh == d.MaHocSinh &&
                            l.MaLop == d.MaLop &&
                            mh.MaMonHoc == d.MaMonHoc &&
                            hk.MaHocKy == d.MaHocKy
                      select new
                      {
                          h.MaHocSinh,
                          h.HoTen,
                          h.NgaySinh,
                          l.TenLop
                      }).Distinct();
            return dl;
        }
        // load điểm của học sinh theo từng loại điểm của môn học 
        public dynamic LoadDiem(string mahs, string mamh, string hocky)
        {
            var diem = from d in db.DIEMs
                       from ld in db.LOAIDIEMs
                       where d.MaHocSinh == mahs &&
                             d.MaMonHoc == mamh &&
                             d.MaHocKy == hocky &&
                             d.MaLoai == ld.MaLoai
                       select new
                       {
                           d.STT,
                           d.MaLoai,
                           ld.TenLoai,
                           d.Diem1
                       };
            return diem;
        }
        // Load cbo Loại điểm
        public dynamic LoaiCBOLoaiDiem()
        {
            return from ld in db.LOAIDIEMs select ld;
        }
        // thêm điểm môn học 
        public void themDiem(string mahs, string mamh, string mahk, string manh, string malop, string maloaidiem, float diem)
        {
            DIEM d = new DIEM();
            d.MaHocSinh = mahs;
            d.MaMonHoc = mamh;
            d.MaHocKy = mahk;
            d.MaNamHoc = manh;
            d.MaLop = malop;
            d.MaLoai = maloaidiem;
            d.Diem1 = diem;
            db.DIEMs.InsertOnSubmit(d);
            db.SubmitChanges();
        }
        // Sửa điểm môn học 
        public void suaDiem(int stt, string mahs, string mamh, string mahk, string manh, string malop, string maloaidiem, float diem)
        {
            var kt = (from d in db.DIEMs where d.STT == stt select d).SingleOrDefault();
            if (kt != null)
            {
                kt.MaHocSinh = mahs;
                kt.MaMonHoc = mamh;
                kt.MaHocKy = mahk;
                kt.MaNamHoc = manh;
                kt.MaLop = malop;
                kt.MaLoai = maloaidiem;
                kt.Diem1 = diem;
                db.SubmitChanges();
            }
        }

        public string LaySTT(string mahs, int stt)
        {

            var dp = from p in db.DIEMs
                     where p.MaLoai == mahs &&
                     p.STT == stt
                     select p;
            foreach (var item in dp)
            {
                return item.STT.ToString();
            }
            return "";
        }

    }

}
