using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LayerBusinessLogic
{
    public class LogicDMDonViTinh
    {
        LayerDataAccess.actionData acData = new LayerDataAccess.actionData();
        public void ActionExcuteQury(LayerBusinessObjec.ObjDMDonViTinh obj, string action)
        {
            string tenthutuc = "P_DMDonViTinh";
            string[] thamso = { "@action", "@MaDonViTinh", "@TenDonViTinh" };
            object[] giatri = { action, obj.MaDonViTinh, obj.TenDonViTinh };
            acData.ExcuteStoredProcedure(tenthutuc, thamso, giatri);
        }
        public DataTable SelectExcuteQuyry(LayerBusinessObjec.ObjDMDonViTinh obj, string action)
        {
            string tenthutuc = "P_DMDonViTinh";
            string[] thamso = { "@action", "@MaDonViTinh", "@TenDonViTinh" };
            object[] giatri = { action, obj.MaDonViTinh, obj.TenDonViTinh };
            DataTable dt = acData.ExcuteStoredProcedureselect(tenthutuc, thamso, giatri);
            return dt;
        }
    }
}
