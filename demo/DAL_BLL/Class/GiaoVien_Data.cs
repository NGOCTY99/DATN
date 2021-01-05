using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAL_BLL.Class
{
    public class GiaoVien_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        PQtrongForm pq = new PQtrongForm();
        public dynamic loadDataGridView(string id, string magv)
        {
            if (id == "LND004")
            {
                return db.GIAOVIENs.Select(t => t);
            }
            else
            {
                var ghichu = db.GIAOVIENs.FirstOrDefault(t => t.GhiChu == "To truong");
                if(ghichu == null)
                {
                    return db.GIAOVIENs.Where(t => t.MaGiaoVien == magv);
                }    
                else
                {
                    var mh = db.GIAOVIENs.FirstOrDefault(t => t.MaGiaoVien == magv).MaMonHoc;
                    return db.GIAOVIENs.Where(t => t.MaMonHoc == mh);
                }                    
            }                
        }
        public string loadtenMH(string mamh)
        {
            return db.MONHOCs.SingleOrDefault(t => t.MaMonHoc == mamh).TenMonHoc;
        }

        public IEnumerable<MONHOC> loadMonHoc(string id,string magv)
        {
            if(id == "LND004")
            {
                return db.MONHOCs.Select(t=>t);
            }
            else
            {
                var mh = db.GIAOVIENs.FirstOrDefault(t => t.MaGiaoVien == magv).MaMonHoc;
                return db.MONHOCs.Where(t => t.MaMonHoc == mh);
            }    
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
        public void themGV(string magv, string tengv, string diachi, string sdt, string mamh)
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
                MessageBox.Show("Thêm giáo viên thành công");
            }
            else
            {
                MessageBox.Show("Thêm giáo viên thất bại");
            }
        }

        // sửa
        public void suaGV(string magv, string tengv, string diachi, string sdt, string mamh)
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
                MessageBox.Show("Cập nhật giáo viên thành công");
            }
            else
                MessageBox.Show("Cập nhật giáo viên thất bại");
        }

    }
}
