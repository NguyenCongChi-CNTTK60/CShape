using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlicoopmart_nam3_24_10_2021
{
    public partial class UC_Thongkehoadon : UserControl
    {
        public UC_Thongkehoadon()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            dpkNgaybd.Value = new DateTime(today.Year, today.Month,1);
            dpkNgaykt.Value = dpkNgaybd.Value.AddMonths(1).AddDays(-1);
            DateTime ngaybd = dpkNgaybd.Value;
            DateTime ngaykt = dpkNgaykt.Value;
            string query = "select Mahd as [Mã hóa đơn],Tenkh as [Tên khách hàng],Tongtien as [Tổng tiền],Tennv as [Người tạo],Ngaytao  as [Ngày tạo],Tenqtn as [Tên quầy thu ngân] from Hoadon, Khachhang, Nhanvien, Quaythungan where Hoadon.Makh = Khachhang.Makh and Nhanvien.Manv = Hoadon.Manv and Quaythungan.Maqtn = Nhanvien.Maqtn and Ngaytao between '" + ngaybd + "' and '" + ngaykt + "'";
            DataTable dt = bll.Thongkehoadon(ngaybd, ngaykt,query);
            dgvThongkehd.DataSource = dt;
            TongtienHoadon();
        }

        BLL bll = new BLL();

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime ngaybd = dpkNgaybd.Value;
            DateTime ngaykt = dpkNgaykt.Value;
            string query = "select Mahd as [Mã hóa đơn],Tenkh as [Tên khách hàng],Tongtien as [Tổng tiền],Tennv as [Người tạo],Ngaytao  as [Ngày tạo],Tenqtn as [Tên quầy thu ngân] from Hoadon, Khachhang, Nhanvien, Quaythungan where Hoadon.Makh = Khachhang.Makh and Nhanvien.Manv = Hoadon.Manv and Quaythungan.Maqtn = Nhanvien.Maqtn and Ngaytao between '" + ngaybd + "' and '" + ngaykt + "'";    
            DataTable dt = bll.Thongkehoadon(ngaybd, ngaykt,query);
            dgvThongkehd.DataSource = dt;
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            DateTime ngaybd = dpkNgaybd.Value;
            DateTime ngaykt = dpkNgaykt.Value;
            string query = "select Mahd as [Mã hóa đơn],Tenkh as [Tên khách hàng],Tongtien as [Tổng tiền],Tennv as [Người tạo],Ngaytao  as [Ngày tạo],Tenqtn as [Tên quầy thu ngân] from Hoadon, Khachhang, Nhanvien, Quaythungan where Hoadon.Makh = Khachhang.Makh and Nhanvien.Manv = Hoadon.Manv and Quaythungan.Maqtn = Nhanvien.Maqtn and Ngaytao between '" + ngaybd + "' and '" + ngaykt + "' order by Tongtien asc";
            DataTable dt = bll.Thongkehoadon(ngaybd, ngaykt, query);
            dgvThongkehd.DataSource = dt;
        }

        private void btnTangngay_Click(object sender, EventArgs e)
        {
            DateTime ngaybd = dpkNgaybd.Value;
            DateTime ngaykt = dpkNgaykt.Value;
            string query = "select Mahd as [Mã hóa đơn],Tenkh as [Tên khách hàng],Tongtien as [Tổng tiền],Tennv as [Người tạo],Ngaytao  as [Ngày tạo],Tenqtn as [Tên quầy thu ngân] from Hoadon, Khachhang, Nhanvien, Quaythungan where Hoadon.Makh = Khachhang.Makh and Nhanvien.Manv = Hoadon.Manv and Quaythungan.Maqtn = Nhanvien.Maqtn and Ngaytao between '" + ngaybd + "' and '" + ngaykt + "' order by Ngaytao asc";
            DataTable dt = bll.Thongkehoadon(ngaybd, ngaykt, query);
            dgvThongkehd.DataSource = dt;
        }

        private void TongtienHoadon()
        {
            int Tongtien = 0;
            string query = "select sum(Tongtien) as [Tổng tiền hóa đơn]from Hoadon";
            DataTable dt = bll.ExcuQuery(query);
            string tien = dt.Rows[0]["Tổng tiền hóa đơn"].ToString();
            Tongtien = Int32.Parse(tien);
            txtTongtienhoadon.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", Tongtien) + " VNĐ";
        }
    }
}
