using quanlicoopmart_nam3_24_10_2021.getdataaa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlicoopmart_nam3_24_10_2021
{
    public partial class UC_Banhang : UserControl
    {
        private string manv, tennv;
        public UC_Banhang(string ma, string ten)
        {

            InitializeComponent();
            list = getListSanPham(); // list các sản phẩm trong csdl 

            //
            // Lấy dữ liệu từ form trang chủ đưa vào 
            //
            this.manv = ma;
            lblManv.Text = "";
            lblManv.Text = manv;
            this.tennv = ten;
            lblTennv.Text = "";
            lblTennv.Text = tennv;

            AutoCompleteStringCollection At = new AutoCompleteStringCollection();
            foreach (Hanghoa items in list)
            {
                At.Add(items.Mahh);
            }


            //
            // Đưa dữ liệu lên các combobox
            //
            cmbMahh.AutoCompleteCustomSource = At;
            cmbMahh.DataSource = list;
            cmbMahh.DisplayMember = "Mahh";
            cmbMahh.ValueMember = "Mahh";
            cmbTenhang.AutoCompleteCustomSource = At;
            cmbTenhang.DataSource = list;
            cmbTenhang.ValueMember = "Tenhh";

            Lammoi();

            lsvBanhang.View = View.Details;
            lsvBanhang.GridLines = true;
            lsvBanhang.FullRowSelect = true;


            //
            // Thêm cột trong listview
            //
            lsvBanhang.Columns.Add("Mã SP", 90);   //0
            lsvBanhang.Columns.Add("Tên SP", 160);  //1
            lsvBanhang.Columns.Add("SL,", 50);   //2
            lsvBanhang.Columns.Add("Đơn giá", 100);  // 3
            lsvBanhang.Columns.Add("Tổng tiền", 120);  // 4




            /* SudungDatabase dt = new SudungDatabase();
            List<Hanghoa> hanghoas = dt.Hanghoas.ToList();
            cmbMahh.DataSource = hanghoas;
            cmbMahh.ValueMember = "Mahh";
            cmbTenhang.DataSource = hanghoas;
            cmbTenhang.ValueMember = "Tenhh"; */



            //
            // Lấy ngày hiện tại
            //
            DateTime today = DateTime.Now;
            dpkNgayban.Value = new DateTime(today.Year, today.Month, today.Day);
            lblMahd.Text = Matudong();


            //Timkiem();
            //Timkiemdv();

        }




        BLL bll = new BLL();
        int tongTien = 0;
        Chuyentien_sangso bs = new Chuyentien_sangso();

        /* private void cmbMahh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int indexx = 0;
            //indexx++;
            string tk = cmbMahh.Text;
            string query = "select Tenhh from Hanghoa where Mahh = '" + tk + "'";
            if (!string.IsNullOrEmpty(cmbMahh.Text))
            {
                DataTable dt = bll.ExecuteTimkiem(tk,query);
                cmbTenhang.Text = dt.Rows[0]["Tenhh"].ToString();
            }
        } */



        //
        // thừa
        //
        private void Timkiem()
        {
            string tk = cmbMahh.Text;
            string query = "select Tenhh from Hanghoa where Mahh = '" + tk + "'";
            if (!string.IsNullOrEmpty(cmbMahh.Text))
            {
                DataTable dt = bll.ExecuteTimkiem(tk, query);
                cmbTenhang.Text = dt.Rows[0]["Tenhh"].ToString();
            }
        }

        private void cmbTenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSoLuong.Value = 0;
        }


        //
        // Lấy dữ liệu từ combobox để tìm kiếm
        //
        int i;
        private void cmbMahh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMahh.SelectedIndex >= 0)
            {
                i = cmbMahh.SelectedIndex;
                txtDonvi.Text = list[i].ĐVT;
                txtGia.Text = list[i].Dongia.ToString();
            }

        }




        //
        // Tạo mã hóa đơn tự động
        //
        private string Matudong()
        {
            string query = "select Mahd from Hoadon";
            DataTable dt = bll.ExcuQuery(query);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "HD001";
            }
            else
            {
                int k;
                ma = "HD";
                //k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = dt.Rows.Count;
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



        private void UC_Banhang_Load(object sender, EventArgs e)
        {

        }


        //
        // Lấy hàng hóa từ CSDL
        //
        List<Hanghoa> list;

        public List<Hanghoa> getListSanPham()
        {
            string query = "select * from Hanghoa";
            List<Hanghoa> list = new List<Hanghoa>();
            DataTable dt = bll.ExcuQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Hanghoa hangHoa = new Hanghoa(item);
                list.Add(hangHoa);
            }
            return list;
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            bool check = false;

            //
            // Thêm từ combobox lên listview
            //
            if (cmbMahh.SelectedIndex >= 0 && txtSoLuong.Value > 0)
            {
                foreach (ListViewItem N in lsvBanhang.Items)
                {
                    if (N.SubItems[0].Text == cmbMahh.SelectedValue.ToString())
                    {
                        check = true;   // nếu hàng đã có ta trả vế true
                    }

                    if (check == true)
                    {
                        int temp = Int32.Parse(N.SubItems[2].Text) + Int32.Parse(txtSoLuong.Value.ToString());
                        N.SubItems[2].Text = temp.ToString();
                        N.SubItems[4].Text = (Int32.Parse(N.SubItems[2].Text) * Int32.Parse(N.SubItems[3].Text)).ToString();
                        break;     // Nếu hàng đã có ta thực hiện cộng dồn
                    }
                }


                int gia = Int32.Parse(txtGia.Text) * Int32.Parse(txtSoLuong.Value.ToString());  // tổng tiền của 1 sp
                // nếu là sản phẩm mới ta sẽ thêm vào listview
                if (!check)
                {
                    string[] arr = new string[5];
                    arr[0] = cmbMahh.SelectedValue.ToString();
                    arr[1] = cmbTenhang.Text;
                    arr[2] = txtSoLuong.Value.ToString();
                    arr[3] = txtGia.Text;
                    arr[4] = gia.ToString();
                    ListViewItem listViewItem = new ListViewItem(arr);
                    lsvBanhang.Items.Add(listViewItem);
                }

                tongTien += gia;    // tổng tiền của n hàng hóa 
                lbTienBangSo.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien) + "VNĐ";
                lbTienBangChu.Text = bs.So_chu(tongTien);
                Lammoi();

            }
        }


        //
        // Tìm kiếm tên khách hàng, mã khách hàng = SĐT
        //
        private void txtTimkiemkh_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTimkiemkh.Text;
            string query = "select Makh,Tenkh as Tenkhachhang from Khachhang where Sdt = '" + tk + "'";
            if (!string.IsNullOrEmpty(txtTimkiemkh.Text))
            {
                DataTable dt = bll.ExecuteTimkiem(tk, query);
                if (dt.Rows.Count > 0)
                {
                    lblTenkh.Text = dt.Rows[0]["Tenkhachhang"].ToString();
                    lblMakh.Text = "";
                    lblMakh.Text = dt.Rows[0]["Makh"].ToString();
                    lblMakh.ForeColor = Color.Maroon;
                }
                else if (dt.Rows.Count <= 0)
                {
                    lblTenkh.Text = "Khách hàng mới";
                    lblMakh.Text = ".";
                }
            }
            else
                lblTenkh.Text = "UNKNOW NAME";
            //lblMakh.Text = ".";

        }






        private void Lammoi()
        {
            cmbMahh.SelectedIndex = -1;
            cmbTenhang.SelectedIndex = -1;
            txtDonvi.Text = "";
            txtGia.Text = "";
            txtSoLuong.Value = 0;
        }



        private void btnXoaMatHang_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsvBanhang.Items.Count; i++) //duyệt tất cả các item trong list
            {
                if (lsvBanhang.Items[i].Checked)//nếu item đó dc check
                {
                    string tien = lsvBanhang.Items[i].SubItems[4].Text.ToString(); // cột 4 là tổng tiền của 1 hàng hóa
                    tongTien -= Int32.Parse(tien);
                    lbTienBangSo.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien) + " VNĐ";
                    lbTienBangChu.Text = bs.So_chu(tongTien);
                    lsvBanhang.Items[i].Remove();//xóa item đó đi
                    i--;
                }
            }
        }


        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            lbltbsoluong.Text = "";
        }


        //
        // Thanh toán ta thực hiện lưu hàng hóa
        //
        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (lsvBanhang.Items.Count > 0)
            {
                Hoadon hd = new Hoadon();
                hd.Mahd = lblMahd.Text;
                hd.Ngaytao = dpkNgayban.Value;
                hd.Tongtien = tongTien;
                hd.Manv = lblManv.Text;
                hd.Makh = lblMakh.Text;

                if (LuuHD(hd))   // lưu hóa đơn
                {
                    //FormInHD formInHD = new FormInHD(lblMakh.Text);
                    foreach (ListViewItem item in lsvBanhang.Items)
                    {
                        LuuDH(hd.Mahd, item.SubItems[0].Text, Int32.Parse(item.SubItems[3].Text), Int32.Parse(item.SubItems[2].Text));  //lưu chi tiết hóa đơn
                        string query = "update Hanghoa set Soluong = Soluong - " + Int32.Parse(item.SubItems[2].Text) + "where Mahh = '" + item.SubItems[0].Text + "'";  // cập nhật lại số lượng 
                        bll.ExcuQuery(query);
                    }
                    lsvBanhang.Items.Clear();
                    lbTienBangSo.Text = "0 VNĐ";
                    lbTienBangChu.Text = "Không đồng";
                    txtTimkiemkh.Text = "";                                // làm mới tất cả 
                    lblMakh.Text = ".";
                    lblTenkh.Text = "UNKNOW NAME";
                    tongTien = 0;
                    lblMahd.Text = Matudong();
                    //formInHD.ShowDialog();
                }

            }
        }




        //
        // Lưu hóa đơn
        //
        private bool LuuHD(Hoadon dh)
        {
            // Convert datetime to date SQL Server 
            string query = String.Format("insert into Hoadon values('{0}','{1}','{2}','{3}','{4}')", dh.Mahd, dh.Ngaytao, dh.Tongtien, dh.Manv, dh.Makh);
            bll.ExcuQuery(query);
            return true;
        }


        //
        // Lưu hàng hóa 
        //
        private bool LuuDH(string mahd, string mahh, int sl, int dg)
        {
            string query = String.Format("insert into Chitiethd values('{0}','{1}','{2}','{3}')", mahd, mahh, sl, dg);
            bll.ExcuQuery(query);
            return true;
        }

    }
}


