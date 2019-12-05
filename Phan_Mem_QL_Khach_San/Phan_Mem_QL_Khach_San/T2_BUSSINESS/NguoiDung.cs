using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Phan_Mem_QL_Khach_San.T1_DATA;
using Phan_Mem_QL_Khach_San.T3_GUI;

namespace Phan_Mem_QL_Khach_San.T2_BUSSINESS
{
    public class NguoiDung
    {
        ThuVienKetNoi ketnoi = new ThuVienKetNoi();
        public object Load_Du_Lieu_Len_Girdview()
        {
            return ketnoi.GetTable("select TENDANGNHAP, MATKHAU, LOAINGUOIDUNG from NGUOIDUNG");
        }
        public object Load_Du_Lieu_Len_CBO()
        {
            return ketnoi.GetTable("select DISTINCT LOAINGUOIDUNG  from NGUOIDUNG");
        }
        
        //Thêm người dùng mới
        public bool Them_Nguoi_Dung(string tennguoidung, string matkhau, string loainguoidung)
        {
            if (ketnoi.ExecuteNoneQuery("insert into NGUOIDUNG values('" + tennguoidung + "','" + matkhau + "','" + loainguoidung + "')") == 1)
                return true;
            return false;
        }

        //Hàm lưu, sửa người dùng
        public bool Luu_Nguoi_Dung(string tennguoidung, string matkhau, string loainguoidung)
        {
            string strluu = "";
            if (matkhau == "")
                strluu = "update NGUOIDUNG set LOAINGUOIDUNG = '" + loainguoidung + "' where TENDANGNHAP = '" + tennguoidung + "'";
            else
                strluu = "update NGUOIDUNG set MATKHAU = '" + matkhau + "', LOAINGUOIDUNG = '" + loainguoidung + "' where TENDANGNHAP = '" + tennguoidung + "'";
            if (ketnoi.ExecuteNoneQuery(strluu) == 1)
                return true;
            else return false;
        }

        //Hàm xóa người dùng
        public bool Xoa_Nguoi_Dung(string tennguoidung)
        {
            if (ketnoi.ExecuteNoneQuery("delete from NGUOIDUNG where TENDANGNHAP = '" + tennguoidung + "'") == 1)
                return true;
            return false;
        }
       
    }
}
