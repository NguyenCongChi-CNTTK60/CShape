using quanlicoopmart_nam3_24_10_2021.getdataaa;
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
    public partial class FormDangkynhanvien : Form
    {
        public FormDangkynhanvien()
        {
            InitializeComponent();
            txtMa.Text = Matudong();
            cmbGioitinhnv.Items.Add("Nam");
            cmbGioitinhnv.Items.Add("Nữ");
            cmbGioitinhnv.Items.Add("Khác");
            cmbGioitinhnv.Items.Add("");

        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FormDangnhap formDangnhap = new FormDangnhap();
            formDangnhap.Show();
            this.Hide();
        }

        BLL bll = new BLL();
        Chuoiketnoi chuoiketnoi = new Chuoiketnoi();



        string query1 = "select Manv, Tennv, Ngaysinh, Diachi, Sdt, Gioitinh, Tendangnhap, Matkhau from Nhanvien";
        private string Matudong()
        {

            DataTable dt = bll.ExcuQuery(query1);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "NV001";
            }
            else
            {
                int k;
                ma = "NV";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k++;
                if (k < 10)
                {
                    ma = ma + "00";
                }
                else if (k >= 10 && k < 100)
                {
                    ma = ma + "0";
                }
                else if (k >= 100 && k < 1000)
                {
                    ma = ma + " ";
                }
                ma = ma + k.ToString();

            }
            return ma;
        }


        private bool check_Data()
        {
            if (string.IsNullOrEmpty(txtMa.Text))
            {
                erMa.SetError(txtMa, labelThem.Text = "Vui lòng nhập mã nhân viên");
                labelThem.ForeColor = Color.Brown;
                return false;
            }
            else
                erMa.SetError(txtMa, null);


            if (string.IsNullOrEmpty(txtTen.Text))
            {
                erTen.SetError(txtTen, labelThem.Text = "Vui lòng nhập tên của bạn");
                labelThem.ForeColor = Color.Brown;
                return false;
            }
            else
                erTen.SetError(txtTen, null);

            /* if (string.IsNullOrEmpty(txtDiachi.Text))
            {
                erDiachi.SetError(txtDiachi, labelThem.Text = "Vui lòng nhập địa chỉ");
                labelThem.ForeColor = Color.Brown;
                return false;
            }
            else
                erDiachi.SetError(txtDiachi, null); */

            if (string.IsNullOrEmpty(txtSđtnv.Text))
            {
                erSđt.SetError(txtSđtnv, labelThem.Text = "Vui lòng nhập địa số điện thoại");
                labelThem.ForeColor = Color.Brown;
                return false;
            }
            else
                erSđt.SetError(txtSđtnv, null);


            if (string.IsNullOrEmpty(txtTendn.Text))
            {
                ertaikhoan.SetError(txtTendn, labelThem.Text = "Vui lòng nhập tên đăng nhập");
                labelThem.ForeColor = Color.Brown;
                return false;
            }
            else
                ertaikhoan.SetError(txtTendn, null);


            if (string.IsNullOrEmpty(txtMatkhau.Text))
            {
                erMatkhau.SetError(txtMatkhau, labelThem.Text = "Vui lòng nhập mật khẩu");
                labelThem.ForeColor = Color.Brown;
                return false;
            }
            else
                erMatkhau.SetError(txtMatkhau, null);


           /* if (string.IsNullOrWhiteSpace(cmbGioitinhnv.Text))
            {
                labelThem.Text = "Vui lòng chọn giới tính";
                labelThem.ForeColor = Color.Brown;
                return false;
            } */

            return true;
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check_Data() == true)
            {
                    string query = "select Matkhau as [Mat khau] from Nhanvien where Matkhau = '" + txtMatkhau.Text + "'";
                    DataTable dt = bll.ExcuQuery(query);
                    int i = dt.Rows.Count;
                if (i > 0)
                {
                    lblktmatkhau.Text = "Mật khẩu đã tồn tại";
                    lblktmatkhau.ForeColor = Color.Brown;
                }
                else
                {
                    lblktmatkhau.Text = "";
                    string query2 = "insert into Nhanvien (Manv, Tennv, Ngaysinh, Gioitinh, Diachi, Sdt, Tendangnhap, Matkhau,Macv,Maqtn) values (@Manv, @Tennv, @Ngaysinh, @Gioitinh, @Diachi, @Sdt, @Tendangnhap, @Matkhau,null,null)";
                    Nhanvien nv = new Nhanvien();
                    nv.Manv = txtMa.Text;
                    nv.Tennv = txtTen.Text;
                    nv.Ngaysinh = dtpNgaysinh.Value;
                    nv.Diachi = txtDiachi.Text;
                    nv.Sdt = txtSđtnv.Text;
                    nv.Gioitinh = cmbGioitinhnv.Text;
                    nv.Tendangnhap = txtTendn.Text;
                    nv.Matkhau = txtMatkhau.Text;
                    nv.Macv = "";
                    nv.Maqtn = "";


                    if (bll.Them_NV(nv, query2))
                    {
                        labelThem.Text = "Đăng ký thành công";
                        labelThem.ForeColor = Color.Brown;
                        Lammoi();
                        txtMa.Text = Matudong();
                    }
                    else
                    {
                        labelThem.Text = "Đăng ký thất bại";
                        labelThem.ForeColor = Color.Brown;
                        txtMa.Text = Matudong();
                    }
                }
                }

            }
        

       



        private void Lammoi()
        {
            txtTen.Text = "";
            txtDiachi.Text = "";
            txtSđtnv.Text = "";
            cmbGioitinhnv.Text = "";
            txtTendn.Text = "";
            txtMatkhau.Text = "";
        }

        private void labelThem_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHienmatkhau.Checked == true)
            {
                txtMatkhau.PasswordChar = '\0';
            }
            else
                txtMatkhau.PasswordChar = '*';
        }

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {
            lblktmatkhau.Text = "";
            labelThem.Text = "";
        }
    }
}

