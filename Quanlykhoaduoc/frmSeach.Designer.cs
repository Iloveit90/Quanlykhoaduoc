namespace Quanlykhoaduoc
{
    partial class frmSeach
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radioBD = new System.Windows.Forms.RadioButton();
            this.radioCT = new System.Windows.Forms.RadioButton();
            this.txtTenmon = new DevExpress.XtraEditors.TextEdit();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btNhan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenmon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Tên cần tìm";
            // 
            // radioBD
            // 
            this.radioBD.AutoSize = true;
            this.radioBD.Checked = true;
            this.radioBD.Location = new System.Drawing.Point(67, 38);
            this.radioBD.Name = "radioBD";
            this.radioBD.Size = new System.Drawing.Size(62, 17);
            this.radioBD.TabIndex = 7;
            this.radioBD.TabStop = true;
            this.radioBD.Text = "Bắt đầu";
            this.radioBD.UseVisualStyleBackColor = true;
            // 
            // radioCT
            // 
            this.radioCT.AutoSize = true;
            this.radioCT.Location = new System.Drawing.Point(192, 38);
            this.radioCT.Name = "radioCT";
            this.radioCT.Size = new System.Drawing.Size(80, 17);
            this.radioCT.TabIndex = 8;
            this.radioCT.Text = "Chứa trong";
            this.radioCT.UseVisualStyleBackColor = true;
            // 
            // txtTenmon
            // 
            this.txtTenmon.Location = new System.Drawing.Point(67, 12);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.Size = new System.Drawing.Size(312, 20);
            this.txtTenmon.TabIndex = 0;
            // 
            // btHuy
            // 
            this.btHuy.Image = global::Quanlykhoaduoc.Properties.Resources.cancel;
            this.btHuy.Location = new System.Drawing.Point(135, 66);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(50, 23);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy";
            // 
            // btNhan
            // 
            this.btNhan.Image = global::Quanlykhoaduoc.Properties.Resources.Returns_16;
            this.btNhan.Location = new System.Drawing.Point(67, 66);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(62, 23);
            this.btNhan.TabIndex = 1;
            this.btNhan.Text = "Nhận";
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // frmSeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 101);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.radioBD);
            this.Controls.Add(this.radioCT);
            this.Controls.Add(this.txtTenmon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmSeach";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSearch_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenmon.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RadioButton radioBD;
        private System.Windows.Forms.RadioButton radioCT;
        private DevExpress.XtraEditors.TextEdit txtTenmon;
        private DevExpress.XtraEditors.SimpleButton btNhan;
        private DevExpress.XtraEditors.SimpleButton btHuy;
    }
}