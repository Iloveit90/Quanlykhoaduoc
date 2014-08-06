using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LayerBusinessLogic
{
    public class LogicDMNhaSX
    {
        LayerDataAccess.actionData acData = new LayerDataAccess.actionData();
        public void ActionExcuteQury(LayerBusinessObjec.ObjDMNhaSX obj, string action)
        {
            string tenthutuc = "P_DMNhaSX";
            string[] thamso = { "@action", "@MaNhaSX", "@TenNhaSX" };
            object[] giatri = { action, obj.MaNhaSX, obj.TenNhaSX };
            acData.ExcuteStoredProcedure(tenthutuc, thamso, giatri);
        }
        public DataTable SelectExcuteQuyry(LayerBusinessObjec.ObjDMNhaSX obj, string action)
        {
            string tenthutuc = "P_DMNhaSX";
            string[] thamso = { "@action", "@MaNhaSX", "@TenNhaSX" };
            object[] giatri = { action, obj.MaNhaSX, obj.TenNhaSX };
            DataTable dt = acData.ExcuteStoredProcedureselect(tenthutuc, thamso, giatri);
            return dt;
        }
    }
}
