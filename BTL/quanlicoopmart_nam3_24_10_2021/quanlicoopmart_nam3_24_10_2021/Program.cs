using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlicoopmart_nam3_24_10_2021
{
    static class Program
    {
        //private static object tk;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormSodienthoai());
            Application.Run(new FormTrangchu());
            //Application.Run(new FormDangnhap());
            //Application.Run(new FormQuyenNhanvien());
            // Application.Run(new FormDangkynhanvien());
            //Application.Run(new FormInHD());

           
        }
    }
}
