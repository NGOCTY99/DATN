using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL.Class
{
    public class MonHoc_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();

        public MonHoc_Data()
        {

        }

        // load danh sách môn học lên datagridView Môn học
        public dynamic loadDataGridView()
        {
            var monhoc = from mh in db.MONHOCs
                         select new
                         {
                             mh.MaMonHoc,
                             mh.TenMonHoc,
                             mh.SoTiet,
                             mh.HeSo
                         };
            return monhoc;
        }
    }
}
