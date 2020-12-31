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
    public partial class frmNguoiDung : Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }
        GiaoVien_Data gv = new GiaoVien_Data();
        DangNhap_Data dn = new DangNhap_Data();
        NguoiDung_Data db = new NguoiDung_Data();
        NhomNguoiDung_Data nnd = new NhomNguoiDung_Data();
        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            loadNDung();
            loadGV();
            loadLoaiND();
        }
        public void loadNDung()
        {
            dgvND.DataSource = db.loadNDnew();

            //DataTable dt = new DataTable();
            //dt.Columns.Add("Mã người dùng");
            //dt.Columns.Add("Mã loại");
            //dt.Columns.Add("Họ tên giáo viên");
            //dt.Columns.Add("Tên đăng nhập");
            //dt.Columns.Add("Mật khẩu");
            //foreach (var item in db.loadND())
            //{
            //    DataRow dr = dt.NewRow();
            //    DataGridViewRow dgvR = (DataGridViewRow)dgvND.CurrentRow;
            //    dr[0] = item.MaND;
            //    dr[1] = nnd.loadLoai(item.MaLoai);
            //    dr[2] = dn.loadten(item.TenND);
            //    dr[3] = item.TenDNhap;
            //    dr[4] = item.MatKhau;
            //    dt.Rows.Add(dr);
            //}
            //dgvND.DataSource = db.loadND();
            //dgvND.DataSource = dt;
            //dgvND.Columns[6].Visible = false;
            //dgvND.Columns[7].Visible = false;
        }

        public void loadLoaiND()
        {
            cboLoaiND.DataSource = nnd.loadNhom();
            cboLoaiND.DisplayMember = "TENLOAIND";
            cboLoaiND.ValueMember = "MALOAI";
        }

        public void loadGV()
        {
            cboGV.DataSource = gv.loadDataGridView();
            cboGV.DisplayMember = "TenGiaoVien";
            cboGV.ValueMember = "MaGiaoVien";
        }

        private void dgvND_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cboGV.Text= cboLoaiND.Text = "";
                DataGridViewRow row = this.dgvND.Rows[e.RowIndex];
                txtMaND.Text = row.Cells[0].Value.ToString();
                cboLoaiND.SelectedText = row.Cells[1].Value.ToString();
                cboGV.SelectedText = row.Cells[2].Value.ToString();
                txtTenDN.Text = row.Cells[3].Value.ToString();
                txtMK.Text = row.Cells[4].Value.ToString();
                if (row.Cells[5].Value.Equals(true))
                {
                    chkStatus.Checked = true;
                }
                else chkStatus.Checked = false;
            }
            catch
            {
                Console.WriteLine("Lỗi rồi");
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaND.Text = txtMK.Text = txtTenDN.Text = "";
            txtMaND.Focus();
            chkStatus.Checked = false;
            cboGV.SelectedIndex = 0;
            cboLoaiND.SelectedIndex = 0;
        }


        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public bool CheckAction(CheckBox checkBox)
        {
            if (checkBox.Checked == true)
                return true;
            else return false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtTenDN.Text != "" && txtMK.Text != "")
                {
                    if (btnAdd.Visibility == BarItemVisibility.Always && btnUpdate.Visibility == BarItemVisibility.Never)
                    {
                        db.insertUser(txtMaND.Text, cboLoaiND.SelectedValue.ToString(), cboGV.SelectedValue.ToString(), txtTenDN.Text, txtMK.Text,CheckAction(chkStatus)) ;
                    }
                    if (btnUpdate.Visibility == BarItemVisibility.Always && btnAdd.Visibility == BarItemVisibility.Never)
                    {
                        db.updateUser(txtMaND.Text, cboLoaiND.SelectedValue.ToString(), cboGV.SelectedValue.ToString(), txtTenDN.Text, txtMK.Text, CheckAction(chkStatus));
                        //namhoc.suaNH(txtMaNamHoc.Text, txtTenNamHoc.Text);
                    }
                    else if (btnAdd.Visibility == BarItemVisibility.Always && btnUpdate.Visibility == BarItemVisibility.Always)
                    {
                        if (db.CheckUser(cboGV.SelectedValue.ToString(),txtMaND.Text) == false)
                        {
                            db.updateUser(txtMaND.Text, cboLoaiND.SelectedValue.ToString(), cboGV.SelectedValue.ToString(), txtTenDN.Text, txtMK.Text, CheckAction(chkStatus));
                        }
                        else
                            db.insertUser(txtMaND.Text, cboLoaiND.SelectedValue.ToString(), cboGV.SelectedValue.ToString(), txtTenDN.Text, txtMK.Text, CheckAction(chkStatus));
                    }
                    loadNDung();
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmPhanQuyen frm = new frmPhanQuyen();
            //frm.Show();
        }

        private void dgvND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //var senderGrid = (DataGridView)sender;

                //if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                //    e.RowIndex >= 0)
                //{
                //    string x = dgvND.Rows[e.RowIndex].Cells[5].Value.ToString();
                //    //MessageBox.Show("Tên giáo viên" + x);
                //    frmPhanQuyen myform = new frmPhanQuyen();
                //    myform.data(x);
                //    myform.Show();
                //}
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void dgvND_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex==4 && e.Value!= null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }    
        }
    }
}
