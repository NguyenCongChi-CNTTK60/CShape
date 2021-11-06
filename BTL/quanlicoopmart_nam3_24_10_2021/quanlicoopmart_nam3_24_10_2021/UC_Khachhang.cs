using quanlicoopmart_nam3_24_10_2021.getdataaa;
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
    public partial class UC_Khachhang : UserControl
    {

        BLL bll = new BLL();
        Khachhang kh = new Khachhang();
        public UC_Khachhang()
        {
            InitializeComponent();
            Hienthi();
            txtMakh.Text = Matudong();
            txtMakh.ReadOnly = true;
        }
        private void UC_Khachhang_Load(object sender, EventArgs e)
        {

        }

        private void Anhxa()
        {
            kh.Makh = txtMakh.Text;
            kh.Tenkh = txtTenkh.Text;
            kh.Ngaysinh = dtpNgaysinh.Value;
            kh.Diachi = txtDiachi.Text;
            kh.Sdt = txtSđt.Text;
        }

        //
        // KIỂM TRA DATA
        //
        private bool check_data()
        {

            if (string.IsNullOrEmpty(txtTenkh.Text))
            {
                errorTenkh.SetError(txtTenkh, labelThem.Text = "Vui lòng nhập tên khách hàng");
                labelThem.ForeColor = Color.Red;
                return false;
            }
            else
                errorTenkh.SetError(txtTenkh, null);


            if (string.IsNullOrEmpty(txtDiachi.Text))
            {
                errorDiachi.SetError(txtDiachi, labelThem.Text = "Vui lòng nhập địa chỉ");
                labelThem.ForeColor = Color.Red;
                return false;
            }
            else
                errorDiachi.SetError(txtDiachi, null);



            if (string.IsNullOrEmpty(txtSđt.Text))
            {
                errorSđt.SetError(txtSđt, labelThem.Text = "Vui lòng số điện thoại");
                labelThem.ForeColor = Color.Red;
                return false;
            }
            else
                errorSđt.SetError(txtSđt, null);

            return true;
        }


        //
        // HIỂN THỊ VÀ TẠO MÃ TỰ ĐỘNG 
        string query1 = "select Makh as [Mã khách hàng], Tenkh as [Tên khách hàng], Ngaysinh as [Ngày sinh], Diachi as [Địa chỉ], Sdt as [Số điện thoại] from Khachhang ";
        public void Hienthi()
        {
            
            DataTable dt = bll.ExcuQuery(query1);
            dgvKhachHang.DataSource = dt;
            //string ma = "";
        }



        private string Matudong()
        {   
            
            DataTable dt = bll.ExcuQuery(query1);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "KH001";
            }
            else
            {
                int k;
                ma = "KH";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k++;
                if (k < 10)
                {
                    ma = ma + "00";
                }
                else if (k > 10 && k < 100)
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

        //
        // THÊM KHÁCH HÀNG
        //
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (check_data() == true)
            {
                string query = "insert into Khachhang (Makh,Tenkh,Ngaysinh,Diachi,Sdt) values (@Makh,@Tenkh,@Ngaysinh,@Diachi,@Sdt)";
                Anhxa();
                if (bll.Them_Sua_Xoa_KH(kh,query) == true)
                {
                    labelThem.Text = "Thêm thành công";
                    labelThem.ForeColor = Color.Brown;
                    Hienthi();
                    Lammoi();
                    txtMakh.Text = Matudong();
                }
                else
                {
                    labelThem.Text = "Thêm thất bại";
                    labelThem.ForeColor = Color.Brown;
                    Lammoi();
                    txtMakh.Text = Matudong();
                }
            }

        }



        //
        // XÓA KHÁCH HÀNG
        //
        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            string query3 = "delete Khachhang where Makh = @Makh ";
            Anhxa();

             if (bll.Them_Sua_Xoa_KH(kh,query3) == true)
            {
                Hienthi();
                labelThem.Text = "Xóa thành công";
                labelThem.ForeColor = Color.Brown;
            }
            else
                labelThem.Text = "Xóa thất bại";
                labelThem.ForeColor = Color.Brown; 
         

        }


        //
        // DATAGRIDVIEW THAY ĐỔI
        //
        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtMakh.Text = dgvKhachHang.Rows[indexx].Cells[0].Value.ToString();
            txtTenkh.Text = dgvKhachHang.Rows[indexx].Cells[1].Value.ToString();
            dtpNgaysinh.Text = dgvKhachHang.Rows[indexx].Cells[2].Value.ToString();
            txtDiachi.Text = dgvKhachHang.Rows[indexx].Cells[3].Value.ToString();
            txtSđt.Text = dgvKhachHang.Rows[indexx].Cells[4].Value.ToString();
            labelThem.Text = "";
        }

        private void txtMakh_TextChanged(object sender, EventArgs e)
        {

        }


        //
        // BUTTON LÀM MỚI 
        //
        private void Lammoi()
        {
            txtMakh.Text = Matudong();
            txtTenkh.Text = "";
            txtDiachi.Text = "";
            txtSđt.Text = "";
        }
        private void btnLamMoiKH_Click(object sender, EventArgs e)
        {
            Lammoi();
        }



        //
        // BUTTON SỬA 
        //
        private void btnSuaKH_Click(object sender, EventArgs e)
        {

            if (check_data() == true)
            {
                string query = "update Khachhang set Makh = @Makh, Tenkh = @Tenkh, Ngaysinh = @Ngaysinh, Diachi = @Diachi, Sdt = @Sdt where Makh = @Makh";
                Anhxa();
                if (bll.Them_Sua_Xoa_KH(kh,query))
                {
                    Hienthi();
                    labelThem.Text = "Sửa thành công";
                    labelThem.ForeColor = Color.Brown;
                }
                else
                    labelThem.Text = "Sửa thất bại";
                    labelThem.ForeColor = Color.Brown;

            }

        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTimkiem.Text;
            string query = "select * from Khachhang where Makh like N'%" + tk + "%' or  Tenkh like  N'%" + tk + "%'  or Diachi like N'%" + tk + "%'";
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                DataTable dt = bll.ExecuteTimkiem(tk,query);
                dgvKhachHang.DataSource = dt;
            }
            else
                Hienthi();

        }


        
    }
}
