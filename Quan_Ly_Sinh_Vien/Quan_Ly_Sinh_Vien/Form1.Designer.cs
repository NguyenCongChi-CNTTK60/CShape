
namespace Quan_Ly_Sinh_Vien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.Masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Truong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtTruong = new System.Windows.Forms.TextBox();
            this.txtTensv = new System.Windows.Forms.TextBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masv,
            this.Tensv,
            this.Lop,
            this.Truong,
            this.Sodienthoai,
            this.Diachi});
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(-1, 0);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.RowHeadersWidth = 62;
            this.dataGridViewSinhVien.RowTemplate.Height = 33;
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(1750, 399);
            this.dataGridViewSinhVien.TabIndex = 0;
            // 
            // Masv
            // 
            this.Masv.HeaderText = "Mã sinh viên";
            this.Masv.MinimumWidth = 8;
            this.Masv.Name = "Masv";
            this.Masv.Width = 300;
            // 
            // Tensv
            // 
            this.Tensv.HeaderText = "Tên sinh viên";
            this.Tensv.MinimumWidth = 8;
            this.Tensv.Name = "Tensv";
            this.Tensv.Width = 300;
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 8;
            this.Lop.Name = "Lop";
            this.Lop.Width = 300;
            // 
            // Truong
            // 
            this.Truong.HeaderText = "Trường";
            this.Truong.MinimumWidth = 8;
            this.Truong.Name = "Truong";
            this.Truong.Width = 350;
            // 
            // Sodienthoai
            // 
            this.Sodienthoai.HeaderText = "Số điện thoại";
            this.Sodienthoai.MinimumWidth = 8;
            this.Sodienthoai.Name = "Sodienthoai";
            this.Sodienthoai.Width = 200;
            // 
            // Diachi
            // 
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.MinimumWidth = 8;
            this.Diachi.Name = "Diachi";
            this.Diachi.Width = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sinh viên:";
            // 
            // txtMasv
            // 
            this.txtMasv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMasv.Location = new System.Drawing.Point(192, 457);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(344, 39);
            this.txtMasv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(612, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã sinh viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1150, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(612, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trường:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1139, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số điện thoại: ";
            // 
            // txtLop
            // 
            this.txtLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLop.Location = new System.Drawing.Point(702, 451);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(397, 39);
            this.txtLop.TabIndex = 8;
            // 
            // txtTruong
            // 
            this.txtTruong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTruong.Location = new System.Drawing.Point(702, 546);
            this.txtTruong.Name = "txtTruong";
            this.txtTruong.Size = new System.Drawing.Size(407, 39);
            this.txtTruong.TabIndex = 9;
            // 
            // txtTensv
            // 
            this.txtTensv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTensv.Location = new System.Drawing.Point(192, 549);
            this.txtTensv.Name = "txtTensv";
            this.txtTensv.Size = new System.Drawing.Size(344, 39);
            this.txtTensv.TabIndex = 10;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSodienthoai.Location = new System.Drawing.Point(1295, 454);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(285, 39);
            this.txtSodienthoai.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(1286, 543);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 105);
            this.textBox1.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(192, 655);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(435, 655);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 34);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(702, 655);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 799);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSodienthoai);
            this.Controls.Add(this.txtTensv);
            this.Controls.Add(this.txtTruong);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSinhVien);
            this.Name = "Form1";
            this.Text = "Quan_Ly_Sinh_Vien_2021";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtTruong;
        private System.Windows.Forms.TextBox txtTensv;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Truong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
    }
}

