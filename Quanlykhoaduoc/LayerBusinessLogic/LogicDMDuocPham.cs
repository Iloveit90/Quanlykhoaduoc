using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LayerBusinessLogic
{
    public class LogicDMDuocPham
    {
        LayerDataAccess.actionData acData = new LayerDataAccess.actionData();
        public void ActionExcuteQury(LayerBusinessObjec.ObjDMDuocPham obj, string action)
        {
            string tenthutuc = "P_DMDuocPham";
            string[] thamso = { "@action", "@MaDuocPhamID", "@MaDuocPham", "@MaDanhMuc", "@MaLoaiThuoc", "@MaDuongDung", "@MaNhaSX", "@Nuocsanxuat", "@NhaNhapKhau",
                                "@MaDonViTinh", "@TenDuocPham", "@TenGoc", "@NguonGoc","@HamLuong","@DangBaoChe","@QuyCach","@SoDangKy","@SttThong","@BaoHiem","@ThuocKTG","@NoiTru",
                                "@TuBaoChe","@NhieuDonChat","@CPThayThe","@isAction","@GhiChu","@MaTanDuoc"};
            object[] giatri = { action, obj.MaDuocPhamID, obj.MaDuocPham, obj.MaDanhMuc, obj.MaLoaiThuoc, obj.MaDuongDung, obj.MaNhaSX, obj.Nuocsanxuat, obj.NhaNhapKhau,
                                obj.MaDonViTinh, obj.TenDuocPham, obj.TenGoc, obj.NguonGoc,obj.HamLuong,obj.DangBaoChe,obj.QuyCach,obj.SoDangKy,obj.SttThongtu,obj.BaoHiem,obj.ThuocKTG,obj.NoiTru,
                                obj.TuBaoChe,obj.NhieuDonChat,obj.CPThayThe,obj.IsAction,obj.GhiChu,obj.MaTanDuoc};
            acData.ExcuteStoredProcedure(tenthutuc, thamso, giatri);
        }
        public DataTable SelectExcuteQuyry(LayerBusinessObjec.ObjDMDuocPham obj, string action)
        {
            string tenthutuc = "P_DMDuocPham";
            string[] thamso = { "@action", "@MaDuocPhamID", "@MaDuocPham", "@MaDanhMuc", "@MaLoaiThuoc", "@MaDuongDung", "@MaNhaSX", "@Nuocsanxuat", "@NhaNhapKhau",
                                "@MaDonViTinh", "@TenDuocPham", "@TenGoc", "@NguonGoc","@HamLuong","@DangBaoChe","@QuyCach","@SoDangKy","@SttThong","@BaoHiem","@ThuocKTG","@NoiTru",
                                "@TuBaoChe","@NhieuDonChat","@CPThayThe","@isAction","@GhiChu","@MaTanDuoc"};
            object[] giatri = { action, obj.MaDuocPhamID, obj.MaDuocPham, obj.MaDanhMuc, obj.MaLoaiThuoc, obj.MaDuongDung, obj.MaNhaSX, obj.Nuocsanxuat, obj.NhaNhapKhau,
                                obj.MaDonViTinh, obj.TenDuocPham, obj.TenGoc, obj.NguonGoc,obj.HamLuong,obj.DangBaoChe,obj.QuyCach,obj.SoDangKy,obj.SttThongtu,obj.BaoHiem,obj.ThuocKTG,obj.NoiTru,
                                obj.TuBaoChe,obj.NhieuDonChat,obj.CPThayThe,obj.IsAction,obj.GhiChu,obj.MaTanDuoc};
            DataTable dt = acData.ExcuteStoredProcedureselect(tenthutuc, thamso, giatri);
            return dt;
        }
    }
}
