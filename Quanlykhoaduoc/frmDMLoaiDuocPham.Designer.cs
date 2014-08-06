namespace Quanlykhoaduoc
{
    partial class frmDMLoaiDuocPham
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Stt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(515, 365);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "THÔNG TIN DƯỢC PHẨM (F2: THÊM, F3: SỬA, F4: XÓA)";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 21);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(511, 342);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Stt,
            this.MaDanhMuc,
            this.TenDanhMuc});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // Stt
            // 
            this.Stt.Caption = "Stt";
            this.Stt.Name = "Stt";
            this.Stt.OptionsColumn.ReadOnly = true;
            this.Stt.Visible = true;
            this.Stt.VisibleIndex = 0;
            this.Stt.Width = 57;
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.Caption = "Mã Danh Mục";
            this.MaDanhMuc.FieldName = "MaDanhMuc";
            this.MaDanhMuc.Name = "MaDanhMuc";
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.Caption = "Tên danh mục";
            this.TenDanhMuc.FieldName = "TenDanhMuc";
            this.TenDanhMuc.Name = "TenDanhMuc";
            this.TenDanhMuc.OptionsColumn.ReadOnly = true;
            this.TenDanhMuc.Visible = true;
            this.TenDanhMuc.VisibleIndex = 1;
            this.TenDanhMuc.Width = 431;
            // 
            // frmDMLoaiDuocPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 365);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(531, 404);
            this.MinimumSize = new System.Drawing.Size(531, 404);
            this.Name = "frmDMLoaiDuocPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN LOẠI DƯỢC PHẨM";
            this.Load += new System.EventHandler(this.frmDMLoaiDuocPham_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDMLoaiDuocPhamAction_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Stt;
        private DevExpress.XtraGrid.Columns.GridColumn MaDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn TenDanhMuc;
    }
}