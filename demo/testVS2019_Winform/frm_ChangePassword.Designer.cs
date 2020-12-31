
namespace QLDiemTHPT_Winform
{
    partial class frm_ChangePassword
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
            this.txtMKM2 = new DevExpress.XtraEditors.TextEdit();
            this.txtMKM1 = new DevExpress.XtraEditors.TextEdit();
            this.txtMKCu = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblTieuDe = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lblNMK = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblNMKM1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblNMKM2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.label2 = new System.Windows.Forms.Label();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.label3 = new System.Windows.Forms.Label();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKM2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKM1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTieuDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNMKM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNMKM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.label3);
            this.layoutControl1.Controls.Add(this.label2);
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this.txtMKM2);
            this.layoutControl1.Controls.Add(this.txtMKM1);
            this.layoutControl1.Controls.Add(this.txtMKCu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(638, 0, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(541, 134);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtMKM2
            // 
            this.txtMKM2.Location = new System.Drawing.Point(159, 91);
            this.txtMKM2.Name = "txtMKM2";
            this.txtMKM2.Properties.UseSystemPasswordChar = true;
            this.txtMKM2.Size = new System.Drawing.Size(148, 22);
            this.txtMKM2.StyleController = this.layoutControl1;
            this.txtMKM2.TabIndex = 6;
            // 
            // txtMKM1
            // 
            this.txtMKM1.Location = new System.Drawing.Point(159, 62);
            this.txtMKM1.Name = "txtMKM1";
            this.txtMKM1.Properties.UseSystemPasswordChar = true;
            this.txtMKM1.Size = new System.Drawing.Size(148, 22);
            this.txtMKM1.StyleController = this.layoutControl1;
            this.txtMKM1.TabIndex = 5;
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(159, 33);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Properties.UseSystemPasswordChar = true;
            this.txtMKCu.Size = new System.Drawing.Size(148, 22);
            this.txtMKCu.StyleController = this.layoutControl1;
            this.txtMKCu.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblTieuDe,
            this.lblNMK,
            this.lblNMKM1,
            this.lblNMKM2,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(541, 134);
            this.Root.TextVisible = false;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AllowHotTrack = false;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(521, 21);
            this.lblTieuDe.Text = "Thay đổi mật khẩu";
            this.lblTieuDe.TextSize = new System.Drawing.Size(144, 17);
            // 
            // lblNMK
            // 
            this.lblNMK.Control = this.txtMKCu;
            this.lblNMK.Location = new System.Drawing.Point(0, 21);
            this.lblNMK.Name = "lblNMK";
            this.lblNMK.Size = new System.Drawing.Size(299, 29);
            this.lblNMK.Text = "Nhập mật khẩu cũ:";
            this.lblNMK.TextSize = new System.Drawing.Size(144, 17);
            // 
            // lblNMKM1
            // 
            this.lblNMKM1.Control = this.txtMKM1;
            this.lblNMKM1.Location = new System.Drawing.Point(0, 50);
            this.lblNMKM1.Name = "lblNMKM1";
            this.lblNMKM1.Size = new System.Drawing.Size(299, 29);
            this.lblNMKM1.Text = "Nhập mật khẩu mới: ";
            this.lblNMKM1.TextSize = new System.Drawing.Size(144, 17);
            // 
            // lblNMKM2
            // 
            this.lblNMKM2.Control = this.txtMKM2;
            this.lblNMKM2.Location = new System.Drawing.Point(0, 79);
            this.lblNMKM2.Name = "lblNMKM2";
            this.lblNMKM2.Size = new System.Drawing.Size(299, 35);
            this.lblNMKM2.Text = "Nhập lại mật khẩu mới: ";
            this.lblNMKM2.TextSize = new System.Drawing.Size(144, 17);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(168, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 29);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(311, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 7;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.label1;
            this.layoutControlItem1.Location = new System.Drawing.Point(299, 21);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(222, 29);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(311, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 8;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.label2;
            this.layoutControlItem2.Location = new System.Drawing.Point(299, 50);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(222, 29);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(311, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 31);
            this.label3.TabIndex = 9;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.label3;
            this.layoutControlItem3.Location = new System.Drawing.Point(299, 79);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(222, 35);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 199);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_ChangePassword";
            this.Text = "Thay đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMKM2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKM1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTieuDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNMKM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNMKM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtMKM2;
        private DevExpress.XtraEditors.TextEdit txtMKM1;
        private DevExpress.XtraEditors.TextEdit txtMKCu;
        private DevExpress.XtraLayout.SimpleLabelItem lblTieuDe;
        private DevExpress.XtraLayout.LayoutControlItem lblNMK;
        private DevExpress.XtraLayout.LayoutControlItem lblNMKM1;
        private DevExpress.XtraLayout.LayoutControlItem lblNMKM2;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}