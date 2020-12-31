using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL.Class
{
    public class HocKy_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public HocKy_Data()
        {

        }
        public dynamic loadDataGridView()
        {
            return from k in db.HOCKies
                   select new
                   {
                       k.MaHocKy,
                       k.TenHocKy,
                       k.HeSo
                   };
        }
    }
}
