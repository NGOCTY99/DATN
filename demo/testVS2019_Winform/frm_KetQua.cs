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
    public partial class frm_KetQua : Form
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        KetQua_Data ketqua = new KetQua_Data();
        public frm_KetQua()
        {
            InitializeComponent();
        }

        private void frm_KetQua_Load(object sender, EventArgs e)
        {
            dgvKetQua.DataSource = ketqua.loadDataGridView();
        }
    }
}
