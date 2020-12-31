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
    public partial class frm_NgheNghiep : Form
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        NgheNghiep_Data nghe = new NgheNghiep_Data();
        public frm_NgheNghiep()
        {
            InitializeComponent();
        }
        public void loadDL()
        {
            dgvNN.DataSource = nghe.load_datagridview();
        }

        private void frm_NgheNghiep_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            loadDL();
        }

        private void dgvNN_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            txtMaNghe.Text = dgvNN.CurrentRow.Cells[0].Value.ToString();
            txtTenNghe.Text = dgvNN.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            txtMaNghe.Text = "";
            txtTenNghe.Text = "";
            txtMaNghe.Enabled = true;
            txtMaNghe.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaNghe.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtMaNghe.Enabled == false) // trạng thái sửa
                {
                    if (nghe.suaNN(txtMaNghe.Text, txtTenNghe.Text) == true)
                    {
                        MessageBox.Show("Sửa nghề nghiệp thành công");
                        loadDL();
                        txtMaNghe.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa nghề nghiệp thất bại");
                    }
                }
                else // trạng thái thêm mới
                {
                    if (txtMaNghe.Text != "" && txtTenNghe.Text != "")
                    {

                        if (nghe.themNN(txtMaNghe.Text, txtTenNghe.Text) == true)
                        {
                            MessageBox.Show("Thêm nghề nghiệp mới thành công");
                            loadDL();
                        }
                        else
                        {
                            MessageBox.Show("Mã nghề nghiệp đã tồn tại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại");
            }
        
    }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_NgheNghiep_Load(sender, e);
        }
    }
}
