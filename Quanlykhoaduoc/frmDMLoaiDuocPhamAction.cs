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
    public partial class frmDMLoaiDuocPhamAction : DevExpress.XtraEditors.XtraForm
    {
        public frmDMLoaiDuocPhamAction()
        {
            InitializeComponent();
        }
        LayerBusinessLogic.LogicDMLoaiDuocPham lgDMLoaiduocpham = new LayerBusinessLogic.LogicDMLoaiDuocPham();
        LayerBusinessObjec.ObjDMLoaiDuocPham objDMloaiduocpham = new LayerBusinessObjec.ObjDMLoaiDuocPham();
        string maloaiduocpham;
        public void nhandata(string Maloai)
        {
            maloaiduocpham = Maloai;
        }
        public void truyenthamso()
        {
            objDMloaiduocpham.MaDanhMuc = maloaiduocpham;
            objDMloaiduocpham.TenDanhMuc = cbLoaiDuocpham.Text;
           
        }
        public void hienthi()
        {
            try
            {
                truyenthamso();
                DataTable dt = lgDMLoaiduocpham.SelectExcuteQuyry(objDMloaiduocpham, "SelectRow");
              
                cbLoaiDuocpham.SelectedText = dt.Rows[0][1].ToString();
            }
            catch 
            {
                cbLoaiDuocpham.Text = "";
            }
        }
        public delegate void SendAction();
        public SendAction SenHienthi;

        private void btLuu_Click(object sender, EventArgs e)
        {
            truyenthamso();
            if (maloaiduocpham == "")
            {
                objDMloaiduocpham.MaDanhMuc = cbLoaiDuocpham.SelectedIndex.ToString();
                lgDMLoaiduocpham.ActionExcuteQury(objDMloaiduocpham, "Insert");
            }
            else
                lgDMLoaiduocpham.ActionExcuteQury(objDMloaiduocpham, "Update");
            this.SenHienthi();
            this.Close();
        }

        private void frmDMLoaiDuocPhamAction_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void frmDMLoaiDuocPhamAction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        
    }
}