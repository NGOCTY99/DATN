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
    public partial class frm_Diem : Form
    {

        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        Diem_Data diem = new Diem_Data();
        PQtrongForm pq = new PQtrongForm();
        string idnv;
        int group;
        public frm_Diem()
        {
            InitializeComponent();
        }

        public frm_Diem(string id, int group)
        {
            InitializeComponent();
            this.idnv = id;
            this.group = group;
        }
        public void loadper()
        {
            btnThemDiem.Visible = pq.loadpertheobutton(idnv, group, btnThemDiem.Name);
            btnSuaDiem.Visible = pq.loadpertheobutton(idnv, group, btnSuaDiem.Name);
            dgvDiem.Visible = pq.loaddgv(idnv, group, dgvDiem.Name);
            dgvHS.Visible = pq.loaddgv(idnv, group, dgvHS.Name);
            if (btnSuaDiem.Visible == false && btnThemDiem.Visible == false)
            {
                btnLuu.Visible=false;
                bar2.Visible = false;
            }
            loadcboLoaiDiem();
            loadCBONamHoc();
            loadCBO_HocKy();
            loadCBO_MonHoc();
        }

        // load cbo năm học
        public void loadCBONamHoc()
        {
            if (pq.LoadCombobox(cboNamHoc) == false)
            {
                cboNamHoc.Text = "-Vui lòng chọn-";
            }
            else
            {
                cboNamHoc.DataSource = diem.loadcboNamHoc(idnv, pq.loadMagv(idnv));
                cboNamHoc.ValueMember = "MaNamHoc";
                cboNamHoc.DisplayMember = "TenNamHoc";
            }
        }
        // load cbo khối lớp
        public void loadCBOKhoiLop()
        {
            if (pq.LoadCombobox(cboMaKhoi) == false)
            {
                cboMaKhoi.Text = "-Vui lòng chọn-";
            }
            else
            {
                cboMaKhoi.DataSource = diem.loadcboKhoiLop(idnv, pq.loadMagv(idnv),cboNamHoc.SelectedValue.ToString());
                cboMaKhoi.ValueMember = "MaKhoiLop";
                cboMaKhoi.DisplayMember = "TenKhoiLop";
            }
        }

        // load cbo lớp học theo khối và năm học
        public void loadCBO_LopHoc()
        {
            if (pq.LoadCombobox(cboMaLop) == false)
            {
                cboMaLop.Text = "-Vui lòng chọn-";
            }
            else
            {
                cboMaLop.DataSource = diem.loadcboLopHoc(idnv, pq.loadMagv(idnv),cboMaKhoi.SelectedValue.ToString(),cboNamHoc.SelectedValue.ToString());
                cboMaLop.ValueMember = "MaLop";
                cboMaLop.DisplayMember = "TenLop";
            }
        }

        // load cbo môn học
        public void loadCBO_MonHoc()
        {
            if (pq.LoadCombobox(cboMonHoc) == false)
            {
                cboMonHoc.Text = "-Vui lòng chọn-";
            }
            else
            {
                cboMonHoc.DataSource = diem.LoadMonHoc(idnv, pq.loadMagv(idnv));
                cboMonHoc.ValueMember = "MaMonHoc";
                cboMonHoc.DisplayMember = "TenMonHoc";
            }
        }
        // load cbo học kỳ
        public void loadCBO_HocKy()
        {
            if (pq.LoadCombobox(cboHocKy) == false)
            {
                cboHocKy.Text = "-Vui lòng chọn-";
            }
            else
            {
                cboHocKy.DataSource = diem.LoadHocKy();
                cboHocKy.ValueMember = "MaHocKy";
                cboHocKy.DisplayMember = "TenHocKy";
            }
        }

        //load cboLoai điểm khi thêm mới
        public void loadcboLoaiDiem()
        {
            if (pq.LoadCombobox(cboLoaiDiem) == false)
            {
                cboLoaiDiem.Text = "-Vui lòng chọn-";
            }
            else
            {
                cboLoaiDiem.DataSource = diem.LoaiCBOLoaiDiem();
                cboLoaiDiem.ValueMember = "MaLoai";
                cboLoaiDiem.DisplayMember = "TenLoai";
            }
        }
        private void frm_Diem_Load(object sender, EventArgs e)
        {
            loadper();
            tableLayoutPanel6.Visible = true;
            txtDTBHK.Visible = btnDTB.Visible =  true;
            lblDTKHK.Visibility = (DevExpress.XtraLayout.Utils.LayoutVisibility)BarItemVisibility.Always;
        }

        private void cboMaKhoi_SelectedValueChanged(object sender, EventArgs e)
        {
            loadCBO_LopHoc();
        }

        private void btnLocTheoDK_Click(object sender, EventArgs e)
        {
            dgvHS.DataSource = diem.loadDL(idnv, pq.loadMagv(idnv),cboMaLop.SelectedValue.ToString(), cboMonHoc.SelectedValue.ToString(), cboHocKy.SelectedValue.ToString());
          
        }

        private void btnLocDSHS_Click(object sender, EventArgs e)
        {
            dgvHS.DataSource = diem.loadDLHS(idnv, pq.loadMagv(idnv),cboNamHoc.SelectedValue.ToString(), cboMaKhoi.SelectedValue.ToString(), cboMaLop.SelectedValue.ToString());
        }

        private void txtSoDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnThemDiem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel6.Visible = true;
            txtSoDiem.Text = "";
            cboLoaiDiem.Enabled = true;
            txtSoDiem.Focus();
        }

        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel6.Visible = true;
            cboLoaiDiem.Enabled = false;
            txtSoDiem.Focus();
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSoDiem.Text) )
                {
                    MessageBox.Show("Vui lòng điền thông tin");
                }
                else
                {
                    if (btnThemDiem.Visible ==true && btnSuaDiem.Visible == false)
                    {
                        if (cboMonHoc.Text == "-Vui lòng chọn-")
                        {
                            MessageBox.Show("Không có quyền");
                        }
                        else
                        {
                            diem.loadcotdiem(dgvHS.CurrentRow.Cells[0].Value.ToString(),
                            cboMonHoc.SelectedValue.ToString(),
                            cboHocKy.SelectedValue.ToString(),
                            cboNamHoc.SelectedValue.ToString(),
                            cboMaLop.SelectedValue.ToString(),
                            cboLoaiDiem.SelectedValue.ToString(), float.Parse(txtSoDiem.Text));
                            txtDTBHK.Text = diem.tinhdiemTBM(dgvHS.CurrentRow.Cells[0].Value.ToString(), cboMonHoc.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString(), cboHocKy.SelectedValue.ToString()).ToString();
                            if (txtDTBHK.Text != "????")
                            diem.tinhdiemtheohocky(dgvHS.CurrentRow.Cells[0].Value.ToString(), cboHocKy.SelectedValue.ToString(), cboMonHoc.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString(), cboMaLop.SelectedValue.ToString(), double.Parse(label9.Text));
                        }
                    }
                    if (btnSuaDiem.Visible == true && btnThemDiem.Visible == false)
                    {
                        if (cboMonHoc.Text == "-Vui lòng chọn-")
                        {
                            MessageBox.Show("Không có quyền");
                        }
                        else
                        {
                            diem.suaDiem(int.Parse(dgvDiem.CurrentRow.Cells[0].Value.ToString()),
                                dgvHS.CurrentRow.Cells[0].Value.ToString(),
                                         cboMonHoc.SelectedValue.ToString(),
                                         cboHocKy.SelectedValue.ToString(),
                                         cboNamHoc.SelectedValue.ToString(),
                                         cboMaLop.SelectedValue.ToString(),
                                         diem.loadMaLoai(dgvDiem.CurrentRow.Cells[1].Value.ToString()),
                                         float.Parse(txtSoDiem.Text));
                            label9.Text = diem.tinhdiemTBM(dgvHS.CurrentRow.Cells[0].Value.ToString(), cboMonHoc.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString(), cboHocKy.SelectedValue.ToString()).ToString();
                            if (label9.Text != "????")
                                diem.tinhdiemtheohocky(dgvHS.CurrentRow.Cells[0].Value.ToString(), cboHocKy.SelectedValue.ToString(), cboMonHoc.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString(), cboMaLop.SelectedValue.ToString(), double.Parse(label9.Text));
                        }
                    }
                    else if (btnThemDiem.Visible == true && btnSuaDiem.Visible == true)
                    {
                        if (cboMonHoc.Text == "-Vui lòng chọn-")
                        {
                            MessageBox.Show("Không có quyền");
                        }
                        else
                        {
                            if (cboLoaiDiem.Enabled==false)
                            {
                                diem.suaDiem(int.Parse(dgvDiem.CurrentRow.Cells[0].Value.ToString()),
                                    dgvHS.CurrentRow.Cells[0].Value.ToString(),
                                             cboMonHoc.SelectedValue.ToString(),
                                             cboHocKy.SelectedValue.ToString(),
                                             cboNamHoc.SelectedValue.ToString(),
                                             cboMaLop.SelectedValue.ToString(),
                                             diem.loadMaLoai(dgvDiem.CurrentRow.Cells[1].Value.ToString()),
                                             float.Parse(txtSoDiem.Text));
                                label9.Text = diem.tinhdiemTBM(dgvHS.CurrentRow.Cells[0].Value.ToString(), cboMonHoc.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString(), cboHocKy.SelectedValue.ToString()).ToString();
                                if (label9.Text != "????")
                                    diem.tinhdiemtheohocky(dgvHS.CurrentRow.Cells[0].Value.ToString(), cboHocKy.SelectedValue.ToString(), cboMonHoc.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString(), cboMaLop.SelectedValue.ToString(), double.Parse(label9.Text));
                            }
                            else
                            {
                                diem.loadcotdiem(dgvHS.CurrentRow.Cells[0].Value.ToString(),
                                cboMonHoc.SelectedValue.ToString(),
                                cboHocKy.SelectedValue.ToString(),
                                cboNamHoc.SelectedValue.ToString(),
                                cboMaLop.SelectedValue.ToString(),
                                cboLoaiDiem.SelectedValue.ToString(), float.Parse(txtSoDiem.Text));
                                label9.Text = diem.tinhdiemTBM(dgvHS.CurrentRow.Cells[0].Value.ToString(), cboMonHoc.SelectedValue.ToString(),cboNamHoc.SelectedValue.ToString(),cboHocKy.SelectedValue.ToString()).ToString();
                                if (label9.Text != "????")
                                    diem.tinhdiemtheohocky(dgvHS.CurrentRow.Cells[0].Value.ToString(), cboHocKy.SelectedValue.ToString(), cboMonHoc.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString(), cboMaLop.SelectedValue.ToString(), double.Parse(label9.Text));
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCBOKhoiLop();
        }

        private void dgvHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string x = dgvHS.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Loại điểm");
                    dt.Columns.Add("Học kỳ");
                    dt.Columns.Add("Điểm");
                    foreach (var item in diem.LoadDiem(x,cboMonHoc.SelectedValue.ToString(),cboHocKy.SelectedValue.ToString()))
                    {
                        DataRow dr = dt.NewRow();
                        DataGridViewRow dgvR = (DataGridViewRow)dgvHS.CurrentRow;
                        dr[0] = item.STT;
                        dr[1] = diem.loaiDiem(item.MaLoai);
                        dr[2] = item.MaHocKy;
                        dr[3] = item.Diem1;
                        dt.Rows.Add(dr);
                    }
                    dgvDiem.DataSource = dt;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoDiem.Text=dgvDiem.CurrentRow.Cells[3].Value.ToString();
            cboLoaiDiem.Text = dgvDiem.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDTB_Click(object sender, EventArgs e)
        {
            txtDTBHK.Text = diem.tinhdiemHK(dgvHS.CurrentRow.Cells[0].Value.ToString(), cboMaLop.SelectedValue.ToString(), cboHocKy.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString()).ToString();
            label9.Text = diem.layTenMon(cboMaLop.SelectedValue.ToString());
            loadHK();
        }

        public void loadHK()
        {
            cboHKHK.DataSource = diem.loadHK();
            cboHKHK.DisplayMember = "TenHanhKiem";
            cboHKHK.ValueMember = "MaHanhKiem";
        }

        private void btnXetHLHK_Click(object sender, EventArgs e)
        {

        }
    }
}
