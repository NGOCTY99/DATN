using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL.Class
{
    public class NguoiDung_New
    {
        string mand, tenloai, tengv, tendangnhap, matkhau;
        bool check;

        public string Mand { get => mand; set => mand = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public string Tengv { get => tengv; set => tengv = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public bool Check { get => check; set => check = value; }
    }
}
