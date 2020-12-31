using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL.Class
{
    public class HocSinh_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();

        public HocSinh_Data()
        {

        }
        public IEnumerable<HOCSINH> loadDSHS()
        {
            return db.HOCSINHs.Select(t => t);
        }
        public string loadTenTG(string tg)
        {
            return db.TONGIAOs.SingleOrDefault(t => t.MaTonGiao == tg).TenTonGiao.ToString(); ;
        }
        public string loadTenDT(string dt)
        {
            return db.DANTOCs.SingleOrDefault(t => t.MaDanToc == dt).TenDanToc.ToString(); ;
        }
        public string loadTenNN(string nn)
        {
            return db.NGHENGHIEPs.SingleOrDefault(t => t.MaNghe == nn).TenNghe.ToString(); 
        }

        public string LoadGT(bool gt)
        {
            if (db.HOCSINHs.FirstOrDefault(t => t.GioiTinh == gt).GioiTinh.ToString() == "False")
            {
                return "Nam";
            }
            else 
            {
                return "Nữ";
            }
        }
        public IQueryable<DANTOC> load_CboDanToc()
        {
            return from dt in db.DANTOCs select dt;
        }
        public IQueryable<TONGIAO> load_CboTonGiao()
        {
            return from tg in db.TONGIAOs select tg;
        }
        public IQueryable<NGHENGHIEP> load_CboNgheNghiep()
        {
            return from nn in db.NGHENGHIEPs select nn;
        }

        // Thêm học sinh mới
        public bool ktkc(string mahs)
        {

            HOCSINH hs = db.HOCSINHs.Where(t => t.MaHocSinh == mahs).FirstOrDefault();
            if (hs == null)
            {
                return true; // mã ko trùng được thêm vào
            }
            else
            {
                return false;
            }
        }

        // thêm học sinh mới
        public bool themHS(string maHS, string tenHS, string noisinh, bool gt, 
            DateTime ngaysinh, string dt, string tg, 
            string hotenCha, string nncha, string hotenMe, string nnMe)
        {
            if (ktkc(maHS) == true)
            {
                HOCSINH hs = new HOCSINH();
                hs.MaHocSinh = maHS;
                hs.HoTen = tenHS;
                hs.GioiTinh = gt;
                hs.NoiSinh = noisinh;
                hs.NgaySinh = ngaysinh;
                hs.MaDanToc = dt;
                hs.MaTonGiao = tg;
                hs.HoTenCha = hotenCha;
                hs.MaNNghiepCha = nncha;
                hs.HoTenMe = hotenMe;
                hs.MaNNghiepMe = nnMe;
                db.HOCSINHs.InsertOnSubmit(hs);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


        // Sửa học sinh
        public bool suaHS(string maHS, string tenHS, string noisinh,
            DateTime ngaysinh, string dt, string tg,
            string hotenCha, string nncha, string hotenMe, string nnMe)
        {
            if (ktkc(maHS) == false)
            {
                HOCSINH suaHS = db.HOCSINHs.Where(t => t.MaHocSinh == maHS).FirstOrDefault();
                suaHS.HoTen = tenHS;
                suaHS.NoiSinh = noisinh;
                suaHS.NgaySinh = ngaysinh;
                suaHS.MaDanToc = dt;
                suaHS.MaTonGiao = tg;
                suaHS.HoTenCha = hotenCha;
                suaHS.MaNNghiepCha = nncha;
                suaHS.HoTenMe = hotenMe;
                suaHS.MaNNghiepMe = nnMe;
                db.SubmitChanges();
                return true;
            }
            else
                return false;
        }
    }
    }
