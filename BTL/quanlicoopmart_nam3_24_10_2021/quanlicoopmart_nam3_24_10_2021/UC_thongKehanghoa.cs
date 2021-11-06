using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlicoopmart_nam3_24_10_2021
{
    public partial class UC_thongKehanghoa : UserControl
    {
        public UC_thongKehanghoa()
        {
            InitializeComponent();
            Hienthi();
        }
        BLL bll = new BLL();

        private void Hienthi()
        {
            string query = "select Chitiethd.Mahh AS [Mã hàng hóa],Hanghoa.Tenhh AS [Tên hàng hóa],Hanghoa.Dongia AS [Đơn giá],(Chitietpn.Soluong - Hanghoa.Soluong) AS [Số lượng đã bán],Hanghoa.Soluong AS [Số lượng hàng tồn],Chitietpn.Soluong AS [Số lượng nhập],ĐVT AS [Đơn vị tính] from Hanghoa inner join Chitiethd on Hanghoa.Mahh = Chitiethd.Mahh inner join Chitietpn on Chitietpn.Mahh = Chitiethd.Mahh group by Chitiethd.Mahh, Hanghoa.Tenhh, Hanghoa.Dongia, Hanghoa.Soluong, Chitietpn.Soluong, ĐVT";
            DataTable dt = bll.ExcuQuery(query);
            dgvThongkehh.DataSource = dt;
        }

        private void btnTangTon_Click(object sender, EventArgs e)
        {
            string query1 = "select Chitiethd.Mahh AS [Mã hàng hóa],Hanghoa.Tenhh AS [Tên hàng hóa],Hanghoa.Dongia AS [Đơn giá],(Chitietpn.Soluong - Hanghoa.Soluong) AS [Số lượng đã bán],Hanghoa.Soluong AS [Số lượng hàng tồn],Chitietpn.Soluong AS [Số lượng nhập],ĐVT AS [Đơn vị tính] from Hanghoa inner join Chitiethd on Hanghoa.Mahh = Chitiethd.Mahh inner join Chitietpn on Chitietpn.Mahh = Chitiethd.Mahh group by Chitiethd.Mahh, Hanghoa.Tenhh, Hanghoa.Dongia, Hanghoa.Soluong, Chitietpn.Soluong, ĐVT order by Hanghoa.Soluong asc";
            DataTable dt = bll.ExcuQuery(query1);
            dgvThongkehh.DataSource = dt;
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTimkiemhanghoa.Text;
            string query2 = "select Chitiethd.Mahh AS [Mã hàng hóa],Hanghoa.Tenhh AS [Tên hàng hóa],Hanghoa.Dongia AS [Đơn giá],(Chitietpn.Soluong - Hanghoa.Soluong) AS [Số lượng đã bán],Hanghoa.Soluong AS [Số lượng hàng tồn],Chitietpn.Soluong AS [Số lượng nhập],ĐVT AS [Đơn vị tính] from Hanghoa inner join Chitiethd on Hanghoa.Mahh = Chitiethd.Mahh inner join Chitietpn on Chitietpn.Mahh = Chitiethd.Mahh where Chitiethd.Mahh like '%"+ tk + "%' or Hanghoa.Tenhh like N'%"+ tk + "%' group by Chitiethd.Mahh, Hanghoa.Tenhh, Hanghoa.Dongia, Hanghoa.Soluong, Chitietpn.Soluong, ĐVT";
            if (!string.IsNullOrEmpty(txtTimkiemhanghoa.Text))
            {
                DataTable dt = bll.ExecuteTimkiem(tk, query2);
                dgvThongkehh.DataSource = dt;
            }
            else
                Hienthi();
        }
    }
}
