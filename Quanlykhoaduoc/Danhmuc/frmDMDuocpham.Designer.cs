namespace Quanlykhoaduoc.Danhmuc
{
    partial class frmDMDuocpham
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
            this.MaDuocPhamID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDuocPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaLoaiThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDuongDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nuocsanxuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhaNhapkhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDuocPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenGoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguonGoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HamLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DangBaoChe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quycach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDangKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SttThongtu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BaoHiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThuocKTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoiTru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TuBaoChe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhieuDonChat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CPThaythe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ghichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.groupControl1.Size = new System.Drawing.Size(1370, 443);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "THÔNG TIN DƯỢC PHẨM (F2: THÊM, F3: SỬA, F4: XÓA, F5: THÊM)";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 21);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1366, 420);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDuocPhamID,
            this.MaDuocPham,
            this.TenDuocPham,
            this.HamLuong,
            this.TenGoc,
            this.NguonGoc,
            this.DangBaoChe,
            this.Quycach,
            this.gridColumn5,
            this.gridColumn4,
            this.gridColumn1,
            this.Nuocsanxuat,
            this.NhaNhapkhau,
            this.SoDangKy,
            this.SttThongtu,
            this.Ghichu,
            this.gridColumn2,
            this.MaDanhMuc,
            this.MaLoaiThuoc,
            this.MaDuongDung,
            this.MaNhSX,
            this.MaDonViTinh,
            this.BaoHiem,
            this.ThuocKTG,
            this.NoiTru,
            this.TuBaoChe,
            this.NhieuDonChat,
            this.CPThaythe,
            this.IsAction});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaDuocPhamID
            // 
            this.MaDuocPhamID.Caption = "Mã Dược Phẩm ID";
            this.MaDuocPhamID.Name = "MaDuocPhamID";
            // 
            // MaDuocPham
            // 
            this.MaDuocPham.Caption = "Mã Dược phẩm";
            this.MaDuocPham.Name = "MaDuocPham";
            this.MaDuocPham.Visible = true;
            this.MaDuocPham.VisibleIndex = 0;
            this.MaDuocPham.Width = 86;
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.Caption = "Mã loại dược phẩm";
            this.MaDanhMuc.Name = "MaDanhMuc";
            // 
            // MaLoaiThuoc
            // 
            this.MaLoaiThuoc.Caption = "Mã dược lý";
            this.MaLoaiThuoc.Name = "MaLoaiThuoc";
            // 
            // MaDuongDung
            // 
            this.MaDuongDung.Caption = "Mã Đường dùng";
            this.MaDuongDung.Name = "MaDuongDung";
            // 
            // MaNhSX
            // 
            this.MaNhSX.Caption = "Mã Nhà sản xuất";
            this.MaNhSX.Name = "MaNhSX";
            // 
            // Nuocsanxuat
            // 
            this.Nuocsanxuat.Caption = "Nước sản xuất";
            this.Nuocsanxuat.Name = "Nuocsanxuat";
            this.Nuocsanxuat.Visible = true;
            this.Nuocsanxuat.VisibleIndex = 11;
            this.Nuocsanxuat.Width = 92;
            // 
            // NhaNhapkhau
            // 
            this.NhaNhapkhau.Caption = "Nhà nhập khẩu";
            this.NhaNhapkhau.Name = "NhaNhapkhau";
            this.NhaNhapkhau.Visible = true;
            this.NhaNhapkhau.VisibleIndex = 12;
            this.NhaNhapkhau.Width = 96;
            // 
            // MaDonViTinh
            // 
            this.MaDonViTinh.Caption = "Mã đơn vị tính";
            this.MaDonViTinh.Name = "MaDonViTinh";
            // 
            // TenDuocPham
            // 
            this.TenDuocPham.Caption = "Tên dược phẩm";
            this.TenDuocPham.Name = "TenDuocPham";
            this.TenDuocPham.Visible = true;
            this.TenDuocPham.VisibleIndex = 1;
            this.TenDuocPham.Width = 122;
            // 
            // TenGoc
            // 
            this.TenGoc.Caption = "Tên gốc";
            this.TenGoc.Name = "TenGoc";
            this.TenGoc.Visible = true;
            this.TenGoc.VisibleIndex = 3;
            this.TenGoc.Width = 99;
            // 
            // NguonGoc
            // 
            this.NguonGoc.Caption = "Nguồn gốc";
            this.NguonGoc.Name = "NguonGoc";
            this.NguonGoc.Visible = true;
            this.NguonGoc.VisibleIndex = 4;
            this.NguonGoc.Width = 102;
            // 
            // HamLuong
            // 
            this.HamLuong.Caption = "Hàm lượng";
            this.HamLuong.Name = "HamLuong";
            this.HamLuong.Visible = true;
            this.HamLuong.VisibleIndex = 2;
            this.HamLuong.Width = 117;
            // 
            // DangBaoChe
            // 
            this.DangBaoChe.Caption = "Dạng bào chế";
            this.DangBaoChe.Name = "DangBaoChe";
            this.DangBaoChe.Visible = true;
            this.DangBaoChe.VisibleIndex = 5;
            this.DangBaoChe.Width = 111;
            // 
            // Quycach
            // 
            this.Quycach.Caption = "Quy cách đóng gói";
            this.Quycach.Name = "Quycach";
            this.Quycach.Visible = true;
            this.Quycach.VisibleIndex = 6;
            this.Quycach.Width = 97;
            // 
            // SoDangKy
            // 
            this.SoDangKy.Caption = "Số đăng ký";
            this.SoDangKy.Name = "SoDangKy";
            this.SoDangKy.Visible = true;
            this.SoDangKy.VisibleIndex = 9;
            this.SoDangKy.Width = 84;
            // 
            // SttThongtu
            // 
            this.SttThongtu.Caption = "Stt Thông tư";
            this.SttThongtu.Name = "SttThongtu";
            this.SttThongtu.Visible = true;
            this.SttThongtu.VisibleIndex = 13;
            this.SttThongtu.Width = 71;
            // 
            // BaoHiem
            // 
            this.BaoHiem.Caption = "Bao hiểm";
            this.BaoHiem.Name = "BaoHiem";
            // 
            // ThuocKTG
            // 
            this.ThuocKTG.Caption = "ThuocKTG";
            this.ThuocKTG.Name = "ThuocKTG";
            // 
            // NoiTru
            // 
            this.NoiTru.Caption = "Nội Trú";
            this.NoiTru.Name = "NoiTru";
            // 
            // TuBaoChe
            // 
            this.TuBaoChe.Caption = "Tự bào chế";
            this.TuBaoChe.Name = "TuBaoChe";
            // 
            // NhieuDonChat
            // 
            this.NhieuDonChat.Caption = "Nhiều đơn chất";
            this.NhieuDonChat.Name = "NhieuDonChat";
            // 
            // CPThaythe
            // 
            this.CPThaythe.Caption = "CP thay thế";
            this.CPThaythe.Name = "CPThaythe";
            // 
            // IsAction
            // 
            this.IsAction.Caption = "IS Action(trạng thái)";
            this.IsAction.Name = "IsAction";
            // 
            // Ghichu
            // 
            this.Ghichu.Caption = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            this.Ghichu.Visible = true;
            this.Ghichu.VisibleIndex = 14;
            this.Ghichu.Width = 135;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đường dùng";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 8;
            this.gridColumn4.Width = 72;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Đơn vị tính";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            this.gridColumn5.Width = 72;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nhà sản xuất";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
            this.gridColumn1.Width = 77;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Loại dược phẩm";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 15;
            this.gridColumn2.Width = 233;
            // 
            // frmDMDuocpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 443);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.Name = "frmDMDuocpham";
            this.Text = "THÔNG TIN DƯỢC PHẨM";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDMDuocpham_KeyDown);
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
        private DevExpress.XtraGrid.Columns.GridColumn MaDuocPhamID;
        private DevExpress.XtraGrid.Columns.GridColumn MaDuocPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenDuocPham;
        private DevExpress.XtraGrid.Columns.GridColumn HamLuong;
        private DevExpress.XtraGrid.Columns.GridColumn TenGoc;
        private DevExpress.XtraGrid.Columns.GridColumn NguonGoc;
        private DevExpress.XtraGrid.Columns.GridColumn DangBaoChe;
        private DevExpress.XtraGrid.Columns.GridColumn Quycach;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn Nuocsanxuat;
        private DevExpress.XtraGrid.Columns.GridColumn NhaNhapkhau;
        private DevExpress.XtraGrid.Columns.GridColumn SoDangKy;
        private DevExpress.XtraGrid.Columns.GridColumn SttThongtu;
        private DevExpress.XtraGrid.Columns.GridColumn Ghichu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn MaDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoaiThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn MaDuongDung;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhSX;
        private DevExpress.XtraGrid.Columns.GridColumn MaDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn BaoHiem;
        private DevExpress.XtraGrid.Columns.GridColumn ThuocKTG;
        private DevExpress.XtraGrid.Columns.GridColumn NoiTru;
        private DevExpress.XtraGrid.Columns.GridColumn TuBaoChe;
        private DevExpress.XtraGrid.Columns.GridColumn NhieuDonChat;
        private DevExpress.XtraGrid.Columns.GridColumn CPThaythe;
        private DevExpress.XtraGrid.Columns.GridColumn IsAction;
    }
}