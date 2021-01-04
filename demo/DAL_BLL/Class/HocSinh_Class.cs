using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL.Class
{
    public class HocSinh_Class
    {
        int id;
        string mahs, ht, noisinh, ngaysinh, dantoc, tongiao, hotencha, nnc, hotenme, nnm, gt;
        public int ID { get => id; set => id = value; }
        public string MaHocSinh { get => mahs; set => mahs = value; }
        public string HoTen { get => ht; set => ht = value; }
        public string GioiTinh { get => gt; set => gt = value; }
        public string NgaySinh { get => ngaysinh; set => ngaysinh = value; }
        public string NoiSinh { get => noisinh; set => noisinh = value; }
        public string DanToc { get => dantoc; set => dantoc = value; }
        public string TonGiao { get => tongiao; set => tongiao = value; }
        public string HoTenCha { get => hotencha; set => hotencha = value; }
        public string NgheNghiepCha { get => nnc; set => nnc = value; }
        public string HoTenMe { get => hotenme; set => hotenme = value; }
        public string NgheNghiepMe { get => nnm; set => nnm = value; }
    }
}
