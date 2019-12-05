using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Phan_Mem_QL_Khach_San.T3_GUI;

namespace Phan_Mem_QL_Khach_San
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Frm_TraPhong());
            Application.Run(new Frm_GiaoDien());
            //Application.Run(new Frm_KhachHang());
            //Application.Run(new Frm_ThuePhong());
            //Application.Run(new Frm_DSKHThuePhong());
            //Application.Run(new Frm_LienHe());
        }
    }
}
