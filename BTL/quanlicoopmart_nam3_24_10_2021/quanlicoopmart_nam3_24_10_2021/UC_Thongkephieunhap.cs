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
    public partial class UC_Thongkephieunhap : UserControl
    {
        public UC_Thongkephieunhap()
        {
  
            InitializeComponent();
            txtTien.ReadOnly = true;
            Hienthi();
          
        }

       
        BLL bll = new BLL();
        private void Hienthi()
        {
            string query = "select Chitietpn.Mapn as [Mã phiếu nhập],Tenhh as [Tên hàng hóa],Chitietpn.Soluong as [Số lượng nhập],Chitietpn.Dongia as [Đơn giá nhập],Ngaynhap as [Ngày nhập],Tenncc as [Nhà cung cấp],Tenk as [Tên kho], (Chitietpn.Dongia * Chitietpn.Soluong) as [Tổng tiền] from Phieunhap, Chitietpn, Hanghoa, Nhacungcap, Khohang where Phieunhap.Mapn = Chitietpn.Mapn and Chitietpn.Mahh = Hanghoa.Mahh and Phieunhap.Mancc = Nhacungcap.Mancc and Khohang.Mak = Phieunhap.Mak ";
            DataTable dt = bll.ExcuQuery(query);
            dgvThongkepn.DataSource = dt;
            txtmapn.ForeColor = Color.Brown;
            txtTien.ForeColor = Color.Brown;
        }


        private void Tongtien(string mapn)
        {
            try
            {
                int Tongtien = 0;
                string query = "select Sum(Soluong * Dongia) as [Tongtien] from Chitietpn where Mapn = '" + mapn + "'";
                DataTable dt = bll.ExcuQuery(query);
                string tien = dt.Rows[0]["Tongtien"].ToString();
                Tongtien = Int32.Parse(tien);
                //txtTien.Text = dt.Rows[0]["Tongtien"].ToString();
                txtTien.Text = txtmapn.Text + " tổng tiền nhập hàng là:  " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", Tongtien) + " VNĐ";
            }catch (Exception)
            {
                txtTien.Text = "Vui lòng nhập đúng mã phiếu nhập";
                txtTien.ForeColor = Color.Brown;
            }
        }


    
        private void btnCong_Click(object sender, EventArgs e)
        {
            string mapn = txtmapn.Text;
            Tongtien(mapn);
            txtmapn.Text = "";
        }

        private void txtTimkiemphieunhap_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTimkiemphieunhap.Text;
            string query = "select Chitietpn.Mapn as [Mã phiếu nhập],Tenhh as [Tên hàng hóa],Chitietpn.Soluong as [Số lượng nhập],Chitietpn.Dongia as [Đơn giá nhập],Ngaynhap as [Ngày nhập],Tenncc as [Nhà cung cấp],Tenk as [Tên kho], (Chitietpn.Dongia * Chitietpn.Soluong) as [Tổng tiền] from Phieunhap, Chitietpn, Hanghoa, Nhacungcap, Khohang where Phieunhap.Mapn = Chitietpn.Mapn and Chitietpn.Mahh = Hanghoa.Mahh and Phieunhap.Mancc = Nhacungcap.Mancc and Khohang.Mak = Phieunhap.Mak  and Hanghoa.Tenhh like N'%"+tk+"%";
            if (!string.IsNullOrEmpty(txtTimkiemphieunhap.Text))
            {
                DataTable dt = bll.ExecuteTimkiem(tk, query);
                dgvThongkepn.DataSource = dt;
            }
            else
                Hienthi();
        }
    }
}
