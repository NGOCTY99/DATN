using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAL_BLL.Class
{
   public class NamHoc_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public NamHoc_Data()
        {

        }
        public dynamic loadDataGridView()
        {
            return from k in db.NAMHOCs
                   select new
                   {
                       k.MaNamHoc,
                       k.TenNamHoc
                   };
        }
        // KT khóa chính
        public bool ktkc(string manh)
        {

            NAMHOC l = db.NAMHOCs.Where(t => t.MaNamHoc == manh).FirstOrDefault();
            if (l == null)
            {
                return true; // mã ko trùng được thêm vào
            }
            else
            {
                return false;
            }
        }
        // Thêm năm học mới
        public void themNamHoc(string manamhoc, string tennamhoc)
        {
            if (ktkc(manamhoc) == true)
            {
                NAMHOC nh = new NAMHOC();
                nh.MaNamHoc = manamhoc;
                nh.TenNamHoc = tennamhoc;
                db.NAMHOCs.InsertOnSubmit(nh);
                db.SubmitChanges();
                MessageBox.Show("Thêm năm học thành công");
            }
            else
            {
                MessageBox.Show("Thêm năm học thất bại");
            }
        }
        //Sửa năm học
        public void suaNH(string manh, string tennh)
        {
            if (ktkc(manh) == false)
            {
                NAMHOC suanh = db.NAMHOCs.Single(t => t.MaNamHoc == manh);
                suanh.TenNamHoc = tennh;
                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công");
            }
            else
                MessageBox.Show("Cập nhật thất bại");
        }
    }
}
