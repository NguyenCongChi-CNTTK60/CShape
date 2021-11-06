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
    public partial class UC_Main : UserControl
    {
        public UC_Main()
        {
            InitializeComponent();
        }

        BLL bll = new BLL();

        public void Demkh()
        {
            string query = "select count(Makh) AS [Soluong] from Khachhang";
            DataTable dt = bll.ExcuQuery(query);
            lblDemkh.Text = "";
            lblDemkh.Text = dt.Rows[0]["Soluong"].ToString();
        }


        public void Demnv()
        {
            string query = "select count(Manv) AS [Soluong] from Nhanvien";
            DataTable dt = bll.ExcuQuery(query);
            lbldemNv.Text = "";
            lbldemNv.Text = dt.Rows[0]["Soluong"].ToString();
        }


        private void Demhd()
        {
            string query = "select count(Mahd) as [Soluong] from Hoadon";
            DataTable dt = bll.ExcuQuery(query);
            lblDemhd.Text = "";
            lblDemhd.Text = dt.Rows[0]["Soluong"].ToString();
        }


        private void UC_Main_Load(object sender, EventArgs e)
        {
            Demkh();
            Demnv();
            Demhd();
        }
    }
}
