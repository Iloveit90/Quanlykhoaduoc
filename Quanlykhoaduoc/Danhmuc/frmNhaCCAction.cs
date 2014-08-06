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
    public partial class frmNhaCCAction : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCCAction()
        {
            InitializeComponent();
        }
        string MaNCC;
        public void NhanData(string maso)
        {
            MaNCC = maso;
        }
        LayerBusinessLogic.LogicDMNhaCC lgDMNhaCc = new LayerBusinessLogic.LogicDMNhaCC();
        LayerBusinessObjec.ObjDMNhaCC objDMNhaCC = new LayerBusinessObjec.ObjDMNhaCC();
        public void truyenthamso()
        {
            objDMNhaCC.MaNhaCC = MaNCC;
            objDMNhaCC.TenNhaCC = txtTenNhaCC.Text;
            objDMNhaCC.Diachi = txtDiachi.Text;
            objDMNhaCC.DienThoai = txtSoDienthoai.Text;
            objDMNhaCC.Fax = txtSofax.Text;
            objDMNhaCC.Email = txtEmail.Text;
            objDMNhaCC.NguoiDaiDien = txtNguoidaidien.Text;
            objDMNhaCC.Nguoilienhe = txtNguoilienhe.Text;
            objDMNhaCC.DienThoaiLH = txtDienthoailienhe.Text;
            objDMNhaCC.MST = txtMST.Text;
            objDMNhaCC.Ghichu = txtGhichu.Text;
            if (radioFaleAction.Checked == true)
            {
                objDMNhaCC.IsAction = "False";
            }
            else objDMNhaCC.IsAction = "True";
        }
        public void hienthiRows()
        {
            try
            {
                truyenthamso();
                DataTable dt = lgDMNhaCc.SelectExcuteQuyry(objDMNhaCC, "SelectRow");
                objDMNhaCC.TenNhaCC = dt.Rows[0][1].ToString();
                objDMNhaCC.Diachi = dt.Rows[0][2].ToString();
                objDMNhaCC.DienThoai = dt.Rows[0][3].ToString();
                objDMNhaCC.Fax = dt.Rows[0][4].ToString();
                objDMNhaCC.Email = dt.Rows[0][5].ToString();
                objDMNhaCC.MST = dt.Rows[0][6].ToString();
                objDMNhaCC.NguoiDaiDien = dt.Rows[0][7].ToString();
                if (dt.Rows[0][8].ToString() == "true")
                {
                    radioTrueAction.Checked = true;
                }
                else radioFaleAction.Checked = true;
                objDMNhaCC.Nguoilienhe = dt.Rows[0][9].ToString();
                objDMNhaCC.DienThoaiLH = dt.Rows[0][10].ToString();
                objDMNhaCC.Ghichu = dt.Rows[0][11].ToString();
            }
            catch 
            {
            }
        }
        private void frmNhaCCAction_KeyDown(object sender, KeyEventArgs e)
        {

        }
        public delegate void SenhienthiAll();
        public SenhienthiAll sender;
        private void btLuu_Click(object sender, EventArgs e)
        {
            truyenthamso();
            if (MaNCC == "")
                lgDMNhaCc.ActionExcuteQury(objDMNhaCC, "Insert");
            else
                lgDMNhaCc.ActionExcuteQury(objDMNhaCC, "Update");
            this.sender();
            this.Close();
        }

        private void frmNhaCCAction_Load(object sender, EventArgs e)
        {
            hienthiRows();
        }

    }
}