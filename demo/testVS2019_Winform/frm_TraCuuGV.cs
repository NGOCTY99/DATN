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
    public partial class frm_TraCuuGV : Form
    {
        GiaoVien_Data gv = new GiaoVien_Data();
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public frm_TraCuuGV()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvGiaoVien.DataSource = from x in db.GIAOVIENs
                                         from mh in db.MONHOCs
                                         where (x.TenGiaoVien.StartsWith(txtTimKiem.Text) ||
                                         x.DiaChi.StartsWith(txtTimKiem.Text) ||
                                         x.MaGiaoVien.StartsWith(txtTimKiem.Text) ||
                                         mh.TenMonHoc.StartsWith(txtTimKiem.Text) ||
                                         x.DienThoai.StartsWith(txtTimKiem.Text)) &&
                                         x.MaMonHoc == mh.MaMonHoc
                                         select new
                                         {
                                             x.MaGiaoVien,
                                             x.TenGiaoVien,
                                             x.DiaChi,
                                             x.DienThoai,
                                             mh.TenMonHoc
                                         };

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm được nội dung phù hợp");
            }
        }

        private void frm_TraCuuGV_Load(object sender, EventArgs e)
        {
            dgvGiaoVien.DataSource = gv.loadDataGridView();
        }
    }
}
