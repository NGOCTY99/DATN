using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL.Class;
using DAL_BLL;
namespace testVS2019_Winform
{
    public partial class frm_KhoiLop : Form
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        KhoiLop_Data khoilop = new KhoiLop_Data();
        public frm_KhoiLop()
        {
            InitializeComponent();
        }

        public void loaddgvKhoiLop()
        {
            dgvKhoiLop.DataSource = khoilop.loadDataGridView();
        }

        private void frm_KhoiLop_Load(object sender, EventArgs e)
        {
            loaddgvKhoiLop();
        }
    }
}
