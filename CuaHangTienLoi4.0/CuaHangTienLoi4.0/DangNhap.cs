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

namespace CuaHangTienLoi4._0
{
    public partial class FormDangnhap : Form
    {
        public FormDangnhap()
        {
            InitializeComponent();
        }
         
        public bool check_Data() { 

            if (string.IsNullOrWhiteSpace(txtTaikhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập Tài Khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaikhoan.Focus();
                return false;
            }
            // TEN SINH VIEN
            if (string.IsNullOrWhiteSpace(txtMatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatkhau.Focus();
                return false;
            }
            return true;
        }

            private void btnDangNhap_Click(object sender, EventArgs e)
           {



            //check_Data();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LRQ8VCB\SQLEXPRESS;Initial Catalog=CUAHANGTIENLOI;Integrated Security=True");
            con.Open();
            string tk = txtTaikhoan.Text;
            string mk = txtMatkhau.Text;
            string sql = "select tendangnhap,matkhau  from nhanvien where tendangnhap like '"+ tk +"' and matkhau like '"+ mk +"' and quyen = 'QL'";
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader dta = cmd.ExecuteReader();
            
            if(dta.Read() == true)
            {
                FormMain formMain = new FormMain();
                formMain.Show();
                this.Hide();              
            }else{
                MessageBox.Show("Bạn nhập sai tên hoặc mật khẩu \nVui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                //txtTaikhoan.Focus();
            }

            con.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
