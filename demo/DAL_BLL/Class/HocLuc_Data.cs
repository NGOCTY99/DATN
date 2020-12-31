using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL_BLL.Class
{
   public class HocLuc_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public HocLuc_Data()
        {

        }

        public dynamic loadDataGridView()
        {
            return from hl in db.HOCLUCs
                   select new
                   {
                       hl.MaHocLuc,
                       hl.TenHocLuc,
                       hl.DiemCanTren,
                       hl.DiemCanDuoi,
                       hl.DiemKhongChe
                   };
        }
    }
}
