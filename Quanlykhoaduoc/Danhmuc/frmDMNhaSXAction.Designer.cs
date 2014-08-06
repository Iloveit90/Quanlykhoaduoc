namespace Quanlykhoaduoc.Danhmuc
{
    partial class frmDMNhaSXAction
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
            this.txtNhaSX = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaSX.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btHuy
            // 
            this.btHuy.Image = global::Quanlykhoaduoc.Properties.Resources.cancel;
            this.btHuy.Location = new System.Drawing.Point(163, 35);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(57, 23);
            this.btHuy.TabIndex = 18;
            this.btHuy.Text = "Hủy";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btLuu
            // 
            this.btLuu.Image = global::Quanlykhoaduoc.Properties.Resources.Save;
            this.btLuu.Location = new System.Drawing.Point(102, 35);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(57, 23);
            this.btLuu.TabIndex = 17;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(84, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Tên nhà sản xuất";
            // 
            // txtNhaSX
            // 
            this.txtNhaSX.Location = new System.Drawing.Point(102, 9);
            this.txtNhaSX.Name = "txtNhaSX";
            this.txtNhaSX.Size = new System.Drawing.Size(399, 20);
            this.txtNhaSX.TabIndex = 16;
            // 
            // frmDMNhaSXAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 63);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtNhaSX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(521, 102);
            this.MinimumSize = new System.Drawing.Size(521, 102);
            this.Name = "frmDMNhaSXAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THIẾT LẬP THÔNG TIN";
            this.Load += new System.EventHandler(this.frmDMNhaSXAction_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDMNhaSXAction_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaSX.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtNhaSX;
    }
}