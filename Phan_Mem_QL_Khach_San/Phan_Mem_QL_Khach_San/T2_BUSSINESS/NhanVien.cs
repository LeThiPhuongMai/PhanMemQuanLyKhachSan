using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Phan_Mem_QL_Khach_San.T1_DATA;
using Phan_Mem_QL_Khach_San.T3_GUI;

namespace Phan_Mem_QL_Khach_San.T2_BUSSINESS
{
    class NhanVien
    {
        ThuVienKetNoi ketnoi = new ThuVienKetNoi();

        //Hàm thêm 1 nhân viên mới
        public bool Them_NhanVien(string manhanvien, string tennhanvien, string sdt, string diachi, string gioitinh, string tendangnhap)
        {
            //Không trùng thì thêm vào
            if (ketnoi.ExecuteNoneQuery("insert into NHANVIEN values('" + manhanvien + "', N'" + tennhanvien + "', '" + sdt + "', N'" + diachi + "', N'" + gioitinh + "', '"+tendangnhap+"')") == 1)
                return true;
            return false;
        }

        //Hàm xóa 1 nhân viên
        public bool Xoa_Nhan_Vien(string manhanvien)
        {
            if (ketnoi.ExecuteNoneQuery("delete from NHANVIEN where MANV = '" + manhanvien + "'") == 1)
                return true;
            return false;
        }

        //Hàm lưu thông tin nhân viên
        public bool Luu_Nhan_Vien(string manhanvien, string tennhanvien, string sdt, string diachi, string gioitinh, string tendangnhap)
        {
            if (ketnoi.ExecuteNoneQuery("update NHANVIEN set TENNV = N'"+tennhanvien+"', SDT = '"+sdt+"', DIACHI = N'"+diachi+"', GIOITINH = N'"+gioitinh+"' where MANV = '"+manhanvien+"'") == 1)
                return true;
            else return false;
        }
    }
}
