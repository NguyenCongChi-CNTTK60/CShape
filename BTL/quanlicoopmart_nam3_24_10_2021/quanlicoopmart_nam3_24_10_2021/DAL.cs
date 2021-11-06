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
    class DAL
    {
        Chuoiketnoi chuoiketnoi = new Chuoiketnoi();
        //
        // ĐĂNG NHẬP 
        //



        //
        // HIỂN THỊ CƠ SỞ DỮ LIỆU
        //
        public DataTable ExcuQuery(string query)
        {
            SqlConnection con = chuoiketnoi.sqlConnection();
            con.Open();
            SqlDataAdapter dta = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            con.Close();
            return dt;
        }



        //
        // THÊM KHÁCH HÀNG VÀ SỬA KHÁCH HÀNG 
        //
        public bool Them_Sua_Xoa_KH(Khachhang kh, string query)
        {
            try
            {
                //string query = "insert into Khachhang (Makh,Tenkh,Ngaysinh,Diachi,Sdt) values (@Makh,@Tenkh,@Ngaysinh,@Diachi,@Sdt)";
                SqlConnection connection = chuoiketnoi.sqlConnection();
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.Add("@Makh", SqlDbType.NVarChar).Value = kh.Makh;
                sqlCommand.Parameters.Add("@Tenkh", SqlDbType.NVarChar).Value = kh.Tenkh;
                sqlCommand.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = kh.Ngaysinh;
                sqlCommand.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = kh.Diachi;
                sqlCommand.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = kh.Sdt;
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }





        //
        // TÌM KIẾM 
        //
        public DataTable ExecuteTimkiem(string tk, string query)
        {
            SqlConnection con = chuoiketnoi.sqlConnection();
            con.Open();
            SqlDataAdapter dta = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            con.Close();
            return dt;
        }



        //
        // THỐNG KÊ 3 THAM SỐ
        //
        public DataTable Thongkehoadon(DateTime ngaybd, DateTime ngaykt, string query)
        {
            //string query = "select Mahd as [Mã hóa đơn],Tenkh as [Tên khách hàng],Tongtien as [Tổng tiền],Tennv as [Người tạo],Ngaytao  as [Ngày tạo],Tenqtn as [Tên quầy thu ngân] from Hoadon, Khachhang, Nhanvien, Quaythungan where Hoadon.Makh = Khachhang.Makh and Nhanvien.Manv = Hoadon.Manv and Quaythungan.Maqtn = Hoadon.Maqtn and Ngaytao between '"+ngaybd+"' and '"+ngaykt+"'";
            SqlConnection con = chuoiketnoi.sqlConnection();
            con.Open();
            SqlDataAdapter dta = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            con.Close();
            return dt;
        }


        //
        // SỬA NHÂN VIÊN 
        //
        public bool Sua_Xoa_NV(Nhanvien nv, string query)
        {
            try
            {
                SqlConnection connection = chuoiketnoi.sqlConnection();
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.Add("@Manv", SqlDbType.NVarChar).Value = nv.Manv;
                sqlCommand.Parameters.Add("@Tennv", SqlDbType.NVarChar).Value = nv.Tennv;
                sqlCommand.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = nv.Ngaysinh;
                sqlCommand.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = nv.Diachi;
                sqlCommand.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = nv.Sdt;
                sqlCommand.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = nv.Gioitinh;
                sqlCommand.Parameters.Add("@Macv", SqlDbType.NVarChar).Value = nv.Macv;
                sqlCommand.Parameters.Add("@Maqtn", SqlDbType.NVarChar).Value = nv.Maqtn;
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }




        //
        // ĐĂNG KÝ CHO NHÂN VIÊN 
        //
        public bool Them_NV(Nhanvien nv, string query)
        {
            try
            {
                SqlConnection connection = chuoiketnoi.sqlConnection();
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.Add("@Manv", SqlDbType.NVarChar).Value = nv.Manv;
                sqlCommand.Parameters.Add("@Tennv", SqlDbType.NVarChar).Value = nv.Tennv;
                sqlCommand.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = nv.Ngaysinh;
                sqlCommand.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = nv.Diachi;
                sqlCommand.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = nv.Sdt;
                sqlCommand.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = nv.Gioitinh;
                sqlCommand.Parameters.Add("@Tendangnhap", SqlDbType.NVarChar).Value = nv.Tendangnhap;
                sqlCommand.Parameters.Add("@Matkhau", SqlDbType.NVarChar).Value = nv.Matkhau;
                sqlCommand.Parameters.Add("@Macv", SqlDbType.NVarChar).Value = nv.Macv;
                sqlCommand.Parameters.Add("@Maqtn", SqlDbType.NVarChar).Value = nv.Maqtn;
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }


        public bool Them_Sua_Xoa_CV(Chucvu cv, string query)
        {
            try
            {

                SqlConnection connection = chuoiketnoi.sqlConnection();
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.Add("@Macv", SqlDbType.NVarChar).Value = cv.Macv;
                sqlCommand.Parameters.Add("@Tencv", SqlDbType.NVarChar).Value = cv.Tencv;
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }



        public bool Them_Sua_Xoa_GC(Chitietpgc gc, string query)
        {
            try
            {
                //string query = "insert into Khachhang (Makh,Tenkh,Ngaysinh,Diachi,Sdt) values (@Makh,@Tenkh,@Ngaysinh,@Diachi,@Sdt)";
                SqlConnection connection = chuoiketnoi.sqlConnection();
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.Add("@Manv", SqlDbType.NVarChar).Value = gc.Manv;
                sqlCommand.Parameters.Add("@Mapgc", SqlDbType.NVarChar).Value = gc.Mapgc;
                sqlCommand.Parameters.Add("@Ngay", SqlDbType.Date).Value = gc.Ngay;
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }



        public bool Caplai_mk(Nhanvien nv, string query)
        {
            try
            {
                //string query = "insert into Khachhang (Makh,Tenkh,Ngaysinh,Diachi,Sdt) values (@Makh,@Tenkh,@Ngaysinh,@Diachi,@Sdt)";
                SqlConnection connection = chuoiketnoi.sqlConnection();
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.Add("@Matkhau", SqlDbType.NVarChar).Value = nv.Matkhau;
                sqlCommand.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = nv.Sdt;
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }



        public bool Them_Sua_Xoa_PGC(Phieugiaoca pgc, string query)
        {
            try
            {
                SqlConnection connection = chuoiketnoi.sqlConnection();
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.Add("@Mapgc", SqlDbType.NVarChar).Value = pgc.Mapgc;
                sqlCommand.Parameters.Add("@Ca", SqlDbType.NVarChar).Value = pgc.Ca;
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }

    }
}

