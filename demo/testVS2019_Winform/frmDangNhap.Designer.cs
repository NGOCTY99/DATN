
namespace QLDiemTHPT_Winform
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtMK = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDN = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblTieuDe = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lblTenDN = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblMatKhau = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTieuDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTenDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMatKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtMK);
            this.layoutControl1.Controls.Add(this.txtTenDN);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(478, 104);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(144, 59);
            this.txtMK.Name = "txtMK";
            this.txtMK.Properties.UseSystemPasswordChar = true;
            this.txtMK.Size = new System.Drawing.Size(322, 22);
            this.txtMK.StyleController = this.layoutControl1;
            this.txtMK.TabIndex = 5;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(144, 33);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(322, 22);
            this.txtTenDN.StyleController = this.layoutControl1;
            this.txtTenDN.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblTieuDe,
            this.lblTenDN,
            this.lblMatKhau});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(478, 104);
            this.Root.TextVisible = false;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AllowHotTrack = false;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(458, 21);
            this.lblTieuDe.Text = "Thông tin đăng nhập";
            this.lblTieuDe.TextSize = new System.Drawing.Size(129, 17);
            // 
            // lblTenDN
            // 
            this.lblTenDN.Control = this.txtTenDN;
            this.lblTenDN.Location = new System.Drawing.Point(0, 21);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(458, 26);
            this.lblTenDN.Text = "Tên đăng nhập";
            this.lblTenDN.TextSize = new System.Drawing.Size(129, 17);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Control = this.txtMK;
            this.lblMatKhau.Location = new System.Drawing.Point(0, 47);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(458, 37);
            this.lblMatKhau.Text = "Mật khẩu";
            this.lblMatKhau.TextSize = new System.Drawing.Size(129, 17);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(211, 110);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 29);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 151);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTieuDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTenDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMatKhau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtMK;
        private DevExpress.XtraEditors.TextEdit txtTenDN;
        private DevExpress.XtraLayout.SimpleLabelItem lblTieuDe;
        private DevExpress.XtraLayout.LayoutControlItem lblTenDN;
        private DevExpress.XtraLayout.LayoutControlItem lblMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
    }
}