using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL.Class
{
   public class NgheNghiep_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public NgheNghiep_Data()
        {

        }
        public dynamic load_datagridview()
        {
            return from n in db.NGHENGHIEPs select n;
        }
        // KT khóa chính
        public bool ktkc(string ma)
        {

            NGHENGHIEP n = db.NGHENGHIEPs.Where(t => t.MaNghe == ma).FirstOrDefault();
            if (n == null)
            {
                return true; // mã ko trùng được thêm vào
            }
            else
            {
                return false;
            }
        }
        // Thêm mới
        public bool themNN(string maNN, string tenNN)
        {
            if (ktkc(maNN) == true)
            {
                NGHENGHIEP n = new NGHENGHIEP();
                n.MaNghe = maNN;
                n.TenNghe = tenNN;
                db.NGHENGHIEPs.InsertOnSubmit(n);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //Sửa
        public bool suaNN(string ma, string ten)
        {
            if (ktkc(ma) == false)
            {
                NGHENGHIEP n = db.NGHENGHIEPs.Where(t => t.MaNghe == ma).FirstOrDefault();
                n.TenNghe = ten;
                db.SubmitChanges();
                return true;
            }
            else
                return false;
        }

    }
}
