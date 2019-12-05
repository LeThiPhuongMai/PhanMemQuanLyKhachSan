using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Phan_Mem_QL_Khach_San.T1_DATA;
using Phan_Mem_QL_Khach_San.T3_GUI;

namespace Phan_Mem_QL_Khach_San.T2_BUSSINESS
{
    public class DangNhap
    {
        //Kiểm tra đăng nhập: 0 - Không tồn tại; 1 - Mật khẩu sai; 2 - Đăng nhập thành công, phân quyền
        public int KiemTraDangNhap(string tendangnhap, string matkhau)
        {
            string str = "select * from NGUOIDUNG where TENDANGNHAP = N'"+ tendangnhap +"'";
            ThuVienKetNoi ketnoi = new ThuVienKetNoi();
            DataTable user = ketnoi.GetTable(str);
            if (user.Rows.Count == 0)
                return 0;
            string mk = user.Rows[0][1].ToString().Trim();
            if (mk != matkhau)
                return 1;
            return 2;
        }

        //Hàm kiểm tra người dùng có phải là admin hay không
        public bool is_admin(string user)
        {
            string str = "select * from NGUOIDUNG where TENDANGNHAP = N'" + user + "'";
            ThuVienKetNoi ketnoi = new ThuVienKetNoi();
            DataTable loainguoidung = ketnoi.GetTable(str);
            string lnd = loainguoidung.Rows[0][2].ToString();
            if(lnd == "ADMIN")
                return true;
            return false;
        }
    }
}
