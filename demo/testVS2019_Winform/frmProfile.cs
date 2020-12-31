using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL;
using DAL_BLL.Class;
namespace QLDiemTHPT_Winform
{
    public partial class frmProfile : Form
    {
        DangNhap_Data db = new DangNhap_Data();
        string tendn;
        public frmProfile()
        {
            InitializeComponent();
        }
        public void data(string ten)
        {
            this.tendn = ten;
        }
        public void loadProfile()
        {
            foreach (var item in db.loadProfile(tendn))
            {
                txtHoTen.Text = item.TenGiaoVien;
                txtChuyenMon.Text = db.loadMH(item.MaMonHoc);
                txtCMND.Text = item.CMND;
                txtSDT.Text = item.DienThoai;
                if (item.GioiTinh == true)
                    rdoNam.Checked = true;
                else rdoNu.Checked = true;
                dtpNgaySinh.Text = item.NgaySinh.ToString();
                txtDiaChi.Text = item.DiaChi;
            }
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            loadProfile();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
