using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAL_BLL.Class
{
    public class DanToc_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();

        public DanToc_Data()
        {

        }

        public dynamic load_datagridview()
        {
                return from dt in db.DANTOCs select dt;
        }
        // KT khóa chính
        public bool ktkc(string madt)
        {

            DANTOC d = db.DANTOCs.Where(t => t.MaDanToc == madt).FirstOrDefault();
            if (d == null)
            {
                return true; // mã ko trùng được thêm vào
            }
            else
            {
                return false;
            }
        }
        // Thêm
        public void themDT(string madt, string tendt)
        {
            if (ktkc(madt) == true)
            {
                DANTOC dt = new DANTOC();
                dt.MaDanToc = madt;
                dt.TenDanToc = tendt;
                db.DANTOCs.InsertOnSubmit(dt);
                db.SubmitChanges();
                MessageBox.Show("Thêm nhóm thành công ");
            }
            else
            {
                MessageBox.Show("Thêm dân tộc thất bại");
            }
        }
        //Sửa 
        public void suaDT(string madt, string tendt)
        {
            if (ktkc(madt) == false)
            {
                DANTOC suadt = db.DANTOCs.Where(t => t.MaDanToc == madt).FirstOrDefault();
                suadt.TenDanToc = tendt;
                db.SubmitChanges();
                MessageBox.Show("Cập nhật nhóm thành công");
            }
            else
                MessageBox.Show("Cập nhật nhóm thất bại");
        }

    }
}
