using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL.Class
{
    public class TonGiao_Data
    {

        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();

        public TonGiao_Data()
        {

        }

        public dynamic load_datagridview()
        {
            return from tg in db.TONGIAOs select tg;
        }
        // KT khóa chính
        public bool ktkc(string ma)
        {

           TONGIAO tg = db.TONGIAOs.Where(t =>t.MaTonGiao == ma).FirstOrDefault();
            if (tg == null)
            {
                return true; // mã ko trùng được thêm vào
            }
            else
            {
                return false;
            }
        }
        // Thêm 
        public bool themTG(string ma, string ten)
        {
            if (ktkc(ma) == true)
            {
                TONGIAO tg = new TONGIAO();
                tg.MaTonGiao = ma;
                tg.TenTonGiao = ten;
                db.TONGIAOs.InsertOnSubmit(tg);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //Sửa 
        public bool suaTG(string ma, string ten)
        {
            if (ktkc(ma) == false)
            {
                TONGIAO tg = db.TONGIAOs.Where(t => t.MaTonGiao == ma).FirstOrDefault();
                tg.TenTonGiao = ten;
                db.SubmitChanges();
                return true;
            }
            else
                return false;
        }

    }
}
