
namespace QLDiemTHPT_Winform
{
    partial class frm_Diem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Diem));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvHS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaDiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemDiem = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLoaiDiem = new System.Windows.Forms.ComboBox();
            this.txtSoDiem = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.btnLocTheoDK = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaKhoi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.btnLocDSHS = new DevExpress.XtraEditors.SimpleButton();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tableLayoutPanel2.Controls.Add(this.dgvHS, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 512F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1067, 512);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dgvHS
            // 
            this.dgvHS.AllowUserToAddRows = false;
            this.dgvHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgvHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHS.Location = new System.Drawing.Point(4, 4);
            this.dgvHS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHS.MultiSelect = false;
            this.dgvHS.Name = "dgvHS";
            this.dgvHS.RowHeadersWidth = 51;
            this.dgvHS.Size = new System.Drawing.Size(642, 504);
            this.dgvHS.TabIndex = 0;
            this.dgvHS.SelectionChanged += new System.EventHandler(this.dgvHS_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHocSinh";
            this.Column1.HeaderText = "Mã học sinh";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgaySinh";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenLop";
            this.Column5.HeaderText = "Tên lớp";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Controls.Add(this.dgvDiem, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(654, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.19512F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.80488F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(409, 504);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dgvDiem
            // 
            this.dgvDiem.AllowUserToAddRows = false;
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column7,
            this.Column4,
            this.Column6});
            this.dgvDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiem.Location = new System.Drawing.Point(4, 4);
            this.dgvDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.Size = new System.Drawing.Size(401, 154);
            this.dgvDiem.TabIndex = 2;
            this.dgvDiem.SelectionChanged += new System.EventHandler(this.dgvDiem_SelectionChanged);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "STT";
            this.Column8.HeaderText = "STT";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaLoai";
            this.Column7.HeaderText = "Mã loại";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenLoai";
            this.Column4.HeaderText = "Loại điểm";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Diem1";
            this.Column6.HeaderText = "Điểm";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 166);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.73399F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.26601F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(401, 334);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel5.Controls.Add(this.btnLuu, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnSuaDiem, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnThemDiem, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(393, 51);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(219, 4);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 43);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnSuaDiem
            // 
            this.btnSuaDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuaDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDiem.ImageOptions.Image")));
            this.btnSuaDiem.Location = new System.Drawing.Point(180, 4);
            this.btnSuaDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaDiem.Name = "btnSuaDiem";
            this.btnSuaDiem.Size = new System.Drawing.Size(31, 43);
            this.btnSuaDiem.TabIndex = 1;
            this.btnSuaDiem.Text = "Sửa";
            this.btnSuaDiem.Click += new System.EventHandler(this.btnSuaDiem_Click);
            // 
            // btnThemDiem
            // 
            this.btnThemDiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThemDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDiem.ImageOptions.Image")));
            this.btnThemDiem.Location = new System.Drawing.Point(104, 4);
            this.btnThemDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemDiem.Name = "btnThemDiem";
            this.btnThemDiem.Size = new System.Drawing.Size(68, 43);
            this.btnThemDiem.TabIndex = 0;
            this.btnThemDiem.Text = "Thêm";
            this.btnThemDiem.Click += new System.EventHandler(this.btnThemDiem_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 63);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.83105F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.16895F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(393, 267);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 6;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.label9, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.label8, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.cboLoaiDiem, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtSoDiem, 3, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(385, 52);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(340, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 52);
            this.label9.TabIndex = 5;
            this.label9.Text = "????";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(244, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 52);
            this.label8.TabIndex = 4;
            this.label8.Text = "Điểm trung bình môn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(148, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 52);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số điểm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 52);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại điểm:";
            // 
            // cboLoaiDiem
            // 
            this.cboLoaiDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLoaiDiem.FormattingEnabled = true;
            this.cboLoaiDiem.Location = new System.Drawing.Point(52, 4);
            this.cboLoaiDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLoaiDiem.Name = "cboLoaiDiem";
            this.cboLoaiDiem.Size = new System.Drawing.Size(88, 24);
            this.cboLoaiDiem.TabIndex = 1;
            // 
            // txtSoDiem
            // 
            this.txtSoDiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSoDiem.Location = new System.Drawing.Point(196, 4);
            this.txtSoDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoDiem.MaxLength = 3;
            this.txtSoDiem.Name = "txtSoDiem";
            this.txtSoDiem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSoDiem.Size = new System.Drawing.Size(36, 22);
            this.txtSoDiem.TabIndex = 3;
            this.txtSoDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDiem_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.30952F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.238095F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.02381F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.190476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.04762F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.833333F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboNamHoc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLocTheoDK, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboMaKhoi, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboMonHoc, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboHocKy, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboMaLop, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLocDSHS, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 42);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm học:";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(54, 4);
            this.cboNamHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(112, 24);
            this.cboNamHoc.TabIndex = 1;
            // 
            // btnLocTheoDK
            // 
            this.btnLocTheoDK.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocTheoDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLocTheoDK.ImageOptions.Image")));
            this.btnLocTheoDK.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnLocTheoDK.Location = new System.Drawing.Point(1003, 4);
            this.btnLocTheoDK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLocTheoDK.Name = "btnLocTheoDK";
            this.btnLocTheoDK.Size = new System.Drawing.Size(45, 34);
            this.btnLocTheoDK.TabIndex = 14;
            this.btnLocTheoDK.Click += new System.EventHandler(this.btnLocTheoDK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(174, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 42);
            this.label2.TabIndex = 15;
            this.label2.Text = "Khối lớp:";
            // 
            // cboMaKhoi
            // 
            this.cboMaKhoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaKhoi.FormattingEnabled = true;
            this.cboMaKhoi.Location = new System.Drawing.Point(229, 4);
            this.cboMaKhoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMaKhoi.Name = "cboMaKhoi";
            this.cboMaKhoi.Size = new System.Drawing.Size(120, 24);
            this.cboMaKhoi.TabIndex = 16;
            this.cboMaKhoi.SelectedValueChanged += new System.EventHandler(this.cboMaKhoi_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(357, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 42);
            this.label3.TabIndex = 18;
            this.label3.Text = "Lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(599, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 42);
            this.label4.TabIndex = 19;
            this.label4.Text = "Môn học:";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(645, 4);
            this.cboMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(134, 24);
            this.cboMonHoc.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(787, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 42);
            this.label5.TabIndex = 21;
            this.label5.Text = "Học kỳ:";
            // 
            // cboHocKy
            // 
            this.cboHocKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(853, 4);
            this.cboHocKy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(142, 24);
            this.cboHocKy.TabIndex = 22;
            // 
            // cboMaLop
            // 
            this.cboMaLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(407, 4);
            this.cboMaLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(116, 24);
            this.cboMaLop.TabIndex = 23;
            // 
            // btnLocDSHS
            // 
            this.btnLocDSHS.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocDSHS.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLocDSHS.ImageOptions.Image")));
            this.btnLocDSHS.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnLocDSHS.Location = new System.Drawing.Point(531, 4);
            this.btnLocDSHS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLocDSHS.Name = "btnLocDSHS";
            this.btnLocDSHS.Size = new System.Drawing.Size(45, 34);
            this.btnLocDSHS.TabIndex = 24;
            this.btnLocDSHS.Click += new System.EventHandler(this.btnLocDSHS_Click);
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
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // frm_Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Diem";
            this.Text = "Bảng điểm";
            this.Load += new System.EventHandler(this.frm_Diem_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvHS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private DevExpress.XtraEditors.SimpleButton btnLocTheoDK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaKhoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.ComboBox cboMaLop;
        private DevExpress.XtraEditors.SimpleButton btnLocDSHS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.SimpleButton btnThemDiem;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSuaDiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboLoaiDiem;
        private System.Windows.Forms.TextBox txtSoDiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}