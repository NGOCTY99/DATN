using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL.Class
{
    public class GiaoVien_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public GiaoVien_Data()
        {

        }

        public dynamic loadDataGridView()
        {
            var giaovien = from gv in db.GIAOVIENs
                           from mh in db.MONHOCs
                           where gv.MaMonHoc == mh.MaMonHoc
                           select new
                           {
                               gv.MaGiaoVien,
                               gv.TenGiaoVien,
                               gv.DiaChi,
                               gv.DienThoai,
                               mh.TenMonHoc
                           };
            return giaovien;
        }

        public IQueryable<MONHOC> loadMonHoc()
        {
            return from mh in db.MONHOCs select mh;
        }

        public bool ktkc(string ma)
        {

            GIAOVIEN gv = db.GIAOVIENs.Where(t => t.MaGiaoVien == ma).FirstOrDefault();
            if (gv == null)
            {
                return true; // mã ko trùng được thêm vào
            }
            else
            {
                return false;
            }
        }

        // thêm mới
        public bool themGV(string magv, string tengv, string diachi, string sdt, string mamh)
        {
            if (ktkc(magv) == true)
            {
                GIAOVIEN gv = new GIAOVIEN();
                gv.MaGiaoVien = magv;
                gv.TenGiaoVien = tengv;
                gv.DiaChi = diachi;
                gv.DienThoai = sdt;
                gv.MaMonHoc = mamh;
                db.GIAOVIENs.InsertOnSubmit(gv);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        // sửa
        public bool suaGV(string magv, string tengv, string diachi, string sdt, string mamh)
        {
            if (ktkc(magv) == false)
            {
                GIAOVIEN gv = db.GIAOVIENs.Where(t => t.MaGiaoVien == magv).FirstOrDefault();
                gv.MaGiaoVien = magv;
                gv.TenGiaoVien = tengv;
                gv.DiaChi = diachi;
                gv.DienThoai = sdt;
                gv.MaMonHoc = mamh;
                db.SubmitChanges();
                return true;
            }
            else
                return false;
        }

    }
}
