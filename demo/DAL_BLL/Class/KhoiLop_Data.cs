using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL.Class
{
    
    public class KhoiLop_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public KhoiLop_Data()
        {

        }
        public dynamic loadDataGridView()
        {
            return  from k in db.KHOILOPs 
                    select  new
                    {
                        k.MaKhoiLop,
                        k.TenKhoiLop
                    };
        }
    }
}
