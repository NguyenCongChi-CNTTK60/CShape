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
    public partial class FormTrangchu : Form
    {
        //private string Taikhoan;


        public FormTrangchu()   // string Taikhoandn
        {
            InitializeComponent();
            timertTrangchu.Start();
            UC_Main uC_Main = new UC_Main();
            addUC(uC_Main);

            //this.Taikhoan = Taikhoandn;
            //lblTaikhoan.Text = "";
            //lblTaikhoan.Text = Taikhoan;

            /* sửa ngày 5/11 này để lấy tên và manv
            string tk = lblTaikhoan.Text;
            string query = "select Manv,Tennv from Nhanvien where Tendangnhap = '" + tk + "'";
            if (!string.IsNullOrEmpty(lblTaikhoan.Text))
            {
                DataTable dt = bll.ExecuteTimkiem(tk, query);
                lblManv.Text = dt.Rows[0]["Manv"].ToString();
                lblTennv.Text = dt.Rows[0]["Tennv"].ToString();
            }  */
        }

        BLL bll = new BLL();


        //
        // Hàm add uc vào trang chủ
        //
        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlTrangchu.Controls.Clear();
            pnlTrangchu.Controls.Add(userControl);
            userControl.BringToFront();
        }


        //
        // Chuyển panle đến các button
        //
        private void DichuyenPanle(Control control)
        {
            panelDichuyen.Top = control.Top;
            panelDichuyen.Height = control.Height;
        }


        //
        // UC_Khachhang
        //
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            DichuyenPanle(btnKhachHang);
            UC_Khachhang uC_Khachhang = new UC_Khachhang();
            addUC(uC_Khachhang);
        }


        //
        // Thoát
        //
        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //
        // UC_Main
        //
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DichuyenPanle(btnDangnhap);
            UC_Main uC_Main = new UC_Main();
            addUC(uC_Main);
        }


        //
        // FormDangnhap
        //
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormDangnhap formDangnhap = new FormDangnhap();
            formDangnhap.Show();
            this.Hide();
        }


        //
        // Timer
        //
        private void timer_Trangchu(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:MM:ss");
        }


        //
        // UC_Thongke
        //
        private void btnThongke_Click(object sender, EventArgs e)
        {
            DichuyenPanle(btnThongke);
            UC_Thongke uC_Thongke = new UC_Thongke();
            addUC(uC_Thongke);
        }


        //
        // UC_Quanlynhanvine
        //
        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            DichuyenPanle(btnNhanvien);
            UC_Quanlynhanvien uC_Quanlynhanvien = new UC_Quanlynhanvien();
            addUC(uC_Quanlynhanvien);
        }


        //
        // UC_Banhang
        //
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            DichuyenPanle(btnBanHang);
            UC_Banhang uC_Banhang = new UC_Banhang(lblManv.Text, lblTennv.Text);
            addUC(uC_Banhang);
        }





    }
}
