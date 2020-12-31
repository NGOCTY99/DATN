
namespace QLDiemTHPT_Winform
{
    partial class frmNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguoiDung));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtMaND = new System.Windows.Forms.TextBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.cboGV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMK = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDN = new DevExpress.XtraEditors.TextEdit();
            this.dgvND = new System.Windows.Forms.DataGridView();
            this.cboLoaiND = new System.Windows.Forms.ComboBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblMK = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblTenDN = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblGV = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblloaiND = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblMaND = new DevExpress.XtraLayout.LayoutControlItem();
            this.MaND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tengv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTenDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblloaiND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMaND)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnDelete,
            this.btnUpdate,
            this.btnSave,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 5;
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.FloatLocation = new System.Drawing.Point(526, 231);
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdate),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm mới";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Cập nhật";
            this.btnUpdate.Id = 2;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 3;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 30);
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
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 420);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 420);
            // 
            // btnDelete
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "form";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtMaND);
            this.layoutControl1.Controls.Add(this.chkStatus);
            this.layoutControl1.Controls.Add(this.cboGV);
            this.layoutControl1.Controls.Add(this.label4);
            this.layoutControl1.Controls.Add(this.txtMK);
            this.layoutControl1.Controls.Add(this.txtTenDN);
            this.layoutControl1.Controls.Add(this.dgvND);
            this.layoutControl1.Controls.Add(this.cboLoaiND);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1062, 186, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 420);
            this.layoutControl1.TabIndex = 19;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtMaND
            // 
            this.txtMaND.Location = new System.Drawing.Point(117, 12);
            this.txtMaND.Name = "txtMaND";
            this.txtMaND.Size = new System.Drawing.Size(281, 25);
            this.txtMaND.TabIndex = 1;
            this.txtMaND.Tag = "";
            // 
            // chkStatus
            // 
            this.chkStatus.Location = new System.Drawing.Point(117, 153);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(281, 25);
            this.chkStatus.TabIndex = 6;
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // cboGV
            // 
            this.cboGV.FormattingEnabled = true;
            this.cboGV.Location = new System.Drawing.Point(117, 71);
            this.cboGV.Name = "cboGV";
            this.cboGV.Size = new System.Drawing.Size(281, 24);
            this.cboGV.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(402, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 166);
            this.label4.TabIndex = 15;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(117, 127);
            this.txtMK.MenuManager = this.barManager1;
            this.txtMK.Name = "txtMK";
            this.txtMK.Properties.MaxLength = 30;
            this.txtMK.Properties.UseSystemPasswordChar = true;
            this.txtMK.Size = new System.Drawing.Size(281, 22);
            this.txtMK.StyleController = this.layoutControl1;
            this.txtMK.TabIndex = 5;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(117, 101);
            this.txtTenDN.MenuManager = this.barManager1;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Properties.MaxLength = 30;
            this.txtTenDN.Size = new System.Drawing.Size(281, 22);
            this.txtTenDN.StyleController = this.layoutControl1;
            this.txtTenDN.TabIndex = 4;
            // 
            // dgvND
            // 
            this.dgvND.AllowUserToAddRows = false;
            this.dgvND.AllowUserToDeleteRows = false;
            this.dgvND.AllowUserToResizeColumns = false;
            this.dgvND.AllowUserToResizeRows = false;
            this.dgvND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvND.ColumnHeadersHeight = 29;
            this.dgvND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaND,
            this.TenLoaiND,
            this.TenDNhap,
            this.MatKhau,
            this.Tengv,
            this.Status});
            this.dgvND.Location = new System.Drawing.Point(12, 182);
            this.dgvND.MultiSelect = false;
            this.dgvND.Name = "dgvND";
            this.dgvND.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvND.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvND.RowHeadersWidth = 51;
            this.dgvND.RowTemplate.Height = 24;
            this.dgvND.Size = new System.Drawing.Size(776, 226);
            this.dgvND.TabIndex = 8;
            this.dgvND.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvND_CellClick);
            this.dgvND.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvND_CellFormatting);
            // 
            // cboLoaiND
            // 
            this.cboLoaiND.FormattingEnabled = true;
            this.cboLoaiND.Location = new System.Drawing.Point(117, 41);
            this.cboLoaiND.Name = "cboLoaiND";
            this.cboLoaiND.Size = new System.Drawing.Size(281, 24);
            this.cboLoaiND.TabIndex = 2;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblUser,
            this.lblMK,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.lblTenDN,
            this.lblGV,
            this.lblloaiND,
            this.lblMaND});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 420);
            this.Root.TextVisible = false;
            // 
            // lblUser
            // 
            this.lblUser.Control = this.dgvND;
            this.lblUser.Location = new System.Drawing.Point(0, 170);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(780, 230);
            this.lblUser.TextSize = new System.Drawing.Size(0, 0);
            this.lblUser.TextVisible = false;
            // 
            // lblMK
            // 
            this.lblMK.Control = this.txtMK;
            this.lblMK.Location = new System.Drawing.Point(0, 115);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(390, 26);
            this.lblMK.Text = "Mật khẩu: ";
            this.lblMK.TextSize = new System.Drawing.Size(102, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.label4;
            this.layoutControlItem4.Location = new System.Drawing.Point(390, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(390, 170);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkStatus;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 141);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(390, 29);
            this.layoutControlItem5.Text = "Trạng thái: ";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(102, 17);
            // 
            // lblTenDN
            // 
            this.lblTenDN.Control = this.txtTenDN;
            this.lblTenDN.Location = new System.Drawing.Point(0, 89);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(390, 26);
            this.lblTenDN.Text = "Tên đăng nhập: ";
            this.lblTenDN.TextSize = new System.Drawing.Size(102, 17);
            // 
            // lblGV
            // 
            this.lblGV.Control = this.cboGV;
            this.lblGV.Location = new System.Drawing.Point(0, 59);
            this.lblGV.Name = "lblGV";
            this.lblGV.Size = new System.Drawing.Size(390, 30);
            this.lblGV.Text = "Tên giáo viên:";
            this.lblGV.TextSize = new System.Drawing.Size(102, 16);
            // 
            // lblloaiND
            // 
            this.lblloaiND.Control = this.cboLoaiND;
            this.lblloaiND.Location = new System.Drawing.Point(0, 29);
            this.lblloaiND.Name = "lblloaiND";
            this.lblloaiND.Size = new System.Drawing.Size(390, 30);
            this.lblloaiND.Text = "Loại người dùng";
            this.lblloaiND.TextSize = new System.Drawing.Size(102, 17);
            // 
            // lblMaND
            // 
            this.lblMaND.Control = this.txtMaND;
            this.lblMaND.Location = new System.Drawing.Point(0, 0);
            this.lblMaND.Name = "lblMaND";
            this.lblMaND.Size = new System.Drawing.Size(390, 29);
            this.lblMaND.Text = "Mã người dùng";
            this.lblMaND.TextSize = new System.Drawing.Size(102, 17);
            // 
            // MaND
            // 
            this.MaND.DataPropertyName = "Mand";
            this.MaND.HeaderText = "Mã người dùng";
            this.MaND.MinimumWidth = 6;
            this.MaND.Name = "MaND";
            this.MaND.ReadOnly = true;
            // 
            // TenLoaiND
            // 
            this.TenLoaiND.DataPropertyName = "Tenloai";
            this.TenLoaiND.HeaderText = "Loại người dùng";
            this.TenLoaiND.MinimumWidth = 6;
            this.TenLoaiND.Name = "TenLoaiND";
            this.TenLoaiND.ReadOnly = true;
            // 
            // TenDNhap
            // 
            this.TenDNhap.DataPropertyName = "Tendangnhap";
            this.TenDNhap.HeaderText = "Tên đăng nhập";
            this.TenDNhap.MinimumWidth = 6;
            this.TenDNhap.Name = "TenDNhap";
            this.TenDNhap.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "Matkhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // Tengv
            // 
            this.Tengv.DataPropertyName = "Tengv";
            this.Tengv.HeaderText = "Họ tên giáo viên";
            this.Tengv.MinimumWidth = 6;
            this.Tengv.Name = "Tengv";
            this.Tengv.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Check";
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNguoiDung";
            this.Text = "User";
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTenDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblloaiND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMaND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.DataGridView dgvND;
        private System.Windows.Forms.ComboBox cboLoaiND;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lblloaiND;
        private DevExpress.XtraLayout.LayoutControlItem lblUser;
        private DevExpress.XtraEditors.TextEdit txtMK;
        private DevExpress.XtraEditors.TextEdit txtTenDN;
        private DevExpress.XtraLayout.LayoutControlItem lblTenDN;
        private DevExpress.XtraLayout.LayoutControlItem lblMK;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.ComboBox cboGV;
        private DevExpress.XtraLayout.LayoutControlItem lblGV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.CheckBox chkStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.TextBox txtMaND;
        private DevExpress.XtraLayout.LayoutControlItem lblMaND;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tengv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}