using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Phan_Mem_QL_Khach_San.T3_GUI
{
    public partial class Frm_DangNhap : Form
    {
        
        public Frm_DangNhap()
        {
           
            InitializeComponent();
            
        }

        private String m_tendangnhap;
        public String tendangnhap
        {
            get { return m_tendangnhap; }
            set { m_tendangnhap = value; }
        }
        private String m_matkhau;
        public String matkhau
        {
            get { return m_matkhau; }
            set { m_matkhau = value; }
        }

        private void btn_dongy_Click(object sender, System.EventArgs e)
        {
            this.txt_user.Focus();
            m_tendangnhap = this.txt_user.Text;
            m_matkhau = this.txt_pass.Text;
            this.DialogResult = DialogResult.OK;
        }
        private void btn_huy_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
