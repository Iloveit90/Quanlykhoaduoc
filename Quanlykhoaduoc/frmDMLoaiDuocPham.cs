using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Quanlykhoaduoc
{
    public partial class frmDMLoaiDuocPham : DevExpress.XtraEditors.XtraForm
    {
        public frmDMLoaiDuocPham()
        {
            InitializeComponent();
        }

        private void frmDMLoaiDuocPhamAction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmDMLoaiDuocPhamAction frm = new frmDMLoaiDuocPhamAction();
                frm.nhandata("");
                frm.SenHienthi = new frmDMLoaiDuocPhamAction.SendAction(hienthiAll);
                frm.ShowDialog();
            }
            if (e.KeyCode == Keys.F3)
            {
                frmDMLoaiDuocPhamAction frm = new frmDMLoaiDuocPhamAction();
                frm.nhandata(MaDM);
                frm.SenHienthi = new frmDMLoaiDuocPhamAction.SendAction(hienthiAll);
                frm.ShowDialog();
            }
            if (e.KeyCode == Keys.F4)
            {
                truyenthamso();
                lgDMLoaiDuocPham.ActionExcuteQury(objDMLoaiDuocPham, "Delete");
                hienthiAll();
            }
            if (e.KeyCode == Keys.F5)
            {
                frmDMLoaiDuocPhamAction frm = new frmDMLoaiDuocPhamAction();
                frm.ShowDialog();
            }
        }
        LayerBusinessLogic.LogicDMLoaiDuocPham lgDMLoaiDuocPham = new LayerBusinessLogic.LogicDMLoaiDuocPham();
        LayerBusinessObjec.ObjDMLoaiDuocPham objDMLoaiDuocPham = new LayerBusinessObjec.ObjDMLoaiDuocPham();
        public void truyenthamso()
        {
            objDMLoaiDuocPham.MaDanhMuc = MaDM;
            objDMLoaiDuocPham.TenDanhMuc = "";
           
        }
        public void hienthiAll()
        {
            truyenthamso();
            objDMLoaiDuocPham.MaDanhMuc = "";
            gridControl.DataSource = lgDMLoaiDuocPham.SelectExcuteQuyry(objDMLoaiDuocPham, "SelectAll");
        }
        private void frmDMLoaiDuocPham_Load(object sender, EventArgs e)
        {
            hienthiAll();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == Stt)
            {
                e.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }
        string MaDM;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                MaDM = gridView1.GetRowCellValue(e.FocusedRowHandle, MaDanhMuc).ToString();
            }
            catch { }
        }

    }
}