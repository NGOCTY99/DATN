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
            if (dgvLopHoc.Visible == true)
                dgvLopHoc.DataSource = lophoc.loadDataGridView(idnv, pq.loadMagv(idnv));
        }

        public void loadKhoiLop()
        {
            cboKhoiLop.DataSource = lophoc.loadKhoiLop(idnv, pq.loadMagv(idnv));
            cboKhoiLop.ValueMember = "MaKhoiLop";
            cboKhoiLop.DisplayMember = "TenKhoiLop";
        }

        public void loadLop()
        {
            cboMaNamHoc.DataSource = lophoc.loadNamHoc(idnv, pq.loadMagv(idnv));
            cboMaNamHoc.ValueMember = "MaNamHoc";
            cboMaNamHoc.DisplayMember = "TenNamHoc";
        }

        public void LoadGVCN()
        {
            if (idnv == "LND004")
            {
                cboGVCN.DataSource = lophoc.loadGiaoVien(idnv, pq.loadMagv(idnv));
                cboGVCN.ValueMember = "MaGiaoVien";
                cboGVCN.DisplayMember = "TenGiaoVien";
            } 
        }
        private void frm_LopHoc_Load(object sender, EventArgs e)
        {
            loadper();
            loadLop();
            loadKhoiLop();
            LoadGVCN();
        }
        public void loadLoptheoMaKhoi()
        {
            dgvLopHoc.DataSource = lophoc.load_dgv_Theo_MaKhoiLop(idnv, pq.loadMagv(idnv),cboKhoiLop.SelectedValue.ToString());
        }

        private void dgvLopHoc_SelectionChanged(object sender, EventArgs e)
        {
            txtMaLop.Text = dgvLopHoc.CurrentRow.Cells[0].Value.ToString();
            txtTenLop.Text = dgvLopHoc.CurrentRow.Cells[1].Value.ToString();
            cboKhoiLop.Text = dgvLopHoc.CurrentRow.Cells[2].Value.ToString();
            cboMaNamHoc.Text = dgvLopHoc.CurrentRow.Cells[3].Value.ToString();
            txtSiSo.Text = dgvLopHoc.CurrentRow.Cells[4].Value.ToString();
            cboGVCN.Text = dgvLopHoc.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;
            cboMaNamHoc.Enabled = true;
            cboKhoiLop.Enabled = true;
            txtMaLop.Text = "";
            txtSiSo.Text = "";
            txtTenLop.Text = "";
            cboGVCN.Text = "";
            cboKhoiLop.Text = "";
            cboMaNamHoc.Text = "";
            txtMaLop.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //cho phép sửa sỉ số lớp và GVCN
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;
            cboMaNamHoc.Enabled = false;
            cboKhoiLop.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //try
            //{
            //    if (lophoc.xoaLop(txtMaLop.Text) == true)
            //    {
            //        MessageBox.Show("Xóa thành công");
            //        frm_LopHoc_Load(sender, e);
            //    }
            //    else
            //        MessageBox.Show("Xóa thất bại");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Xóa thất bại, lỗi ràng buộc khóa chính");
            //}
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try { 
            //int ss = int.Parse(txtSiSo.Text);
            //    if (ss > 30 && ss < 45)
            //    {
            //        if (txtMaLop.Enabled == false) // Trạng thái sửa
            //    {
            //        if (lophoc.suaLop(txtMaLop.Text, ss, cboGVCN.SelectedValue.ToString()) == true)
            //        {
            //            MessageBox.Show("Sửa lớp học thành công");
            //            frm_LopHoc_Load(sender, e);
            //            txtMaLop.Enabled = true;
            //            txtTenLop.Enabled = true;
            //            cboMaNamHoc.Enabled = true;
            //            cboKhoiLop.Enabled = true;
            //        }
            //        else
            //            MessageBox.Show("Thất bại");
            //    }    
            //    else // trạng thái thêm mới
            //     {
                   
            //        if (lophoc.themLop(txtMaLop.Text, txtTenLop.Text, cboKhoiLop.SelectedValue.ToString(), cboMaNamHoc.SelectedValue.ToString(), ss, cboGVCN.SelectedValue.ToString()) == true)
            //        {
            //            MessageBox.Show("Thêm lớp học mới thành công");
            //            frm_LopHoc_Load(sender, e);
            //        }
            //        else
            //            MessageBox.Show("Lớp học này đã có");
            //      }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sỉ số lớp học tối thiểu 30, tối đa 45 học sinh");
            //    }
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

        
    }
}
