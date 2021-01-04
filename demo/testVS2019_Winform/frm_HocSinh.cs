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
    public partial class frm_HocSinh : Form
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        HocSinh_Data hocsinh = new HocSinh_Data();
        PQtrongForm pq = new PQtrongForm();
        string idnv;
        int group;
        public frm_HocSinh()
        {
            InitializeComponent();
        }
        public frm_HocSinh(string id, int group)
        {
            InitializeComponent();
            this.idnv = id;
            this.group = group;
        }

        public void loadper()
        {
            btnThem.Visibility = pq.loadper(idnv, group, btnThem.Name);
            btnSua.Visibility = pq.loadper(idnv, group, btnSua.Name);
            dgvHocSinh.Visible = pq.loaddgv(idnv, group, dgvHocSinh.Name);
            if (btnSua.Visibility == BarItemVisibility.Never && btnThem.Visibility == BarItemVisibility.Never)
            {
                btnLuu.Visibility = BarItemVisibility.Never;
                bar2.Visible = false;
            }
            if (dgvHocSinh.Visible == true)
            {
                loadDSHS();
            }    
        }

        public void loadDSHS()
        {
            dgvHocSinh.DataSource = hocsinh.loadDSHS(idnv, pq.loadMagv(idnv));
        }

        public void LoadDanToc()
        {
            if (pq.LoadCombobox(cboDanToc) == false)
            {
                cboDanToc.Text = "-Vui lòng chọn-";
            }
            else
            {
                cboDanToc.DataSource = hocsinh.load_CboDanToc();
                cboDanToc.ValueMember = "MaDanToc";
                cboDanToc.DisplayMember = "TenDanToc";
            }
        }
        public void LoadTonGiao()
        {
            if (pq.LoadCombobox(cboTonGiao) == false)
            {
                cboTonGiao.Text = "-Vui lòng chọn-";
            }
            else
            {
                cboTonGiao.DataSource = hocsinh.load_CboTonGiao();
                cboTonGiao.ValueMember = "MaTonGiao";
                cboTonGiao.DisplayMember = "TenTonGiao";
            }
        }
        public void LoadNNCha()
        {
            if (pq.LoadCombobox(cboNNCha) == false)
            {
                cboNNCha.Text = "-Vui lòng chọn-";
            }
            else
            {
                cboNNCha.DataSource = hocsinh.load_CboNgheNghiep();
                cboNNCha.ValueMember = "MaNghe";
                cboNNCha.DisplayMember = "TenNghe";
            }
        }
        public void LoadNNMe()
        {
            if (pq.LoadCombobox(cboNNMe) == false)
            {
                cboNNMe.Text = "-Vui lòng chọn-";
            }
            else
            {
                cboNNMe.DataSource = hocsinh.load_CboNgheNghiep();
                cboNNMe.ValueMember = "MaNghe";
                cboNNMe.DisplayMember = "TenNghe";
            }
        }
        private void frm_HocSinh_Load(object sender, EventArgs e)
        {
            loadper();
            txtMaHS.Enabled = txtHoTen.Enabled = txtHoTenCha.Enabled = txtHoTenMe.Enabled
                = cboDanToc.Enabled = cboNNCha.Enabled = cboNNMe.Enabled =
                cboTonGiao.Enabled = rbtNam.Enabled = rbtNu.Enabled = txtNgaySinh.Enabled = txtNoiSinh.Enabled = false;

        }
        
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_HocSinh_Load(sender, e);
        }

        private void dgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            txtMaHS.Text = dgvHocSinh.CurrentRow.Cells[1].Value.ToString();
            txtHoTen.Text = dgvHocSinh.CurrentRow.Cells[2].Value.ToString();
            if (dgvHocSinh.CurrentRow.Cells[3].Value.ToString() == "Nam")
            {
                rbtNam.Checked = true;
            }
            else
                rbtNu.Checked = true;
            txtNgaySinh.Value = DateTime.Parse(dgvHocSinh.CurrentRow.Cells[4].Value.ToString());
            txtNoiSinh.Text = dgvHocSinh.CurrentRow.Cells[5].Value.ToString();
            cboDanToc.Text = dgvHocSinh.CurrentRow.Cells[6].Value.ToString();
            cboTonGiao.Text = dgvHocSinh.CurrentRow.Cells[7].Value.ToString();
            txtHoTenCha.Text = dgvHocSinh.CurrentRow.Cells[8].Value.ToString();
            cboNNCha.Text = dgvHocSinh.CurrentRow.Cells[9].Value.ToString();
            txtHoTenMe.Text = dgvHocSinh.CurrentRow.Cells[10].Value.ToString();
            cboNNMe.Text = dgvHocSinh.CurrentRow.Cells[11].Value.ToString();

        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaHS.Enabled = txtHoTen.Enabled = txtHoTenCha.Enabled = txtHoTenMe.Enabled
                = cboDanToc.Enabled = cboNNCha.Enabled = cboNNMe.Enabled =
                cboTonGiao.Enabled = rbtNam.Enabled = rbtNu.Enabled = txtNgaySinh.Enabled = txtNoiSinh.Enabled = true;
            btnLuu.Enabled = true;
            txtMaHS.Text = "";
            txtHoTen.Text = "";
            txtNoiSinh.Text = "";
            txtNgaySinh.Text = "";
            cboDanToc.Text = "";
            cboTonGiao.Text = "";
            txtHoTenCha.Text = "";
            cboNNCha.Text = "";
            txtHoTenMe.Text = "";
            cboNNMe.Text = "";
            LoadDanToc();
            LoadTonGiao();
            LoadNNCha();
            LoadNNMe();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtHoTen.Enabled = txtHoTenCha.Enabled = txtHoTenMe.Enabled =
            cboDanToc.Enabled = cboNNCha.Enabled = cboNNMe.Enabled =
            cboTonGiao.Enabled = rbtNam.Enabled = rbtNu.Enabled = txtNgaySinh.Enabled = txtNoiSinh.Enabled = true;
            btnLuu.Enabled = true;
        }

        public bool gioiTinh()
        {
            if(rbtNam.Checked == true)
            {
                return true;
            }
            if (rbtNu.Checked == true)
            {
                return true;
            }
            return false;
        }
      
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtMaHS.Text != "" && txtHoTen.Text != "" && txtNoiSinh.Text != "" && txtHoTenCha.Text != "" && txtHoTenMe.Text != "")
                {
                    if (btnThem.Visibility == BarItemVisibility.Always && btnSua.Visibility == BarItemVisibility.Never)
                    {
                        hocsinh.themHS(txtMaHS.Text, txtHoTen.Text, txtNoiSinh.Text, gioiTinh(), DateTime.Parse(txtNgaySinh.Text),
                                cboDanToc.SelectedValue.ToString(), cboTonGiao.SelectedValue.ToString(),
                                txtHoTenCha.Text, cboNNCha.SelectedValue.ToString(), txtHoTenMe.Text, cboNNMe.SelectedValue.ToString());                    }
                    if (btnSua.Visibility == BarItemVisibility.Always && btnThem.Visibility == BarItemVisibility.Never)
                    {
                        hocsinh.suaHS(txtMaHS.Text, txtHoTen.Text, txtNoiSinh.Text, DateTime.Parse(txtNgaySinh.Text),
                            cboDanToc.SelectedValue.ToString(), cboTonGiao.SelectedValue.ToString(),
                            txtHoTenCha.Text, cboNNCha.SelectedValue.ToString(), txtHoTenMe.Text, cboNNMe.SelectedValue.ToString());                   }
                    else if (btnThem.Visibility == BarItemVisibility.Always && btnSua.Visibility == BarItemVisibility.Always)
                    {
                        if (hocsinh.ktkc(txtMaHS.Text) == false)
                        {
                            hocsinh.suaHS(txtMaHS.Text, txtHoTen.Text, txtNoiSinh.Text, DateTime.Parse(txtNgaySinh.Text),
                            cboDanToc.SelectedValue.ToString(), cboTonGiao.SelectedValue.ToString(),
                            txtHoTenCha.Text, cboNNCha.SelectedValue.ToString(), txtHoTenMe.Text, cboNNMe.SelectedValue.ToString());
                        }
                        else
                            hocsinh.themHS(txtMaHS.Text, txtHoTen.Text, txtNoiSinh.Text, gioiTinh(), DateTime.Parse(txtNgaySinh.Text),
                                    cboDanToc.SelectedValue.ToString(), cboTonGiao.SelectedValue.ToString(),
                                    txtHoTenCha.Text, cboNNCha.SelectedValue.ToString(), txtHoTenMe.Text, cboNNMe.SelectedValue.ToString());                  }
                }
                loadDSHS();
                }
            catch
            {
                MessageBox.Show("Thất bại, vui lòng kiểm tra dữ liệu nhập vào");
            }
        }
    }
}
