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
    public partial class FormDangnhap : Form
    {
        public FormDangnhap()
        {
            InitializeComponent();
        }
        Chuoiketnoi chuoiketnoi = new Chuoiketnoi();


        private bool check_data()
        {
            if (string.IsNullOrEmpty(txtTaikhoan.Text))
            {
                errtxtTaikhoan.SetError(txtTaikhoan, " ");
                lblCanhbao.Text = "Vui lòng nhập tài khoản";
                lblCanhbao.ForeColor = Color.Brown;
                return false;
            }
            else
                errtxtTaikhoan.SetError(txtTaikhoan, null);

            if (string.IsNullOrEmpty(txtMatkhau.Text))
            {
                errMatkhau.SetError(txtMatkhau, " ");
                lblCanhbao.Text = "";
                lblCanhbao.Text = "Vui lòng nhập mật khẩu";
                lblCanhbao.ForeColor = Color.Brown;
                return false;
            }
            else
                errtxtTaikhoan.SetError(txtMatkhau, null);

            return true;
        }


        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (check_data() == true)
            {
                SqlConnection con = chuoiketnoi.sqlConnection();
                con.Open();
                string tk = txtTaikhoan.Text;
                string mk = txtMatkhau.Text;
                string query = "select tendangnhap,matkhau from Nhanvien where tendangnhap = '" + tk + "' and matkhau = '" + mk + "' and Macv = 'NV'";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read() == true)
                {
                    FormQuyenNhanvien formQuyenNhanvien = new FormQuyenNhanvien();
                    formQuyenNhanvien.Show();
                    this.Hide();
                }
                else
                    lblCanhbao.Text = "Sai tài khoản hoặc mật khẩu. Lưu ý đăng nhập là nhân viên!";
                lblCanhbao.ForeColor = Color.Brown;
                con.Close();
            }
        }


        private void chkHienthimatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienthimatkhau.Checked == true)
            {
                txtMatkhau.PasswordChar = '\0';
            }
            else
                txtMatkhau.PasswordChar = '*';
        }


        private void lblThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblAmind_Click(object sender, EventArgs e)
        {
            if (check_data() == true)
            {
                SqlConnection con = chuoiketnoi.sqlConnection();
                con.Open();
                string tk = txtTaikhoan.Text;
                string mk = txtMatkhau.Text;
                string query = "select tendangnhap,matkhau from Nhanvien where tendangnhap = '" + tk + "' and matkhau = '" + mk + "' and Macv = 'QL'";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read() == true)
                {
                    FormTrangchu formTrangchu = new FormTrangchu(); // txt Taikhoan.text
                    formTrangchu.Show();
                    this.Hide();
                }
                else
                    lblCanhbao.Text = "Sai tài khoản hoặc mật khẩu. Lưu ý đăng nhập là nhà quản lý!";
                lblCanhbao.ForeColor = Color.Brown;
                con.Close();
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            FormDangkynhanvien formDangkynhanvien = new FormDangkynhanvien();
            formDangkynhanvien.Show();
            this.Hide();
        }

        private void lblMatkhau_Click(object sender, EventArgs e)
        {
            FormSodienthoai formSodienthoai = new FormSodienthoai();
            formSodienthoai.Show();
            this.Hide();
        }

        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {
            lblCanhbao.Text = "";
        }

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {
            lblCanhbao.Text = "";
        }
    }
}
