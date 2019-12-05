using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phan_Mem_QL_Khach_San.T3_GUI
{
    public partial class Frm_QuiDinh : Form
    {
        public Frm_QuiDinh()
        {
            InitializeComponent();
        }

        private void qUIDINHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qUIDINHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ql_khachsanDataSet);

        }

        private void Frm_QuiDinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ql_khachsanDataSet.QUIDINH' table. You can move, or remove it, as needed.
            this.qUIDINHTableAdapter.Fill(this.ql_khachsanDataSet.QUIDINH);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
