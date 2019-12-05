using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Phan_Mem_QL_Khach_San.T1_DATA;
using Phan_Mem_QL_Khach_San.T2_BUSSINESS;

namespace Phan_Mem_QL_Khach_San.T3_GUI
{
    public partial class Frm_HoaDon : Form
    {
        public Frm_HoaDon()
        {
            InitializeComponent();
        }

        HoaDon hd = new HoaDon();
        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Frm_HoaDon_Load(object sender, EventArgs e)
        {
            dgv_hoadon.DataSource = hd.LoadDL();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Frm_TraPhong tp = new Frm_TraPhong();
            tp.Show();
        }

        private void btn_hoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
