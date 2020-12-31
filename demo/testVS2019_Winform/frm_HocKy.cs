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
    public partial class frm_HocKy : Form
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        HocKy_Data hocky = new HocKy_Data();
        public frm_HocKy()
        {
            InitializeComponent();
        }

        public void loaddgvhocky()
        {
            dgvHocKy.DataSource = hocky.loadDataGridView();
        }

        private void frm_HocKy_Load(object sender, EventArgs e)
        {
            loaddgvhocky();
        }
    }
}
