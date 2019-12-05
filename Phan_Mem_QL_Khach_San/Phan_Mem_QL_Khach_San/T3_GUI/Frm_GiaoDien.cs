using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phan_Mem_QL_Khach_San.T2_BUSSINESS;
using Phan_Mem_QL_Khach_San.T1_DATA;

namespace Phan_Mem_QL_Khach_San.T3_GUI
{
    public partial class Frm_GiaoDien : Form
    {
        public Frm_GiaoDien()
        {
            InitializeComponent();
            
        }

        Frm_DangNhap dangnhap = null;
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {

            TiepTuc:
            if (dangnhap == null || dangnhap.IsDisposed)
            {
                dangnhap = new Frm_DangNhap();
            }
            if (dangnhap.ShowDialog() == DialogResult.OK)
            {
                String tendangnhap = dangnhap.tendangnhap;
                String matKhau = dangnhap.matkhau;
                DangNhap dn = new DangNhap();
                int KetQua = dn.KiemTraDangNhap(tendangnhap, matKhau);
                switch (KetQua)
                {
                    case 0:
                        MessageBox.Show("Không tồn tại người dùng trong hệ thống");
                        goto TiepTuc;

                    case 1:
                        MessageBox.Show("Mật khẩu sai");
                        goto TiepTuc;

                    case 2:
                        MessageBox.Show("Đăng nhập thành công");
                        if (dn.is_admin(tendangnhap))
                            PQ_Admin();
                        else
                            PQ_User();
                        lbl_tennguoidung.Text = tendangnhap;
                        break;
                }
            }
            else this.Close();
        }
        public void PQ_Default()
        {
            this.btnThanhToan.Enabled = false;
            this.btnLoaiPhong.Enabled = false;
            this.buttonItemLoaiPhong.Enabled = false;
            this.btn_dangky.Enabled = false;
            this.buttonDangNhap.Enabled = true;
            this.buttonDangXuat.Enabled = false;
            this.buttonDoiMatKhau.Enabled = false;
            this.buttonHuongDan.Enabled = false;
            this.buttonKHThuephong.Enabled = false;
            this.buttonNguoiDung.Enabled = false;
            this.btn_phong.Enabled = false;
            this.buttonQuiDinh.Enabled = false;
            this.BTN_KHACHHANG.Enabled = false;
            this.btn_traphong.Enabled = false;
            this.btnDoanhThu.Enabled = false;
            this.btn_chietsuat.Enabled = false;
            
        }
        public void PQ_Admin()
        {
            this.btnThanhToan.Enabled = true;
            this.btnLoaiPhong.Enabled = true;
            this.buttonItemLoaiPhong.Enabled = true;
            this.btnDangKy.Enabled = true;
            this.buttonDangNhap.Enabled = false;
            this.buttonDangXuat.Enabled = true;
            this.buttonDoiMatKhau.Enabled = true;
            this.buttonHuongDan.Enabled = true;
            this.buttonKHThuephong.Enabled = true;
            this.buttonNguoiDung.Enabled = true;
            this.btn_phong.Enabled = true;
            this.buttonQuiDinh.Enabled = true;
            this.BTN_KHACHHANG.Enabled = true;
            this.btn_traphong.Enabled = true;
            this.btnDoanhThu.Enabled = true;
            this.btn_chietsuat.Enabled = true;
            this.btn_dangky.Enabled = true;
        }

        public void PQ_User()
        {
            this.btnThanhToan.Enabled = true;
            this.buttonItemLoaiPhong.Enabled = true;
            this.btnLoaiPhong.Enabled = true;
            this.btnDangKy.Enabled = true;
            this.buttonDangNhap.Enabled = false;
            this.buttonDangXuat.Enabled = true;
            this.buttonDoiMatKhau.Enabled = true;
            this.buttonHuongDan.Enabled = true;
            this.buttonKHThuephong.Enabled = true;
            this.buttonNguoiDung.Enabled = false;
            this.btn_phong.Enabled = true;
            this.buttonQuiDinh.Enabled = false;
            this.BTN_KHACHHANG.Enabled = true;
            this.btn_traphong.Enabled = true;
            this.btnDoanhThu.Enabled = true;
            this.btn_dangky.Enabled = true;
        }
        Frm_DoiMatKhau doimatkhau = null;
        private void buttonDoiMatKhau_Click(object sender, EventArgs e)
        {
        TiepTuc:
            if (doimatkhau == null || doimatkhau.IsDisposed)
            {
                doimatkhau = new Frm_DoiMatKhau();
            }
            if (doimatkhau.ShowDialog() == DialogResult.OK)
            {
                String mkcu = doimatkhau.matkhaucu;
                String mkmoi = doimatkhau.matkhaumoi;
                string xnmkmoi = doimatkhau.xacnhanmatkhaumoi;
                DoiMatKhau dmk = new DoiMatKhau();
                int KetQua = dmk.kiemtra(mkcu, mkmoi, xnmkmoi, lbl_tennguoidung.Text);
                switch (KetQua)
                {
                    case 0:
                        MessageBox.Show("Không được để trống bất kỳ trường nào!");
                        goto TiepTuc;

                    case 1:
                        MessageBox.Show("Mật khẩu cũ không khớp!");
                        goto TiepTuc;

                    case 2:
                        MessageBox.Show("Mật khẩu mới & Xác nhận mật khẩu mới: Không khớp với nhau!");
                        goto TiepTuc;
                    case 3:
                        if (dmk.Capnhatmatkhau(mkmoi, lbl_tennguoidung.Text))
                        {
                            if (MessageBox.Show("Cập nhật mật khẩu thành công!. Khởi động lại ứng dụng?", "Thông báo", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                                Application.Restart();
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu không thành công!");
                            goto TiepTuc;
                        }

                        break;
                }
            }
        }

        private void buttonNguoiDung_Click(object sender, EventArgs e)
        {
            Frm_NguoiDung ngdung = new Frm_NguoiDung();
            ngdung.Show();
        }

        private void BTN_KHACHHANG_Click(object sender, EventArgs e)
        {
            Frm_KhachHang khachhang = new Frm_KhachHang();
            khachhang.Show();
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            Frm_ThuePhong thuephong = new Frm_ThuePhong();
            thuephong.Show();
        }
        
        private void btn_traphong_Click(object sender, EventArgs e)
        {
            Frm_TraPhong traphong = new Frm_TraPhong();
            traphong.Get_user_nv(lbl_tennguoidung.Text.Trim());   
            traphong.Show();
        }

        private void btn_phong_Click(object sender, EventArgs e)
        {
            Frm_Phong phong = new Frm_Phong();
            phong.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Frm_HoaDon hd = new Frm_HoaDon();
            hd.Show();
        }

        private void buttonQuiDinh_Click(object sender, EventArgs e)
        {
            Frm_QuiDinh qd = new Frm_QuiDinh();
            qd.Show();
        }

        private void buttonItemLoaiPhong_Click(object sender, EventArgs e)
        {
            Frm_LoaiPhong lp = new Frm_LoaiPhong();
            lp.Show();
        }

        private void Frm_GiaoDien_Load(object sender, EventArgs e)
        {
            PQ_Default();
        }

        private void buttonKHThuephong_Click(object sender, EventArgs e)
        {
            Frm_DSKHThuePhong dstp = new Frm_DSKHThuePhong();
            dstp.Show();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            Frm_LienHe lienhe = new Frm_LienHe();
                lienhe.Show();
        }
    }
}
