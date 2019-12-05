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
    public partial class Frm_NguoiDung : Form
    {
        public Frm_NguoiDung()
        {
            InitializeComponent();
        }
        NguoiDung nd = new NguoiDung();
        private void nGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }
        public void Load_Du_Lieu()
        {
            dtgridview_nguoidung.DataSource = nd.Load_Du_Lieu_Len_Girdview();

            cbo_loainguoidung.DataSource = nd.Load_Du_Lieu_Len_CBO();
            cbo_loainguoidung.ValueMember = "LOAINGUOIDUNG";
            cbo_loainguoidung.DisplayMember = "LOAINGUOIDUNG";

            txt_matkhau.Text = dtgridview_nguoidung.CurrentRow.Cells[1].Value.ToString();
        }
        private void Frm_NguoiDung_Load(object sender, EventArgs e)
        {
            Load_Du_Lieu();
        }

        private void dtgridview_nguoidung_SelectionChanged(object sender, EventArgs e)
        {
            txt_tendangnhap.Text = dtgridview_nguoidung.CurrentRow.Cells[0].Value.ToString();
            cbo_loainguoidung.SelectedValue = dtgridview_nguoidung.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //Xóa 1 người dùng
            if (MessageBox.Show("Bạn chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nd.Xoa_Nguoi_Dung(dtgridview_nguoidung.CurrentRow.Cells[0].Value.ToString().Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                else
                    MessageBox.Show("Có lỗi trong quá trình xóa!", "Thông báo");
                Load_Du_Lieu();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_tendangnhap.Enabled == false)
            {
                txt_tendangnhap.Enabled = true;
                txt_tendangnhap.Clear();
                txt_matkhau.Clear();
                btn_xoa.Enabled = btn_luu.Enabled = btn_thoat.Enabled = btn_timkiem.Enabled = false;
            }
            else
            { //Thực hiện thêm một dòng mới vào DB
                if (!nd.Them_Nguoi_Dung(txt_tendangnhap.Text.Trim(),txt_matkhau.Text.Trim(),cbo_loainguoidung.Text))
                {
                    MessageBox.Show("Người dùng này chưa tồn tại trong bảng nhân viên, Có lỗi trong quá trình thêm!", "Thông báo");
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thành công!", "Thông báo");
                    Load_Du_Lieu();
                    txt_tendangnhap.Enabled = false;
                    btn_xoa.Enabled = btn_luu.Enabled = btn_thoat.Enabled = btn_timkiem.Enabled = true;
                }
            }
        }

        private void link_nhanvien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_QLDS_NhanVien nv = new Frm_QLDS_NhanVien();
            nv.Show();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (nd.Luu_Nguoi_Dung(txt_tendangnhap.Text.Trim(), txt_matkhau.Text.Trim(), cbo_loainguoidung.Text.Trim()))
                MessageBox.Show("Lưu thông tin người dùng thành công!");
            else
                MessageBox.Show("Có lỗi trong quá trình lưu!");
            Load_Du_Lieu();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
