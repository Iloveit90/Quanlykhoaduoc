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
    public partial class frmSeach : DevExpress.XtraEditors.XtraForm
    {
        public frmSeach()
        {
            InitializeComponent();
        }
        public delegate void sen(string Ten, string kieu);
        public sen sender;

        private void frmSearch_Load(object sender, EventArgs e)
        {

        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            string kieu;
            if (radioBD.Checked == true)
            {
                kieu = "Batdau";
            }
            else kieu = "Chuatrong";
            this.sender(txtTenmon.Text, kieu);
            this.Close();
        }

        private void frmSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}