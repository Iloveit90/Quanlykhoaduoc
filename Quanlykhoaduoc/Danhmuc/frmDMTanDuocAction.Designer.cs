namespace Quanlykhoaduoc.Danhmuc
{
    partial class frmDMTanDuocAction
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
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTanDuoc = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTanDuoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btHuy
            // 
            this.btHuy.Image = global::Quanlykhoaduoc.Properties.Resources.cancel;
            this.btHuy.Location = new System.Drawing.Point(136, 38);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(57, 23);
            this.btHuy.TabIndex = 22;
            this.btHuy.Text = "Hủy";
            // 
            // btLuu
            // 
            this.btLuu.Image = global::Quanlykhoaduoc.Properties.Resources.Save;
            this.btLuu.Location = new System.Drawing.Point(75, 38);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(57, 23);
            this.btLuu.TabIndex = 21;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(5, 15);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 13);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Tên tân dược";
            // 
            // txtTenTanDuoc
            // 
            this.txtTenTanDuoc.Location = new System.Drawing.Point(75, 12);
            this.txtTenTanDuoc.Name = "txtTenTanDuoc";
            this.txtTenTanDuoc.Size = new System.Drawing.Size(352, 20);
            this.txtTenTanDuoc.TabIndex = 20;
            // 
            // frmDMTanDuocAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 70);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtTenTanDuoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(448, 109);
            this.MinimumSize = new System.Drawing.Size(448, 109);
            this.Name = "frmDMTanDuocAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THIẾT LẬP THÔNG TIN";
            this.Load += new System.EventHandler(this.frmDMTanDuocAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTanDuoc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtTenTanDuoc;
    }
}