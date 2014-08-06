using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraTab;


namespace Quanlykhoaduoc
{
    public partial class frmMain : RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            InitSkinGallery();
          
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
          
        }
        static bool checkTabcontrol(DevExpress.XtraTab.XtraTabControl TabControlName, string TabName)
        {
            bool kt = false;
            for (int i = 0; i < TabControlName.TabPages.Count; i++)
            {
                if (TabControlName.TabPages[i].Name == TabName)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        public void addTab(Form frm, string Name, string NameShow)
        {
            DevExpress.XtraTab.XtraTabPage page = new DevExpress.XtraTab.XtraTabPage();
            page.Text = NameShow;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Show();
            page.Name = Name;
            page.Controls.Add(frm);
            tabHienThi.TabPages.Add(page);
            tabHienThi.SelectedTabPage = page;
            frm.Focus();
        }
        public int indexTab(string nameTab)
        {
            int vt = 0;
            for (int i = 0; i < tabHienThi.TabPages.Count; i++)
            {
                if (tabHienThi.TabPages[i].Name == nameTab)
                {
                    vt = i;
                    break;
                }
                continue;

            }
            return vt;
        }
        public void showfrominTab(string NameTab, DevExpress.XtraEditors.XtraForm Namefrom, string captionTab)
        {
            try
            {
                if (checkTabcontrol(tabHienThi, NameTab) == true)
                {
                    int index = indexTab(NameTab);
                    tabHienThi.SelectedTabPage = tabHienThi.TabPages[index];
                    tabHienThi.TabPages[index].Refresh();
                    tabHienThi.Focus();
                }
                else
                {
                    addTab(Namefrom, NameTab, captionTab);
                }
            }
            catch { }
        }
       
        private void frmMain_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Caramel";
        }
        private void btNhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem42_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void splitContainerControl_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
        {
            Danhmuc.frmDMDuocpham frm = new Danhmuc.frmDMDuocpham();
            showfrominTab(frm.Name, frm, frm.Text);
        }

        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDMLoaiDuocPham frm = new frmDMLoaiDuocPham();
            frm.ShowDialog();
        }

        private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
        {
            Danhmuc.frmNhaCC frm = new Danhmuc.frmNhaCC();
            showfrominTab(frm.Name, frm, frm.Text);
        }

        private void tabHienThi_CloseButtonClick(object sender, EventArgs e)
        {
            XtraTabControl TabControl = (XtraTabControl)sender;
            int i = TabControl.SelectedTabPageIndex;
            TabControl.TabPages.RemoveAt(TabControl.SelectedTabPageIndex);
            TabControl.SelectedTabPageIndex = i - 1;
        }

        private void barButtonItem80_ItemClick(object sender, ItemClickEventArgs e)
        {
            Danhmuc.frmDMNhaSX frm = new Danhmuc.frmDMNhaSX ();
           // showfrominTab(frm.Name, frm, frm.Text);
            frm.ShowDialog();

        }

    }
}