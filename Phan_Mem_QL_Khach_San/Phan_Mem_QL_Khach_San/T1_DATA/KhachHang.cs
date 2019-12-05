using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Phan_Mem_QL_Khach_San.T2_BUSSINESS;
using Phan_Mem_QL_Khach_San.T3_GUI;

namespace Phan_Mem_QL_Khach_San.T1_DATA
{
    public class KhachHang
    {
        DAL_KhachHang dalks = new DAL_KhachHang();
        public List<KHACHHANG> LoadDL()
        {
            return dalks.LoadDL();
        }
        public bool Them(KHACHHANG kh)
        { return dalks.Them(kh); }

        public bool Xoa(string pMaKhachHang)
        { return dalks.Xoa(pMaKhachHang); }

        public bool Sua(string pMaKhachHang, string pTenKH, string pcmnd, string psdt, string pdiachi, string pgioitinh)
        { return dalks.Sua(pMaKhachHang, pTenKH, pcmnd, psdt, pdiachi, pgioitinh); }
    
    }
}
