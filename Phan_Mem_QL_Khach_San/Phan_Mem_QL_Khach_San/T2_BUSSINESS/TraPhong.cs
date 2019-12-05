using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using Phan_Mem_QL_Khach_San.T1_DATA;
using System.Data;

namespace Phan_Mem_QL_Khach_San.T2_BUSSINESS
{
    public class TraPhong
    {
        ThuVienKetNoi ketnoi = new ThuVienKetNoi();
        public DataTable LoadMAKH_Dang_Thue()
        {
            return ketnoi.GetTable("select DISTINCT(MAKH) from PHIEUTHUEPHONG");
        }
        public DataTable LoadMAP_Dang_Thue(string makh)
        {
            return ketnoi.GetTable("select DISTINCT(MAP) from PHIEUTHUEPHONG, CHITIETPHIEUTHUEPHONG where PHIEUTHUEPHONG.MAPT = CHITIETPHIEUTHUEPHONG.MAPT and PHIEUTHUEPHONG.MAKH = '" + makh + "'");
        }
        public string SoLuongPhongThue(string makh)
        {
            return (ketnoi.ExecuteScalar("select COUNT(DISTINCT(MAP)) from PHIEUTHUEPHONG, CHITIETPHIEUTHUEPHONG where PHIEUTHUEPHONG.MAPT = CHITIETPHIEUTHUEPHONG.MAPT and PHIEUTHUEPHONG.MAKH = '"+makh+"'")).ToString();
            
        }
        public string TinhSoNgay(string maphong, DateTime ngaytra)
        {
            DateTime ngaynhan = Convert.ToDateTime(ketnoi.ExecuteScalar("select NGAYNHAN from CHITIETPHIEUTHUEPHONG where MAP = '"+maphong+"'"));
            TimeSpan songay = (ngaytra - ngaynhan);
            if (songay.Days == 0)
                return "1";
            return songay.Days.ToString();
        }
        public int GiaPhong(string maphong = "01")
        {
            if(LoadMAKH_Dang_Thue().Rows.Count > 0)
                return Int32.Parse(ketnoi.ExecuteScalar("select GIAPHONG from PHONG where MAP = N'"+maphong+"'").ToString());
            return 0;
            
        }
        public float TongTien(string makh,DateTime ngaytra)
        {
            float tongtien = 0;
            int soluongphongthue = Int32.Parse(SoLuongPhongThue(makh));
            DataTable tb = LoadMAP_Dang_Thue(makh);
            for (int i = 0; i < soluongphongthue; i++)
            {
                //Lấy Giá của phòng đó * TinhSoNgay cộng dồn vào tongtien;
                string maphong = tb.Rows[i][0].ToString();
                tongtien += GiaPhong(maphong) * Int32.Parse(TinhSoNgay(maphong, ngaytra));
            }
            return tongtien;
        }
        public string GetMaNV(string user)
        {
            try
            {
                return (ketnoi.ExecuteScalar("select MANV FROM NHANVIEN where TENDANGNHAP = '" + user + "'")).ToString();
            }
            catch(Exception e)
            {
                return "";
            }
        }
        //Trả phòng
        //Thêm vào hóa đơn
        public bool ThemHoaDon(string mahd, string manv, string makh, float tongtien, string ngaylap)
        {
            if (ketnoi.ExecuteNoneQuery("insert into HOADON values('" + mahd + "', '" + manv + "', '" + makh + "', " + tongtien + ", '" + ngaylap + "')") == 1)
                return true;
            return false;
        }
        //Thêm vào chi tiết hóa đơn
        public bool ThemChiTietHoaDon(string makh, string mahd, DateTime ngaytra)
        {
            float thanhtien;
            int soluongphongthue = Int32.Parse(SoLuongPhongThue(makh));
            DataTable tb = LoadMAP_Dang_Thue(makh);
            for (int i = 0; i < soluongphongthue; i++)
            {
                //Lấy Giá của phòng đó * TinhSoNgay cộng dồn vào tongtien;
                string maphong = tb.Rows[i][0].ToString();
                thanhtien = GiaPhong(maphong) * Int32.Parse(TinhSoNgay(maphong, ngaytra));
                if(ketnoi.ExecuteNoneQuery("insert into CHITIETHOADON values ('"+mahd+"', '"+maphong+"', "+Int32.Parse(TinhSoNgay(maphong, ngaytra))+", "+thanhtien.ToString()+")") != 1)
                    return false;
            }
            return true;
            
        }
        public DataTable LoadDTGridView()
        {
            return ketnoi.GetTable("select HOADON.MAHD, MANV, MAKH, MAP, SONGAY, THANHTIEN, TONGTIEN, NGAYLAP from HOADON, CHITIETHOADON where HOADON.MAHD = CHITIETHOADON.MAHD");
        }
        public bool XoaThuePhong(string makh)
        {
            if (ketnoi.ExecuteNoneQuery("delete from PHIEUTHUEPHONG where MAKH = '" + makh + "'") > 0)
                return true;
            return false;
        }
        public bool XoaChiTietPhieuThuePhong(string makh)
        {
            if (ketnoi.ExecuteNoneQuery("delete from CHITIETPHIEUTHUEPHONG where exists (select * from PHIEUTHUEPHONG where CHITIETPHIEUTHUEPHONG.MAPT = PHIEUTHUEPHONG.MAPT AND MAKH = '" + makh + "')") > 0)
                return true;
            return false;
        }
        public void ThayDoiTinhTrangPhong(string maphong)
        {
            int i = ketnoi.ExecuteNoneQuery("update PHONG set TINHTRANG = N'TRỐNG' where MAP = '"+maphong+"'");
        }

    }
    
}
