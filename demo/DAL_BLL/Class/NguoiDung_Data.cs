using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAL_BLL.Class
{
    public class NguoiDung_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public IEnumerable<NGUOIDUNG> loadND()
        {
            return db.NGUOIDUNGs.Select(t => t);
        }

        public bool Loadstatus(string id)
        {
            return (bool)db.NGUOIDUNGs.FirstOrDefault(t => t.MaND == id).Status;
        }

        public List<NguoiDung_New> loadNDnew()
        {
            List<NguoiDung_New> lst = new List<NguoiDung_New>();
            var nd = (from ngd in db.NGUOIDUNGs
                      join loainv in db.LOAINGUOIDUNGs on ngd.MaLoai equals loainv.MaLoai
                      join gv in db.GIAOVIENs on ngd.TenND equals gv.MaGiaoVien
                      select new
                      {
                          Mand = ngd.MaND,
                          Tenloai = loainv.TenLoaiND,
                          Tengv = gv.TenGiaoVien,
                          Tendangnhap = ngd.TenDNhap,
                          Matkhau = ngd.MatKhau,
                      });
            foreach (var item in nd)
            {

                NguoiDung_New clr = new NguoiDung_New();
                clr.Mand = item.Mand;
                clr.Tenloai = item.Tenloai;
                clr.Tengv = item.Tengv;
                clr.Tendangnhap = item.Tendangnhap;
                clr.Matkhau = item.Matkhau;
                clr.Check = Loadstatus(item.Mand);
                lst.Add(clr);
            }
            return lst;
        }
        public bool CheckUser(string magv, string mand)
        {
            var nd = db.NGUOIDUNGs.FirstOrDefault(t => t.TenND == mand && t.MaND==mand);
            if (nd == null)
            {
                return true;
            }
            else return false;
        }

        public void insertUser(string mand, string maloai, string tennd, string tendn, string matkhau, bool check)
        {
            if (CheckUser(tennd, mand) == true)
            {
                NGUOIDUNG nd = new NGUOIDUNG();
                nd.MaND = mand;
                nd.MaLoai = maloai;
                nd.TenND = tennd;
                nd.TenDNhap = tendn;
                nd.MatKhau = matkhau;
                nd.Status = check;
                db.NGUOIDUNGs.InsertOnSubmit(nd);
                db.SubmitChanges();
                MessageBox.Show("Thêm người dùng thành công");
            }
            else MessageBox.Show("Đã tồn tại người dùng này");
        }

        public void updateUser(string mand, string maloai, string tennd, string tendn, string matkhau, bool check)
        {
            if (CheckUser(tennd, mand) == false)
            {
                NGUOIDUNG nd = db.NGUOIDUNGs.FirstOrDefault(t => t.MaND == mand);
                nd.MaLoai = maloai;
                nd.TenDNhap = tendn;
                nd.MatKhau = matkhau;
                nd.Status = check;
                db.NGUOIDUNGs.InsertOnSubmit(nd);
                db.SubmitChanges();
                MessageBox.Show("Cập nhật người dùng thành công");
            }
            else MessageBox.Show("Cập nhật thất bại");
        }
    }
}
