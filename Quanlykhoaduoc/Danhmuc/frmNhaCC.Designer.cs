namespace Quanlykhoaduoc.Danhmuc
{
    partial class frmNhaCC
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
            this.MaNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Diachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiDaiDien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienthoaiLH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ghichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsAction = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.groupControl1.Size = new System.Drawing.Size(1036, 446);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "THÔNG TIN NHÀ CUNG CẤP (F2: THÊM, F3: SỬA, F4: XÓA)";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 21);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1032, 423);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Stt,
            this.MaNhaCC,
            this.TenNhaCC,
            this.Diachi,
            this.DienThoai,
            this.Fax,
            this.MST,
            this.NguoiDaiDien,
            this.DienthoaiLH,
            this.Ghichu,
            this.IsAction});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
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
            this.Stt.Visible = true;
            this.Stt.VisibleIndex = 0;
            this.Stt.Width = 47;
            // 
            // MaNhaCC
            // 
            this.MaNhaCC.Caption = "Mã số";
            this.MaNhaCC.FieldName = "MaNhaCC";
            this.MaNhaCC.Name = "MaNhaCC";
            this.MaNhaCC.Width = 72;
            // 
            // TenNhaCC
            // 
            this.TenNhaCC.Caption = "Tên nhà cung cấp";
            this.TenNhaCC.FieldName = "TenNhaCC";
            this.TenNhaCC.Name = "TenNhaCC";
            this.TenNhaCC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.TenNhaCC.Visible = true;
            this.TenNhaCC.VisibleIndex = 1;
            this.TenNhaCC.Width = 168;
            // 
            // Diachi
            // 
            this.Diachi.Caption = "Địa chỉ";
            this.Diachi.FieldName = "DiaChi";
            this.Diachi.Name = "Diachi";
            this.Diachi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Diachi.Visible = true;
            this.Diachi.VisibleIndex = 2;
            this.Diachi.Width = 174;
            // 
            // DienThoai
            // 
            this.DienThoai.Caption = "Điện thoại";
            this.DienThoai.FieldName = "DienThoai";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DienThoai.Visible = true;
            this.DienThoai.VisibleIndex = 3;
            this.DienThoai.Width = 107;
            // 
            // Fax
            // 
            this.Fax.Caption = "Fax";
            this.Fax.FieldName = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Fax.Visible = true;
            this.Fax.VisibleIndex = 4;
            this.Fax.Width = 103;
            // 
            // MST
            // 
            this.MST.Caption = "Mã số thuế";
            this.MST.FieldName = "MST";
            this.MST.Name = "MST";
            this.MST.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.MST.Visible = true;
            this.MST.VisibleIndex = 5;
            this.MST.Width = 115;
            // 
            // NguoiDaiDien
            // 
            this.NguoiDaiDien.Caption = "Người đại diện";
            this.NguoiDaiDien.FieldName = "NguoiDaiDien";
            this.NguoiDaiDien.Name = "NguoiDaiDien";
            this.NguoiDaiDien.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.NguoiDaiDien.Visible = true;
            this.NguoiDaiDien.VisibleIndex = 6;
            this.NguoiDaiDien.Width = 100;
            // 
            // DienthoaiLH
            // 
            this.DienthoaiLH.Caption = "Điện thoại liên hệ";
            this.DienthoaiLH.FieldName = "DienThoaiLH";
            this.DienthoaiLH.Name = "DienthoaiLH";
            this.DienthoaiLH.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DienthoaiLH.Visible = true;
            this.DienthoaiLH.VisibleIndex = 7;
            this.DienthoaiLH.Width = 122;
            // 
            // Ghichu
            // 
            this.Ghichu.Caption = "Ghi chú";
            this.Ghichu.FieldName = "Ghichu";
            this.Ghichu.Name = "Ghichu";
            this.Ghichu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Ghichu.Visible = true;
            this.Ghichu.VisibleIndex = 8;
            this.Ghichu.Width = 170;
            // 
            // IsAction
            // 
            this.IsAction.Caption = "Trạng thái";
            this.IsAction.FieldName = "IsAction";
            this.IsAction.Name = "IsAction";
            this.IsAction.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // frmNhaCC
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 446);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmNhaCC";
            this.Text = "THÔNG TIN NHÀ CUNG CẤP";
            this.Load += new System.EventHandler(this.frmNhaCC_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNhaCC_KeyDown);
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
        private DevExpress.XtraGrid.Columns.GridColumn MaNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn Diachi;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn Fax;
        private DevExpress.XtraGrid.Columns.GridColumn MST;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiDaiDien;
        private DevExpress.XtraGrid.Columns.GridColumn IsAction;
        private DevExpress.XtraGrid.Columns.GridColumn DienthoaiLH;
        private DevExpress.XtraGrid.Columns.GridColumn Ghichu;
        private DevExpress.XtraGrid.Columns.GridColumn Stt;
    }
}