using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Phan_Mem_QL_Khach_San.T1_DATA;
using Phan_Mem_QL_Khach_San.T3_GUI;

namespace Phan_Mem_QL_Khach_San.T2_BUSSINESS
{
    public class ThuePhong
    {
        ThuVienKetNoi ketnoi = new ThuVienKetNoi();
        //Hàm load dữ liệu lên DataTable
        public DataTable LoadDL_Table(string str_load)
        {
            DataTable tb = new DataTable();
            tb = ketnoi.GetTable(str_load);
            return tb;
        }
        public DataTable dtgrid_thuephong()
        {
            DataTable tb = new DataTable();
            tb = ketnoi.GetTable("select PHIEUTHUEPHONG.MAPT, KHACHHANG.MAKH, KHACHHANG.TENKH, KHACHHANG.CMDN, PHONG.GIAPHONG, PHONG.MAP,  CHITIETPHIEUTHUEPHONG.NGAYNHAN  from PHONG, CHITIETPHIEUTHUEPHONG, PHIEUTHUEPHONG, KHACHHANG where PHONG.MAP = CHITIETPHIEUTHUEPHONG.MAP and CHITIETPHIEUTHUEPHONG.MAPT = PHIEUTHUEPHONG.MAPT and PHIEUTHUEPHONG.MAKH = KHACHHANG.MAKH");
            return tb;
        }
        public DataTable Load_cbo_makh()
        {
            DataTable tb = new DataTable();
            tb = ketnoi.GetTable("select MAKH from KHACHHANG /*** where  not exists (select PHIEUTHUEPHONG.MAKH FROM PHIEUTHUEPHONG where KHACHHANG.MAKH = PHIEUTHUEPHONG.MAKH) ***/");
            return tb;
        }
        public DataTable Load_cbo_loaiphong()
        {
            DataTable tb = new DataTable();
            tb = ketnoi.GetTable("select MALOAIP from LOAIPHONG where exists (select MALOAIP from PHONG where LOAIPHONG.MALOAIP = PHONG.MALOAIP and PHONG.TINHTRANG = N'TRỐNG')");
            return tb;
        }
        public DataTable Load_cbo_maphong(string loaip)
        {
            DataTable tb = new DataTable();
            tb = ketnoi.GetTable("select MAP from PHONG where MALOAIP = '" + loaip + "' and TINHTRANG = N'TRỐNG'");
            return tb;
        }
        // Hàm lấy dữ liệu lên textbox khi Combobox Changed
        public string Get_Text(string str_cbo)
        {
            return ketnoi.ExecuteScalar(str_cbo).ToString();
        }
        public string Get_txt_tenkh(string makh)
        {
            return ketnoi.ExecuteScalar("select TENKH from KHACHHANG where MAKH = '" + makh + "'").ToString();
        }
        public string Get_txt_cmnd(string makh)
        {
            return ketnoi.ExecuteScalar("select CMDN from KHACHHANG where MAKH = '" + makh + "'").ToString();
        }

        public string Get_txt_giaphong(string map)
        {
            return ketnoi.ExecuteScalar("select GIAPHONG from PHONG WHERE MAP = '" + map + "'").ToString();
        }

        //Hàm lưu dữ liệu khi chèn câu lệnh string vào
        public bool Luu(string str_luu)
        {
            if (ketnoi.ExecuteNoneQuery(str_luu) == 1)
                return true;
            return false;
        }
        public bool Luu_PHIEUTHUEPHONG(string mapt, string makh)
        {
            if (ketnoi.ExecuteNoneQuery("insert into PHIEUTHUEPHONG values('" + mapt + "','" + makh + "')") == 1)
                return true;
            return false;
        }
        public bool Luu_CHITIETPHIEUTHUEPHONG(string mapt, string map, string ngaynhan)
        {
            if (ketnoi.ExecuteNoneQuery("insert into CHITIETPHIEUTHUEPHONG values ('" + mapt + "','" + map + "','" + ngaynhan + "')") == 1)
                return true;
            return false;
        }
        public bool Luu_TINHTRANGPHONG(string map)
        {
            if (ketnoi.ExecuteNoneQuery("update PHONG set TINHTRANG = N'ĐẶT' where MAP = '" + map + "'") == 1)
                return true;
            return false;
        }
    }
}
