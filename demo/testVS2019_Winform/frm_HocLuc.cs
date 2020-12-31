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
    public partial class frm_HocLuc : Form
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        HocLuc_Data hocluc = new HocLuc_Data();
        public frm_HocLuc()
        {
            InitializeComponent();
        }

        private void frm_HocLuc_Load(object sender, EventArgs e)
        {
            dgvHocLuc.DataSource = hocluc.loadDataGridView();
        }
    }
}
