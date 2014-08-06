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
    public partial class frmDMNhaSXAction : DevExpress.XtraEditors.XtraForm
    {
        public frmDMNhaSXAction()
        {
            InitializeComponent();
        }
        string MaNSX;
        public void nhandata(string NhaSXID)
        {
            MaNSX = NhaSXID;
        }
        LayerBusinessLogic.LogicDMNhaSX lgDMNhaSX = new LayerBusinessLogic.LogicDMNhaSX();
        LayerBusinessObjec.ObjDMNhaSX objDMNhaSX = new LayerBusinessObjec.ObjDMNhaSX();
        public void truyenthamso()
        {
            objDMNhaSX.MaNhaSX = MaNSX;
            objDMNhaSX.TenNhaSX = txtNhaSX.Text;
        }
        public void hienthiRow()
        {
            try
            {
                truyenthamso();
                objDMNhaSX.MaNhaSX = MaNSX;
                DataTable dt = lgDMNhaSX.SelectExcuteQuyry(objDMNhaSX, "SelectRow");
                txtNhaSX.Text = dt.Rows[0][1].ToString();
            }
            catch 
            {
            }
        }
        public delegate void SenhienthiAll();
        public SenhienthiAll Sender;
        private void btLuu_Click(object sender, EventArgs e)
        {
            truyenthamso();
            if (MaNSX == "")
                lgDMNhaSX.ActionExcuteQury(objDMNhaSX, "Insert");
            else lgDMNhaSX.ActionExcuteQury(objDMNhaSX, "Update");
            this.Sender();
            this.Close();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDMNhaSXAction_Load(object sender, EventArgs e)
        {
            hienthiRow();
        }

        private void frmDMNhaSXAction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }


    }
}