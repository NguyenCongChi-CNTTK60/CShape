create database Quan_Ly_Sinh_Vien_2021
go

use Quan_Ly_Sinh_Vien_2021
go

Create table Sinhvien(
    Masv varchar(12),
	Tensv nvarchar(30),
	Lop   nvarchar(20),
	Truong nvarchar(30),
	Sodienthoai varchar(12),
	Diachi nvarchar(50),

	primary key (Masv),
)


insert into Sinhvien
(Masv,Tensv,Lop,Truong,Sodienthoai,Diachi)

values 
('6051071009',N'Nguyễn Công Chí',N'Công Nghệ Thông Tin',N'Giao Thông Vận Tải','0328644258',N'Phú Thạnh, An Chấn, Tuy An, Phú Yên'),

('6051071019',N'Nguyễn Thị Đào',N'Kế Toán Tổng Hợp',N'Giao Thông Vận Tải','0328644216',N'Phú Thạnh, An Chấn, Tuy An, Phú Yên'),

('6051071021',N'Võ Văn Chiến',N'kỹ Thuật Xây Dựng',N'Giao Thông Vận Tải','0328644207',N'Phú Thạnh, An Chấn, Tuy An, Phú Yên'),

('6051071023',N'Lê Văn Lâm',N'Công Nghệ Thông Tin',N'Giao Thông Vận Tải','0328644243',N'Phú Thạnh, An Chấn, Tuy An, Phú Yên'),

('6051071032',N'Nguyễn Lê Hồng Ngọc',N'Công Nghệ Thông Tin',N'Giao Thông Vận Tải','0328644234',N'Phú Thạnh, An Chấn, Tuy An, Phú Yên');

select *
from Sinhvien