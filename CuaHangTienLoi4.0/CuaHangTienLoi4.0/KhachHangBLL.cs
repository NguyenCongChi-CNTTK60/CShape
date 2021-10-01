using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CuaHangTienLoi4._0
{
    class KhachHangBLL
    {
        KhachHangDAL dal = new KhachHangDAL();
        public void ThemKhachHang(BangKhachHang kh1)
        {
            dal.ThemKhachHang(kh1);
        }

        public void XoaKhachHang(BangKhachHang kh1)
        {
            dal.XoaKhachHang(kh1);
        }

        public void SuaKhachHang(BangKhachHang kh1)
        {
            dal.SuaKhachHang(kh1);
        }

        public DataTable TimkiemKhachHang(string kh)
        {
            return dal.TimkiemaKhachHang(kh);
        }
    }
}
