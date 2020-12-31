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
    public partial class frm_PhanCong : Form
    {

        PhanCong_Data phancong = new PhanCong_Data();

        public frm_PhanCong()
        {
            InitializeComponent();
        }
        // load cbo năm học
        public void loadcboNamHoc()
        {
            phancong.loadcboNamHoc(cboNamHoc);
            cboNamHoc.ValueMember = "MaNamHoc";
            cboNamHoc.DisplayMember = "TenNamHoc";
        }
        // load cbo khoi lớp
        public void loadKhoiLop()
        {
            phancong.loadcboKhoiLop(cboKhoiLop);
        }
        // load cbo lớp học theo khối lớp
        public void LoadLopHoctheoKL()
        {
            cboLopHoc.DataSource = phancong.loadcboLopHoc(cboKhoiLop.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString());
            cboLopHoc.ValueMember = "MaLop";
            cboLopHoc.DisplayMember = "TenLop";

        }

        private void cboKhoiLop_SelectedValueChanged(object sender, EventArgs e)
        {
            // LoadLopHoctheoKL();
        }
        // load cbo môn học
        public void loadMonHoc()
        {
            phancong.loadcboMonHoc(cboMonHoc);
        }
        //load datagridview trái (DS GV chưa được phân công)
        public void loadGV()
        {
            dgvIn.DataSource = phancong.loadGVMoi();
        }

        private void frm_PhanCong_Load(object sender, EventArgs e)
        {

            loadGV();
            loadKhoiLop();
            loadcboNamHoc();
            loadMonHoc();
            cboLopHoc.Text = "";
        }

        // Load datagridview phải (DS giáo viên được phân công theo điều kiện lọc: năm học, lớp học, môn học)
        public void load_DKLoc()
        {
            dgvOut.DataSource = phancong.locDLTheoDK(cboNamHoc.SelectedValue.ToString(), cboLopHoc.SelectedValue.ToString(), cboMonHoc.SelectedValue.ToString());

        }

        private void btnLocDK_Click_1(object sender, EventArgs e)
        {
            load_DKLoc();
        }
        public void phanGV_DayLopMoi()
        {

            phancong.themGV_Day(cboNamHoc.SelectedValue.ToString(), cboLopHoc.SelectedValue.ToString(),
                                dgvIn.CurrentRow.Cells[3].Value.ToString(), dgvIn.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("Phân công giáo viên giảng dạy thành công ", dgvIn.CurrentRow.Cells[1].Value.ToString());
            loadGV();
            load_DKLoc();

        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            phanGV_DayLopMoi();

        }
        public void xoaGV_Day()
        {

            phancong.xoaGV_Day(dgvOut.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("Loại giáo viên giảng dạy thành công ", dgvOut.CurrentRow.Cells[1].Value.ToString());

            loadGV();
            load_DKLoc();

        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            xoaGV_Day();
        }


        private void cboNamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            cboLopHoc.Text = "";
            LoadLopHoctheoKL();
        }

        private void cboKhoiLop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboLopHoc.Text = "";
            LoadLopHoctheoKL();
        }

        private void dgvIn_SelectionChanged(object sender, EventArgs e)
        {
            cboMonHoc.Text = dgvIn.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
