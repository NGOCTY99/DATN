using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAL_BLL.Class
{
    public class HocSinh_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();

        public HocSinh_Data()
        {

        }

        public string NN(string nn)
        {
            return db.NGHENGHIEPs.FirstOrDefault(t => t.MaNghe == nn).TenNghe;
        }

        public List<HocSinh_Class> loadDSHS(string id, string magv)
        {
            List<HocSinh_Class> lst = new List<HocSinh_Class>();
            int t = 1;
            if (id == "LND004")
            {
                var hocsinh = (from hs in db.HOCSINHs
                               from l in db.LOPs
                               from pl in db.PHANLOPs
                               from pc in db.PHANCONGs
                               from gv in db.GIAOVIENs
                               where hs.MaHocSinh == pl.MaHocSinh &&
                               l.MaLop == pl.MaLop &&
                               pc.MaGiaoVien == gv.MaGiaoVien &&
                               pc.MaLop == l.MaLop
                               select new
                               {
                                   hs.MaHocSinh,
                                   hs.HoTen,
                                   hs.GioiTinh,
                                   hs.NgaySinh,
                                   hs.NoiSinh,
                                   hs.MaDanToc,
                                   hs.MaTonGiao,
                                   hs.HoTenCha,
                                   hs.MaNNghiepCha,
                                   hs.HoTenMe,
                                   hs.MaNNghiepMe
                               });
                foreach (var item in hocsinh)
                {
                    HocSinh_Class hocsinh_Class = new HocSinh_Class();
                    hocsinh_Class.ID = t;
                    hocsinh_Class.MaHocSinh = item.MaHocSinh;
                    hocsinh_Class.HoTen = item.HoTen;
                    hocsinh_Class.GioiTinh = LoadGT((bool)item.GioiTinh);
                    hocsinh_Class.NgaySinh = item.NgaySinh.ToString();
                    hocsinh_Class.NoiSinh = item.NoiSinh;
                    hocsinh_Class.DanToc = loadTenDT(item.MaDanToc);
                    hocsinh_Class.TonGiao = loadTenTG(item.MaTonGiao);
                    hocsinh_Class.HoTenCha = item.HoTenCha;
                    hocsinh_Class.NgheNghiepCha = loadTenNN(item.MaNNghiepCha);
                    hocsinh_Class.HoTenMe = item.HoTenMe;
                    hocsinh_Class.NgheNghiepMe = loadTenNN(item.MaNNghiepMe);
                    t++;
                    lst.Add(hocsinh_Class);
                }
            }
            else
            {
                var hocsinh1 = (from hs in db.HOCSINHs
                               from l in db.LOPs
                               from pl in db.PHANLOPs
                               from pc in db.PHANCONGs
                               from gv in db.GIAOVIENs
                               where hs.MaHocSinh == pl.MaHocSinh &&
                               l.MaLop == pl.MaLop &&
                               pc.MaGiaoVien == gv.MaGiaoVien &&
                               pc.MaLop == l.MaLop &&
                               gv.MaGiaoVien == magv
                               select new
                               {
                                   hs.MaHocSinh,
                                   hs.HoTen,
                                   hs.GioiTinh,
                                   hs.NgaySinh,
                                   hs.NoiSinh,
                                   hs.MaDanToc,
                                   hs.MaTonGiao,
                                   hs.HoTenCha,
                                   hs.MaNNghiepCha,
                                   hs.HoTenMe,
                                   hs.MaNNghiepMe
                               }) ;
                foreach (var item in hocsinh1)
                {
                    HocSinh_Class hocsinh_Class = new HocSinh_Class();
                    hocsinh_Class.ID = t;
                    hocsinh_Class.MaHocSinh = item.MaHocSinh;
                    hocsinh_Class.HoTen = item.HoTen;
                    hocsinh_Class.GioiTinh = LoadGT((bool)item.GioiTinh);
                    hocsinh_Class.NgaySinh = DateTime.Parse(item.NgaySinh.ToString()).ToShortDateString().ToString();
                    hocsinh_Class.NoiSinh = item.NoiSinh;
                    hocsinh_Class.DanToc = loadTenDT(item.MaDanToc);
                    hocsinh_Class.TonGiao = loadTenTG(item.MaTonGiao);
                    hocsinh_Class.HoTenCha = item.HoTenCha;
                    hocsinh_Class.NgheNghiepCha = loadTenNN(item.MaNNghiepCha);
                    hocsinh_Class.HoTenMe = item.HoTenMe;
                    hocsinh_Class.NgheNghiepMe = loadTenNN(item.MaNNghiepMe);
                    t++;
                    lst.Add(hocsinh_Class);
                }
            }

            return lst;
        }

        public IEnumerable<HOCSINH> loadTTHS(string mahs)
        {
            return db.HOCSINHs.Where(t => t.MaHocSinh == mahs);
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
        public void themHS(string maHS, string tenHS, string noisinh, bool gt, 
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
                MessageBox.Show("Thêm học sinh thành công");
            }
            else
            {
                MessageBox.Show("Thêm học sinh thất bại");
            }
        }


        // Sửa học sinh
        public void suaHS(string maHS, string tenHS, string noisinh,
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
                MessageBox.Show("Cập nhật thông tin học sinh thành công");
            }
            else
                MessageBox.Show("Cập nhật thông tin học sinh thất bại");
        }
    }
    }
