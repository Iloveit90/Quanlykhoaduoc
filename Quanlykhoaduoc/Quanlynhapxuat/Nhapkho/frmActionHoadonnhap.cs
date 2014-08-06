using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlykhoaduoc.Quanlynhapxuat.Nhapkho
{
    public partial class frmActionHoadonnhap : Form
    {
        public frmActionHoadonnhap()
        {
            InitializeComponent();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmActionHoadonnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
