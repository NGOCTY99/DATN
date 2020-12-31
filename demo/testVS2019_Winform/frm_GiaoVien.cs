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
    public partial class frm_GiaoVien : Form
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        GiaoVien_Data gv = new GiaoVien_Data();
        public frm_GiaoVien()
        {
            InitializeComponent();
        }

        public void LoadDL()
        {
            dgvGiaoVien.DataSource = gv.loadDataGridView();
        }
        public void loadcboMonHoc()
        {
            cboMonHoc.DataSource = gv.loadMonHoc();
            cboMonHoc.ValueMember = "MaMonHoc";
            cboMonHoc.DisplayMember = "TenMonHoc";
        }
        private void frm_GiaoVien_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            LoadDL();
            loadcboMonHoc();

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void dgvGiaoVien_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            txtMaGV.Text = dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
            txtTenGV.Text = dgvGiaoVien.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvGiaoVien.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgvGiaoVien.CurrentRow.Cells[3].Value.ToString();
            cboMonHoc.Text = dgvGiaoVien.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSua.Enabled = false;
            txtMaGV.Enabled = true;
            txtTenGV.Enabled = true;
            btnLuu.Enabled = true;
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            cboMonHoc.Text = "";
            txtMaGV.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaGV.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_GiaoVien_Load(sender, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtMaGV.Enabled == false) // Trạng thái sửa
                {
                    if (gv.suaGV(txtMaGV.Text, txtTenGV.Text, txtDiaChi.Text, txtSDT.Text, cboMonHoc.SelectedValue.ToString()) == true)
                    {
                        MessageBox.Show("Sửa giáo viên thành công");
                        frm_GiaoVien_Load(sender, e);
                        txtMaGV.Enabled = true;

                    }
                    else
                        MessageBox.Show("Thất bại");
                }
                else // trạng thái thêm mới
                {
                    if (txtMaGV.Text != "" && txtTenGV.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && cboMonHoc.Text != "")
                    {
                        if (gv.themGV(txtMaGV.Text, txtTenGV.Text, txtDiaChi.Text, txtSDT.Text, cboMonHoc.SelectedValue.ToString()) == true)
                        {
                            MessageBox.Show("Thêm giáo viên mới thành công");
                            frm_GiaoVien_Load(sender, e);
                        }
                        else
                            MessageBox.Show("Mã giáo viên này đã có");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại");
            }
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
    }
}
