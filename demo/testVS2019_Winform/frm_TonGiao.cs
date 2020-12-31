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
    public partial class frm_TonGiao : Form
    {
        public frm_TonGiao()
        {
            InitializeComponent();
        }
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        TonGiao_Data tongiao = new TonGiao_Data();
        public void loadDL()
        {
            dgvTonGiao.DataSource = tongiao.load_datagridview();
        }
        private void frm_TonGiao_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            loadDL();
        }

        private void dgvTonGiao_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            txtMaTG.Text = dgvTonGiao.CurrentRow.Cells[0].Value.ToString();
            txtTenTG.Text = dgvTonGiao.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            txtMaTG.Text = "";
            txtTenTG.Text = "";
            txtMaTG.Enabled = true;
            txtMaTG.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaTG.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_TonGiao_Load(sender, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtMaTG.Enabled == false) // trạng thái sửa
                {
                    if (tongiao.suaTG(txtMaTG.Text, txtTenTG.Text) == true)
                    {
                        MessageBox.Show("Sửa tôn giáo thành công");
                        loadDL();
                        txtMaTG.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa tôn giáo thất bại");
                    }
                }
                else // trạng thái thêm mới
                {
                    if (txtMaTG.Text != "" && txtTenTG.Text != "")
                    {

                        if (tongiao.themTG(txtMaTG.Text, txtTenTG.Text) == true)
                        {
                            MessageBox.Show("Thêm tôn giáo mới thành công");
                            loadDL();
                        }
                        else
                        {
                            MessageBox.Show("Mã tôn giáo đã tồn tại");
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
    
    }
}
