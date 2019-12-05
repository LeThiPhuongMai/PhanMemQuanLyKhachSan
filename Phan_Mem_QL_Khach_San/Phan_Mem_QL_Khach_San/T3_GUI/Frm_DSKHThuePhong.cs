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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Phan_Mem_QL_Khach_San.T3_GUI
{
    public partial class Frm_DSKHThuePhong : Form
    {   
        public Frm_DSKHThuePhong()
        {
            InitializeComponent();
        }

        
        DSKHThuePhong ds = new DSKHThuePhong();
        private void Frm_DSSKhachHang_Load(object sender, EventArgs e)
        {
            dtgridview_danhsach.DataSource =  ds.LoadDL();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pHIEUTHUEPHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pHIEUTHUEPHONGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void btn_tk_Click(object sender, EventArgs e)
        {

            dtgridview_danhsach.DataSource = ds.LoadDL(txt_search.Text.Trim());
  
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dtgridview_danhsach.DataSource = ds.LoadDL();
        }

    }
}
