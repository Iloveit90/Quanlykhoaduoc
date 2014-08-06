using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Quanlykhoaduoc.Danhmuc
{
    public partial class frmDMTanDuocAction : DevExpress.XtraEditors.XtraForm
    {
        public frmDMTanDuocAction()
        {
            InitializeComponent();
        }
        string MaTD;
        public void Nhandata(string MaTanDuoc)
        {
            MaTD = MaTanDuoc;
        }
        LayerBusinessLogic.LogicDMTanDuoc lgDMTanDuoc = new LayerBusinessLogic.LogicDMTanDuoc();
        LayerBusinessObjec.ObjDMTanDuoc objDMTanDuoc = new LayerBusinessObjec.ObjDMTanDuoc();
        public void truyenthamso()
        {
            objDMTanDuoc.MaTanDuoc = MaTD;
            objDMTanDuoc.TenTanDuoc = txtTenTanDuoc.Text;
        }
        public void HienthiRow()
        {
            try
            {
                truyenthamso();
                DataTable dt = lgDMTanDuoc.SelectExcuteQuyry(objDMTanDuoc, "SelectRow");
                txtTenTanDuoc.Text = dt.Rows[0][1].ToString();
            }
            catch { }
        }
        public delegate void SendHienthi();
        public SendHienthi senderHT;
        private void btLuu_Click(object sender, EventArgs e)
        {
            truyenthamso();
            if (MaTD == "")
                lgDMTanDuoc.ActionExcuteQury(objDMTanDuoc, "Insert");
            else lgDMTanDuoc.ActionExcuteQury(objDMTanDuoc, "Update");
            this.senderHT();
        }

        private void frmDMTanDuocAction_Load(object sender, EventArgs e)
        {
            HienthiRow();
        }

    }
}