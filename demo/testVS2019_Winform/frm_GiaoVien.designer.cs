
namespace QLDiemTHPT_Winform
{
    partial class frm_GiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GiaoVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnTimKiemGV = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.txtTenGV = new DevExpress.XtraEditors.TextEdit();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtTimKiem = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
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
            this.btnLuu,
            this.btnRefresh,
            this.btnTimKiemGV});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh)});
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
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 2;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 3;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 426);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 426);
            // 
            // btnTimKiemGV
            // 
            this.btnTimKiemGV.Caption = "Tìm kiếm";
            this.btnTimKiemGV.Id = 4;
            this.btnTimKiemGV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemGV.ImageOptions.Image")));
            this.btnTimKiemGV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiemGV.ImageOptions.LargeImage")));
            this.btnTimKiemGV.Name = "btnTimKiemGV";
            this.btnTimKiemGV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtTimKiem);
            this.layoutControl1.Controls.Add(this.txtSDT);
            this.layoutControl1.Controls.Add(this.txtMaGV);
            this.layoutControl1.Controls.Add(this.txtTenGV);
            this.layoutControl1.Controls.Add(this.cboMonHoc);
            this.layoutControl1.Controls.Add(this.txtDiaChi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 64);
            this.layoutControl1.TabIndex = 10;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(415, 37);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(119, 20);
            this.txtSDT.TabIndex = 8;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(151, 12);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(121, 20);
            this.txtMaGV.StyleController = this.layoutControl1;
            this.txtMaGV.TabIndex = 4;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(415, 12);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(119, 20);
            this.txtTenGV.StyleController = this.layoutControl1;
            this.txtTenGV.TabIndex = 5;
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(677, 12);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(94, 21);
            this.cboMonHoc.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(151, 37);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(121, 20);
            this.txtDiaChi.StyleController = this.layoutControl1;
            this.txtDiaChi.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(783, 69);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMaGV;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "Mã giáo viên:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(264, 25);
            this.layoutControlItem1.Text = "Mã giáo viên:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(136, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTenGV;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "Tên giáo viên:";
            this.layoutControlItem2.Location = new System.Drawing.Point(264, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(262, 25);
            this.layoutControlItem2.Text = "Tên giáo viên:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(136, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cboMonHoc;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "Môn dạy:";
            this.layoutControlItem3.Location = new System.Drawing.Point(526, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(237, 25);
            this.layoutControlItem3.Text = "Môn dạy:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(136, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtDiaChi;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "Địa chỉ:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem4.Text = "Địa chỉ:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(136, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtSDT;
            this.layoutControlItem5.Location = new System.Drawing.Point(264, 25);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(262, 24);
            this.layoutControlItem5.Text = "Số điện thoại:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(136, 13);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.panelControl1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 88);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(800, 362);
            this.layoutControl2.TabIndex = 11;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgvGiaoVien);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(776, 338);
            this.panelControl1.TabIndex = 4;
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AllowUserToAddRows = false;
            this.dgvGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaoVien.Location = new System.Drawing.Point(2, 2);
            this.dgvGiaoVien.MultiSelect = false;
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvGiaoVien.Size = new System.Drawing.Size(772, 334);
            this.dgvGiaoVien.TabIndex = 0;
            this.dgvGiaoVien.SelectionChanged += new System.EventHandler(this.dgvGiaoVien_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaGiaoVien";
            this.Column1.HeaderText = "Mã giáo viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenGiaoVien";
            this.Column2.HeaderText = "Họ tên giáo viên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DienThoai";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenMonHoc";
            this.Column5.HeaderText = "Môn dạy";
            this.Column5.Name = "Column5";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 362);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.panelControl1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(780, 342);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtTimKiem;
            this.layoutControlItem7.Location = new System.Drawing.Point(526, 25);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(237, 24);
            this.layoutControlItem7.Text = "Tìm kiếm thông tin giáo viên:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(136, 13);
            this.layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(677, 37);
            this.txtTimKiem.MenuManager = this.barManager1;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtTimKiem.Size = new System.Drawing.Size(94, 20);
            this.txtTimKiem.StyleController = this.layoutControl1;
            this.txtTimKiem.TabIndex = 9;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // frm_GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_GiaoVien";
            this.Text = "Giáo viên";
            this.Load += new System.EventHandler(this.frm_GiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private DevExpress.XtraEditors.TextEdit txtTenGV;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtSDT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraBars.BarButtonItem btnTimKiemGV;
        private DevExpress.XtraEditors.SearchControl txtTimKiem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}