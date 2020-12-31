using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAL_BLL.Class
{
    public class NhomNguoiDung_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        
        //Nhóm người dùng
        public IEnumerable<LOAINGUOIDUNG> loadNhom()
        {
            return db.LOAINGUOIDUNGs.Select(t => t);
        }

        public string loadLoai(string ma)
        {
            return db.LOAINGUOIDUNGs.SingleOrDefault(t => t.MaLoai == ma).TenLoaiND.ToString();
        }

        public bool KTNhom(string ma)
        {
            if (db.LOAINGUOIDUNGs.SingleOrDefault(t => t.MaLoai == ma) == null)
            {
                return true;
            }
            else return false;
        }

        public void insertGroupUser(string ma, string ten)
        {
            if (KTNhom(ma) == true)
            {
                LOAINGUOIDUNG loai = new LOAINGUOIDUNG();
                loai.MaLoai = ma;
                loai.TenLoaiND = ten;
                db.LOAINGUOIDUNGs.InsertOnSubmit(loai);
                db.SubmitChanges();
                MessageBox.Show("Thêm mới nhóm người dùng thành công");
            }
            else MessageBox.Show("Đã có người dùng này");
        }

        public void updateGroupUser(string ma, string ten)
        {
            if (KTNhom(ma) == false)
            {
                LOAINGUOIDUNG loai = db.LOAINGUOIDUNGs.Single(t => t.MaLoai == ma);
                loai.TenLoaiND = ten;
                db.SubmitChanges();
                MessageBox.Show("Cập nhật nhóm người dùng thành công");
            }
            else MessageBox.Show("Cập nhật thất bại");
        }

        public void deleteGroupUser(string ma)
        {
            if (KTNhom(ma) == false)
            {
                db.LOAINGUOIDUNGs.DeleteOnSubmit(db.LOAINGUOIDUNGs.SingleOrDefault(t => t.MaLoai == ma));
                db.SubmitChanges();
                MessageBox.Show("Xóa nhóm thành công");
            }
            else MessageBox.Show("Xóa nhóm thất bại");
        }
    }
}
