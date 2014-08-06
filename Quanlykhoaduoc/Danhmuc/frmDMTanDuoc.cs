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
    public partial class frmDMTanDuoc : DevExpress.XtraEditors.XtraForm
    {
        public frmDMTanDuoc()
        {
            InitializeComponent();
        }
        string MaTD;
        LayerBusinessLogic.LogicDMTanDuoc lgDMTanduoc = new LayerBusinessLogic.LogicDMTanDuoc();
        LayerBusinessObjec.ObjDMTanDuoc objDMTanDuoc = new LayerBusinessObjec.ObjDMTanDuoc();
        public void truyenthamso()
        {
            objDMTanDuoc.MaTanDuoc = "";
            objDMTanDuoc.TenTanDuoc = "";
        }
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == Stt)
            {
                e.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }
        public void HienthiAll()
        {
            truyenthamso();
            gridControl.DataSource = lgDMTanduoc.SelectExcuteQuyry(objDMTanDuoc, "SelectAll");
        }
        private void frmDMTanDuoc_Load(object sender, EventArgs e)
        {
            HienthiAll();
        }

        private void frmDMTanDuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Danhmuc.frmDMTanDuocAction frm = new frmDMTanDuocAction();
                frm.Nhandata("");
                frm.senderHT = new frmDMTanDuocAction.SendHienthi(HienthiAll);
                frm.ShowDialog();
            }
            if (e.KeyCode == Keys.F3)
            {
                Danhmuc.frmDMTanDuocAction frm = new frmDMTanDuocAction();
                frm.Nhandata(MaTD);
                frm.senderHT = new frmDMTanDuocAction.SendHienthi(HienthiAll);
                frm.ShowDialog();
            }
            if (e.KeyCode == Keys.F4)
            {

            }
            if (e.KeyCode == Keys.F5)
            {

            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                MaTD = gridView1.GetRowCellValue(e.FocusedRowHandle, MaTanDuoc).ToString();
            }
            catch { }
        }

        private void gridControl_DragEnter(object sender, DragEventArgs e)
        {
           
        }
    }
}