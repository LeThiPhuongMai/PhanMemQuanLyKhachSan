using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Phan_Mem_QL_Khach_San.T1_DATA;
using System.Data;

namespace Phan_Mem_QL_Khach_San.T2_BUSSINESS
{
    public class DSKHThuePhong
    {
        ThuVienKetNoi ketnoi = new ThuVienKetNoi();
        public DataTable LoadDL(string strsearch = null)
        {
            if (strsearch == null)
                return ketnoi.GetTable("select TENKH, CMDN, SDT, DIACHI, GIOITINH, TENP,NGAYNHAN from KHACHHANG, PHIEUTHUEPHONG, CHITIETPHIEUTHUEPHONG, PHONG  where PHIEUTHUEPHONG.MAPT = CHITIETPHIEUTHUEPHONG.MAPT and KHACHHANG.MAKH = PHIEUTHUEPHONG.MAKH and PHONG.MAP = CHITIETPHIEUTHUEPHONG.MAP");
            else
                return ketnoi.GetTable("select TENKH, CMDN, SDT, DIACHI, GIOITINH, TENP,NGAYNHAN from KHACHHANG, PHIEUTHUEPHONG, CHITIETPHIEUTHUEPHONG, PHONG where PHIEUTHUEPHONG.MAPT = CHITIETPHIEUTHUEPHONG.MAPT and KHACHHANG.MAKH = PHIEUTHUEPHONG.MAKH and PHONG.MAP = CHITIETPHIEUTHUEPHONG.MAP and CMDN like '%"+strsearch+"%'");

        }
    }
}
