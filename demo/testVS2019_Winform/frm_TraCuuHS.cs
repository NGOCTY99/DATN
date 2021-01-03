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
        HocSinh_Data hocsinh = new HocSinh_Data();
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
        // load dgvHS theo đk lọc theo năm học, khối lớp, lớp học
        public void loaddgvtheodkloc()
        {
            dgvHS.DataSource = tracuuhs.loadDLLoc(cboKhoiLop.SelectedValue.ToString(),
                                              cboLopHoc.SelectedValue.ToString(),
                                              cboNamHoc.SelectedValue.ToString());
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

        private void btnLocDK_Click(object sender, EventArgs e)
        {
            loaddgvtheodkloc();
        }

        private void dgvHS_SelectionChanged(object sender, EventArgs e)
        {
            grbChiTietHS.Visible = true;
            loadTTCT1HS();
        }
        public void loadTTCT1HS()
        {
            DataTable Dt = new DataTable();
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
            foreach (var item in hocsinh.loadTTHS(dgvHS.CurrentRow.Cells[0].Value.ToString()))
            {
                DataRow dr = Dt.NewRow();
                DataGridViewRow dgvR = (DataGridViewRow)dgvCTHS.CurrentRow;
                dr[0] = item.MaHocSinh;
                dr[1] = item.HoTen;
                dr[2] = hocsinh.LoadGT(item.GioiTinh.Value);
                dr[3] = DateTime.Parse(item.NgaySinh.ToString()).ToShortDateString().ToString();
                dr[4] = item.NoiSinh;
                dr[5] = hocsinh.loadTenDT(item.MaDanToc);
                dr[6] = hocsinh.loadTenTG(item.MaTonGiao);
                dr[7] = item.HoTenCha;
                dr[8] = hocsinh.loadTenNN(item.MaNNghiepCha);
                dr[9] = item.HoTenMe;
                dr[10] = hocsinh.loadTenNN(item.MaNNghiepMe);
                Dt.Rows.Add(dr);
            }
            dgvCTHS.DataSource = Dt;
        }
    }
}
