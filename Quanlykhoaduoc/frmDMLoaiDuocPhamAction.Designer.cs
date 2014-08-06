namespace Quanlykhoaduoc
{
    partial class frmDMLoaiDuocPhamAction
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipSeparatorItem toolTipSeparatorItem1 = new DevExpress.Utils.ToolTipSeparatorItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbLoaiDuocpham = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiDuocpham.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên loại";
            // 
            // cbLoaiDuocpham
            // 
            this.cbLoaiDuocpham.Location = new System.Drawing.Point(46, 6);
            this.cbLoaiDuocpham.Name = "cbLoaiDuocpham";
            this.cbLoaiDuocpham.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbLoaiDuocpham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLoaiDuocpham.Properties.Items.AddRange(new object[] {
            "Thuốc tân dược",
            "Vật tư y tế tiêu hao",
            "Hóa chất",
            "Loại khác"});
            this.cbLoaiDuocpham.Size = new System.Drawing.Size(457, 20);
            toolTipTitleItem1.Appearance.Image = global::Quanlykhoaduoc.Properties.Resources.account;
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = global::Quanlykhoaduoc.Properties.Resources.account;
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "ádfsadf";
            toolTipTitleItem2.Appearance.Image = global::Quanlykhoaduoc.Properties.Resources.alacarte;
            toolTipTitleItem2.Appearance.Options.UseImage = true;
            toolTipTitleItem2.Image = global::Quanlykhoaduoc.Properties.Resources.alacarte;
            toolTipTitleItem2.LeftIndent = 6;
            toolTipTitleItem2.Text = "ádfasfsadfasdfasdfsaf";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            superToolTip1.Items.Add(toolTipSeparatorItem1);
            superToolTip1.Items.Add(toolTipTitleItem2);
            this.cbLoaiDuocpham.SuperTip = superToolTip1;
            this.cbLoaiDuocpham.TabIndex = 3;
            // 
            // btHuy
            // 
            this.btHuy.Image = global::Quanlykhoaduoc.Properties.Resources.cancel;
            this.btHuy.Location = new System.Drawing.Point(107, 32);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(55, 23);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy";
            // 
            // btLuu
            // 
            this.btLuu.Image = global::Quanlykhoaduoc.Properties.Resources.Save;
            this.btLuu.Location = new System.Drawing.Point(46, 32);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(55, 23);
            this.btLuu.TabIndex = 1;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // frmDMLoaiDuocPhamAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 60);
            this.Controls.Add(this.cbLoaiDuocpham);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btLuu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(531, 99);
            this.MinimumSize = new System.Drawing.Size(531, 99);
            this.Name = "frmDMLoaiDuocPhamAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN LOẠI DƯỢC PHẨM";
            this.Load += new System.EventHandler(this.frmDMLoaiDuocPhamAction_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDMLoaiDuocPhamAction_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiDuocpham.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.ComboBoxEdit cbLoaiDuocpham;
    }
}