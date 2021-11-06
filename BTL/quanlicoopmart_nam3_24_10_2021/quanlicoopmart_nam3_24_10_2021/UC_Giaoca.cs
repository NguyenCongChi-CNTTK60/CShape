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
    public partial class UC_Giaoca : UserControl
    {
        public UC_Giaoca()
        {
            InitializeComponent();
            Hienthi();
            cmbgiaoca.Items.Add("PGC001");
            cmbgiaoca.Items.Add("PGC002");
            cmbgiaoca.Items.Add("PGC003");
            cmbgiaoca.Items.Add("");
            SudungDatabase st = new SudungDatabase();
            List<Phieugiaoca> pgc = st.Phieugiaocas.ToList();
            cmbgiaoca.DataSource = pgc;
            cmbgiaoca.ValueMember = "Mapgc";
        }
        BLL bll = new BLL();
        Chitietpgc gc = new Chitietpgc();
        private void Hienthi()
        {
            string query = "select Chitietpgc.Manv as [Mã nhân viên],Tennv as [Tên nhân viên],Chitietpgc.Mapgc as [Mã phiếu giao ca],Ca as [Giờ làm],Ngay as [Ngày làm]  from Chitietpgc,Nhanvien,Phieugiaoca where Nhanvien.Manv = Chitietpgc.Manv and Chitietpgc.Mapgc = Phieugiaoca.Mapgc  order by Ngay asc";
            DataTable dt = bll.ExcuQuery(query);
            dgvGiaoca.DataSource = dt;
        }

        private void btnThemGC_Click(object sender, EventArgs e)
        {
            string query1 = "insert into Chitietpgc(Manv,Mapgc,Ngay) values (@Manv,@Mapgc,@Ngay)";
            Anhxa();
            if (bll.Them_Sua_Xoa_GC(gc,query1) == true)
            {
                lblThem.Text = "Thêm thành công";
                lblThem.ForeColor = Color.Brown;
                Hienthi();
          
            }
            else
            {
                lblThem.Text = "Thêm thất bại";
                lblThem.ForeColor = Color.Brown;
                
            } 
        }


        private void Anhxa()
        {
            gc.Manv = txtManvgiaoca.Text;
            gc.Mapgc = cmbgiaoca.Text;
            gc.Ngay = dpkNgaygc.Value;
        }


        private void dgvGiaoca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtManvgiaoca.Text = dgvGiaoca.Rows[indexx].Cells["Mã nhân viên"].Value.ToString();
            cmbgiaoca.Text = dgvGiaoca.Rows[indexx].Cells["Mã phiếu giao ca"].Value.ToString();
            dpkNgaygc.Text = dgvGiaoca.Rows[indexx].Cells["Ngày làm"].Value.ToString();
        }

        private void btnXoagc_Click(object sender, EventArgs e)
        {
            string query1 = "delete Chitietpgc where  Manv = @Manv";
            Anhxa();
            if (bll.Them_Sua_Xoa_GC(gc, query1) == true)
            {
                lblThem.Text = "Xóa thành công";
                lblThem.ForeColor = Color.Brown;
                Hienthi();

            }
            else
            {
                lblThem.Text = "Không thể xóa giao ca này";
                lblThem.ForeColor = Color.Brown;

            }
        }

        private void btnSuagc_Click(object sender, EventArgs e)
        {
            string query1 = "update Chitietpgc set Manv = @Manv,Mapgc = @Mapgc,Ngay = @Ngay where Manv = @Manv";
            Anhxa();
            if (bll.Them_Sua_Xoa_GC(gc, query1) == true)
            {
                lblThem.Text = "Xóa thành công";
                lblThem.ForeColor = Color.Brown;
                Hienthi();

            }
            else
            {
                lblThem.Text = "Không thể xóa giao ca này";
                lblThem.ForeColor = Color.Brown;

            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTimkiem.Text;
            string query = "select Chitietpgc.Manv as [Mã nhân viên],Tennv as [Tên nhân viên],Chitietpgc.Mapgc as [Mã phiếu giao ca],Ca as [Giờ làm],Ngay as [Ngày làm]  from Chitietpgc inner join Nhanvien on Nhanvien.Manv = Chitietpgc.Manv inner join Phieugiaoca on Chitietpgc.Mapgc = Phieugiaoca.Mapgc where Chitietpgc.Manv like '%"+tk+"%' or Tennv like N'%"+tk+"%' or Ngay like N'%"+tk+"%' or Ca like N'"+tk+"' order by Ngay asc";
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                DataTable dt = bll.ExecuteTimkiem(tk, query);
                dgvGiaoca.DataSource = dt;
            }
            else
                Hienthi();
        }

        private void btnLamMoigc_Click(object sender, EventArgs e)
        {
            txtManvgiaoca.Text = "";
            cmbgiaoca.Text = "";
        }
    }
}
