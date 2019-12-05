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
    public partial class Frm_QLDS_NhanVien : Form
    {
        public Frm_QLDS_NhanVien()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        public void Load_Du_Lieu()
        {
            ThuVienKetNoi ketnoi = new ThuVienKetNoi();
            dtgridview_nhanvien.DataSource = ketnoi.GetTable("SELECT * FROM NHANVIEN");
        }

        private void Frm_QLDS_NhanVien_Load(object sender, EventArgs e)
        {
            Load_Du_Lieu();

            cbo_gioitinh.Items.Add("NAM");
            cbo_gioitinh.Items.Add("NỮ");
        }

        private void dtgridview_nhanvien_SelectionChanged(object sender, EventArgs e)
        {
            txt_manhanvien.Text = dtgridview_nhanvien.CurrentRow.Cells[0].Value.ToString();
            txt_tennhanvien.Text = dtgridview_nhanvien.CurrentRow.Cells[1].Value.ToString();
            txt_sdt.Text = dtgridview_nhanvien.CurrentRow.Cells[2].Value.ToString();
            txt_diachi.Text = dtgridview_nhanvien.CurrentRow.Cells[3].Value.ToString();
            cbo_gioitinh.Text = dtgridview_nhanvien.CurrentRow.Cells[4].Value.ToString();
            txt_tendangnhap.Text = dtgridview_nhanvien.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //Nếu txt_them đang làm false thì bật lên
            if (txt_manhanvien.Enabled == false)
            {
                //Clear các ô để nhập giá trị vào
                txt_manhanvien.Enabled = true;
                txt_manhanvien.Clear();
                txt_tennhanvien.Clear();
                txt_sdt.Clear();
                txt_diachi.Clear();
                txt_tendangnhap.Clear();

                //Tắt các chức năng khác
                btn_xoa.Enabled = btn_luu.Enabled = btn_timkiem.Enabled = false;
            }
            else
            { //Thực hiện thêm một dòng mới vào DB
                if (!nv.Them_NhanVien(txt_manhanvien.Text.Trim(),txt_tennhanvien.Text.Trim(),txt_sdt.Text.Trim(),txt_diachi.Text.Trim(),cbo_gioitinh.Text.Trim(),txt_tendangnhap.Text.Trim()))
                {//Thông báo không thành công
                    MessageBox.Show("Có lỗi trong quá trình thêm, có thể thiếu trường, trùng mã các thứ!!", "Thông báo");
                    return;
                }
                else
                {//Thông báo thành công
                    MessageBox.Show("Thêm người dùng thành công!", "Thông báo");
                    Load_Du_Lieu();
                    txt_manhanvien.Enabled = false;
                    btn_xoa.Enabled = btn_luu.Enabled = btn_timkiem.Enabled = true;
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //Xóa 1 nhân viên
            if (MessageBox.Show("Bạn chắc chắn xóa không?", "Dich Vu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nv.Xoa_Nhan_Vien(dtgridview_nhanvien.CurrentRow.Cells[0].Value.ToString().Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                else
                    MessageBox.Show("Có lỗi trong quá trình xóa!", "Thông báo");
                Load_Du_Lieu();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (nv.Luu_Nhan_Vien(txt_manhanvien.Text.Trim(), txt_tennhanvien.Text.Trim(), txt_sdt.Text.Trim(), txt_diachi.Text.Trim(), cbo_gioitinh.Text.Trim(), txt_tendangnhap.Text.Trim()))
                MessageBox.Show("Lưu thông tin nhân viên thành công!");
            else
                MessageBox.Show("Có lỗi trong quá trình lưu!");
            Load_Du_Lieu();
        }
    }
}
