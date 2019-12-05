using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phan_Mem_QL_Khach_San.T1_DATA;
using Phan_Mem_QL_Khach_San.T2_BUSSINESS;

namespace Phan_Mem_QL_Khach_San.T3_GUI
{
    public partial class Frm_DoiMatKhau : Form
    {
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
        }

        private String m_matkhaucu;
        public String matkhaucu
        {
            get { return m_matkhaucu; }
            set { m_matkhaucu = value; }
        }
        private String m_matkhaumoi;
        public String matkhaumoi
        {
            get { return m_matkhaumoi; }
            set { m_matkhaumoi = value; }
        }
        private String m_xacnhanmatkhaumoi;
        public String xacnhanmatkhaumoi
        {
            get { return m_xacnhanmatkhaumoi; }
            set { m_xacnhanmatkhaumoi = value; }
        }

        private void btn_dongy_Click(object sender, EventArgs e)
        {
            this.txt_matkhaucu.Focus();
            m_matkhaucu = this.txt_matkhaucu.Text.Trim();
            m_matkhaumoi = this.txt_matkhaumoi.Text.Trim();
            m_xacnhanmatkhaumoi = this.txt_xacnhanmatkhaumoi.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }
    }
}
