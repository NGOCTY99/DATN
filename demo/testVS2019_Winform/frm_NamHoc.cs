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
    public partial class frm_NamHoc : Form
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        NamHoc_Data namhoc = new NamHoc_Data();
        PQtrongForm pq = new PQtrongForm();
        string id;
        int group;
        public frm_NamHoc()
        {
            InitializeComponent();
            txtMaNamHoc.Enabled = txtTenNamHoc.Enabled = false;
        }
        public frm_NamHoc(string idnv, int idGroup)
        {
            InitializeComponent();
            this.id = idnv;
            this.group = idGroup;
        }

        public void loadper()
        {
            btnThem.Visibility = pq.loadper(id, group, btnThem.Name);
            btnSua.Visibility = pq.loadper(id, group, btnSua.Name);
            dgvNamHoc.Visible = pq.loaddgv(id, group, dgvNamHoc.Name);
            if(btnSua.Visibility== BarItemVisibility.Never && btnThem.Visibility== BarItemVisibility.Never)
            {
                btnLuu.Visibility = BarItemVisibility.Never;
                bar2.Visible = false;
            }
            if(dgvNamHoc.Visible==true)
                dgvNamHoc.DataSource = namhoc.loadDataGridView();
        }
        public void load_dgvNamhoc()
        {
            dgvNamHoc.DataSource = namhoc.loadDataGridView();
        }

        private void frm_NamHoc_Load(object sender, EventArgs e)
        {
            load_dgvNamhoc();
            loadper();
        }

        private void txtTenNamHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void dgvNamHoc_SelectionChanged(object sender, EventArgs e)
        {
            txtMaNamHoc.Text = dgvNamHoc.CurrentRow.Cells[0].Value.ToString();
            txtTenNamHoc.Text = dgvNamHoc.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaNamHoc.Enabled=txtTenNamHoc.Enabled = true;
            txtMaNamHoc.Text = "";
            txtTenNamHoc.Text = "";
            txtMaNamHoc.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaNamHoc.Enabled = false;
            txtTenNamHoc.Enabled = true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtMaNamHoc.Text != "" && txtTenNamHoc.Text != "")
                {
                    if (btnThem.Visibility == BarItemVisibility.Always && btnSua.Visibility == BarItemVisibility.Never)
                    {
                        namhoc.themNamHoc(txtMaNamHoc.Text, txtTenNamHoc.Text);
                    }
                    if (btnSua.Visibility == BarItemVisibility.Always && btnThem.Visibility == BarItemVisibility.Never)
                    {
                        namhoc.suaNH(txtMaNamHoc.Text, txtTenNamHoc.Text);
                    }
                    else if (btnThem.Visibility == BarItemVisibility.Always && btnSua.Visibility == BarItemVisibility.Always)
                    {
                        if(namhoc.ktkc(txtMaNamHoc.Text)==false)
                        {
                            namhoc.suaNH(txtMaNamHoc.Text, txtTenNamHoc.Text);
                        }
                        else
                            namhoc.themNamHoc(txtMaNamHoc.Text, txtTenNamHoc.Text);
                    }
                    load_dgvNamhoc();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
            } catch
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
