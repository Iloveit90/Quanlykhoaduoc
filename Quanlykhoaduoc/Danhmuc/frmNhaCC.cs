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
    public partial class frmNhaCC : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCC()
        {
            InitializeComponent();
        }
        LayerBusinessLogic.LogicDMNhaCC lgDMNhaCC = new LayerBusinessLogic.LogicDMNhaCC();
        LayerBusinessObjec.ObjDMNhaCC objDMNhaCC = new LayerBusinessObjec.ObjDMNhaCC();
       
        public void truyenthamso()
        {
            objDMNhaCC.MaNhaCC = "";
            objDMNhaCC.TenNhaCC = "";
            objDMNhaCC.Diachi = "";
            objDMNhaCC.DienThoai = "";
            objDMNhaCC.Fax = "";
            objDMNhaCC.DienThoaiLH = "";
            objDMNhaCC.MST = "";
            objDMNhaCC.NguoiDaiDien = "";
            objDMNhaCC.Nguoilienhe = "";
            objDMNhaCC.IsAction = "";
            objDMNhaCC.Email = "";
            objDMNhaCC.Ghichu = "";

        }
        public void hienthiAll()
        {
            truyenthamso();
            gridControl.DataSource = lgDMNhaCC.SelectExcuteQuyry(objDMNhaCC, "SelectAll");
        }
        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            hienthiAll();
        }

        private void frmNhaCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Danhmuc.frmNhaCCAction frm = new frmNhaCCAction();
                frm.NhanData("");
                frm.sender = new frmNhaCCAction.SenhienthiAll(hienthiAll);
                frm.ShowDialog(); 
            }
            if (e.KeyCode == Keys.F3)
            {
                Danhmuc.frmNhaCCAction frm = new frmNhaCCAction();
                frm.NhanData("");
                frm.sender = new frmNhaCCAction.SenhienthiAll(hienthiAll);
                frm.ShowDialog(); 
            }
            if (e.KeyCode == Keys.F4)
            {

            }
            if (e.KeyCode == Keys.F5)
            {

            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == Stt)
            {
                e.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }
        string MaNCC;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                MaNCC = gridView1.GetRowCellValue(e.FocusedRowHandle, MaNhaCC).ToString();
            }
            catch { }
        }
    }
}