
namespace QLDiemTHPT_Winform
{
    partial class frmForgotPassword
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
            this.txtTenDN = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblTTDN = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lblTKDN = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.lblMKMoi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTTDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTKDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this.txtTenDN);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(717, 0, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(424, 80);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(206, 33);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(177, 22);
            this.txtTenDN.StyleController = this.layoutControl1;
            this.txtTenDN.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblTTDN,
            this.lblTKDN,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(424, 80);
            this.Root.TextVisible = false;
            // 
            // lblTTDN
            // 
            this.lblTTDN.AllowHotTrack = false;
            this.lblTTDN.Location = new System.Drawing.Point(0, 0);
            this.lblTTDN.Name = "lblTTDN";
            this.lblTTDN.Size = new System.Drawing.Size(404, 21);
            this.lblTTDN.Text = "Thông tin tài khoản";
            this.lblTTDN.TextSize = new System.Drawing.Size(191, 17);
            // 
            // lblTKDN
            // 
            this.lblTKDN.Control = this.txtTenDN;
            this.lblTKDN.Location = new System.Drawing.Point(0, 21);
            this.lblTKDN.Name = "lblTKDN";
            this.lblTKDN.Size = new System.Drawing.Size(375, 39);
            this.lblTKDN.Text = "Tài khoản đăng nhập của bạn: ";
            this.lblTKDN.TextSize = new System.Drawing.Size(191, 17);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(236, 86);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 29);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Tìm lại mật khẩu";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblMKMoi
            // 
            this.lblMKMoi.AutoSize = true;
            this.lblMKMoi.ForeColor = System.Drawing.Color.Red;
            this.lblMKMoi.Location = new System.Drawing.Point(59, 134);
            this.lblMKMoi.Name = "lblMKMoi";
            this.lblMKMoi.Size = new System.Drawing.Size(155, 17);
            this.lblMKMoi.TabIndex = 2;
            this.lblMKMoi.Text = "Mật khẩu mới của bạn: ";
            this.lblMKMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMKMoi.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(387, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 35);
            this.label1.TabIndex = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.label1;
            this.layoutControlItem1.Location = new System.Drawing.Point(375, 21);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(29, 39);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 174);
            this.Controls.Add(this.lblMKMoi);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmForgotPassword";
            this.Text = "Quên mật khẩu";
            this.Load += new System.EventHandler(this.frmForgotPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTTDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTKDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtTenDN;
        private DevExpress.XtraLayout.SimpleLabelItem lblTTDN;
        private DevExpress.XtraLayout.LayoutControlItem lblTKDN;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.Label lblMKMoi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}