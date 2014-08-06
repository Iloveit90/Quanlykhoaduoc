using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LayerBusinessLogic
{
    public class LogicDMDuongDung
    {
        LayerDataAccess.actionData acData = new LayerDataAccess.actionData();
        public void ActionExcuteQury(LayerBusinessObjec.ObjDMDuongDung obj, string action)
        {
            string tenthutuc = "P_DMDuongDung";
            string[] thamso = { "@action", "@MaDuongDung", "@TenDuongDung"};
            object[] giatri = { action, obj.MaDuongDung, obj.TenDuongDung};
            acData.ExcuteStoredProcedure(tenthutuc, thamso, giatri);
        }
        public DataTable SelectExcuteQuyry(LayerBusinessObjec.ObjDMDuongDung obj, string action)
        {
            string tenthutuc = "P_DMDuongDung";
            string[] thamso = { "@action", "@MaDuongDung", "@TenDuongDung" };
            object[] giatri = { action, obj.MaDuongDung, obj.TenDuongDung };
            DataTable dt = acData.ExcuteStoredProcedureselect(tenthutuc, thamso, giatri);
            return dt;
        }
    }
}
