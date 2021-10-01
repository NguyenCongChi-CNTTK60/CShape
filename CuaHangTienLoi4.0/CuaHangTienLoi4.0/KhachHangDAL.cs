using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace CuaHangTienLoi4._0
{
    class KhachHangDAL
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LRQ8VCB\SQLEXPRESS;Initial Catalog=CUAHANGTIENLOI;Integrated Security=True");
        SqlCommand cmd;



        // 
        // Hàm thêm khách hàng
        //
        public void ThemKhachHang(BangKhachHang kh1)
        {
           
                con.Open();
                string sql = "insert into khachang(makh,tenkh,gioitinh,diachi,sdt,email) values (@makh,@tenkh,@gioitinh,@diachi,@sdt,@email)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = kh1.makh;
                cmd.Parameters.Add("@tenkh", SqlDbType.NVarChar).Value = kh1.tenkh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = kh1.gioitinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = kh1.diachi;
                cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = kh1.sdt;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = kh1.email;
                cmd.ExecuteNonQuery();
                con.Close();

        }

       
      

        //
        // Hàm sửa khách hàng
        //
        public void SuaKhachHang(BangKhachHang kh1)
        {

            con.Open();
            string sql = "update khachang set makh=@makh,tenkh=@tenkh,gioitinh=@gioitinh,diachi=@diachi,sdt=@sdt,email=@email where makh = @makh";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = kh1.makh;
            cmd.Parameters.Add("@tenkh", SqlDbType.NVarChar).Value = kh1.tenkh;
            cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = kh1.gioitinh;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = kh1.diachi;
            cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = kh1.sdt;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = kh1.email;
            cmd.ExecuteNonQuery();
            con.Close();

        }

        //
        // Hàm xóa khách hàng
        //
        public void XoaKhachHang(BangKhachHang kh1)
        {
            con.Open();
            string sql = "delete from khachang where makh = @makh";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = kh1.makh;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        //
        // Hàm tìm kiếm khách hàng
        //
        public DataTable TimkiemaKhachHang(string kh)
        {
            string sql = "select * from khachang where makh like N'"+ kh +"' or tenkh like N'"+kh+"'";

            con.Open();

            //b3: khoi tao doi tuong lop dataAdapter
            SqlDataAdapter dat = new SqlDataAdapter(sql, con);


            //b5: do du lieu dataAdapter vao DataTable
            DataTable dtb = new DataTable();
            dat.Fill(dtb);

            //b6: dong chuoi ket noi
            con.Close();

            return dtb;

        }

    }
}
