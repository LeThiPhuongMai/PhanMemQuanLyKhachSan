using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Phan_Mem_QL_Khach_San.T2_BUSSINESS;

namespace Phan_Mem_QL_Khach_San.T3_GUI
{
    public partial class Frm_TraPhong : Form
    {
        WordExport word = new WordExport();
        TraPhong tp = new TraPhong();
        public Frm_TraPhong()
        {
            InitializeComponent();
        }
        string user_nv;
        public void Get_user_nv(string us)
        {
            user_nv = us;
        }
        public void LoadDL_Form()
        {
            if (tp.LoadMAKH_Dang_Thue().Rows.Count != 0)
            {
                txt_manhanvien.Text = tp.GetMaNV(user_nv);

                cbo_makh.DataSource = tp.LoadMAKH_Dang_Thue();
            }
            dtgridview_hoadon.DataSource = tp.LoadDTGridView();
        }
        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }
        private void Frm_TraPhong_Load(object sender, EventArgs e)
        {
            LoadDL_Form();
        }
        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void cbo_makh_SelectedValueChanged(object sender, EventArgs e)
        {

            cbo_maphong.DataSource = tp.LoadMAP_Dang_Thue(cbo_makh.Text.Trim());

            cbo_maphong.DisplayMember = cbo_maphong.ValueMember = "MAP";

            lbl_soluongphongthue.Text = tp.SoLuongPhongThue(cbo_makh.Text.Trim());

            //Load hết số tiền mà khách phải trả
            txt_tongtien.Text = tp.TongTien(cbo_makh.Text.Trim(), Convert.ToDateTime(txt_ngaylap.Value.ToString())).ToString();
          
        }

        private void cbo_maphong_SelectedValueChanged(object sender, EventArgs e)
        {
            //Số ngày
            txt_songay.Text = tp.TinhSoNgay(cbo_maphong.Text.Trim(), Convert.ToDateTime(txt_ngaylap.Value.ToString()));

            //Load số tiền ứng với số ngày ở của phòng đó
            if (cbo_maphong.Text.Trim() != "System.Data.DataRowView")
            {
                txt_thanhtien.Text = (Convert.ToInt32(txt_songay.Text.Trim()) * tp.GiaPhong(cbo_maphong.Text.Trim())).ToString();
            }
        }

        private void txt_songay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_tra_Click(object sender, EventArgs e)
        {
            //Không được bỏ trống trường mã hóa đơn
            if (txt_mahd.Text.Trim() == "")
            {
                MessageBox.Show("Mã hóa đơn không được bỏ trống!");
                return;
            }
            //Thông tin đầy đủ thì thêm vào bảng hóa đơn
            if (tp.ThemHoaDon(txt_mahd.Text.Trim(), txt_manhanvien.Text.Trim(), cbo_makh.Text.Trim() ,float.Parse(txt_tongtien.Text.Trim()), txt_ngaylap.Value.ToString()))
            {
                MessageBox.Show("Thêm vào bảng hóa đơn thành công");
                //Thêm vào bảng chi tiết hóa đơn
                if (tp.ThemChiTietHoaDon(cbo_makh.Text.Trim(), txt_mahd.Text.Trim(), Convert.ToDateTime(txt_ngaylap.Text.Trim())))
                { 
                    MessageBox.Show("Thêm vào bảng chi tiết hóa đơn thành công"); 
                    //Sau khi thêm xong thì xóa bên bảng thuê phòng và chi tiết thuê phòng
                    if (tp.XoaChiTietPhieuThuePhong(cbo_makh.Text.Trim()) && tp.XoaThuePhong(cbo_makh.Text.Trim()))
                    {   
                        //Thay đỗi tình trạng phòng
                        for (int i = 0; i < cbo_maphong.Items.Count; i++)
                        {
                            cbo_maphong.SelectedIndex = i;
                            tp.ThayDoiTinhTrangPhong(cbo_maphong.Text.ToString().Trim());
                        }
                        MessageBox.Show("Thành công!");
                    }
                }
                
            }
            LoadDL_Form();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dtgridview_hoadon.DataSource = tp.LoadDTGridView();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //string mahd = dtgridview_hoadon.CurrentRow.Cells[0].Value.ToString();

            //MessageBox.Show(mahd);
            word.QuyetDinhKhenThuong(txt_mahd.Text);
        }
    }
}
