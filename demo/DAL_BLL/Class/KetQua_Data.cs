using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL.Class
{
   public class KetQua_Data
    {

        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public KetQua_Data()
        {

        }

        public dynamic loadDataGridView()
        {
            return from kq in db.KETQUAs
                   select new
                   {
                      kq.MaKetQua,
                      kq.TenKetQua
                   };
        }
    }
}
