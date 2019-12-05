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
    public partial class Frm_LoaiPhong : Form
    {
        public Frm_LoaiPhong()
        {
            InitializeComponent();
        }
        LoaiPhong lp = new LoaiPhong();

        //Hàm load dữ liệu lên Datagridview
        public void LoadDL()
        {
            dtgridview_loaiphong.DataSource = lp.LoadTable("select * from LOAIPHONG");
        }


        private void Frm_LoaiPhong_Load(object sender, EventArgs e)
        {

            LoadDL();
        }

        private void dtgridview_loaiphong_SelectionChanged(object sender, EventArgs e)
        {
            txt_maloai.Text = dtgridview_loaiphong.CurrentRow.Cells[0].Value.ToString();
            txt_tenloaiphong.Text = dtgridview_loaiphong.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_maloai.Enabled == false)
            {
                //Mở lên & clear dữ liệu của các textbox & tắt các chức năng khác
                txt_maloai.Enabled = true;
                txt_maloai.Clear();
                txt_tenloaiphong.Clear();
                btn_xoa.Enabled = btn_luu.Enabled = btn_timkiem.Enabled = false;
            }
            else
            {
                if (lp.Them(txt_maloai.Text.Trim(), txt_tenloaiphong.Text.Trim()))
                    MessageBox.Show("Thêm loại phòng thành công!");
                else
                    MessageBox.Show("Thêm không thành công!");
                LoadDL();

                txt_maloai.Enabled = false;
                btn_xoa.Enabled = btn_luu.Enabled = btn_timkiem.Enabled = true;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lp.Xoa(dtgridview_loaiphong.CurrentRow.Cells[0].Value.ToString().Trim()))
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
            LoadDL();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (lp.Luu(txt_maloai.Text.Trim(), txt_tenloaiphong.Text.Trim()))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại!");
            LoadDL();
        }
    }
}
