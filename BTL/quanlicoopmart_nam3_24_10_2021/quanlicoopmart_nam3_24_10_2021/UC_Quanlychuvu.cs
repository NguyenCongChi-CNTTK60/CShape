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
    public partial class UC_Quanlychuvu : UserControl
    {
        //private string cvthem;
        public UC_Quanlychuvu()
        {
            InitializeComponent();
            Hienthi();
           


        }

        BLL bll = new BLL();
        private bool check_Data()
        {
            if (string.IsNullOrEmpty(txtMacv.Text))
            {
                errorMacv.SetError(txtMacv, lblThongbao.Text = "Vui lòng nhập mã chức vụ");
                lblThongbao.ForeColor = Color.Brown;
                return false;
            }
            else
                errorMacv.SetError(txtMacv, null);

            if (string.IsNullOrEmpty(txtTencv.Text))
            {
                errorTencv.SetError(txtTencv, lblThongbao.Text = "Vui lòng tên chức vụ");
                lblThongbao.ForeColor = Color.Brown;
                return false;
            }
            else
                errorTencv.SetError(txtTencv, null);

            return true;

        }
        private void Hienthi()
        {
            string query = "select Macv as [Mã chức vụ], Tencv as [Tên chức vụ] from Chucvu";
            DataTable dt = bll.ExcuQuery(query);
            dgvQuanlychucvu.DataSource = dt;
        }

        private void btnThemCV_Click(object sender, EventArgs e)
        {
            if (check_Data() == true)
            {
                Chucvu cv = new Chucvu();
                cv.Macv = txtMacv.Text;
                cv.Tencv = txtTencv.Text;
                string query = "insert into Chucvu  (Macv,Tencv) values (@Macv,@Tencv)";
                if (bll.Them_Sua_Xoa_CV(cv, query) == true)
                {
                    Hienthi();
                    lblThongbao.Text = "Thêm chức vụ thành công";
                    lblThongbao.ForeColor = Color.Brown;
                    Lammoi();


                }
                else
                    lblThongbao.Text = "Mã chức vụ đã tồn tại\nHãy tạo một mã mới";
                lblThongbao.ForeColor = Color.Brown;
                //UC_Nhanvien uC_Nhanvien = new UC_Nhanvien(txtMacv.Text);
            }
        }

        private void btnXoacv_Click(object sender, EventArgs e)
        {
            if (check_Data() == true)
            {
                Chucvu cv = new Chucvu();
                cv.Macv = txtMacv.Text;
                cv.Tencv = txtTencv.Text;
                string query = "delete Chucvu where Macv = @Macv";
                if (bll.Them_Sua_Xoa_CV(cv, query) == true)
                {
                    Hienthi();
                    lblThongbao.Text = "Xóa chức vụ thành công";
                    lblThongbao.ForeColor = Color.Brown;
                    Lammoi();
                }
                else
                    lblThongbao.Text = "Không thể xóa chức vụ này";
                lblThongbao.ForeColor = Color.Brown;
            }
        }

        private void dgvQuanlychucvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtMacv.Text = dgvQuanlychucvu.Rows[indexx].Cells[0].Value.ToString();
            txtTencv.Text = dgvQuanlychucvu.Rows[indexx].Cells[1].Value.ToString();
            lblThongbao.Text = "";
        }


        private void Lammoi()
        {
            txtMacv.Text = "";
            txtTencv.Text = "";
        }

        private void btnSuanv_Click(object sender, EventArgs e)
        {
            if (check_Data() == true)
            {
                Chucvu cv = new Chucvu();
                string query1 = "update Chucvu set Macv = @Macv, Tencv = @Tencv where Macv = @Macv";
                cv.Macv = txtMacv.Text;
                cv.Tencv = txtTencv.Text;
                if (bll.Them_Sua_Xoa_CV(cv, query1) == true)
                {
                    Hienthi();
                    lblThongbao.Text = "Sửa chức vụ thành công";
                    lblThongbao.ForeColor = Color.Brown;
                    Lammoi();
                }
                else
                    lblThongbao.Text = "Bạn không được sửa mã chức vụ";
                lblThongbao.ForeColor = Color.Brown;
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTimkiem.Text;
            string query = "select Macv as [Mã chức vụ], Tencv as [Tên chức vụ] from Chucvu where Macv like '%" + tk + "%' or Tencv like N'%" + tk + "%'";
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                DataTable dt = bll.ExecuteTimkiem(tk, query);
                dgvQuanlychucvu.DataSource = dt;
            }
            else
                Hienthi();

        }

        private void btnLamMoiKH_Click(object sender, EventArgs e)
        {
            Lammoi();
        }
    }
}
