using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace LayerBusinessLogic
{
    public class LogicDMLoaiDuocPham
    {
        LayerDataAccess.actionData acData = new LayerDataAccess.actionData();
        public void ActionExcuteQury(LayerBusinessObjec.ObjDMLoaiDuocPham obj, string action)
        {
            string tenthutuc = "P_DMLoaiDuocPham";
            string[] thamso = { "@action", "@MaDanhMuc", "@TenDanhMuc"};
            object[] giatri = { action, obj.MaDanhMuc, obj.TenDanhMuc };
            acData.ExcuteStoredProcedure(tenthutuc, thamso, giatri);
        }
        public DataTable SelectExcuteQuyry(LayerBusinessObjec.ObjDMLoaiDuocPham obj, string action)
        {
            string tenthutuc = "P_DMLoaiDuocPham";
            string[] thamso = { "@action", "@MaDanhMuc","@TenDanhMuc" };
            object[] giatri = { action, obj.MaDanhMuc, obj.TenDanhMuc };
            DataTable dt = acData.ExcuteStoredProcedureselect(tenthutuc, thamso, giatri);
            return dt;
        }
    }
}
