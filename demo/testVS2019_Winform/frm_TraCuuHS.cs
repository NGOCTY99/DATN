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
    public partial class frm_TraCuuHS : Form
    {
        TraCuuHS_Data tracuuhs = new TraCuuHS_Data();
        public frm_TraCuuHS()
        {
           
            InitializeComponent();
        }
        // load data gridview 
        public void loadDL_DgvHS()
        {
            dgvHS.DataSource = tracuuhs.loadDSHS();
        }

        // load dl tìm kiếm theo mã, tên
        public void timKiem()
        {
            dgvHS.DataSource = tracuuhs.traCuu(txtTimKiemHS.Text);
        }

        //load cbo năm học
        public void loadcboNamHoc()
        {
            cboNamHoc.DataSource = tracuuhs.loadCBO_NamHoc();
            cboNamHoc.ValueMember = "MaNamHoc";
            cboNamHoc.DisplayMember = "TenNamHoc";
        }

        //load cbo Khối lớp
        public void loadcboKhoiLop()
        {
            cboKhoiLop.DataSource = tracuuhs.loadcboKhoiLop();
            cboKhoiLop.ValueMember = "MaKhoiLop";
            cboKhoiLop.DisplayMember = "TenKhoiLop";
        }

        //Load cbo lớp học theo năm học và khối lớp
        public void loadcboLopHoc()
        {
            cboLopHoc.DataSource = tracuuhs.loadcboLopHoc(cboKhoiLop.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString());
            cboLopHoc.ValueMember = "MaLop";
            cboLopHoc.DisplayMember = "TenLop";
        }
        private void frm_TraCuuHS_Load(object sender, EventArgs e)
        {
            loadDL_DgvHS();
            loadcboNamHoc();
            loadcboKhoiLop();
            grbChiTietHS.Visible = false;
        }

        private void txtTimKiemHS_TextChanged(object sender, EventArgs e)
        {
            timKiem();
        }

        private void cboKhoiLop_SelectedValueChanged(object sender, EventArgs e)
        {
            loadcboLopHoc();
        }
    }
}
