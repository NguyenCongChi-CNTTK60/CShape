create database ConnectDatabase_Basic_Kteam
go 

use ConnectDatabase_Basic_Kteam
go

create table NhanVien(
     id int primary key,
	 names nvarchar (50),
	 dateofBirth date,
	 Sex bit,
)

insert into NhanVien
(id,names,dateofBirth,Sex)
values
(1,N'Nguyễn Công Chí','20010706',1),
(2,N'Trần Thị Thư','19980407',0),
(3,N'NHuỳnh Nhật Hào','20011019',1),
(4,N'Lê Thị Tuyết','20030709',0),
(5,N'Võ Văn Thiết','20020506',1);

select *
from NhanVien
