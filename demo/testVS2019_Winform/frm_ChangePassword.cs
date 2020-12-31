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
    public partial class frm_ChangePassword : Form
    {
        DangNhap_Data db = new DangNhap_Data();
        public frm_ChangePassword()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMKCu.Text == txtMKM1.Text)
            {
                MessageBox.Show("Mật khẩu trùng");
            }
            else if(txtMKCu.Text == txtMKM2.Text)
            {
                MessageBox.Show("Mật khẩu trùng");
            }    
            else
            {
                if (txtMKM1.Text == txtMKM2.Text)
                {
                    db.changePass(txtMKCu.Text, txtMKM2.Text);
                }
                else
                {
                    MessageBox.Show("Mật khẩu không giống nhau");
                }
            }
        }
    }
}
