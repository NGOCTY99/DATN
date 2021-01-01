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
    public partial class frm_PhanLop : Form
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        PhanLop_Data phanlop = new PhanLop_Data();
        public frm_PhanLop()
        {
            InitializeComponent();
        }

       public void loadCBO_NamHoc()
        {
            cboNamHoc.DataSource = phanlop.loadcboNamHoc();
            cboNamHoc.ValueMember = "MaNamHoc";
            cboNamHoc.DisplayMember = "TenNamHoc";
        }
        public void loadCBO_KhoiLop()
        {
            cboKhoiLop.DataSource = phanlop.loadcboKhoiLop();
            cboKhoiLop.ValueMember = "MaKhoiLop";
            cboKhoiLop.DisplayMember = "TenKhoiLop";
        }
        public void loadCBO_LopHoc()
        {
            cboLopHoc.DataSource = phanlop.loadcboLopHoc(cboKhoiLop.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString());
            cboLopHoc.ValueMember = "MaLop";
            cboLopHoc.DisplayMember = "TenLop";
        }
        //Load dl đầu vào bảng phân lớp: DS HS được phân bổ
        public void loadHS_Lop()
        {
            dgvOut.DataSource = phanlop.loadDLDauVao();
        }
        public void LoadHS_ChuaPL() 
        { 
            dgvIn.DataSource = phanlop.locPhanLop();
         }
            //Load DL lên datagrid theo điều kiện lọc
            public void loadDGVTheoDK()
        {
            dgvOut.DataSource = phanlop.loadDL(cboKhoiLop.SelectedValue.ToString(),
                                               cboLopHoc.SelectedValue.ToString(),
                                               cboNamHoc.SelectedValue.ToString());
        }
        private void frm_PhanLop_Load(object sender, EventArgs e)
        {
            LoadHS_ChuaPL();
            loadCBO_NamHoc();
            loadCBO_KhoiLop();
            loadHS_Lop();
            btnLocDK.Visible = false;
            //loadCBO_LopHoc();
        }

        //Load combobox lớp học theo khối lớp
        private void cboKhoiLop_SelectedValueChanged(object sender, EventArgs e)
        {
            loadCBO_LopHoc();
        }

        // lọc DS học sinh theo điều kiện
        private void btnLocDK_Click(object sender, EventArgs e)
        {
            loadDGVTheoDK();
        }

        //Phân lớp cho HS
        public void phanLop_HSMoi()
        {
            phanlop.themHS_Lop(cboNamHoc.SelectedValue.ToString(), cboLopHoc.SelectedValue.ToString(),
                                cboKhoiLop.SelectedValue.ToString(), dgvIn.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("Phân lớp thành công "  , dgvIn.CurrentRow.Cells[1].Value.ToString());
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            phanLop_HSMoi();
            frm_PhanLop_Load(sender, e);
            loadDGVTheoDK();
            phanlop.capNhatSS(cboLopHoc.SelectedValue.ToString(), cboKhoiLop.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString());
        }

        //Xóa HS ra khỏi lớp học
        public void xoaHS_Lop()
        {
            phanlop.xoaHS_Lop(dgvOut.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("Loại học sinh ra khỏi lớp học thành công ", dgvOut.CurrentRow.Cells[1].Value.ToString());
            phanlop.capNhatSS(cboLopHoc.SelectedValue.ToString(), cboKhoiLop.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString());

        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            xoaHS_Lop();
            frm_PhanLop_Load(sender, e);
            loadDGVTheoDK();
        }

        private void cboLopHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            btnLocDK.Visible = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_PhanLop_Load(sender, e);
        }
    }
}
