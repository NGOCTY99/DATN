using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon; 
namespace DAL_BLL.Class
{
    public class DangNhap_Data
    {
        QLDiemTHPTDataContext db = new QLDiemTHPTDataContext();
        public bool KTTK(string tendn, string mk)
        {
            var dn = db.NGUOIDUNGs.SingleOrDefault(t => t.TenDNhap == tendn && t.MatKhau == mk);
            if (dn != null)
            {
                var status = db.NGUOIDUNGs.SingleOrDefault(t => t.TenDNhap == tendn && t.MatKhau == mk).Status;
                if (status.Equals(false))
                    return false;
                //MessageBox.Show("Tài khoản vô hiệu hóa");
                else
                {
                    return true;
                    //MessageBox.Show("Đăng nhập thành công");
                }
            }
            else return false;//MessageBox.Show("Không có tài khoản này");
        }
        
        public string LoaiNV(string tendn)
        {
            return db.NGUOIDUNGs.SingleOrDefault(t => t.TenDNhap == tendn).MaLoai.ToString();
        }
        public int Group(string ten)
        {
            return db.GroupPers.SingleOrDefault(t => t.GroupPer_Code == ten).ID_GroupPer;
        }

        public bool loadRole(string id, string name)
        {
            if(id=="LND004")
            {
                return true;
            }
            else
            {
                var role = db.Roles.SingleOrDefault(t => t.Role_Code == name).ID_Role;
                var kq = db.Details.FirstOrDefault(t => t.ID_Role == role && t.ID_NV == id);
                if (kq == null)
                {
                    return false;
                }
                else return true;
            }
        }

        public BarItemVisibility LoadGroup(string id,RibbonPage ribbonPage,string name)
        {
            BarButtonItem barButtonItem1 = new BarButtonItem();
            if(id =="LND004")
            {
                barButtonItem1.Visibility = BarItemVisibility.Always;
            }
            else
            {
                if(ribbonPage.Visible==true)
                {
                    var group = db.GroupPers.Single(t => t.GroupPer_Code == name).ID_GroupPer;
                    var kq = db.Details.FirstOrDefault(t => t.ID_Group == group);
                    if (kq == null)
                    barButtonItem1.Visibility = BarItemVisibility.Never;
                    else barButtonItem1.Visibility = BarItemVisibility.Always;
                }
            }
            return barButtonItem1.Visibility;
        }
        
        public string loadtenND(string ten)
        {
            return db.NGUOIDUNGs.SingleOrDefault(t => t.TenDNhap == ten).TenND.ToString();
        }
        public string loadten(string tendn)
        {
            return db.GIAOVIENs.SingleOrDefault(t => t.MaGiaoVien == tendn).TenGiaoVien.ToString();
        }

        public bool KTTenTK(string tendn)
        {
            if (db.NGUOIDUNGs.SingleOrDefault(t => t.TenDNhap == tendn) == null)
            {

                return true;
            }
            else
            {
                return false;

            }
        }

        public void updatePass(string tendn, string pass)
        {
            if (KTTenTK(tendn) == false)
            {
                NGUOIDUNG nv = db.NGUOIDUNGs.Single(t => t.TenDNhap == tendn);
                nv.MatKhau = pass;
                db.SubmitChanges();
                MessageBox.Show("Đã cập nhật mật khẩu: " + pass);
            }
            else
            {
                MessageBox.Show("Không có tài khoản này");
            }
        }

        public void changePass(string pass, string pass2)
        {
            NGUOIDUNG nv = db.NGUOIDUNGs.Single(t => t.MatKhau == pass);
            nv.MatKhau = pass2;
            db.SubmitChanges();
            MessageBox.Show("Đã thay đổi mật khẩu");
        }

        public IEnumerable<GIAOVIEN> loadProfile(string ten)
        {
            return db.GIAOVIENs.Where(t => t.MaGiaoVien==ten);
        }

        public string loadMH(string tenmon)
        {
            return db.MONHOCs.SingleOrDefault(t => t.MaMonHoc == tenmon).TenMonHoc.ToString();
        }
    }
}
