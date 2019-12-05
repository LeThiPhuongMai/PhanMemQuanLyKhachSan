using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Phan_Mem_QL_Khach_San.T1_DATA;
using Phan_Mem_QL_Khach_San.T3_GUI;

namespace Phan_Mem_QL_Khach_San.T2_BUSSINESS
{
    public class Phong
    {
        static ThuVienKetNoi ketnoi = new ThuVienKetNoi();
        //Hàm xóa phòng
        public bool Xoa_Phong(string map)
        {
            if (ketnoi.ExecuteNoneQuery("delete from PHONG where MAP = '" + map + "'") == 1)
                return true;
            return false;
        }

        //Hàm thêm phòng
        public bool Them_Phong(string maphong, string tenphong, string giaphong, string tinhtrang, string loaiphong, string ghichu)
        {
            //Không trùng thì thêm vào
            if (ketnoi.ExecuteNoneQuery("insert into PHONG values('" + maphong + "',N'" + tenphong + "','" + giaphong + "',N'"+tinhtrang+"','"+loaiphong+"',N'"+ghichu+"')") == 1)
                return true;
            return false;
        }

        //Hàm lưu thông tin phòng
        public bool Luu_Phong(string maphong, string tenphong, string giaphong, string tinhtrang, string loaiphong, string ghichu)
        {
            if (ketnoi.ExecuteNoneQuery("update PHONG set TENP = N'"+tenphong+"', GIAPHONG = '"+giaphong+"', TINHTRANG = N'"+tinhtrang+"', MALOAIP = '"+loaiphong+"', GHICHU = N'"+ghichu+"' where MAP = '"+maphong+"'") == 1)
                return true;
            else return false;
        }
    }
}
