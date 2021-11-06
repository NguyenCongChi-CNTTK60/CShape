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
    public partial class UC_Thongke : UserControl
    {
        public UC_Thongke()
        {
            InitializeComponent();
        }

        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlThongke.Controls.Clear();
            pnlThongke.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnHanghoa_Click(object sender, EventArgs e)
        {
            pnldichuyenHanghoa.BackColor = Color.Maroon;
            pnldichuyenhoadon.BackColor = Color.LightSteelBlue;
            pnldichuyenkhachhang.BackColor = Color.LightSteelBlue;
            pnldichuyenphieunhap.BackColor = Color.LightSteelBlue;
            UC_thongKehanghoa uC_ThongKehanghoa = new UC_thongKehanghoa();
            addUC(uC_ThongKehanghoa);
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            pnldichuyenHanghoa.BackColor = Color.LightSteelBlue;
            pnldichuyenhoadon.BackColor = Color.Maroon;
            pnldichuyenkhachhang.BackColor = Color.LightSteelBlue;
            pnldichuyenphieunhap.BackColor = Color.LightSteelBlue;
            UC_Thongkehoadon uC_Thongkehoadon = new UC_Thongkehoadon();
            addUC(uC_Thongkehoadon);
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            pnldichuyenHanghoa.BackColor = Color.LightSteelBlue;
            pnldichuyenhoadon.BackColor = Color.LightSteelBlue;
            pnldichuyenkhachhang.BackColor = Color.Maroon;
            pnldichuyenphieunhap.BackColor = Color.LightSteelBlue;
            UC_Thongkekhachhang uC_Thongkekhachhang = new UC_Thongkekhachhang();
            addUC(uC_Thongkekhachhang);
        }

        private void btnphieunhap_Click(object sender, EventArgs e)
        {
            pnldichuyenHanghoa.BackColor = Color.LightSteelBlue;
            pnldichuyenhoadon.BackColor = Color.LightSteelBlue;
            pnldichuyenkhachhang.BackColor = Color.LightSteelBlue;
            pnldichuyenphieunhap.BackColor = Color.Maroon;
            UC_Thongkephieunhap uC_Thongkephieunhap = new UC_Thongkephieunhap();
            addUC(uC_Thongkephieunhap);
        }
    }
}
