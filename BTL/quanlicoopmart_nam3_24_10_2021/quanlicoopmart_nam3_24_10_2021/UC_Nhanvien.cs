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
    public partial class UC_Nhanvien : UserControl
    {

        public UC_Nhanvien()
        {
            InitializeComponent();
            Hienthi();
            Themvaocmb();
            cmbmacv.Items.Add("");
            SudungDatabase sudungDatabase = new SudungDatabase();
            List<Chucvu> chucvu = sudungDatabase.Chucvus.ToList();
            cmbmacv.DataSource = chucvu;
            cmbmacv.ValueMember = "Macv";
        }

        BLL bll = new BLL();
        Nhanvien nv = new Nhanvien();

        //
        // HIỂN THỊ DATA LÊN GRIDVIEW
        //
        private void Hienthi()
        {
            string query = "select Manv,Tennv,Gioitinh,Ngaysinh,Diachi,Sdt,Macv,Maqtn from Nhanvien";
            DataTable dt = bll.ExcuQuery(query);
            dgvNhanvien.DataSource = dt;
            
        }


        //
        // LẤY DỮ LIỆU TỪ GRID LÊN TEXTBOX
        //
        private void dgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtManv.Text = dgvNhanvien.Rows[indexx].Cells["Column1"].Value.ToString();
            txtTennv.Text = dgvNhanvien.Rows[indexx].Cells["Column2"].Value.ToString();
            dtpNgaysinhnv.Text = dgvNhanvien.Rows[indexx].Cells["Column3"].Value.ToString();
            txtDiachinv.Text = dgvNhanvien.Rows[indexx].Cells["Column5"].Value.ToString();
            txtSđt.Text = dgvNhanvien.Rows[indexx].Cells["Column6"].Value.ToString();
            cmbmacv.Text = dgvNhanvien.Rows[indexx].Cells["Column7"].Value.ToString();
            cmbGioitinh.Text = dgvNhanvien.Rows[indexx].Cells["Column4"].Value.ToString();
            cmbQuaytn.Text = dgvNhanvien.Rows[indexx].Cells["Column8"].Value.ToString();
            lblThongbao.Text = "";
        }

       
        //
        // SỬA NHÂN VIÊN 
        //
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (check_Data() == true)
            {
                string query = "update Nhanvien set Manv = @Manv ,Tennv = @Tennv ,Ngaysinh = @Ngaysinh, Diachi = @Diachi,Sdt = @Sdt, Gioitinh = @Gioitinh, Macv = @Macv,Maqtn = @Maqtn  where Manv = @Manv";
                Anhxa();

                if (bll.Sua_Xoa_NV(nv, query) == true)
                {
                    Hienthi();
                    lblThongbao.Text = "Sửa nhân viên thành công";
                    lblThongbao.ForeColor = Color.Brown;
                }
                else
                    lblThongbao.Text = "Không thể sửa nhân viên này";
                    lblThongbao.ForeColor = Color.Brown;
            }

            

        }


        //
        // LÀM MỚI 
        //
        private void btnLamMoiNV_Click(object sender, EventArgs e)
        { 
            txtDiachinv.Text = "";
            txtManv.Text = "";
            txtSđt.Text = "";
            txtTimkiem.Text = "";
            txtTennv.Text = "";
            cmbGioitinh.Text = "";
            cmbmacv.Text = "";
            cmbQuaytn.Text = "";
        }


        private void Anhxa()
        {
          
            nv.Manv = txtManv.Text;
            nv.Tennv = txtTennv.Text;
            nv.Ngaysinh = dtpNgaysinhnv.Value;
            nv.Diachi = txtDiachinv.Text;
            nv.Sdt = txtSđt.Text;
            nv.Gioitinh = cmbGioitinh.Text;
            nv.Macv = cmbmacv.Text;
            nv.Maqtn = cmbQuaytn.Text;
        }

        //
        // KIỂM TRA DATA
        //
        private bool check_Data()
        {
            
            if (string.IsNullOrEmpty(txtManv.Text))
            {
                errorManv.SetError(txtManv, lblThongbao.Text = "Mã nhân viên buộc phải nhập");
                lblThongbao.ForeColor = Color.Brown;
                return false;
            }
            else
                errorManv.SetError(txtManv, null);


            if (string.IsNullOrEmpty(txtTennv.Text))
            {
                errorTennv.SetError(txtTennv, lblThongbao.Text = "Tên nhân viên buộc phải nhập");
                lblThongbao.ForeColor = Color.Brown;
                return false;
            }
            else
                errorTennv.SetError(txtTennv, null);


            if (string.IsNullOrEmpty(txtSđt.Text))
            {
                errorSdt.SetError(txtSđt, lblThongbao.Text = "SĐT nhân viên buộc phải nhập");
                lblThongbao.ForeColor = Color.Brown;
                return false;
            }
            else
                errorSdt.SetError(txtSđt, null);


            if (string.IsNullOrWhiteSpace(cmbmacv.Text))
            {
                lblThongbao.Text = "Vui lòng chọn chức vụ";
                lblThongbao.ForeColor = Color.Brown;
                return false;
            }


            if (string.IsNullOrWhiteSpace(cmbQuaytn.Text))
            {
                lblThongbao.Text = "Vui lòng quầy thu ngân";
                lblThongbao.ForeColor = Color.Brown;
                return false;
            }



            return true;
        }

        private void btnXoaNV_Click_1(object sender, EventArgs e)
        {
            if (check_Data() == true)
            {
                string query3 = "delete Nhanvien where Manv = @Manv";
                Anhxa();
                if (bll.Sua_Xoa_NV(nv, query3) == true)
                {
                    Hienthi();
                    lblThongbao.Text = "Xóa thành công";
                    lblThongbao.ForeColor = Color.Brown;
                }
                else
                    lblThongbao.Text = "Không thể xóa nhân viên này";
                lblThongbao.ForeColor = Color.Brown;

            }
        }

       

        private void Themvaocmb()
        {
            cmbmacv.Items.Add("QL");
            cmbmacv.Items.Add("NV");
            cmbGioitinh.Items.Add("Nam");
            cmbGioitinh.Items.Add("Nữ");
            cmbGioitinh.Items.Add("Khác");
            cmbGioitinh.Items.Add("");
            cmbQuaytn.Items.Add("QTN001");
            cmbQuaytn.Items.Add("QTN002");
            cmbQuaytn.Items.Add("QTN003");
            cmbQuaytn.Items.Add("QTN004");
            cmbQuaytn.Items.Add("");

        }

        private void cmbQuaytn_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblThongbao.Text = "";
        }

        private void cmbmacv_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblThongbao.Text = "";
        }

        private void txtTennv_TextChanged(object sender, EventArgs e)
        {
            lblThongbao.Text = "";
        }

        private void txtDiachinv_TextChanged(object sender, EventArgs e)
        {
            lblThongbao.Text = "";
        }

        private void txtSđt_TextChanged(object sender, EventArgs e)
        {
            lblThongbao.Text = "";
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTimkiem.Text;
            string query = "select Manv,Tennv,Gioitinh,Ngaysinh,Diachi,Sdt,Macv,Maqtn from Nhanvien where Manv like '%" + tk + "' or Tennv like '%" + tk + "' or Sdt like '%" + tk + "%' or Diachi like N'%" + tk + "%'";
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                DataTable dt = bll.ExecuteTimkiem(tk, query);
                dgvNhanvien.DataSource = dt;
            }
            else
                Hienthi();
        }
    }
    }

