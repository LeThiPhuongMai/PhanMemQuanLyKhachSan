using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Phan_Mem_QL_Khach_San.T3_GUI;
using Phan_Mem_QL_Khach_San.T1_DATA;
using System.Data;

namespace Phan_Mem_QL_Khach_San.T2_BUSSINESS
{
    public class HoaDon
    {

        ThuVienKetNoi ketnoi = new ThuVienKetNoi();

       //Hàm load dữ liệu
        public DataTable LoadDL(string hoadon = null)
        {
            return ketnoi.GetTable("select HOADON.MAHD, TENNV, TENKH, MAP, NGAYLAP, TONGTIEN from HOADON, NHANVIEN, KHACHHANG, CHITIETHOADON where NHANVIEN.MANV = HOADON.MANV and KHACHHANG.MAKH = HOADON.MAKH and HOADON.MAHD = CHITIETHOADON.MAHD ");
        }

        
    }
}
