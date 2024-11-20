create database MobileShop;
use MobileShop;

create table NguoiDung(
	ID_NguoiDung int primary key identity,
	TenDangNhap varchar(50) not null,
	MatKhau varchar(30) not null
)

create table SanPham(
	ID_SanPham varchar(10) primary key,
	TenSanPham varchar(50) not null,
	Gia float not null,
	HangSX varchar(50),
	ID_NguoiDung int foreign key references NguoiDung(ID_NguoiDung)
)

create table KhachHang(
	ID_KhachHang varchar(10) primary key,
	TenKhachHang varchar(50) not null,
	DiaChi varchar(50),
	SoDienThoai varchar(10),
	ID_NguoiDung int foreign key references NguoiDung(ID_NguoiDung)
)

create table DonHang(
	ID_DonHang varchar(10) primary key,
	ID_KhachHang varchar(10) foreign key references KhachHang(ID_KhachHang),
	ID_SanPham varchar(10) foreign key references SanPham(ID_SanPham),
	SoLuong int not null,
	NgayMua date not null,
	ID_NguoiDung int foreign key references NguoiDung(ID_NguoiDung)
)

insert into NguoiDung
values ('user01', '123456'),
	   ('user02', '777777'),
	   ('user03', '8888')

insert into SanPham
values ('DT101', 'SamSung A20', 3.4, 'SamSung', '1'),
	   ('DT202', 'Xiaomi Redmi Note 10S', 5.4, 'Xiaomi', '2'),
	   ('DT203', 'Xiaomi 10T', 7, 'Xiaomi', '2'),
	   ('DT104', 'SamSung Galaxy S20', 10.5, 'SamSung', '1'),
	   ('DT105', 'Iphone 15 Pro Max', 20.3, 'Apple', '1')

insert into KhachHang
values ('KH101', 'Nguyen Van A', 'Ha Noi', '0974567890', '1'),
	   ('KH201', 'Nguyen Van A', 'Ha Noi', '0974567890', '2'),
	   ('KH202', 'Nguyen Tan B', 'Ha Noi', '0931234567', '2'),
	   ('KH103', 'Tran Tuan C', 'Phu Tho', '0971987654', '1'),
	   ('KH204', 'Dinh Van D', 'Hai Phong', '0312345678', '2'),
	   ('KH105', 'Nguyen Hai E', 'Ha Noi', '099199888', '1')

insert into DonHang
values ('DH101', 'KH101', 'DT105', 1, '2024-03-10', '1'),
	   ('DH201', 'KH202', 'DT202', 1, '2024-05-11', '2'),
	   ('DH102', 'KH105', 'DT104', 1, '2024-07-14', '1'),
	   ('DH202', 'KH201', 'DT202', 1, '2024-06-17', '2'),
	   ('DH203', 'KH204', 'DT203', 1, '2024-07-21', '2'),
	   ('DH103', 'KH103', 'DT105', 1, '2024-08-04', '1')
