using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraBars;
using System.Threading.Tasks;
using System.Windows.Forms;
using testVS2019_Winform.Controller;
using QLDiemTHPT_Winform;
using DAL_BLL;
using DAL_BLL.Class;
using System.Collections;
using DevExpress.XtraBars.Ribbon;

namespace testVS2019_Winform
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DangNhap_Data db = new DangNhap_Data();
        string msgv, loainv;
        string idnv;
        public frm_Main()
        {
            InitializeComponent();
        }
        public frm_Main(string id)
        {
            this.idnv = id;
            InitializeComponent();
        }
        public void loadRole()
        {
            PageAdmin.Visible = db.loadRole(db.LoaiNV(idnv), PageAdmin.Name);
            ribbonQuanLy.Visible = db.loadRole(db.LoaiNV(idnv), ribbonQuanLy.Name);
            ribbonThongKe.Visible = db.loadRole(db.LoaiNV(idnv), ribbonThongKe.Name);
            ribbonTraCuu.Visible = db.loadRole(db.LoaiNV(idnv), ribbonTraCuu.Name);
            btnNND.Visibility=db.LoadGroup(db.LoaiNV(idnv), PageAdmin, btnNND.Name);
            btnRole.Visibility = db.LoadGroup(db.LoaiNV(idnv), PageAdmin, btnRole.Name);
            btnPermission.Visibility = db.LoadGroup(db.LoaiNV(idnv), PageAdmin, btnPermission.Name);
            btnTacVu.Visibility = db.LoadGroup(db.LoaiNV(idnv), PageAdmin, btnTacVu.Name);
            btnLopHoc.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnLopHoc.Name);
            btnKhoiLop.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnKhoiLop.Name);
            btnHocKy.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnHocKy.Name);
            btnNamHoc.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnNamHoc.Name);
            btnMonHoc.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnMonHoc.Name);
            btnDiem.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnDiem.Name);
            btnKetQua.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnKetQua.Name);
            btnHocLuc.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnHocLuc.Name);
            btnHocSinh.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnHocSinh.Name);
            btnPhanLop.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnPhanLop.Name);
            btnHanhKiem.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnHanhKiem.Name);
            btnDanToc.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnDanToc.Name);
            btnGiaoVien.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnGiaoVien.Name);
            btnTonGiao.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnTonGiao.Name);
            btnNgheNghiep.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnNgheNghiep.Name);
            btnPhanCong.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonQuanLy, btnPhanCong.Name);
            barButtonItem1.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonTraCuu, barButtonItem1.Name);
            btnTraCuuHS.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonTraCuu, btnTraCuuHS.Name);
            barButtonItem2.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonThongKe, barButtonItem2.Name);
            barButtonItem3.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonThongKe, barButtonItem3.Name);
            barButtonItem4.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonThongKe, barButtonItem4.Name);
            barButtonItem5.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonThongKe, barButtonItem5.Name);
            barButtonItem6.Visibility = db.LoadGroup(db.LoaiNV(idnv), ribbonThongKe, barButtonItem6.Name);
            GroupAdmin.Visible = ShowGroup(btnNND, btnRole, btnPermission, btnTacVu,null);
            ribbonLop_KhoiLop.Visible = ShowGroup(btnLopHoc, btnKhoiLop, null, null, null);
            ribbonHocKy_NamHoc.Visible = ShowGroup(btnHocKy, btnNamHoc, null, null, null);
            ribbonGiaoVien_PhanCong.Visible = ShowGroup(btnGiaoVien, btnPhanCong, null, null,null);
            ribbonHocSinh.Visible = ShowGroup(btnHocSinh, btnNgheNghiep, btnTonGiao, btnPhanLop, btnDanToc);
            ribbonKetQua.Visible = ShowGroup(btnKetQua, btnHocLuc, btnHanhKiem, null, null);
            ribbonMonHoc_Diem.Visible = ShowGroup(btnMonHoc, btnDiem, null, null, null);
            ribbonTT.Visible = ShowGroup(barButtonItem1, btnTraCuuHS, null, null, null);
            ribbonKQHK.Visible = ShowGroup(barButtonItem2, barButtonItem4, null, null,null);
            ribbonKQCN.Visible = ShowGroup(barButtonItem5, barButtonItem6, null, null, null);
        }
        public bool ShowGroup(BarButtonItem barButtonItem1, BarButtonItem barButtonItem2, BarButtonItem barButtonItem3, BarButtonItem barButtonItem4, BarButtonItem barButtonItem5)
        {
            if(barButtonItem3 == null || barButtonItem4 == null ||barButtonItem5 ==null)
            {
                if (barButtonItem1.Visibility == BarItemVisibility.Never && barButtonItem2.Visibility == BarItemVisibility.Never)
                    return false;
            }    
            else if(barButtonItem1.Visibility==BarItemVisibility.Never&& barButtonItem2.Visibility == BarItemVisibility.Never&& barButtonItem3.Visibility == BarItemVisibility.Never&& barButtonItem4.Visibility == BarItemVisibility.Never&& barButtonItem5.Visibility == BarItemVisibility.Never)
            {
                return false;
            }
            return true;
        }
        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void btnLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_LopHoc));
            if (frm == null)
            {
                frm_LopHoc forms = new frm_LopHoc(db.LoaiNV(idnv), db.Group(btnLopHoc.Name));
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnKhoiLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_KhoiLop));
            if (frm == null)
            {
                frm_KhoiLop forms = new frm_KhoiLop();
                forms.MdiParent = this;
               forms.Show();              
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnHocKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_HocKy));
            if (frm == null)
            {
                frm_HocKy forms = new frm_HocKy();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnNamHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_NamHoc));
            if (frm == null)
            {
                frm_NamHoc forms = new frm_NamHoc(db.LoaiNV(idnv),db.Group(btnNamHoc.Name));
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }
        public void showMSG()
        {
            msgv = db.loadtenND(idnv);
            loainv = db.LoaiNV(idnv);
        }

        private void btnTDMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_ChangePassword));
            if (frm == null)
            {
                frm_ChangePassword forms = new frm_ChangePassword();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnQMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmForgotPassword));
            if (frm == null)
            {
                frmForgotPassword forms = new frmForgotPassword();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.msgv = null;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.ShowInTaskbar)
                {
                    frm.Close();

                }
            }
            this.Close();
        }

        private void btnProfile_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmProfile));
            if (frm == null)
            {
                frmProfile f = new frmProfile();
                f.data(msgv);
                f.MdiParent = this;
                f.Show();
            }
            else
            {  
            frm.Activate();
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            loadRole();
            showMSG();
        }

        private void btnDanToc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_DanToc));
            if (frm == null)
            {
                frm_DanToc f = new frm_DanToc(db.LoaiNV(idnv), db.Group(btnNamHoc.Name));
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnNND_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Form frm = kiemtraform(typeof(FrmNhomND));
            //if (frm == null)
            //{
            //    FrmNhomND f = new FrmNhomND();
            //    f.MdiParent = this;
            //    f.Show();
            //}
            //else
            //{
            //    frm.Activate();
            //}

        }  
    }
}
