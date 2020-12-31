using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL.Class
{
    public class HanhKiem_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public HanhKiem_Data()
        {

        }
        public dynamic loadDataGridView()
        {
            return from hk in db.HANHKIEMs
                   select new
                   {
                       hk.MaHanhKiem,
                       hk.TenHanhKiem
                   };
        }

    }
}
