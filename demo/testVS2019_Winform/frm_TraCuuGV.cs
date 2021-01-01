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
    public partial class frm_TraCuuGV : Form
    {
        TraCuuGV_Data tracuu = new TraCuuGV_Data();
        GiaoVien_Data gv = new GiaoVien_Data();
        public frm_TraCuuGV()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvGiaoVien.DataSource = tracuu.traCuu(txtTimKiem.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm được nội dung phù hợp");
            }
        }

        private void frm_TraCuuGV_Load(object sender, EventArgs e)
        {
            dgvGiaoVien.DataSource = gv.loadDataGridView();
        }
    }
}
