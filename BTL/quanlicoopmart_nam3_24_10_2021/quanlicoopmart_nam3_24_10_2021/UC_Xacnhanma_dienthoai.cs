using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlicoopmart_nam3_24_10_2021
{
    public partial class UC_Xacnhanma_dienthoai : UserControl
    {
        private string xn;
        public UC_Xacnhanma_dienthoai(string mk)
        {
            InitializeComponent();
            this.xn = mk;
            txtSđtnv.Text = xn;
            timer1.Start();
            txtMa.Focus();
        }
        Chuoiketnoi chuoiketnoi = new Chuoiketnoi();

        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void dem()
        {

        }

        int i = 60;
        private void giay(object sender, EventArgs e)
        {
            i--;
            lblDem.Text = i.ToString();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            lblCanhbao.Text = "";
        }

        private bool check_data()
        {
            if (string.IsNullOrEmpty(txtMa.Text))
            {
                errorProvider1.SetError(txtMa, " ");
                lblCanhbao.Text = "Vui lòng nhập tài khoản";
                lblCanhbao.ForeColor = Color.Brown;
                return false;
            }
            else
                errorProvider1.SetError(txtMa, null);
            return true;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            lblDem.Text = "";
            lblmaxn.Text = "";
            lblgiay.Text = "";
            timer1.Stop();
            if (check_data() == true)
            {
                SqlConnection con = chuoiketnoi.sqlConnection();
                con.Open();
                string tk = txtMa.Text;
                string query = "select Tendangnhap from Nhanvien where Tendangnhap = '" + tk + "'";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read() == true)
                {
                    UC_Dangkymk_moi uC_Dangkymk_Moi = new UC_Dangkymk_moi(txtSđtnv.Text);
                    addUC(uC_Dangkymk_Moi);
                }
                else
                    lblCanhbao.Text = "Mã không đúng - Vui lòng thử lại";
                lblCanhbao.ForeColor = Color.Brown;
                con.Close();
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FormDangnhap formDangnhap = new FormDangnhap();
            formDangnhap.Show();
            this.Hide();
        }
    }
}
