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
    public partial class UC_Thongkekhachhang : UserControl
    {
        public UC_Thongkekhachhang()
        {
            InitializeComponent();
            Hienthi();
        }

        BLL bll = new BLL();

        private void Hienthi()
        {
            string query = "select Khachhang.Makh as [Mã khách hàng],Tenkh as [Tên khách hàng],Sdt as [Số điện thoại],count (Hoadon.Makh) as [Số lần mua hàng] from Hoadon, Khachhang where Khachhang.Makh = Hoadon.Makh group by Hoadon.Makh,Khachhang.Makh,Tenkh,Sdt ";
            DataTable dt = bll.ExcuQuery(query);
            dgvThongkekh.DataSource = dt;

        }

        private void txtTimkiemkhachhang_TextChanged(object sender, EventArgs e)
        { 
            string tk = txtTimkiemkhachhang.Text;
            string query1 = "select Khachhang.Makh as [Mã khách hàng],Tenkh as [Tên khách hàng],Sdt as [Số điện thoại],count(Hoadon.Makh) as [Số lần mua hàng] from Hoadon inner join Khachhang on Hoadon.Makh = Khachhang.Makh  where Khachhang.Makh like '%"+ tk +"%' or Khachhang.Tenkh like N'%"+ tk +"%' or Khachhang.Sdt like N'%"+ tk + "%' group by Hoadon.Makh,Khachhang.Makh,Tenkh,Sdt";
            if (!string.IsNullOrEmpty(txtTimkiemkhachhang.Text))
            {
                DataTable dt = bll.ExecuteTimkiem(tk, query1);
                dgvThongkekh.DataSource = dt;
            }
            else
                Hienthi();
        }
    }
}
