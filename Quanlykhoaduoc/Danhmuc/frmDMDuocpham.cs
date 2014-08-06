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
    public partial class frmDMDuocpham : DevExpress.XtraEditors.XtraForm
    {
        public frmDMDuocpham()
        {
            InitializeComponent();
        }

        private void frmDMDuocpham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                
            }
            if (e.KeyCode == Keys.F3)
            {

            }
            if (e.KeyCode == Keys.F4)
            {

            }
            if (e.KeyCode == Keys.F5)
            {

            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}