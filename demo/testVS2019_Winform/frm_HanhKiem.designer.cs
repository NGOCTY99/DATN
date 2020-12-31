
namespace QLDiemTHPT_Winform
{
    partial class frm_HanhKiem
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgvHanhKiem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgvHanhKiem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 450);
            this.panelControl1.TabIndex = 0;
            // 
            // dgvHanhKiem
            // 
            this.dgvHanhKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHanhKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanhKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvHanhKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHanhKiem.Location = new System.Drawing.Point(2, 2);
            this.dgvHanhKiem.MultiSelect = false;
            this.dgvHanhKiem.Name = "dgvHanhKiem";
            this.dgvHanhKiem.Size = new System.Drawing.Size(796, 446);
            this.dgvHanhKiem.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHanhKiem";
            this.Column1.HeaderText = "Mã hạnh kiểm";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenHanhKiem";
            this.Column2.HeaderText = "Tên hạnh kiểm";
            this.Column2.Name = "Column2";
            // 
            // frm_HanhKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_HanhKiem";
            this.Text = "Hạnh kiểm";
            this.Load += new System.EventHandler(this.frm_HanhKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dgvHanhKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}