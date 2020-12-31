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
    public partial class frm_HanhKiem : Form
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        HanhKiem_Data hanhkiem = new HanhKiem_Data();
        public frm_HanhKiem()
        {
            InitializeComponent();
        }

        private void frm_HanhKiem_Load(object sender, EventArgs e)
        {
            dgvHanhKiem.DataSource = hanhkiem.loadDataGridView();
        }

    }
}
