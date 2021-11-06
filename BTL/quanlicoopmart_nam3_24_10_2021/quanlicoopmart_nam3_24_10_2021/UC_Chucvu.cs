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
    public partial class UC_Chucvu : UserControl
    {
        public UC_Chucvu()
        {
            InitializeComponent();
        }

        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlPhanquyen.Controls.Clear();
            pnlPhanquyen.Controls.Add(userControl);
            userControl.BringToFront();
        }

    

        private void btnQuanly_Click_1(object sender, EventArgs e)
        {

            UC_Vaitroquanly uC_Vaitroquanly = new UC_Vaitroquanly();
            addUC(uC_Vaitroquanly);
        }

        private void btnquyenNhanvien_Click(object sender, EventArgs e)
        {
            UC_Vaitronhanvien uC_Vaitronhanvien = new UC_Vaitronhanvien();
            addUC(uC_Vaitronhanvien);
        }

        private void btnChucvu_Click(object sender, EventArgs e)
        {
            UC_Quanlychuvu uC_Quanlychuvu = new UC_Quanlychuvu();
            addUC(uC_Quanlychuvu);
        }
    }
}
