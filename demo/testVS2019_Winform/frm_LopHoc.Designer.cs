
namespace testVS2019_Winform.Controller
{
    partial class frm_LopHoc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LopHoc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cboGVCN = new System.Windows.Forms.ComboBox();
            this.cboMaNamHoc = new System.Windows.Forms.ComboBox();
            this.cboKhoiLop = new System.Windows.Forms.ComboBox();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtSiSo = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sád = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sád)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnLuu});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1067, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 554);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1067, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 524);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1067, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 524);
            // 
            // btnXoa            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboGVCN);
            this.layoutControl1.Controls.Add(this.cboMaNamHoc);
            this.layoutControl1.Controls.Add(this.cboKhoiLop);
            this.layoutControl1.Controls.Add(this.txtTenLop);
            this.layoutControl1.Controls.Add(this.txtMaLop);
            this.layoutControl1.Controls.Add(this.txtSiSo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1067, 92);
            this.layoutControl1.TabIndex = 8;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cboGVCN
            // 
            this.cboGVCN.FormattingEnabled = true;
            this.cboGVCN.Location = new System.Drawing.Point(850, 44);
            this.cboGVCN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGVCN.Name = "cboGVCN";
            this.cboGVCN.Size = new System.Drawing.Size(201, 24);
            this.cboGVCN.TabIndex = 10;
            // 
            // cboMaNamHoc
            // 
            this.cboMaNamHoc.FormattingEnabled = true;
            this.cboMaNamHoc.Location = new System.Drawing.Point(148, 40);
            this.cboMaNamHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMaNamHoc.Name = "cboMaNamHoc";
            this.cboMaNamHoc.Size = new System.Drawing.Size(221, 24);
            this.cboMaNamHoc.TabIndex = 9;
            // 
            // cboKhoiLop
            // 
            this.cboKhoiLop.FormattingEnabled = true;
            this.cboKhoiLop.Location = new System.Drawing.Point(850, 14);
            this.cboKhoiLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboKhoiLop.Name = "cboKhoiLop";
            this.cboKhoiLop.Size = new System.Drawing.Size(201, 24);
            this.cboKhoiLop.TabIndex = 8;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(507, 14);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenLop.MenuManager = this.barManager1;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(205, 22);
            this.txtTenLop.StyleController = this.layoutControl1;
            this.txtTenLop.TabIndex = 5;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(148, 14);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaLop.MenuManager = this.barManager1;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(221, 22);
            this.txtMaLop.StyleController = this.layoutControl1;
            this.txtMaLop.TabIndex = 4;
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(507, 40);
            this.txtSiSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(205, 22);
            this.txtSiSo.StyleController = this.layoutControl1;
            this.txtSiSo.TabIndex = 5;
            this.txtSiSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSiSo_KeyPress);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.sád,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1067, 92);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMaLop;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(359, 26);
            this.layoutControlItem1.Text = "Mã lớp:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(128, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTenLop;
            this.layoutControlItem2.Location = new System.Drawing.Point(359, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(343, 26);
            this.layoutControlItem2.Text = "Tên lớp:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(128, 17);
            // 
            // sád
            // 
            this.sád.Control = this.txtSiSo;
            this.sád.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.sád.CustomizationFormText = "Tên lớp:";
            this.sád.Location = new System.Drawing.Point(359, 26);
            this.sád.Name = "sád";
            this.sád.Size = new System.Drawing.Size(343, 42);
            this.sád.Text = "Sỉ số:";
            this.sád.TextSize = new System.Drawing.Size(128, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cboKhoiLop;
            this.layoutControlItem3.Location = new System.Drawing.Point(702, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(339, 30);
            this.layoutControlItem3.Text = "Mã khối lớp:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(128, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cboMaNamHoc;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(359, 42);
            this.layoutControlItem4.Text = "Mã năm học:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(128, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cboGVCN;
            this.layoutControlItem5.Location = new System.Drawing.Point(702, 30);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(339, 38);
            this.layoutControlItem5.Text = "Giáo viên chủ nhiệm:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(128, 17);
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.ss,
            this.Column6});
            this.dgvLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLopHoc.Location = new System.Drawing.Point(0, 122);
            this.dgvLopHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.RowHeadersWidth = 51;
            this.dgvLopHoc.Size = new System.Drawing.Size(1067, 432);
            this.dgvLopHoc.TabIndex = 18;
            this.dgvLopHoc.SelectionChanged += new System.EventHandler(this.dgvLopHoc_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLop";
            this.Column1.HeaderText = "Mã lớp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenLop";
            this.Column2.HeaderText = "Tên lớp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenKhoiLop";
            this.Column3.HeaderText = "Khối lớp";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenNamHoc";
            this.Column4.HeaderText = "Năm học";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // ss
            // 
            this.ss.DataPropertyName = "SiSo";
            this.ss.HeaderText = "Sĩ số";
            this.ss.MinimumWidth = 6;
            this.ss.Name = "ss";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenGiaoVien";
            this.Column6.HeaderText = "Giáo viên chủ nhiệm";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // frm_LopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvLopHoc);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_LopHoc";
            this.Text = "Lớp học";
            this.Load += new System.EventHandler(this.frm_LopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sád)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtSiSo;
        private DevExpress.XtraLayout.LayoutControlItem sád;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.ComboBox cboKhoiLop;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.ComboBox cboGVCN;
        private System.Windows.Forms.ComboBox cboMaNamHoc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}