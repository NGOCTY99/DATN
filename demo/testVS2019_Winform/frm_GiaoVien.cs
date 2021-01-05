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
using DevExpress.XtraBars;

namespace QLDiemTHPT_Winform
{
    public partial class frm_GiaoVien : Form
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        GiaoVien_Data gv = new GiaoVien_Data();
        PQtrongForm pq = new PQtrongForm();
        string idnv;
        int group;
        public frm_GiaoVien()
        {
            InitializeComponent();
        }

        public frm_GiaoVien(string id, int group)
        {
            InitializeComponent();
            this.idnv = id;
            this.group = group;
        }

        public void loadper()
        {
            btnThem.Visibility = pq.loadper(idnv, group, btnThem.Name);
            btnSua.Visibility = pq.loadper(idnv, group, btnSua.Name);
            dgvGiaoVien.Visible = pq.loaddgv(idnv, group, dgvGiaoVien.Name);
            if (btnSua.Visibility == BarItemVisibility.Never && btnThem.Visibility == BarItemVisibility.Never)
            {
                btnLuu.Visibility = BarItemVisibility.Never;
                bar2.Visible = false;
            }
            if (dgvGiaoVien.Visible == true)
            {
                LoadDL();
            }
            loadcboMonHoc();
        }

        public void LoadDL()
        {
            dgvGiaoVien.DataSource = gv.loadDataGridView(idnv,pq.loadMagv(idnv));
        }

        public void loadcboMonHoc()
        {
            if (pq.LoadCombobox(cboMonHoc) == false)
            {
                cboMonHoc.Text = "-Vui lòng chọn-";
            }
            else
            {
                cboMonHoc.DataSource = gv.loadMonHoc(idnv,pq.loadMagv(idnv));
                cboMonHoc.ValueMember = "MaMonHoc";
                cboMonHoc.DisplayMember = "TenMonHoc";
            }
        }

        private void frm_GiaoVien_Load(object sender, EventArgs e)
        {
            loadper();
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
            //txtMaGV.Text = dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
            //txtTenGV.Text = dgvGiaoVien.CurrentRow.Cells[1].Value.ToString();
            //txtDiaChi.Text = dgvGiaoVien.CurrentRow.Cells[2].Value.ToString();
            //txtSDT.Text = dgvGiaoVien.CurrentRow.Cells[3].Value.ToString();
            //cboMonHoc.Text = dgvGiaoVien.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
                if (string.IsNullOrEmpty(txtMaGV.Text) || string.IsNullOrEmpty(txtTenGV.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng điền thông tin");
                }
                else
                {
                    if (btnThem.Visibility == BarItemVisibility.Always && btnSua.Visibility == BarItemVisibility.Never)
                    {
                        if (cboMonHoc.Text == "-Vui lòng chọn-" )
                        {
                            MessageBox.Show("Không có quyền");
                        }
                        else
                        {
                            gv.themGV(txtMaGV.Text, txtTenGV.Text, txtDiaChi.Text, txtSDT.Text, cboMonHoc.SelectedValue.ToString());
                        }
                    }
                    if (btnSua.Visibility == BarItemVisibility.Always && btnThem.Visibility == BarItemVisibility.Never)
                    {
                        if (cboMonHoc.Text == "-Vui lòng chọn-")
                        {
                            MessageBox.Show("Không có quyền");
                        }
                        else
                        {
                            gv.suaGV(txtMaGV.Text, txtTenGV.Text, txtDiaChi.Text, txtSDT.Text, cboMonHoc.SelectedValue.ToString());                        }
                    }
                    else if (btnThem.Visibility == BarItemVisibility.Always && btnSua.Visibility == BarItemVisibility.Always)
                    {
                        if (cboMonHoc.Text == "-Vui lòng chọn-")
                        {
                            MessageBox.Show("Không có quyền");
                        }
                        else
                        {
                            if (gv.ktkc(txtMaGV.Text) == false)
                            {
                                gv.themGV(txtMaGV.Text, txtTenGV.Text, txtDiaChi.Text, txtSDT.Text, cboMonHoc.SelectedValue.ToString());
                            }
                            else
                                gv.suaGV(txtMaGV.Text, txtTenGV.Text, txtDiaChi.Text, txtSDT.Text, cboMonHoc.SelectedValue.ToString());
                        }
                    }
                }
            }
            catch
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
            catch
            {
                MessageBox.Show("Không tìm được nội dung phù hợp");
            }
        }
    }
}
