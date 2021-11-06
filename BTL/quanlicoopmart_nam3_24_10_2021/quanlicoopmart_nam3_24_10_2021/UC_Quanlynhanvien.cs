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
    public partial class UC_Quanlynhanvien : UserControl
    {
        public UC_Quanlynhanvien()
        {
            
            InitializeComponent();
            UC_Nhanvien uC_Nhanvien = new UC_Nhanvien();
            addUC(uC_Nhanvien);
        }


        private void DichuyenPanle(Control control)
        {
          
        }

        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlQuanlynhanvien.Controls.Clear();
            pnlQuanlynhanvien.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnChucvu_Click(object sender, EventArgs e)
        {
            paneldichuyencv.BackColor = Color.Maroon;
            pnldichuyenpgc.BackColor = Color.LightSteelBlue;
            pnldichuyengiaoc.BackColor = Color.LightSteelBlue;
            pnlduchuyenptk.BackColor = Color.LightSteelBlue;
            UC_Chucvu uC_Chucvu = new UC_Chucvu();
            addUC(uC_Chucvu);
        }

        private void btnPhieugc_Click(object sender, EventArgs e)
        {
            paneldichuyencv.BackColor = Color.LightSteelBlue;
            pnldichuyenpgc.BackColor = Color.Maroon;
            pnldichuyengiaoc.BackColor = Color.LightSteelBlue;
            pnlduchuyenptk.BackColor = Color.LightSteelBlue;
            UC_Quanlyphieugiaoca uC_Quanlyphieugiaoca = new UC_Quanlyphieugiaoca();
            addUC(uC_Quanlyphieugiaoca);
        }

        private void btnGiaoca_Click(object sender, EventArgs e)
        {
            paneldichuyencv.BackColor = Color.LightSteelBlue;
            pnldichuyenpgc.BackColor = Color.LightSteelBlue;
            pnldichuyengiaoc.BackColor = Color.Maroon;
            pnlduchuyenptk.BackColor = Color.LightSteelBlue;
            UC_Giaoca uC_Giaoca = new UC_Giaoca();
            addUC(uC_Giaoca);
        }
    }
}
