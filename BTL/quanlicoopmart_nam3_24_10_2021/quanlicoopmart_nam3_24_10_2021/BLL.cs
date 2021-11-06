using quanlicoopmart_nam3_24_10_2021.getdataaa;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlicoopmart_nam3_24_10_2021
{
    class BLL
    {
        DAL dal = new DAL();

        // HIỆN THỊ 
        public DataTable ExcuQuery(string query)
        {
            return dal.ExcuQuery(query);
        }


        // THÊM VÀ SỬA XÓA
        public bool Them_Sua_Xoa_KH(Khachhang kh, string query)
        {
            return dal.Them_Sua_Xoa_KH(kh, query);
        }




        //
        // TÌM KIẾM KHÁCH HÀNG
        //
        public DataTable ExecuteTimkiem(string tk, string query)
        {
            return dal.ExecuteTimkiem(tk, query);
        }


        //
        // THỐNG KÊ HÀNG HÓA 
        //
        public DataTable Thongkehoadon(DateTime ngaybd, DateTime ngaykt, string query)
        {
            return dal.Thongkehoadon(ngaybd, ngaykt, query);
        }

        //
        //THÊM NHÂN VIÊN 
        //
        public bool Sua_Xoa_NV(Nhanvien nv, string query)
        {
            return dal.Sua_Xoa_NV(nv, query);
        }



        public bool Them_NV(Nhanvien nv, string query)
        {
            return dal.Them_NV(nv, query);
        }


        public bool Them_Sua_Xoa_CV(Chucvu cv, string query)
        {
            return dal.Them_Sua_Xoa_CV(cv, query);
        }


        public bool Them_Sua_Xoa_GC(Chitietpgc gc, string query)
        {
            return dal.Them_Sua_Xoa_GC(gc, query);
        }



        public bool Caplai_mk(Nhanvien nv, string query)
        {
            return dal.Caplai_mk(nv, query);
        }


        public bool Them_Sua_Xoa_PGC(Phieugiaoca pgc, string query)
        {
            return dal.Them_Sua_Xoa_PGC(pgc, query);

        }
    }
}
