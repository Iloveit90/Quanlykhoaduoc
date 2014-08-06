using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Quanlykhoaduoc.Quanlynhapxuat.Xuatkho
{
    public partial class frmChitetxuat : DevExpress.XtraEditors.XtraForm
    {
        public frmChitetxuat()
        {
            InitializeComponent();
        }

        private void frmChitetxuat_Resize(object sender, EventArgs e)
        {
            if (dataGridView.Size.Width > 1210)
            {
                dataGridView.Columns["Tenhang"].Width = (dataGridView.Size.Width - 910) / 2;
                dataGridView.Columns["Mota"].Width = (dataGridView.Size.Width - 910) / 2;
            }
           
        }
    }
}