using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CuaHangTienLoi4._0
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
            SumKhachHang();
        }


        //
        // Chuỗi kết nối data
        //
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LRQ8VCB\SQLEXPRESS;Initial Catalog=CUAHANGTIENLOI;Integrated Security=True");
        KhachHangBLL khbll = new KhachHangBLL();


        //
        // Lấy data lên gridview
        //
        public DataTable getAllKhachHang()
        {

            con.Open();
            string sql = "select *from khachang";
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dtb = new DataTable();
            cmd.Fill(dtb);
            con.Close();

            return dtb;
        }

        //
        // Đặt vào một data table 
        //
        public void HienThi()
        {
            DataTable dt = getAllKhachHang();
            dataGridViewKhachHang.DataSource = dt;
        }


        //
        // Form chính khách hàng khi load
        //
        private void FormKhachHang_Load(object sender, EventArgs e)
        {

            HienThi();

        }


        //
        // Kết nối dữ kiện label với bảng Main 
        //
        private void labelHomeKhachhang_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }


        //
        // Sự kiện Cancle
        //
        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtmakh.Text = " ";
            txttenkh.Text = " ";
            cmbgioitinh.Text = " ";
            txtdiachi.Text = " ";
            txtsdt.Text = " ";
            txtemail.Text = " ";
        }


        //
        // get data từ gridview lên các textbox
        //
        private void dataGridViewKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewKhachHang.CurrentCell.RowIndex;
            txtmakh.Text = dataGridViewKhachHang.Rows[index].Cells[0].Value.ToString();
            txttenkh.Text = dataGridViewKhachHang.Rows[index].Cells[1].Value.ToString();
            cmbgioitinh.Text = dataGridViewKhachHang.Rows[index].Cells[2].Value.ToString();
            txtdiachi.Text = dataGridViewKhachHang.Rows[index].Cells[3].Value.ToString();
            txtsdt.Text = dataGridViewKhachHang.Rows[index].Cells[4].Value.ToString();
            txtemail.Text = dataGridViewKhachHang.Rows[index].Cells[5].Value.ToString();

        }


        //
        // Sự kiện nút Thêm khách hàng
        //
        private void btnThemKhanchhang_Click(object sender, EventArgs e)
        {
            BangKhachHang kh1 = new BangKhachHang();

           
                if (check_Data() == true)
                {
                    kh1.makh = txtmakh.Text;
                    kh1.tenkh = txttenkh.Text;
                    kh1.gioitinh = cmbgioitinh.Text;
                    kh1.diachi = txtdiachi.Text;
                    kh1.sdt = txtsdt.Text;
                    kh1.email = txtemail.Text;
                    khbll.ThemKhachHang(kh1);
                    SumKhachHang();
                     HienThi();
                    con.Close();
                }
        }


        //
        // Tính tổng khách hàng trong database
        //
        public void SumKhachHang()
        {
            con.Open();
            string sql = @"select COUNT(makh) from khachang";
            SqlDataAdapter adt = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            txtTongkh.Text = dt.Rows[0][0].ToString();
            txtTongkh.ReadOnly = true;
            con.Close();
        }


        //
        // Dữ kiện xóa khách hàng
        //
        private void btnXoaKhachhang_Click(object sender, EventArgs e)
        {

            if (check_Data() == true)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    BangKhachHang kh1 = new BangKhachHang();
                    kh1.makh = txtmakh.Text;
                    khbll.XoaKhachHang(kh1);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    SumKhachHang();
                    HienThi();
                }
            }
        }



        //
        // Kiểm tra data nhập vào 
        //
        public bool check_Data()
        {
            if (string.IsNullOrWhiteSpace(txtmakh.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtmakh.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txttenkh.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txttenkh.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(cmbgioitinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập giới tính khách hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbgioitinh.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtdiachi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdiachi.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtsdt.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtsdt.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("Bạn chưa nhập email khách hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtemail.Focus();
                return false;
            }

            return true;

        }



        //
        // Kiểm tra dữ liệu khi xóa
        //
        public bool check_Xoa()
        {
            if (string.IsNullOrWhiteSpace(txtmakh.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtmakh.Focus();
                //return false;
                txtmakh.ReadOnly = false;
                txttenkh.ReadOnly = true;
                cmbgioitinh.Text = " ";
                txtdiachi.ReadOnly = true;
                txtsdt.ReadOnly = true;
                txtemail.ReadOnly = true;
                return false;
            }

            return true;

        }

        private void SuaKhachHang_Click(object sender, EventArgs e)
        {
            BangKhachHang kh1 = new BangKhachHang();

            if (check_Data() == true)
            {
                kh1.makh = txtmakh.Text;
                kh1.tenkh = txttenkh.Text;
                kh1.gioitinh = cmbgioitinh.Text;
                kh1.diachi = txtdiachi.Text;
                kh1.sdt = txtsdt.Text;
                kh1.email = txtemail.Text;
                khbll.SuaKhachHang(kh1);
                SumKhachHang();
                HienThi();

            }
        }

                          
        //
        // Tìm kiếm khách hàng
        //
        private void txtTimkiemkh_TextChanged(object sender, EventArgs e)
        {
            string value = txtTimkiemkh.Text;
            //DataTable dt = new DataTable();

            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = khbll.TimkiemKhachHang(value);
                dataGridViewKhachHang.DataSource = dt;
            }
            else
                HienThi();
        }

        private void labelHoaDonKhachHang_Click(object sender, EventArgs e)
        {
            FormHoaDon formHoaDon = new FormHoaDon();
            formHoaDon.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
