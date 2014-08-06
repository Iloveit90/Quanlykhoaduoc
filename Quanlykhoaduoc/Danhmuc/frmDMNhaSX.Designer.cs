namespace Quanlykhoaduoc.Danhmuc
{
    partial class frmDMNhaSX
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
            this.MaNhaSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.groupControl1.Size = new System.Drawing.Size(505, 392);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "THÔNG TIN NHÀ SẢN XUẤT (F2: THÊM, F3: SỬA, F4: XÓA)";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 21);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(501, 369);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Stt,
            this.MaNhaSX,
            this.TenNhaCC});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
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
            this.Stt.Width = 58;
            // 
            // MaNhaSX
            // 
            this.MaNhaSX.Caption = "Mã số";
            this.MaNhaSX.FieldName = "MaNhaSX";
            this.MaNhaSX.Name = "MaNhaSX";
            this.MaNhaSX.Width = 72;
            // 
            // TenNhaCC
            // 
            this.TenNhaCC.Caption = "Tên nhà cung cấp";
            this.TenNhaCC.FieldName = "TenNhaSX";
            this.TenNhaCC.Name = "TenNhaCC";
            this.TenNhaCC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.TenNhaCC.Visible = true;
            this.TenNhaCC.VisibleIndex = 1;
            this.TenNhaCC.Width = 485;
            // 
            // frmDMNhaSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 392);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(521, 431);
            this.MinimumSize = new System.Drawing.Size(521, 431);
            this.Name = "frmDMNhaSX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN NHÀ SẢN XUẤT";
            this.Load += new System.EventHandler(this.frmDMNhaSX_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDMNhaSX_KeyDown);
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
        private DevExpress.XtraGrid.Columns.GridColumn MaNhaSX;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhaCC;
    }
}