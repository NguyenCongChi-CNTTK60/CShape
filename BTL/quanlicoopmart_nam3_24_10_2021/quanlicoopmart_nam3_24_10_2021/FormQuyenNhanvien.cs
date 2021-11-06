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
    public partial class FormQuyenNhanvien : Form
    {
        public FormQuyenNhanvien()
        {
            InitializeComponent();
            timerNhanvien.Start();
            UC_Main uC_Main = new UC_Main();
            addUC(uC_Main);
        }

        private void DichuyenPanle(Control control)
        {
            panelDichuyen.Top = control.Top;
            panelDichuyen.Height = control.Height;
        }


        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlTrangchu.Controls.Clear();
            pnlTrangchu.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DichuyenPanle(btnDangnhap);
            UC_Main uC_Main = new UC_Main();
            addUC(uC_Main);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            DichuyenPanle(btnKhachHang);
            UC_Khachhang uC_Khachhang = new UC_Khachhang();
            addUC(uC_Khachhang);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormDangnhap formDangnhap = new FormDangnhap();
            formDangnhap.Show();
            this.Hide();
        }

        private void TimerNhanvien_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:MM:ss");
        }
    }
}
