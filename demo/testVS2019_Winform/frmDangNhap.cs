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
using QLDiemTHPT_Winform;
using testVS2019_Winform;

namespace QLDiemTHPT_Winform
{
    public partial class frmDangNhap : Form
    {
        DangNhap_Data db = new DangNhap_Data();
        public delegate void sendMess(string mess1);
        public sendMess mess;
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public frmDangNhap(sendMess sender)
        {
            InitializeComponent();
            this.mess = sender;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(txtTenDN.Text) == true || string.IsNullOrEmpty(txtMK.Text) == true)
                    MessageBox.Show("Vui lòng nhập");
                else
                {
                    if (db.KTTK(txtTenDN.Text, txtMK.Text) == false)
                        MessageBox.Show("Không có tài khoản này hoặc tài khoản vô hiệu hóa");
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        frm_Main frm = new frm_Main(txtTenDN.Text);
                        frm.ShowDialog();
                    }
                }
        }
    }
}
