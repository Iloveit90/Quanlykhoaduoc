using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LayerBusinessLogic
{
    public class LogicDMTanDuoc
    {
        LayerDataAccess.actionData acData = new LayerDataAccess.actionData();
        public void ActionExcuteQury(LayerBusinessObjec.ObjDMTanDuoc obj, string action)
        {
            string tenthutuc = "P_DMTanDuoc";
            string[] thamso = { "@action", "@MaTanDuoc", "@TenTanDuoc" };
            object[] giatri = { action, obj.MaTanDuoc, obj.TenTanDuoc };
            acData.ExcuteStoredProcedure(tenthutuc, thamso, giatri);
        }
        public DataTable SelectExcuteQuyry(LayerBusinessObjec.ObjDMTanDuoc obj, string action)
        {
            string tenthutuc = "P_DMTanDuoc";
            string[] thamso = { "@action", "@MaTanDuoc", "@TenTanDuoc" };
            object[] giatri = { action, obj.MaTanDuoc, obj.TenTanDuoc };
            DataTable dt = acData.ExcuteStoredProcedureselect(tenthutuc, thamso, giatri);
            return dt;
        }
    }
}
