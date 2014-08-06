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
    public partial class frmDMDuocphamAction : DevExpress.XtraEditors.XtraForm
    {
        public frmDMDuocphamAction()
        {
            InitializeComponent();
        }
        LayerBusinessLogic.LogicDMDuocPham lgDMDuocPham = new LayerBusinessLogic.LogicDMDuocPham();
        LayerBusinessObjec.ObjDMDuocPham objDMDuocPham = new LayerBusinessObjec.ObjDMDuocPham();
        LayerBusinessObjec.ObjDMLoaiDuocPham objDMLoaiDuocpham = new LayerBusinessObjec.ObjDMLoaiDuocPham();
        LayerBusinessLogic.LogicDMLoaiDuocPham lgDMLoaiDuocPham = new LayerBusinessLogic.LogicDMLoaiDuocPham();
        LayerBusinessLogic.LogicDMNhaSX lgDMNhaSX = new LayerBusinessLogic.LogicDMNhaSX();
        LayerBusinessObjec.ObjDMNhaSX objDMNhaSX = new LayerBusinessObjec.ObjDMNhaSX();
        LayerBusinessLogic.LogicDMDuongDung lgDMDuongDung = new LayerBusinessLogic.LogicDMDuongDung();
        LayerBusinessObjec.ObjDMDuongDung objDMDuongDung = new LayerBusinessObjec.ObjDMDuongDung();
        LayerBusinessObjec.ObjDMDonViTinh objDMDonViTinh = new LayerBusinessObjec.ObjDMDonViTinh();
        LayerBusinessLogic.LogicDMDonViTinh lgDMDonViTinh = new LayerBusinessLogic.LogicDMDonViTinh();
        LayerBusinessLogic.LogicDMTanDuoc lgDMTanDuoc = new LayerBusinessLogic.LogicDMTanDuoc();
        LayerBusinessObjec.ObjDMTanDuoc objDMTanDuoc = new LayerBusinessObjec.ObjDMTanDuoc();

        public void HienthiDMLoaiduocpham()
        {
            objDMLoaiDuocpham.MaDanhMuc = "";
            objDMLoaiDuocpham.TenDanhMuc = "";
            cbLoaiDuocPham.Properties.DataSource = lgDMLoaiDuocPham.SelectExcuteQuyry(objDMLoaiDuocpham, "SelectAll");
            cbLoaiDuocPham.Properties.DisplayMember = "TenDanhMuc";
            cbLoaiDuocPham.Properties.ValueMember = "MaDanhMuc";
            cbLoaiDuocPham.EditValue = "MaDanhMuc";
        }
        public void HienthiDMNhaSX()
        {
            objDMNhaSX.MaNhaSX = "";
            objDMNhaSX.TenNhaSX = "";
            cbNhaSX.Properties.DataSource = lgDMNhaSX.SelectExcuteQuyry(objDMNhaSX,"SelectAll");
            cbNhaSX.Properties.DisplayMember = "TenNhaSX";
            cbNhaSX.Properties.ValueMember = "MaNhaSX";
            cbNhaSX.EditValue = "MaNhaSX";
        }
        public void HienthiDMDuongDung()
        {
            objDMDuongDung.MaDuongDung = "";
            objDMDuongDung.TenDuongDung = "";
            cbDuongdung.Properties.DataSource = lgDMDuongDung.SelectExcuteQuyry(objDMDuongDung, "SelectAll");
            cbDuongdung.Properties.DisplayMember = "TenDuongDung";
            cbDuongdung.Properties.ValueMember = "MaDuongDung";
        }
        public void HienthiDMDonViTinh()
        {
            objDMDonViTinh.MaDonViTinh = "";
            objDMDonViTinh.TenDonViTinh = "";
            cbDonViTinh.Properties.DataSource = lgDMDonViTinh.SelectExcuteQuyry(objDMDonViTinh, "SelectAll");
            cbDonViTinh.Properties.DisplayMember = "TenDonViTinh";
            cbDonViTinh.Properties.ValueMember = "MaDonViTinh";
        }
        public void HienthiDMTanDuoc()
        {
            objDMTanDuoc.MaTanDuoc = "";
            objDMTanDuoc.TenTanDuoc = "";
            cbNhomtanduoc.Properties.DataSource = lgDMTanDuoc.SelectExcuteQuyry(objDMTanDuoc, "SelectAll");
            cbNhomtanduoc.Properties.DisplayMember = "TenTanDuoc";
            cbNhomtanduoc.Properties.ValueMember = "MaTanduoc";
        }
        public void AlowControl(bool kt)
        {
                cbNhomtanduoc.Enabled = kt;
                txtManhomduocly.Enabled = kt;
                txtThanhphanhamluong.Enabled = kt;
                cbDuongdung.Enabled = kt;
                txtSodangky.Enabled = kt;
                txtDangbaoche.Enabled = kt;
                groupBaohiem.Enabled = kt;
                groupCPThaythe.Enabled = kt;
                groupDonChat.Enabled = kt;
                groupKTG.Enabled = kt;
                groupTubaoche.Enabled = kt;
        }
        public void truyenthamso()
        {
            objDMDuocPham.MaDuocPham = txtMaduocpham.Text;
            //objDMDuocPham.MaDanhMuc = cbLoaiduocpham.
        }
        public void hienthiRow()
        {
            try
            {
                
            }
            catch 
            {
            }
        }
        
        private void frmDMDuocphamAction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void frmDMDuocphamAction_Load(object sender, EventArgs e)
        {
            HienthiDMLoaiduocpham();
            HienthiDMDonViTinh();
            HienthiDMNhaSX();
            HienthiDMDuongDung();
            HienthiDMTanDuoc();
        }
        private void cbLoaiDuocPham_EditValueChanged(object sender, EventArgs e)
        {
            object MaDP = cbLoaiDuocPham.EditValue;
            try
            {
                if (MaDP.ToString() == "0")
                    AlowControl(true);
                else AlowControl(false);
            }
            catch {
               // MessageBox.Show("Vui lòng chọn nhóm tân dược");
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtTenduocpham.Text);
        }

        private void cbNhomtanduoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Danhmuc.frmDMTanDuoc frm = new frmDMTanDuoc();
                
                frm.ShowDialog();
            }
        }

        private void radioTrueKTG_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTrueKTG.Checked == true)
                radioFaleKTG.Checked = false;
            else radioFaleKTG.Checked = true;
        }

        private void radioFaleKTG_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTrueKTG.Checked == true)
                radioFaleKTG.Checked = false;
            else radioFaleKTG.Checked = true;
        }
    }
}