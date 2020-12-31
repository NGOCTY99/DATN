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
    public partial class frmForgotPassword : Form
    {
        DangNhap_Data db = new DangNhap_Data();
        public frmForgotPassword()
        {
            InitializeComponent();
        }
        public string randomMK()
        {
            string kq = "";
            Random rd = new Random();
            for (int i = 0; i < 4; i++)
            {
                int t = rd.Next(0, 9);
                kq += t.ToString();
            }
            return kq;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mk = randomMK();
            db.updatePass(txtTenDN.Text, mk);
            lblMKMoi.Visible = true;
            lblMKMoi.Text = "Mật khẩu đã cập nhật là:" + mk;
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {
            txtTenDN.Focus();
        }
    }
}
