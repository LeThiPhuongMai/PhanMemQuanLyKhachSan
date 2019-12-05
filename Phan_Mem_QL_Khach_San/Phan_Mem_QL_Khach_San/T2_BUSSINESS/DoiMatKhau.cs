using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Phan_Mem_QL_Khach_San.T3_GUI;
using Phan_Mem_QL_Khach_San.T1_DATA;

namespace Phan_Mem_QL_Khach_San.T2_BUSSINESS
{
    public class DoiMatKhau
    {
        ThuVienKetNoi ketnoi = new ThuVienKetNoi();
        public int kiemtra(string mkcu, string mkmoi, string xnmkmoi, string user)
        {
            //Nếu trống 1 trường bất kỳ thì trẻ về 0
            if (mkcu == "" || mkmoi == "" || xnmkmoi == "")
                return 0;

            //Nếu mật khẩu cũ không khớp thì trả về 1
            if (ketnoi.ExecuteScalar("select count(*) from NGUOIDUNG where TENDANGNHAP = '" + user + "' and MATKHAU = '" + mkcu + "'").ToString() != "1")
                return 1;

            //Nếu 2 mật khẩu mới không khớp thì trả về 2
            if (mkmoi != xnmkmoi)
                return 2;

            //Còn lại thì trả về 3 để viết hàm Update mật khẩu
            return 3;
        }
        
        public bool Capnhatmatkhau(string matkhaumoi, string user)
        {
            if (ketnoi.ExecuteNoneQuery("update NGUOIDUNG set MATKHAU = '"+matkhaumoi+"' where TENDANGNHAP = '"+user+"'") == 1)
                return true;
            return false;
        }

    }
}
