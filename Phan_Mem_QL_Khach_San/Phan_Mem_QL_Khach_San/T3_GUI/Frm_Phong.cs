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
    public partial class Frm_Phong : Form
    {
        public Frm_Phong()
        {
            InitializeComponent();
        }

        Phong p = new Phong();
        public void Load_Du_Lieu_Len_Gridview()
        {
            //Load dữ liệu lên Datagridview
            ThuVienKetNoi ketnoi = new ThuVienKetNoi();
            dtgridview_phong.DataSource = ketnoi.GetTable("SELECT * FROM PHONG");
        }
        private void Frm_Phong_Load(object sender, EventArgs e)
        {
            Load_Du_Lieu_Len_Gridview();
        }

        private void dtgridview_phong_SelectionChanged(object sender, EventArgs e)
        {
            txt_maphong.Text = dtgridview_phong.CurrentRow.Cells[0].Value.ToString();
            txt_tenphong.Text = dtgridview_phong.CurrentRow.Cells[1].Value.ToString();
            txt_giaphong.Text = dtgridview_phong.CurrentRow.Cells[2].Value.ToString();
            txt_tinhtrang.Text = dtgridview_phong.CurrentRow.Cells[3].Value.ToString();
            
            ThuVienKetNoi ketnoi = new ThuVienKetNoi();
            cbo_maloaiphong.DataSource = ketnoi.GetTable("select MALOAIP from LOAIPHONG");
            cbo_maloaiphong.DisplayMember = "MALOAIP";
            cbo_maloaiphong.ValueMember = "MALOAIP";
            cbo_maloaiphong.SelectedValue = dtgridview_phong.CurrentRow.Cells[4].Value.ToString();

            txt_ghichu.Text = dtgridview_phong.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(p.Luu_Phong(txt_maphong.Text.Trim(),txt_tenphong.Text.Trim(),txt_giaphong.Text.Trim(),txt_tinhtrang.Text.Trim(),cbo_maloaiphong.SelectedValue.ToString(),txt_ghichu.Text.Trim()))
                MessageBox.Show("Lưu thành công!");
            else
                MessageBox.Show("Lưu không thành công");
            Load_Du_Lieu_Len_Gridview();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_maphong.Enabled == false)
            {
                btn_xoa.Enabled = btn_luu.Enabled = btn_timkiem.Enabled = false;
                txt_maphong.Clear();
                txt_tenphong.Clear();
                txt_giaphong.Clear();
                txt_tinhtrang.Clear();
                txt_ghichu.Clear();
                txt_maphong.Enabled = true;
                txt_maphong.Focus();
            }
            else
            {
                //Thực hiện thêm một dòng mới vào Database
                if (p.Them_Phong(txt_maphong.Text.Trim(), txt_tenphong.Text.Trim(), txt_giaphong.Text.Trim(), txt_tinhtrang.Text.Trim(), cbo_maloaiphong.SelectedValue.ToString().Trim(), txt_ghichu.Text.Trim()) == false)
                {
                    MessageBox.Show("Bị trùng mã, trùng khóa phụ hoặc lỗi khác, không thêm vào được");
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm phòng thành công!");

                    //Mở lại các chức năng
                    btn_xoa.Enabled = btn_luu.Enabled = btn_timkiem.Enabled = true;
                    //Tắt txt ma loai đi
                    txt_maphong.Enabled = true;

                }
                Load_Du_Lieu_Len_Gridview();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phòng này?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (p.Xoa_Phong(dtgridview_phong.CurrentRow.Cells[0].Value.ToString()))
                    MessageBox.Show("Xóa thành công!");
                else
                    MessageBox.Show("Xóa không thành công");
                Load_Du_Lieu_Len_Gridview();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
