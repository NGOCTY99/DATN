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

namespace testVS2019_Winform.Controller
{
    public partial class frm_LopHoc : Form
    {

        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        LopHoc_Data lophoc = new LopHoc_Data();
        PQtrongForm pq = new PQtrongForm();
        string idnv;
        int group;
        public frm_LopHoc()
        {
            InitializeComponent();
        }
        public frm_LopHoc(string id,int group)
        {
            InitializeComponent();
            this.idnv = id;
            this.group = group;
        }

        public void loadper()
        {
            btnThem.Visibility = pq.loadper(idnv, group, btnThem.Name);
            btnSua.Visibility = pq.loadper(idnv, group, btnSua.Name);
            dgvLopHoc.Visible = pq.loaddgv(idnv, group, dgvLopHoc.Name);
            if (btnSua.Visibility == BarItemVisibility.Never && btnThem.Visibility == BarItemVisibility.Never)
            {
                btnLuu.Visibility = BarItemVisibility.Never;
                bar2.Visible = false;
            }
            if (dgvLopHoc.Visible == true) loaddgv();
            loadLop();
            loadKhoiLop();
            LoadGVCN();
        }

        public void loaddgv()
        {
            dgvLopHoc.DataSource = lophoc.loadDataGridView(idnv, pq.loadMagv(idnv));
        }

        public void loadKhoiLop()
        {
            if (pq.LoadCombobox(cboKhoiLop) == false)
            {
                cboKhoiLop.Text = "-Vui lòng chọn-";
            }
            else
            {
                cboKhoiLop.DataSource = lophoc.loadKhoiLop(idnv, pq.loadMagv(idnv));
                cboKhoiLop.ValueMember = "MaKhoiLop";
                cboKhoiLop.DisplayMember = "TenKhoiLop";
            }
        }

        public void loadLop()
        {
            if (pq.LoadCombobox(cboMaNamHoc) == false)
            {
                cboMaNamHoc.Text = "-Vui lòng chọn-";
            }
            else
            {
                cboMaNamHoc.DataSource = lophoc.loadNamHoc(idnv, pq.loadMagv(idnv));
                cboMaNamHoc.ValueMember = "MaNamHoc";
                cboMaNamHoc.DisplayMember = "TenNamHoc";
            }
        }

        public void LoadGVCN()
        {
            if (pq.LoadCombobox(cboGVCN) == false)
            {
                cboGVCN.Text = "-Vui lòng chọn-";
            }
            else
            {    
                cboGVCN.DataSource = lophoc.loadGiaoVien(idnv, pq.loadMagv(idnv));
                cboGVCN.ValueMember = "MaGiaoVien";
                cboGVCN.DisplayMember = "TenGiaoVien";
            } 
        }
      
        private void frm_LopHoc_Load(object sender, EventArgs e)
        {
            loadper();

        }
        public void loadLoptheoMaKhoi()
        {
            dgvLopHoc.DataSource = lophoc.load_dgv_Theo_MaKhoiLop(idnv, pq.loadMagv(idnv),cboKhoiLop.SelectedValue.ToString());
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;
            cboMaNamHoc.Enabled = true;
            cboKhoiLop.Enabled = true;
            cboGVCN.Enabled = true;
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cboGVCN.Text = "";
            cboKhoiLop.Text = "";
            cboMaNamHoc.Text = "";
            txtMaLop.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cboGVCN.Enabled = true;
            txtTenLop.Enabled = true;
        }


        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtMaLop.Text != "" && txtTenLop.Text != "")
                {
                    if (btnThem.Visibility == BarItemVisibility.Always && btnSua.Visibility == BarItemVisibility.Never)
                    {
                        if (cboGVCN.Text == "-Vui lòng chọn-"|| cboKhoiLop.Text =="-Vui lòng chọn-" || cboMaNamHoc.Text=="-Vui lòng chọn-")
                        {
                            MessageBox.Show("Bạn không có quyền, thêm thất bại");
                        } 
                        else
                        lophoc.themLop(txtMaLop.Text, txtTenLop.Text,cboKhoiLop.SelectedValue.ToString(),cboMaNamHoc.SelectedValue.ToString(),0,cboGVCN.SelectedValue.ToString());
                    }
                    if (btnSua.Visibility == BarItemVisibility.Always && btnThem.Visibility == BarItemVisibility.Never)
                    {
                        if (cboGVCN.Text == "-Vui lòng chọn-" || cboKhoiLop.Text == "-Vui lòng chọn-" || cboMaNamHoc.Text == "-Vui lòng chọn-")
                        {
                            MessageBox.Show("Bạn không có quyền, cập nhật thất bại");
                        }
                        else
                        {
                            lophoc.suaLop(txtMaLop.Text, cboMaNamHoc.SelectedValue.ToString(), txtTenLop.Text, cboGVCN.SelectedValue.ToString());
                        }
                    }
                    else if (btnThem.Visibility == BarItemVisibility.Always && btnSua.Visibility == BarItemVisibility.Always)
                    {
                        if (cboGVCN.Text == "-Vui lòng chọn-" || cboKhoiLop.Text == "-Vui lòng chọn-" || cboMaNamHoc.Text == "-Vui lòng chọn-")
                        {
                            MessageBox.Show("Bạn không có quyền");
                        }
                        else
                        {
                            if (lophoc.ktkc(txtMaLop.Text, cboMaNamHoc.SelectedValue.ToString()) == false)
                            {
                                lophoc.suaLop(txtMaLop.Text, cboMaNamHoc.SelectedValue.ToString(), txtTenLop.Text, cboGVCN.SelectedValue.ToString());
                            }
                            else
                                lophoc.themLop(txtMaLop.Text, txtTenLop.Text, cboKhoiLop.SelectedValue.ToString(), cboMaNamHoc.SelectedValue.ToString(), 0, cboGVCN.SelectedValue.ToString());
                        }
                    }
                    loaddgv();
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void txtSiSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_LopHoc_Load(sender, e);
        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLop.Text = dgvLopHoc.CurrentRow.Cells[0].Value.ToString();
            txtTenLop.Text = dgvLopHoc.CurrentRow.Cells[1].Value.ToString();
            cboKhoiLop.Text = dgvLopHoc.CurrentRow.Cells[2].Value.ToString();
            cboMaNamHoc.Text = dgvLopHoc.CurrentRow.Cells[3].Value.ToString();
            txtSiSo.Text = dgvLopHoc.CurrentRow.Cells[4].Value.ToString();
            cboGVCN.Text = dgvLopHoc.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
