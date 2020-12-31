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
    public partial class frm_HocSinh : Form
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        HocSinh_Data hocsinh = new HocSinh_Data();
        public frm_HocSinh()
        {
            InitializeComponent();
        }
       

        public void loadDSHS()
        {
            DataTable Dt = new DataTable();
            Dt.Columns.Add("STT");
            Dt.Columns.Add("Mã học sinh");
            Dt.Columns.Add("Họ tên");
            Dt.Columns.Add("Giới tính");
            Dt.Columns.Add("Ngày sinh");
            Dt.Columns.Add("Nơi sinh");
            Dt.Columns.Add("Dân tộc");
            Dt.Columns.Add("Tôn giáo");
            Dt.Columns.Add("Họ tên cha");
            Dt.Columns.Add("Nghề nghiệp cha");
            Dt.Columns.Add("Họ tên mẹ");
            Dt.Columns.Add("Nghề nghiệp mẹ");
            int t = 1;
            foreach (var item in hocsinh.loadDSHS())
            {
                DataRow dr = Dt.NewRow();
                DataGridViewRow dgvR = (DataGridViewRow)dgvHocSinh.CurrentRow;
                dr[0] = t;
                dr[1] = item.MaHocSinh;
                dr[2] = item.HoTen;
                dr[3] = hocsinh.LoadGT(item.GioiTinh.Value);
                dr[4] = DateTime.Parse(item.NgaySinh.ToString()).ToShortDateString().ToString();
                dr[5] = item.NoiSinh;
                dr[6] = hocsinh.loadTenDT(item.MaDanToc);
                dr[7] = hocsinh.loadTenTG(item.MaTonGiao);
                dr[8] = item.HoTenCha;
                dr[9] = hocsinh.loadTenNN(item.MaNNghiepCha);
                dr[10] = item.HoTenMe;
                dr[11] = hocsinh.loadTenNN(item.MaNNghiepMe);
                Dt.Rows.Add(dr);
                t++;
            }

            dgvHocSinh.DataSource = Dt;
        }

        public void LoadDanToc()
        {
            cboDanToc.DataSource = hocsinh.load_CboDanToc();
            cboDanToc.ValueMember = "MaDanToc";
            cboDanToc.DisplayMember = "TenDanToc";
        }
        public void LoadTonGiao()
        {
            cboTonGiao.DataSource = hocsinh.load_CboTonGiao();
            cboTonGiao.ValueMember = "MaTonGiao";
            cboTonGiao.DisplayMember = "TenTonGiao";
        }
        public void LoadNNCha()
        {
            cboNNCha.DataSource = hocsinh.load_CboNgheNghiep();
            cboNNCha.ValueMember = "MaNghe";
            cboNNCha.DisplayMember = "TenNghe";
        }
        public void LoadNNMe()
        {
            cboNNMe.DataSource = hocsinh.load_CboNgheNghiep();
            cboNNMe.ValueMember = "MaNghe";
            cboNNMe.DisplayMember = "TenNghe";
        }
        private void frm_HocSinh_Load(object sender, EventArgs e)
        {
            loadDSHS();
            LoadDanToc();
            LoadTonGiao();
            LoadNNCha();
            LoadNNMe();
        }
        
      

     
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_HocSinh_Load(sender, e);
        }

        private void dgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            txtMaHS.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
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
            btnSua.Enabled = false;
            txtMaHS.Enabled = true;
            txtHoTen.Enabled = true;
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
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaHS.Enabled = false;
            btnLuu.Enabled = true;
            rbtNu.Enabled = true;
            rbtNam.Enabled = true;
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
                if (txtMaHS.Enabled == false) // sửa
                {
                    if (hocsinh.suaHS(txtMaHS.Text, txtHoTen.Text, txtNoiSinh.Text, DateTime.Parse(txtNgaySinh.Text),
                        cboDanToc.SelectedValue.ToString(), cboTonGiao.SelectedValue.ToString(),
                        txtHoTenCha.Text, cboNNCha.SelectedValue.ToString(), txtHoTenMe.Text, cboNNMe.SelectedValue.ToString()) == true)
                    {
                        MessageBox.Show("Sửa học sinh thành công");
                        frm_HocSinh_Load(sender, e);
                        txtMaHS.Enabled = true;
                    }
                    else
                        MessageBox.Show("Thất bại");
                }
                else // thêm mới 
                {
                    if (txtMaHS.Text != "" || txtHoTen.Text != "" || txtNoiSinh.Text != "" || cboDanToc.Text != "" ||
                        cboTonGiao.Text != "" || txtHoTenCha.Text != "" || cboNNCha.Text != "" || txtHoTenMe.Text != "" ||
                        cboNNMe.Text != "")
                    {
                        if (hocsinh.themHS(txtMaHS.Text, txtHoTen.Text, txtNoiSinh.Text, gioiTinh(), DateTime.Parse(txtNgaySinh.Text),
                            cboDanToc.SelectedValue.ToString(), cboTonGiao.SelectedValue.ToString(),
                            txtHoTenCha.Text, cboNNCha.SelectedValue.ToString(), txtHoTenMe.Text, cboNNMe.SelectedValue.ToString()) == true)
                        {
                            MessageBox.Show("Thêm học sinh mới thành công");
                            frm_HocSinh_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Mã học sinh đã tồn tại");
                        }
                    }
                    else
                        MessageBox.Show("Vui lòng điền thông tin đầy đủ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại, vui lòng kiểm tra dữ liệu nhập vào");
            }
        }
    }
}
