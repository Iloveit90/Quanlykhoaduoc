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
    public partial class frmDMNhaSX : DevExpress.XtraEditors.XtraForm
    {

        public frmDMNhaSX()
        {
            InitializeComponent();
        }
        LayerBusinessLogic.LogicDMNhaSX lgDMNhaSX = new LayerBusinessLogic.LogicDMNhaSX();
        LayerBusinessObjec.ObjDMNhaSX objDMNhaSX = new LayerBusinessObjec.ObjDMNhaSX();
        public void truyenthamso()
        {
            objDMNhaSX.MaNhaSX = "";
            objDMNhaSX.TenNhaSX = "";
        }
        public void hienthiAll()
        {
            truyenthamso();
            gridControl.DataSource = lgDMNhaSX.SelectExcuteQuyry(objDMNhaSX, "SelectAll");
        }
        private void frmDMNhaSX_Load(object sender, EventArgs e)
        {
            hienthiAll();
        }

        private void frmDMNhaSX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Danhmuc.frmDMNhaSXAction frm = new frmDMNhaSXAction();
                frm.nhandata("");
                frm.Sender = new frmDMNhaSXAction.SenhienthiAll(hienthiAll);
                frm.ShowDialog();
            }
            if (e.KeyCode == Keys.F3)
            {
                Danhmuc.frmDMNhaSXAction frm = new frmDMNhaSXAction();
                frm.nhandata(MaNSX);
                frm.Sender = new frmDMNhaSXAction.SenhienthiAll(hienthiAll);
                frm.ShowDialog();
            }
            if (e.KeyCode == Keys.F4)
            {
                try
                {
                    truyenthamso();
                    objDMNhaSX.MaNhaSX = MaNSX;
                    lgDMNhaSX.ActionExcuteQury(objDMNhaSX, "Delete");
                    hienthiAll();
                }
                catch 
                {
                }
            }
            if (e.KeyCode == Keys.F5)
            {
                MessageBox.Show("Chức năng đang được câng cấp");
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == Stt)
            {
                e.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }
        string MaNSX;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                MaNSX = gridView1.GetRowCellValue(e.FocusedRowHandle, MaNhaSX).ToString();
            }
            catch 
            {
            }
        }
    }
}