
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
    public partial class UC_Quanlyphieugiaoca : UserControl
    {
        public UC_Quanlyphieugiaoca()
        {
            InitializeComponent();
            Hienthi();
            txtMapgc.Text =  Matudong();
        }
        Phieugiaoca phieugiaoca = new Phieugiaoca();
        BLL bll = new BLL();
      

        private string Matudong()
        {
            string query1 = "select Mapgc from Phieugiaoca";
            DataTable dt = bll.ExcuQuery(query1);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "PGC001";
            }
            else
            {
                int k;
                ma = "PGC";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(3,3));
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
                    ma = ma + "";
                }

                ma = ma + k.ToString();

            }
            return ma;
        }


        private void Hienthi()
        {
            string query1 = "select Mapgc as [Mã phiếu giao ca],Ca as [Ca làm việc] from Phieugiaoca";
            DataTable dt = bll.ExcuQuery(query1);
            dgvQuanlypgc.DataSource = dt;
        }

        private void btnThempgc_Click(object sender, EventArgs e)
        {
            if (check_data() == true)
            {
                string query = "insert into Phieugiaoca (Mapgc,Ca) values (@Mapgc,@Ca)";
                phieugiaoca.Mapgc = txtMapgc.Text;
                phieugiaoca.Ca = txtCa.Text;
                if (bll.Them_Sua_Xoa_PGC(phieugiaoca, query) == true)
                {
                    Hienthi();
                    txtMapgc.Text = Matudong();
                    Lammoi();
                    labelcanhbao.Text = "Thêm phiếu giao ca thành công";
                    labelcanhbao.ForeColor = Color.Brown;
                }
                else
                    labelcanhbao.Text = "Mã phiếu giao ca đã tồn tại";
                labelcanhbao.ForeColor = Color.Brown;
            }
        }

        private void btnXoapgc_Click(object sender, EventArgs e)
        {
            if (check_data() == true)
            {
                string query = "delete Phieugiaoca where Mapgc = @Mapgc";
                phieugiaoca.Mapgc = txtMapgc.Text;
                phieugiaoca.Ca = txtCa.Text;
                if (bll.Them_Sua_Xoa_PGC(phieugiaoca, query) == true)
                {
                    Hienthi();
                    Lammoi();
                    labelcanhbao.Text = "Xóa phiếu giao ca thành công";
                    labelcanhbao.ForeColor = Color.Brown;
                }
                else
                    labelcanhbao.Text = "Mã phiếu giao ca xóa không hợp lệ";
                labelcanhbao.ForeColor = Color.Brown;
            }
        }

        private void txtMapgc_TextChanged(object sender, EventArgs e)
        {
            labelcanhbao.Text = "";
        }

        private void txtCa_TextChanged(object sender, EventArgs e)
        {
            labelcanhbao.Text = "";
        }

        private void dgvQuanlypgc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtMapgc.Text = dgvQuanlypgc.Rows[indexx].Cells[0].Value.ToString();
            txtCa.Text = dgvQuanlypgc.Rows[indexx].Cells[1].Value.ToString();
            labelcanhbao.Text = "";
        }

        private void btnSuapgc_Click(object sender, EventArgs e)
        {
            if (check_data() == true)
            {
                string query = "update Phieugiaoca set Mapgc = @Mapgc, Ca = @Ca where Mapgc = @Mapgc";
                phieugiaoca.Mapgc = txtMapgc.Text;
                phieugiaoca.Ca = txtCa.Text;
                if (bll.Them_Sua_Xoa_PGC(phieugiaoca, query) == true)
                {
                    Hienthi();
                    Lammoi();
                    labelcanhbao.Text = "Sửa phiếu giao ca thành công";
                    labelcanhbao.ForeColor = Color.Brown;
                }
                else
                    labelcanhbao.Text = "Sửa phiếu giao ca xóa không hợp lệ";
                labelcanhbao.ForeColor = Color.Brown;
            }
        }

        private void btnLamMoipgc_Click(object sender, EventArgs e)
        {
            Lammoi();
            //labelcanhbao.Text = "";
        }

        private void Lammoi()
        {
            //txtMapgc.Text = "";
            txtCa.Text = "";
            txtMapgc.Text = Matudong();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTimkiem.Text;
            string query = "select * from Phieugiaoca where Mapgc like N'%" + tk + "%' or  Ca like  N'%" + tk + "%'";
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                DataTable dt = bll.ExecuteTimkiem(tk, query);
                dgvQuanlypgc.DataSource = dt;
            }
            else
                Hienthi();
        }


        private bool check_data()
        {
            if (string.IsNullOrEmpty(txtCa.Text))
            {
                errorProvider1.SetError(txtCa, labelcanhbao.Text = "Ca làm việc bắt buộc phải nhập");
                labelcanhbao.ForeColor = Color.Brown;
                return false;
            }
            else
                errorProvider1.SetError(txtCa, null);
            return true;
        }
    }
}
