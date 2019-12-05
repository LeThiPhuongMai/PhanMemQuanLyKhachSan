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
    public partial class Frm_ThuePhong : Form
    {
        public Frm_ThuePhong()
        {
            InitializeComponent();
        }

        ThuePhong tp = new ThuePhong();
        
        //Hàm load dữ liệu
        public void LoadDL()
        {
            dtgrid_thuephong.DataSource = tp.dtgrid_thuephong();

            cbo_makh.DataSource = tp.Load_cbo_makh();
            cbo_makh.ValueMember = cbo_makh.DisplayMember = "MAKH";

            cbo_loaiphong.DataSource = tp.Load_cbo_loaiphong();
            cbo_loaiphong.ValueMember = "MALOAIP";

        }

        private void Frm_ThuePhong_Load(object sender, EventArgs e)
        {
            LoadDL();

        }

        private void btn_themkh_Click(object sender, EventArgs e)
        {
            Frm_KhachHang kh = new Frm_KhachHang();
            kh.Show();
        }

        private void btn_themphong_Click(object sender, EventArgs e)
        {
            Frm_Phong p = new Frm_Phong();
            p.Show();
        }

        private void cbo_makh_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_tenkh.Text = tp.Get_txt_tenkh(cbo_makh.Text.Trim());
            txt_cmnd.Text = tp.Get_txt_cmnd(cbo_makh.Text.Trim());
        }

        private void cbo_maphong_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_giaphong.Text = tp.Get_txt_giaphong(cbo_maphong.Text.Trim());
        }

        private void cbo_loaiphong_SelectedValueChanged(object sender, EventArgs e)
        {
            cbo_maphong.DataSource = tp.Load_cbo_maphong(cbo_loaiphong.Text.Trim());
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //Nếu không nhập mã phiếu thuê thì không được thuê
            if (txt_maphieuthue.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu thuê không được bỏ trống!","Thông báo");
                return;
            }
            //Lưu mã phiếu thuê và khách hàng vào PHIEUTHUEPHONG
            if (tp.Luu_PHIEUTHUEPHONG(txt_maphieuthue.Text.Trim(), cbo_makh.Text.Trim()))
            {
                MessageBox.Show("Lưu mã phiếu thuê thành công!","Thông báo");

                //Lưu chi tiết phiếu thuê phòng
                if (tp.Luu_CHITIETPHIEUTHUEPHONG(txt_maphieuthue.Text.Trim(),cbo_maphong.Text.Trim(),txt_ngaynhan.Value.ToString()))
                {
                    MessageBox.Show("Thêm chi tiết phiếu thuê phòng thành công!","Thông báo");

                    //Lưu thành công rồi thì thay đổi tình trạng phòng từ phòng TRỐNG thành ĐẶT
                    if (tp.Luu_TINHTRANGPHONG(cbo_maphong.Text.Trim()))
                        MessageBox.Show("Thay đổi tình trạng phòng từ trống sang đặt thành công!","Thông báo");
                }
            }
            else
                MessageBox.Show("Đặt phòng không thành công","Thông báo");
            LoadDL();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            LoadDL();
        }
///////////test tim kiem///////////////////////
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_DSKHThuePhong dskh_thuephong = new Frm_DSKHThuePhong();
            dskh_thuephong.Show();
            
        }

        private void dtgrid_thuephong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //this.Close();
        }
    }
}
