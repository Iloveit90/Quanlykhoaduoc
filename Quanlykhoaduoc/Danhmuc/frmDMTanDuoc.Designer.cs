namespace Quanlykhoaduoc.Danhmuc
{
    partial class frmDMTanDuoc
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
            this.MaTanDuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTanDuoc = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.groupControl1.Size = new System.Drawing.Size(432, 391);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "THÔNG TIN NHÓM TÂN DƯỢC (F2: THÊM, F3: SỬA, F4: XÓA)";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 21);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(428, 368);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl.DragEnter += new System.Windows.Forms.DragEventHandler(this.gridControl_DragEnter);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Stt,
            this.MaTanDuoc,
            this.TenTanDuoc});
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
            // MaTanDuoc
            // 
            this.MaTanDuoc.Caption = "Mã số";
            this.MaTanDuoc.FieldName = "MaTanduoc";
            this.MaTanDuoc.Name = "MaTanDuoc";
            this.MaTanDuoc.Width = 72;
            // 
            // TenTanDuoc
            // 
            this.TenTanDuoc.Caption = "Tên đường dùng";
            this.TenTanDuoc.FieldName = "TenTanDuoc";
            this.TenTanDuoc.Name = "TenTanDuoc";
            this.TenTanDuoc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.TenTanDuoc.Visible = true;
            this.TenTanDuoc.VisibleIndex = 1;
            this.TenTanDuoc.Width = 485;
            // 
            // frmDMTanDuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 391);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmDMTanDuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN TÂN DƯỢC";
            this.Load += new System.EventHandler(this.frmDMTanDuoc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDMTanDuoc_KeyDown);
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
        private DevExpress.XtraGrid.Columns.GridColumn MaTanDuoc;
        private DevExpress.XtraGrid.Columns.GridColumn TenTanDuoc;
    }
}