using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Phan_Mem_QL_Khach_San.T1_DATA;
using Phan_Mem_QL_Khach_San.T3_GUI;


namespace Phan_Mem_QL_Khach_San.T2_BUSSINESS
{

    public class DAL_KhachHang
    {
        KhachHangDataContext _qlks = new KhachHangDataContext();
        public List<KHACHHANG> LoadDL()
        {
            return _qlks.KHACHHANGs.Select(t => t).ToList<KHACHHANG>();
        }
       

        public bool Them(KHACHHANG kh)
        {
            try
            {
                _qlks.KHACHHANGs.InsertOnSubmit(kh);
                _qlks.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(string pMaKhachHang)
        {
            try
            {
                KHACHHANG kh = _qlks.KHACHHANGs.Where(t => t.MAKH == pMaKhachHang).FirstOrDefault();
                _qlks.KHACHHANGs.DeleteOnSubmit(kh);
                _qlks.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Sua(string pMaKhachHang, string pTenKH, string pcmnd, string psdt, string pdiachi, string pgioitinh)
        {
            try
            {
                KHACHHANG kh = _qlks.KHACHHANGs.Where(t => t.MAKH == pMaKhachHang).FirstOrDefault();
                kh.TENKH = pTenKH;
                kh.CMDN = pcmnd;
                kh.SDT = psdt;
                kh.DIACHI = pdiachi;
                kh.GIOITINH = pgioitinh;
                _qlks.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
    }
}
