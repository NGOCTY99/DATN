
namespace QLDiemTHPT_Winform
{
    partial class frm_TraCuuGV
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtTimKiem = new DevExpress.XtraEditors.SearchControl();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgvGiaoVien, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.layoutControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtTimKiem);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(3, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(794, 30);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(777, 44);
            this.Root.TextVisible = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(160, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtTimKiem.Size = new System.Drawing.Size(605, 20);
            this.txtTimKiem.StyleController = this.layoutControl1;
            this.txtTimKiem.TabIndex = 9;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtTimKiem;
            this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem7.CustomizationFormText = "Tìm kiếm thông tin giáo viên:";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(757, 24);
            this.layoutControlItem7.Text = "Tìm kiếm thông tin giáo viên:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(136, 13);
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
            this.dgvGiaoVien.Location = new System.Drawing.Point(3, 39);
            this.dgvGiaoVien.MultiSelect = false;
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvGiaoVien.Size = new System.Drawing.Size(794, 408);
            this.dgvGiaoVien.TabIndex = 2;
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
            // frm_TraCuuGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_TraCuuGV";
            this.Text = "Tra cứu thông tin giáo viên";
            this.Load += new System.EventHandler(this.frm_TraCuuGV_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SearchControl txtTimKiem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}