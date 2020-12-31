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
    public partial class frm_MonHoc : Form
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        MonHoc_Data monhoc = new MonHoc_Data();
        public frm_MonHoc()
        {
            InitializeComponent();
        }

        private void frm_MonHoc_Load(object sender, EventArgs e)
        {
            dgv_MonHoc.DataSource = monhoc.loadDataGridView();
        }
    }
}
