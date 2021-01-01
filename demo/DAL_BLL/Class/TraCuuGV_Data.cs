using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL.Class
{
    public class TraCuuGV_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public TraCuuGV_Data()
        {

        }
        public dynamic traCuu(string s)
        {
            var result = from x in db.GIAOVIENs
                         from mh in db.MONHOCs
                         where (x.TenGiaoVien.StartsWith(s) ||
                         x.DiaChi.StartsWith(s) ||
                         x.MaGiaoVien.StartsWith(s) ||
                         mh.TenMonHoc.StartsWith(s) ||
                         x.DienThoai.StartsWith(s) ||
                         x.TenGiaoVien.Contains(s) ||
                         x.DiaChi.Contains(s) ||
                         x.MaGiaoVien.Contains(s) ||
                         mh.TenMonHoc.Contains(s) ||
                         x.DienThoai.Contains(s)) &&
                         x.MaMonHoc == mh.MaMonHoc
                         select new
                         {
                             x.MaGiaoVien,
                             x.TenGiaoVien,
                             x.DiaChi,
                             x.DienThoai,
                             mh.TenMonHoc
                         };
            return result;
        }
    }
}
