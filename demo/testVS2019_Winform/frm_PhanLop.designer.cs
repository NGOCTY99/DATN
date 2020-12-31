
namespace QLDiemTHPT_Winform
{
    partial class frm_PhanLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PhanLop));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvIn = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboKhoiLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLocDK = new DevExpress.XtraEditors.SimpleButton();
            this.dgvOut = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOut)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(497, 546);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Học sinh mới";
            // 
            // dgvIn
            // 
            this.dgvIn.AllowUserToAddRows = false;
            this.dgvIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIn.Location = new System.Drawing.Point(4, 19);
            this.dgvIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvIn.MultiSelect = false;
            this.dgvIn.Name = "dgvIn";
            this.dgvIn.RowHeadersWidth = 51;
            this.dgvIn.Size = new System.Drawing.Size(489, 523);
            this.dgvIn.TabIndex = 0;
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
            this.Column2.HeaderText = "Họ tên";
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
            // Column4
            // 
            this.Column4.DataPropertyName = "NoiSinh";
            this.Column4.HeaderText = "Nơi sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvOut, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(565, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.76577F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.23424F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(498, 546);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.cboLopHoc, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cboNamHoc, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboKhoiLop, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnLocDK, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.73684F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.26316F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(490, 78);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(53, 38);
            this.cboLopHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(188, 24);
            this.cboLopHoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lớp học:";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(298, 4);
            this.cboNamHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(188, 24);
            this.cboNamHoc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(249, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm học:";
            // 
            // cboKhoiLop
            // 
            this.cboKhoiLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboKhoiLop.FormattingEnabled = true;
            this.cboKhoiLop.Location = new System.Drawing.Point(53, 4);
            this.cboKhoiLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboKhoiLop.Name = "cboKhoiLop";
            this.cboKhoiLop.Size = new System.Drawing.Size(188, 24);
            this.cboKhoiLop.TabIndex = 0;
            this.cboKhoiLop.SelectedValueChanged += new System.EventHandler(this.cboKhoiLop_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khối lớp:";
            // 
            // btnLocDK
            // 
            this.btnLocDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLocDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLocDK.ImageOptions.Image")));
            this.btnLocDK.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnLocDK.Location = new System.Drawing.Point(249, 38);
            this.btnLocDK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLocDK.Name = "btnLocDK";
            this.btnLocDK.Size = new System.Drawing.Size(41, 36);
            this.btnLocDK.TabIndex = 13;
            this.btnLocDK.Click += new System.EventHandler(this.btnLocDK_Click);
            // 
            // dgvOut
            // 
            this.dgvOut.AllowUserToAddRows = false;
            this.dgvOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOut.Location = new System.Drawing.Point(4, 90);
            this.dgvOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOut.MultiSelect = false;
            this.dgvOut.Name = "dgvOut";
            this.dgvOut.RowHeadersWidth = 51;
            this.dgvOut.Size = new System.Drawing.Size(490, 452);
            this.dgvOut.TabIndex = 3;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaHocSinh";
            this.Column5.HeaderText = "Mã học sinh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "HoTen";
            this.Column6.HeaderText = "Họ tên";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NgaySinh";
            this.Column7.HeaderText = "Ngày sinh";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenLop";
            this.Column8.HeaderText = "Lớp học";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TenKhoiLop";
            this.Column9.HeaderText = "Khối lớp";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TenNamHoc";
            this.Column10.HeaderText = "Năm học";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "NoiSinh";
            this.Column11.HeaderText = "Nơi sinh";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.Controls.Add(this.btnOut, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnIn, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(509, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(48, 546);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnOut
            // 
            this.btnOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOut.Location = new System.Drawing.Point(4, 277);
            this.btnOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(40, 28);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "<";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnIn
            // 
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIn.Location = new System.Drawing.Point(4, 241);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(40, 28);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = ">";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frm_PhanLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_PhanLop";
            this.Text = "Phân lớp";
            this.Load += new System.EventHandler(this.frm_PhanLop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOut)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboKhoiLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private DevExpress.XtraEditors.SimpleButton btnLocDK;
    }
}