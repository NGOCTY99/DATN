using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAL_BLL.Class
{
    public class Diem_Data
    {

        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public Diem_Data()
        {

        }

        public dynamic loadcboNamHoc(string id, string magv)
        {
            if (id == "LND004")
            {
                return db.NAMHOCs.Select(t => t);
            }
            else
            {
                var namday = from nh in db.NAMHOCs
                             from gv in db.GIAOVIENs
                             from pc in db.PHANCONGs
                             where gv.MaGiaoVien == pc.MaGiaoVien &&
                             gv.MaGiaoVien == magv &&
                             nh.MaNamHoc == pc.MaNamHoc
                             select new
                             {
                                 nh.MaNamHoc,
                                 nh.TenNamHoc
                             };
                return namday;
            }
        }

        //Load combobox khối lớp
        public dynamic loadcboKhoiLop(string id, string magv, string namhoc)
        {
            if (id == "LND004")
            {
                var khoi = (from kl in db.KHOILOPs
                            join l in db.LOPs on kl.MaKhoiLop equals l.MaKhoiLop
                            join nam in db.NAMHOCs on l.MaNamHoc equals nam.MaNamHoc
                            where nam.MaNamHoc == namhoc
                            group kl by new { kl.MaKhoiLop, kl.TenKhoiLop } into kl1
                            select new
                            {
                                kl1.Key.MaKhoiLop,
                                kl1.Key.TenKhoiLop
                            });
                return khoi;

            }
            else
            {
                var kq = from kl in db.KHOILOPs
                         from l in db.LOPs
                         from gv in db.GIAOVIENs
                         from pc in db.PHANCONGs
                         from nh in db.NAMHOCs
                         where kl.MaKhoiLop == l.MaKhoiLop &&
                         gv.MaGiaoVien == pc.MaGiaoVien &&
                         gv.MaGiaoVien == magv &&
                         nh.MaNamHoc == l.MaNamHoc &&
                         nh.MaNamHoc == namhoc &&
                         pc.MaLop == l.MaLop
                         group kl by new { kl.MaKhoiLop, kl.TenKhoiLop } into kl1
                         select new
                         {
                             kl1.Key.MaKhoiLop,
                             kl1.Key.TenKhoiLop
                         };
                return kq;
            }
        }

        //Load combobox lớp học 
        public dynamic loadcboLopHoc(string id, string magv, string makhoi, string namhoc)
        {
            if (id == "LND004")
            {
                return db.LOPs.Where(t => t.MaKhoiLop == makhoi && t.MaNamHoc == namhoc);
            }
            else
            {
                var kq = from l in db.LOPs
                         from kl in db.KHOILOPs
                         from nh in db.NAMHOCs
                         from pc in db.PHANCONGs
                         from gv in db.GIAOVIENs
                         where l.MaKhoiLop == kl.MaKhoiLop &&
                         l.MaNamHoc == nh.MaNamHoc &&
                         pc.MaGiaoVien == gv.MaGiaoVien &&
                         gv.MaGiaoVien == magv &&
                         pc.MaLop == l.MaLop
                         select new
                         {
                             l.MaLop,
                             l.TenLop
                         };
                return kq;
            }
        }

        // load combobox môn học
        public dynamic LoadMonHoc(string id, string magv)
        {
            if (id == "LND004")
            {
                return from mh in db.MONHOCs select mh;
            }
            else
            {
                var monhoc = from mh in db.MONHOCs
                             from gv in db.GIAOVIENs
                             where gv.MaMonHoc == mh.MaMonHoc &&
                             gv.MaGiaoVien == magv
                             select new
                             {
                                 mh.MaMonHoc,
                                 mh.TenMonHoc
                             };
                return monhoc;
            }
        }

        // load cbb học kỳ
        public dynamic LoadHocKy()
        {
            return from hk in db.HOCKies select hk;
        }
        //Load datagridView: hiện ds học sinh theo năm, khối, lớp
        public dynamic loadDLHS(string id, string magv, string manam, string makhoi, string malop)
        {
            if (id == "LND004")
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
                          });
                return dl;
            }
            else
            {
                var dl = (from l in db.LOPs
                          from h in db.HOCSINHs
                          from p in db.PHANLOPs
                          from pc in db.PHANCONGs
                          from gv in db.GIAOVIENs
                          where l.MaLop == malop &&
                                p.MaKhoiLop == makhoi &&
                                p.MaNamHoc == manam &&
                                h.MaHocSinh == p.MaHocSinh &&
                                p.MaLop == l.MaLop &&
                                pc.MaGiaoVien == gv.MaGiaoVien &&
                                pc.MaLop == l.MaLop &&
                                gv.MaGiaoVien == magv
                          select new
                          {
                              h.MaHocSinh,
                              h.HoTen,
                              h.NgaySinh,
                              l.TenLop
                          });
                return dl;
            }
        }
        //Load datagridView theo từng môn học của học kỳ (DS HS đã có điểm)
        public dynamic loadDL(string id, string magv, string malop, string mamh, string mahk)
        {
            if (id == "LND004")
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
                          group h by new
                          {
                              h.MaHocSinh,
                              h.HoTen,
                              h.NgaySinh,
                              l.TenLop
                          } into g
                          select new
                          {
                              g.Key.MaHocSinh,
                              g.Key.HoTen,
                              g.Key.NgaySinh,
                              g.Key.TenLop
                          });
                return dl;
            }
            else
            {
                var dl = (from l in db.LOPs
                          from mh in db.MONHOCs
                          from h in db.HOCSINHs
                          from p in db.PHANLOPs
                          from d in db.DIEMs
                          from hk in db.HOCKies
                          from pc in db.PHANCONGs
                          from gv in db.GIAOVIENs
                          where l.MaLop == malop &&
                                mh.MaMonHoc == mamh &&
                                hk.MaHocKy == mahk &&
                                h.MaHocSinh == p.MaHocSinh &&
                                p.MaHocSinh == d.MaHocSinh &&
                                l.MaLop == d.MaLop &&
                                mh.MaMonHoc == d.MaMonHoc &&
                                hk.MaHocKy == d.MaHocKy &&
                                pc.MaGiaoVien == gv.MaGiaoVien &&
                                pc.MaLop == l.MaLop &&
                                gv.MaGiaoVien == magv
                          group h by new
                          {
                              h.MaHocSinh,
                              h.HoTen,
                              h.NgaySinh,
                              l.TenLop
                          } into g
                          select new
                          {
                              g.Key.MaHocSinh,
                              g.Key.HoTen,
                              g.Key.NgaySinh,
                              g.Key.TenLop
                          });
                return dl;
            }
        }
        // load điểm của học sinh theo từng loại điểm của môn học 
        public IEnumerable<DIEM> LoadDiem(string mahs, string mamh, string hocky)
        {
            return db.DIEMs.Where(t => t.MaHocSinh == mahs && t.MaMonHoc == mamh && t.MaHocKy == hocky);
        }

        public string loadMaLoai(string tenloai)
        {
            return db.LOAIDIEMs.Single(t => t.TenLoai == tenloai).MaLoai.ToString();
        }
        // Load cbo Loại điểm
        public dynamic LoaiCBOLoaiDiem()
        {
            return from ld in db.LOAIDIEMs select ld;
        }
        // thêm điểm môn học 
        public void loadcotdiem(string mahs, string mamh, string mahk, string manh, string malop, string maloaidiem, float diem)
        {
            var demdiemmieng = db.DIEMs.Where(t => t.MaHocSinh == mahs
                             && t.MaHocKy == mahk
                             && t.MaNamHoc == manh
                             && t.MaMonHoc == mamh
                             && t.MaLoai == "LD0001").Count();
            var demdiem15 = db.DIEMs.Where(t => t.MaHocSinh == mahs
                 && t.MaHocKy == mahk
                 && t.MaNamHoc == manh
                 && t.MaMonHoc == mamh
                 && t.MaLoai == "LD0002").Count();
            var demdiem1 = db.DIEMs.Where(t => t.MaHocSinh == mahs
                 && t.MaHocKy == mahk
                 && t.MaNamHoc == manh
                 && t.MaMonHoc == mamh
                 && t.MaLoai == "LD0003").Count();
            var demdiemthi = db.DIEMs.Where(t => t.MaHocSinh == mahs
                 && t.MaHocKy == mahk
                 && t.MaNamHoc == manh
                 && t.MaMonHoc == mamh
                 && t.MaLoai == "LD0004").Count();
            if (maloaidiem == "LD0001")
            {
                if (demdiemmieng < 4)
                {
                    themDiem(mahs, mamh, mahk, manh, malop, maloaidiem, diem);
                }
                else MessageBox.Show("Điểm miệng và điểm 15 có tối đa 4 cột");
            }
            if (maloaidiem == "LD0002")
            {
                if (demdiem15 < 4)
                {
                    themDiem(mahs, mamh, mahk, manh, malop, maloaidiem, diem);
                }
                else MessageBox.Show("Điểm miệng và điểm 15 có tối đa 4 cột");
            }

            if (maloaidiem == "LD0003")
            {
                if (demdiem1 > 1) MessageBox.Show("Điểm 1 tiết có 2 cột");
                else themDiem(mahs, mamh, mahk, manh, malop, maloaidiem, diem);
            }
            else
            {
                if (maloaidiem == "LD0004")
                {
                    if (demdiemthi > 0) MessageBox.Show("Điểm thi duy nhất 1");

                    else themDiem(mahs, mamh, mahk, manh, malop, maloaidiem, diem);
                }
            }
        }

        public void themDiem(string mahs, string mamh, string mahk, string manh, string malop, string maloaidiem, float diem)
        {
            DIEM d = new DIEM();
            d.MaMonHoc = mamh;
            d.MaHocKy = mahk;
            d.MaHocSinh = mahs;
            d.MaNamHoc = manh;
            d.MaLop = malop;
            d.MaLoai = maloaidiem;
            d.Diem1 = diem;
            db.DIEMs.InsertOnSubmit(d);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công");
        }

        public bool ktst(int stt)
        {
            var kq = (from d in db.DIEMs where d.STT == stt select d).SingleOrDefault();
            if (kq != null) return false;
            else return true;

        }
        // Sửa điểm môn học 
        public void suaDiem(int stt, string mahs, string mamh, string mahk, string manh, string malop, string maloaidiem, float diem)
        {

            if (ktst(stt) == false)
            {
                var kt = db.DIEMs.FirstOrDefault(t => t.STT == stt);
                kt.MaHocSinh = mahs;
                kt.MaMonHoc = mamh;
                kt.MaHocKy = mahk;
                kt.MaNamHoc = manh;
                kt.MaLop = malop;
                kt.MaLoai = maloaidiem;
                kt.Diem1 = diem;
                db.SubmitChanges();
                MessageBox.Show("Cập nhật điểm thành công");
            }
            else MessageBox.Show("Cập nhật điểm thất bại");
        }

        public string loaiDiem(string ma)
        {
            return db.LOAIDIEMs.SingleOrDefault(t => t.MaLoai == ma).TenLoai;
        }

        public double tinhdiemTBM(string mahs, string mamonhoc, string manam, string mahocky)
        {
            double diemtb = new double();
            double diem;
            List<double> lstdiemhs1 = new List<double>();
            List<double> lstdiemhs2 = new List<double>();
            List<double> lstdiemhs3 = new List<double>();
            foreach (var item in db.DIEMs.Where(t => t.MaHocSinh == mahs && t.MaMonHoc == mamonhoc && t.MaNamHoc == manam && t.MaHocKy == mahocky))
            {
                if (item.MaLoai == "LD0001" || item.MaLoai == "LD0002")
                {
                    diem = item.Diem1;
                    lstdiemhs1.Add(diem);
                }
                if (item.MaLoai == "LD0003")
                {
                    diem = item.Diem1;
                    lstdiemhs2.Add(diem);
                }
                else
                {
                    if (item.MaLoai == "LD0004")
                        lstdiemhs3.Add(item.Diem1);
                }
            }
            for (int i = 0; i < lstdiemhs1.Count; i++)
            {
                diemtb += lstdiemhs1[i];
            }
            for (int i = 0; i < lstdiemhs2.Count; i++)
            {
                diemtb += lstdiemhs2[i] * 2;
            }
            for (int i = 0; i < lstdiemhs3.Count; i++)
            {
                diemtb += lstdiemhs3[i] * 3;
            }
            diemtb = (double)((diemtb) / (lstdiemhs1.Count + (lstdiemhs2.Count * 2) + (lstdiemhs3.Count * 3)));
            return (double)Math.Round(Convert.ToDecimal(diemtb), 1);
        }

        public void tinhdiemtheohocky(string mahs, string mahk, string mon, string manamhoc, string malop, double diemtb)
        {
            KQ_HOC_KY_MON_HOC ketqua = db.KQ_HOC_KY_MON_HOCs.Where(t => t.MaHocSinh == mahs && t.MaHocKy == mahk && t.MaNamHoc == manamhoc && t.MaMonHoc == mon).SingleOrDefault();
            if (ketqua != null)
            {
                ketqua.MaHocSinh = mahs;
                ketqua.MaHocKy = mahk;
                ketqua.MaMonHoc = mon;
                ketqua.MaNamHoc = manamhoc;
                ketqua.MaLop = malop;
                ketqua.DTBMonHocKy = diemtb;
                db.SubmitChanges();
            }
            else
            {
                KQ_HOC_KY_MON_HOC hk = new KQ_HOC_KY_MON_HOC();
                hk.MaHocSinh = mahs;
                hk.MaHocKy = mahk;
                hk.MaMonHoc = mon;
                hk.MaNamHoc = manamhoc;
                hk.MaLop = malop;
                hk.DTBMonHocKy = diemtb;
                db.KQ_HOC_KY_MON_HOCs.InsertOnSubmit(hk);
                db.SubmitChanges();
            }
        }
        public string layTenMon(string malop)
        {
            var l = db.LOPs.SingleOrDefault(t => t.MaLop == malop).MaGiaoVien;
            var gv = db.GIAOVIENs.SingleOrDefault(t => t.MaGiaoVien == l).MaMonHoc;
            return gv;
        }

        public double tinhdiemHK(string mahs, string malop, string mahk, string manh)
        {
            List<double> dtbmonhs2 = new List<double>();
            List<double> dtbmon = new List<double>();
            double dtbhk = 0;
            double diem;
            foreach (var item in db.KQ_HOC_KY_MON_HOCs.Where(t => t.MaHocSinh == mahs && t.MaHocKy == mahk && t.MaLop == malop))
            {
                if (item.MaMonHoc == "MH0001")
                {
                    diem = item.DTBMonHocKy;
                    dtbmonhs2.Add(diem);
                }
                else if (item.MaMonHoc == "MH0005")
                {
                    diem = item.DTBMonHocKy;
                    dtbmonhs2.Add(diem);
                }
                else if (item.MaMonHoc == "MH0002" || item.MaMonHoc == "MH0003" || item.MaMonHoc == "MH0004" ||
                            item.MaMonHoc == "MH0006" || item.MaMonHoc == "MH0007" || item.MaMonHoc == "MH0009")
                {
                    if (item.MaMonHoc == layTenMon(item.MaLop))
                    {
                        diem = item.DTBMonHocKy;
                        dtbmonhs2.Add(diem);
                    }
                    else dtbmon.Add(item.DTBMonHocKy);
                }
                else if (item.MaMonHoc == "MH0008")
                {
                    if (layTenMon(item.MaLop) != "MH0002" && layTenMon(item.MaLop) != "MH0003" && layTenMon(item.MaLop) != "MH0004" &&
                            layTenMon(item.MaLop) != "MH0006" && layTenMon(item.MaLop) != "MH0007" && layTenMon(item.MaLop) != "MH0009")
                    {
                        diem = item.DTBMonHocKy;
                        dtbmonhs2.Add(diem);
                    }
                    else dtbmon.Add(item.DTBMonHocKy);
                }
                else dtbmon.Add(item.DTBMonHocKy);
            }
            for (int i = 0; i < dtbmonhs2.Count(); i++)
            {
                dtbhk += (dtbmonhs2[i] * 2);
            }
            for (int i = 0; i < dtbmon.Count(); i++)
            {
                dtbhk += dtbmon[i];
            }
            dtbhk = dtbhk / 14;
            dtbhk = (double)Math.Round(Convert.ToDecimal(dtbhk), 1);
            return dtbhk;
        }

        public IEnumerable<HANHKIEM> loadHK()
        {
            return db.HANHKIEMs.Select(t => t);
        }
        public double laydiemtheomon(string mahs, string malop, string manam, string mahk,string mamonhoc)
        {
            return db.KQ_HOC_KY_MON_HOCs.SingleOrDefault(t => t.MaHocSinh == mahs && t.MaNamHoc==manam && t.MaHocKy == mahk && t.MaLop == malop && t.MaMonHoc == mamonhoc).DTBMonHocKy;
        }

        public bool KTMon(string mahs, string malop, string manam, string mahk, string mamonhoc)
        {
            var kq = db.KQ_HOC_KY_MON_HOCs.SingleOrDefault(t => t.MaHocSinh == mahs && t.MaNamHoc == manam && t.MaHocKy == mahk && t.MaLop == malop && t.MaMonHoc == mamonhoc);
            if (kq == null)
                return true;
            else return false;
        }


        string kq;
        public string XetHLTheoDTB(double diemtb, string mahs, string malop, string manam, string mahk)
        {
            double toan, van, anh, su, dia, vat, gdcd, gdqp, cn, hoa, sinh, td, tin;
            bool kqtoan, kqvan, kqanh, kqsu, kqdia, kqvat, kqgdcd, kqgdqp, kqcn, kqhoa, kqsinh, kqtd, kqtin;
            //kt xem điểm có null hay không?
            kqtoan = KTMon(mahs, malop, manam, mahk, "MH0001");
            kqvan = KTMon(mahs, malop, manam, mahk, "MH0005");
            kqanh = KTMon(mahs, malop, manam, mahk, "MH0008");
            kqsu = KTMon(mahs, malop, manam, mahk, "MH0006");
            kqdia = KTMon(mahs, malop, manam, mahk, "MH0007");
            kqvat = KTMon(mahs, malop, manam, mahk, "MH0002");
            kqgdcd = KTMon(mahs, malop, manam, mahk, "MH0009");
            kqgdqp = KTMon(mahs, malop, manam, mahk, "MH0012");
            kqcn = KTMon(mahs, malop, manam, mahk, "MH0013");
            kqhoa = KTMon(mahs, malop, manam, mahk, "MH0003");
            kqsinh = KTMon(mahs, malop, manam, mahk, "MH0004");
            kqtd = KTMon(mahs, malop, manam, mahk, "MH0011");
            kqtin = KTMon(mahs, malop, manam, mahk, "MH0010");

            if (kqtoan == false && kqvan == false && kqanh == false &&
                kqsu == false && kqdia == false && kqvat == false && kqgdcd == false &&
                kqgdqp == false && kqcn == false && kqhoa == false && kqsinh == false &&
                kqtd == false && kqtin == false)
            {
                //lấy điểm của từng môn học nếu có
                toan = laydiemtheomon(mahs, malop, manam, mahk, "MH0001");
                van = laydiemtheomon(mahs, malop, manam, mahk, "MH0005");
                anh = laydiemtheomon(mahs, malop, manam, mahk, "MH0008");
                su = laydiemtheomon(mahs, malop, manam, mahk, "MH0006");
                dia = laydiemtheomon(mahs, malop, manam, mahk, "MH0007");
                vat = laydiemtheomon(mahs, malop, manam, mahk, "MH0002");
                gdcd = laydiemtheomon(mahs, malop, manam, mahk, "MH0009");
                gdqp = laydiemtheomon(mahs, malop, manam, mahk, "MH0012");
                cn = laydiemtheomon(mahs, malop, manam, mahk, "MH0013");
                hoa = laydiemtheomon(mahs, malop, manam, mahk, "MH0003");
                sinh = laydiemtheomon(mahs, malop, manam, mahk, "MH0004");
                td = laydiemtheomon(mahs, malop, manam, mahk, "MH0011");
                tin = laydiemtheomon(mahs, malop, manam, mahk, "MH0010");

                tin = db.KQ_HOC_KY_MON_HOCs.SingleOrDefault(t => t.MaHocSinh == mahs && t.MaHocKy == mahk && t.MaLop == malop && t.MaMonHoc == "MH0010").DTBMonHocKy;
                if (diemtb >= 8.0)
                {
                    if (anh >= 6.5 && su >= 6.5 && dia >= 6.5 && vat >= 6.5 && gdcd >= 6.5 && gdqp >= 6.5 && cn >= 6.5 && hoa >= 6.5 && sinh >= 6.5 && td >= 6.5 && tin >= 6.5)
                    {
                        if (van >= 8.0 && toan >= 6.5)
                            kq = "Gioi";
                        else if (van >= 6.5 && toan >= 8.0)
                            kq = "Gioi";
                    }
                    else kq = "Kha";
                }
                else if (diemtb >= 6.5)
                {
                    if (anh >= 5.0 && su >= 5.0 && dia >= 5.0 && vat >= 5.0 && gdcd >= 5.0 && gdqp >= 5.0 && cn >= 5.0 && hoa >= 5.0 && sinh >= 5.0 && td >= 5.0 && tin >= 5.0)
                    {
                        if (van >= 6.5 && toan >= 5.0)
                            kq = "Kha";
                        else if (van >= 5.0 && toan >= 6.5)
                            kq = "Kha";
                    }
                    else kq = "Trung binh";
                }
                else if (diemtb >= 5.0)
                {
                    if (anh >= 3.5 && su >= 3.5 && dia >= 3.5 && vat >= 3.5 && gdcd >= 3.5 && gdqp >= 3.5 && cn >= 3.5 && hoa >= 3.5 && sinh >= 3.5 && td >= 3.5 && tin >= 3.5)
                    {
                        if (van >= 5.0 && toan >= 3.5)
                            kq = "Trung binh";
                        else if (van >= 3.5 && toan >= 5.0)
                            kq = "Trung binh";
                    }
                    else kq = "Yeu";
                }
                else
                    kq = "Yeu";
            }
            else kq = "Trong";
            return kq;
        }
        string kqhl;
        public string xetloaiHoclucHKCN(string hltheodiem, string mahk)
        {
            if (hltheodiem == "Gioi")
            {
                if (mahk == "Tot")
                    kqhl = "Gioi";
                else
                    kqhl = mahk;
            }
            else if (hltheodiem == "Kha")
            {
                if (mahk == "Tot" || mahk == "Kha")
                    kqhl = "Kha";
                else kqhl = mahk;
            }
            else if (hltheodiem == "Trung binh")
            {
                if (mahk == "Yeu") kqhl = mahk;
                else kqhl = hltheodiem;
            }
            else kqhl = hltheodiem;
            return kqhl;
        }
        public IEnumerable<HOCLUC> loadhl()
        {
            return db.HOCLUCs.Select(t => t);
        }

        public void kqhocky(string mahs,string malop, string mahocky, string manamhoc, string mahocluc, string mahk, double diem)
        {
            KQ_HOC_KY_TONG_HOP kq = db.KQ_HOC_KY_TONG_HOPs.SingleOrDefault(t => t.MaHocSinh == mahs && t.MaLop == malop && t.MaHocKy == mahocky && t.MaNamHoc == manamhoc);
            if(kq!=null)
            {
                kq.MaHanhKiem = mahk;
                kq.DTBMonHocKy = diem;
                kq.MaHocLuc = mahocluc;
                db.SubmitChanges();
            }    
            else
            {
                KQ_HOC_KY_TONG_HOP kqhk = new KQ_HOC_KY_TONG_HOP();
                kqhk.MaHocSinh = mahs;
                kqhk.MaLop = malop;
                kqhk.MaHocKy = mahocky;
                kqhk.MaNamHoc = manamhoc;
                kqhk.MaHocLuc = mahocluc;
                kqhk.MaHanhKiem = mahk;
                kqhk.DTBMonHocKy = diem;
                db.KQ_HOC_KY_TONG_HOPs.InsertOnSubmit(kqhk);
                db.SubmitChanges();
            }
        }
        
        public string loadMaHL(string ten)
        {
            return db.HOCLUCs.SingleOrDefault(t => t.TenHocLuc == ten).MaHocLuc;
        }

        public double capnhatdiemMHcanam(string mahs, string malop, string manamhoc,string mamonhoc)
        {
            var kqk1 = db.KQ_HOC_KY_MON_HOCs.SingleOrDefault(t => t.MaHocSinh == mahs && t.MaLop == malop && t.MaHocKy == "HK1" && t.MaMonHoc==mamonhoc && t.MaNamHoc == manamhoc).DTBMonHocKy;
            var kqk2 = db.KQ_HOC_KY_MON_HOCs.SingleOrDefault(t => t.MaHocSinh == mahs && t.MaLop == malop && t.MaHocKy == "HK2" && t.MaMonHoc == mamonhoc && t.MaNamHoc == manamhoc).DTBMonHocKy;
            double kq;
            if (kqk1 >=0 && kqk2 >=0)
            {
                kq = (double)((kqk1 + kqk2 * 2) / 3);
                KQ_CA_NAM_MON_HOC kqmn = db.KQ_CA_NAM_MON_HOCs.SingleOrDefault(t => t.MaHocSinh == mahs && t.MaLop == malop && t.MaMonHoc == mamonhoc && t.MaNamHoc == manamhoc);
                if (kqmn == null)
                {
                    kqmn = new KQ_CA_NAM_MON_HOC();
                    kqmn.MaHocSinh = mahs;
                    kqmn.MaLop = malop;
                    kqmn.MaNamHoc = manamhoc;
                    kqmn.MaMonHoc = mamonhoc;
                    kqmn.DTBCaNam = (double)Math.Round(Convert.ToDecimal(kq), 1);
                    db.KQ_CA_NAM_MON_HOCs.InsertOnSubmit(kqmn);
                    db.SubmitChanges();
                }
                else
                {
                    kqmn.DTBCaNam = kq;
                    db.SubmitChanges();
                }
            }
            else kq = 0;

            return (double)Math.Round(Convert.ToDecimal(kq), 1);
        }

        public double loaddiemhk(string mahs, string malop, string mamonhoc, string manamhoc, string hocky)
        {
            return db.KQ_HOC_KY_MON_HOCs.SingleOrDefault(t => t.MaHocSinh == mahs && t.MaLop == malop && t.MaNamHoc == manamhoc && t.MaMonHoc == mamonhoc && t.MaHocKy == hocky).DTBMonHocKy;
        }

        public double loaddiemcn(string mahs, string malop, string manamhoc, string hocky)
        {
            return (double)db.KQ_HOC_KY_TONG_HOPs.SingleOrDefault(t => t.MaHocSinh == mahs && t.MaLop == malop && t.MaNamHoc == manamhoc  && t.MaHocKy == hocky).DTBMonHocKy;
        }

        public double capnhatDTBcanam(string mahs, string malop, string manamhoc, string mamonhoc)
        {
            var kqk1 = db.KQ_HOC_KY_TONG_HOPs.SingleOrDefault(t => t.MaHocSinh == mahs && t.MaLop == malop && t.MaHocKy == "HK1" && t.MaNamHoc == manamhoc).DTBMonHocKy;
            var kqk2 = db.KQ_HOC_KY_TONG_HOPs.SingleOrDefault(t => t.MaHocSinh == mahs && t.MaLop == malop && t.MaHocKy == "HK2" && t.MaNamHoc == manamhoc).DTBMonHocKy;
            double kq;
            if (kqk1 >= 0 && kqk2 >= 0)
            {
                kq = (double)((kqk1 + kqk2 * 2) / 3);
                KQ_CA_NAM_MON_HOC kqmn = db.KQ_CA_NAM_MON_HOCs.SingleOrDefault(t => t.MaHocSinh == mahs && t.MaLop == malop && t.MaMonHoc == mamonhoc && t.MaNamHoc == manamhoc);
                if (kqmn == null)
                {
                    kqmn = new KQ_CA_NAM_MON_HOC();
                    kqmn.MaHocSinh = mahs;
                    kqmn.MaLop = malop;
                    kqmn.MaNamHoc = manamhoc;
                    kqmn.MaMonHoc = mamonhoc;
                    kqmn.DTBCaNam = (double)Math.Round(Convert.ToDecimal(kq), 1);
                    db.KQ_CA_NAM_MON_HOCs.InsertOnSubmit(kqmn);
                    db.SubmitChanges();
                }
                else
                {
                    kqmn.DTBCaNam = kq;
                    db.SubmitChanges();
                }
            }
            else kq = 0;

            return (double)Math.Round(Convert.ToDecimal(kq), 1);
        }

    }
}
