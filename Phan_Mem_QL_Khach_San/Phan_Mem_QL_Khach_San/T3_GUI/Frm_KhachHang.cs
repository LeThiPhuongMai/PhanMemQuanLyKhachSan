using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Phan_Mem_QL_Khach_San.T2_BUSSINESS;
using Phan_Mem_QL_Khach_San.T1_DATA;

namespace Phan_Mem_QL_Khach_San.T3_GUI
{
    public partial class Frm_KhachHang : Form
    {

        KhachHang bllkh = new KhachHang();
        public Frm_KhachHang()
        {
            InitializeComponent();
        }
        
        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllkh.LoadDL();
            
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            this.Close();
        }


        private void Them_Click(object sender, EventArgs e)
        {
            //Nếu txt_makh vẫn là Enable=false thì cho nó hiện lên, còn ngược lại thì thêm vô
            if (txt_makh.Enabled == false)
            {
                txt_makh.Enabled = true;
                btn_timkiem.Enabled = true;
                Xoa.Enabled = Luu.Enabled = btn_in.Enabled = false;
                txt_makh.Clear();
                txt_sdt.Clear();
                txt_cmnd.Clear();
                txt_dc.Clear();
                txt_tenkh.Clear();
                txt_makh.Focus();
            }
            else
            {
                KHACHHANG kh = new KHACHHANG();
                kh.MAKH = txt_makh.Text;
                kh.TENKH = txt_tenkh.Text;
                kh.CMDN = txt_cmnd.Text;
                kh.SDT = txt_sdt.Text;
                kh.DIACHI = txt_dc.Text;
                if (rdo_nam.Checked == true)
                    kh.GIOITINH = "Nam";
                else
                    kh.GIOITINH = "Nữ";

                if (!bllkh.Them(kh))
                {
                    MessageBox.Show("Mã khách hàng bị trùng, mời bạn nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txt_makh.Enabled = false;
                    Xoa.Enabled = Luu.Enabled = btn_in.Enabled = btn_timkiem.Enabled = true;
                }
                dataGridView1.DataSource = bllkh.LoadDL();
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            string makh = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if(bllkh.Xoa(makh))
                    MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            dataGridView1.DataSource = bllkh.LoadDL();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txt_makh.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_tenkh.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_cmnd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_sdt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_dc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim() == "NAM")
                rdo_nam.Checked = true;
            else
                rdo_nu.Checked = true;
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            string makh = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            string pMaKhachHang = txt_makh.Text;
            string pTenKH = txt_tenkh.Text;
            string pcmnd = txt_cmnd.Text;
            string psdt = txt_sdt.Text;
            string pdiachi = txt_dc.Text;
            string pgioitinh;
            if (rdo_nam.Checked == true)
                pgioitinh = "NAM";
            else
                pgioitinh = "NỮ";
            if (bllkh.Sua(pMaKhachHang, pTenKH, pcmnd, psdt, pdiachi, pgioitinh))
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            dataGridView1.DataSource = bllkh.LoadDL();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            using (KhachHangDataContext _qlks = new KhachHangDataContext())
            {
                dataGridView1.DataSource = _qlks.KHACHHANGs.Where(p => p.CMDN.Equals(textBox1.Text));
            }
        }
    }
}
