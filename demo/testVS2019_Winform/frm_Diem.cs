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
    public partial class frm_Diem : Form
    {

        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        Diem_Data diem = new Diem_Data();
        public frm_Diem()
        {
            InitializeComponent();
        }
        // load cbo năm học
        public void loadCBONamHoc()
        {
            cboNamHoc.DataSource = diem.loadcboNamHoc();
            cboNamHoc.ValueMember = "MaNamHoc";
            cboNamHoc.DisplayMember = "TenNamHoc";
        }
        // load cbo khối lớp
        public void loadCBOKhoiLop()
        {
            cboMaKhoi.DataSource = diem.loadcboKhoiLop();
            cboMaKhoi.ValueMember = "MaKhoiLop";
            cboMaKhoi.DisplayMember = "TenKhoiLop";
        }

        // load cbo lớp học theo khối và năm học
        public void loadCBO_LopHoc()
        {
            cboMaLop.DataSource = diem.loadcboLopHoc(cboMaKhoi.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString());
            cboMaLop.ValueMember = "MaLop";
            cboMaLop.DisplayMember = "TenLop";
        }

        // load cbo môn học
        public void loadCBO_MonHoc()
        {
            cboMonHoc.DataSource = diem.LoadMonHoc();
            cboMonHoc.ValueMember = "MaMonHoc";
            cboMonHoc.DisplayMember = "TenMonHoc";
        }
        // load cbo học kỳ
        public void loadCBO_HocKy()
        {
            cboHocKy.DataSource = diem.LoadHocKy();
            cboHocKy.ValueMember = "MaHocKy";
            cboHocKy.DisplayMember = "TenHocKy";
        }
       // load dgv diem
       public void loadDiemCuThe()
        {
            dgvDiem.DataSource = diem.LoadDiem(dgvHS.CurrentRow.Cells[0].Value.ToString(), cboMonHoc.SelectedValue.ToString(), cboHocKy.SelectedValue.ToString());
            
        }

        //load cboLoai điểm khi thêm mới
        public void loadcboLoaiDiem()
        {
            cboLoaiDiem.DataSource = diem.LoaiCBOLoaiDiem();
            cboLoaiDiem.ValueMember = "MaLoai";
            cboLoaiDiem.DisplayMember = "TenLoai";
        }
        private void frm_Diem_Load(object sender, EventArgs e)
        {

            loadCBONamHoc();
            loadCBOKhoiLop();
            loadCBO_MonHoc();
            loadCBO_HocKy();
            loadcboLoaiDiem();
            tableLayoutPanel6.Visible = false;
            btnSuaDiem.Visible = false;
            btnLuu.Visible = false;
            btnThemDiem.Visible = false;
        }

        private void cboMaKhoi_SelectedValueChanged(object sender, EventArgs e)
        {
            loadCBO_LopHoc();
        }

        private void btnLocTheoDK_Click(object sender, EventArgs e)
        {
            dgvHS.DataSource = diem.loadDL(cboMaLop.SelectedValue.ToString(), cboMonHoc.SelectedValue.ToString(), cboHocKy.SelectedValue.ToString());
          
        }

        private void dgvHS_SelectionChanged(object sender, EventArgs e)
        {
            loadDiemCuThe();
            txtSoDiem.Text = "";
            btnThemDiem.Visible = true;
        }

        private void btnLocDSHS_Click(object sender, EventArgs e)
        {
            dgvHS.DataSource = diem.loadDLHS(cboNamHoc.SelectedValue.ToString(), cboMaKhoi.SelectedValue.ToString(), cboMaLop.SelectedValue.ToString());
        }

        private void txtSoDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemDiem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel6.Visible = true;
            txtSoDiem.Focus();
            btnLuu.Visible = true;
        }

        private void dgvDiem_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string stt = diem.LaySTT(dgvDiem.CurrentRow.Cells[1].Value.ToString(),int.Parse( dgvDiem.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show(stt);
                cboLoaiDiem.Enabled = true;
                btnSuaDiem.Visible = true;
                cboLoaiDiem.Text = dgvDiem.CurrentRow.Cells[2].Value.ToString();
                txtSoDiem.Text = dgvDiem.CurrentRow.Cells[3].Value.ToString();
                tableLayoutPanel6.Visible = true;
            }
            catch 
            {

            }

        }

        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            cboLoaiDiem.Enabled = false;
            txtSoDiem.Focus();
            btnLuu.Visible = true;
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboLoaiDiem.Enabled == false) // sửa điểm
                {
                    try
                    {
                        diem.suaDiem(int.Parse(dgvDiem.CurrentRow.Cells[0].Value.ToString()),
                            dgvHS.CurrentRow.Cells[0].Value.ToString(),
                                     cboMonHoc.SelectedValue.ToString(),
                                     cboHocKy.SelectedValue.ToString(),
                                     cboNamHoc.SelectedValue.ToString(),
                                     cboMaLop.SelectedValue.ToString(),
                                     dgvDiem.CurrentRow.Cells[1].Value.ToString(),
                                     float.Parse(txtSoDiem.Text));
                        MessageBox.Show("Cập nhật điểm của môn học thành công");
                        dgvHS_SelectionChanged(sender, e);
                        // MessageBox.Show("Đang bug, chưa fix thông cảm");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi");
                    }

                }
                else // thêm điểm
                {
                    diem.themDiem(dgvHS.CurrentRow.Cells[0].Value.ToString(),
                                   cboMonHoc.SelectedValue.ToString(),
                                   cboHocKy.SelectedValue.ToString(),
                                   cboNamHoc.SelectedValue.ToString(),
                                   cboMaLop.SelectedValue.ToString(),
                                   cboLoaiDiem.SelectedValue.ToString(), float.Parse(txtSoDiem.Text));
                    MessageBox.Show("Thêm điểm của môn học thành công");
                    dgvHS_SelectionChanged(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
