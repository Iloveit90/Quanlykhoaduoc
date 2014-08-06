using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LayerBusinessLogic
{
    public class LogicDMNhanVien
    {
        LayerDataAccess.actionData acData = new LayerDataAccess.actionData();
        public void ActionExcuteQury(LayerBusinessObjec.ObjDMNhaCC obj, string action)
        {
            string tenthutuc = "P_DMNhanVien";
            string[] thamso = { "@action", "@MaNhaCC", "@TenNhaCC", "@Diachi", "@Dienthoai", "@fax", "@Email", "@MST", "@Nguoidaidien", "@isAction", "@NguoiLienHe", "@DienThoaiLH", "@GhiChu" };
            object[] giatri = { action, obj.MaNhaCC, obj.TenNhaCC, obj.Diachi, obj.DienThoai, obj.Fax, obj.Email, obj.MST, obj.NguoiDaiDien, obj.IsAction, obj.Nguoilienhe, obj.DienThoaiLH, obj.Ghichu };
            acData.ExcuteStoredProcedure(tenthutuc, thamso, giatri);
        }
        public DataTable SelectExcuteQuyry(LayerBusinessObjec.ObjDMNhaCC obj, string action)
        {
            string tenthutuc = "P_DMNhaCC";
            string[] thamso = { "@action", "@MaNhaCC", "@TenNhaCC", "@Diachi", "@Dienthoai", "@fax", "@Email", "@MST", "@Nguoidaidien", "@isAction", "@NguoiLienHe", "@DienThoaiLH", "@GhiChu" };
            object[] giatri = { action, obj.MaNhaCC, obj.TenNhaCC, obj.Diachi, obj.DienThoai, obj.Fax, obj.Email, obj.MST, obj.NguoiDaiDien, obj.IsAction, obj.Nguoilienhe, obj.DienThoaiLH, obj.Ghichu };
            DataTable dt = acData.ExcuteStoredProcedureselect(tenthutuc, thamso, giatri);
            return dt;
        }
    }
}
