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
    public partial class frm_DanToc : Form
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        DanToc_Data dantoc = new DanToc_Data();
        PQtrongForm pq = new PQtrongForm();
        string id;
        int group;
        public frm_DanToc()
        {
            InitializeComponent();
        }
        public frm_DanToc(string idnv, int group)
        {
            InitializeComponent();
            this.id = idnv;
            this.group = group;
        }

        public void loadper()
        {
            btnThem.Visibility = pq.loadper(id, group, btnThem.Name);
            btnSua.Visibility = pq.loadper(id, group, btnSua.Name);
            dgvDanToc.Visible = pq.loaddgv(id, group, dgvDanToc.Name);
            if (btnSua.Visibility == BarItemVisibility.Never && btnThem.Visibility == BarItemVisibility.Never)
            {
                btnLuu.Visibility = BarItemVisibility.Never;
                bar2.Visible = false;
            }
            if (dgvDanToc.Visible == true)
                dgvDanToc.DataSource = dantoc.load_datagridview();
        }

        public void loadDL()
        {
            dgvDanToc.DataSource = dantoc.load_datagridview();
        }

        private void frm_DanToc_Load(object sender, EventArgs e)
        {
            txtMaDT.Enabled = txtTenDT.Enabled = false;
            loadper();
        }

        private void dgvDanToc_SelectionChanged(object sender, EventArgs e)
        {
            txtMaDT.Text = dgvDanToc.CurrentRow.Cells[0].Value.ToString();
            txtTenDT.Text = dgvDanToc.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaDT.Text = "";
            txtTenDT.Text = "";
            txtMaDT.Enabled = txtTenDT.Enabled = true;
            txtMaDT.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenDT.Enabled = true;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_DanToc_Load(sender, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtMaDT.Text != "" && txtTenDT.Text != "")
                {
                    if (btnThem.Visibility == BarItemVisibility.Always && btnSua.Visibility == BarItemVisibility.Never)
                    {
                        dantoc.themDT(txtMaDT.Text, txtTenDT.Text);
                    }
                    if (btnSua.Visibility == BarItemVisibility.Always && btnThem.Visibility == BarItemVisibility.Never)
                    {
                        dantoc.suaDT(txtMaDT.Text, txtTenDT.Text);
                    }
                    else if (btnThem.Visibility == BarItemVisibility.Always && btnSua.Visibility == BarItemVisibility.Always)
                    {
                        if (dantoc.ktkc(txtMaDT.Text) == false)
                        {
                            dantoc.suaDT(txtMaDT.Text, txtTenDT.Text);
                        }
                        else
                            dantoc.themDT(txtMaDT.Text, txtTenDT.Text);
                    }
                    loadDL();
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
    }
}
