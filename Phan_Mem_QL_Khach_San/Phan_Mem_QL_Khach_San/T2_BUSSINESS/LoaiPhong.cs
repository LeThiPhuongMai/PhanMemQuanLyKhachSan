using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Phan_Mem_QL_Khach_San.T1_DATA;
using Phan_Mem_QL_Khach_San.T3_GUI;

namespace Phan_Mem_QL_Khach_San.T2_BUSSINESS
{
    public class LoaiPhong
    {
        ThuVienKetNoi ketnoi = new ThuVienKetNoi();

        //Hàm trả về bảng để load lên Datagridview
        public DataTable LoadTable(string loai)
        {
            return ketnoi.GetTable("select * from LOAIPHONG");
        }

        //Hàm thêm loại phòng
        public bool Them(string maloai, string tenloai)
        {
            if (ketnoi.ExecuteNoneQuery(("insert into LOAIPHONG values ('" + maloai + "',N'" + tenloai + "')")) == 1)
                return true;
            return false;
        }

        //Hàm xóa loại phòng
        public bool Xoa(string maloai)
        {
            if (ketnoi.ExecuteNoneQuery("delete from LOAIPHONG where MALOAIP = '" + maloai + "'") == 1)
                return true;
            return false;
        }

        // Hàm lưu, sửa
        public bool Luu(string maloai, string tenloai)
        {
            if (ketnoi.ExecuteNoneQuery(("update LOAIPHONG set TENLOAIP = N'"+tenloai+"' where MALOAIP = '"+maloai+"'")) == 1)
                return true;
            return false;
        }
    }
}
