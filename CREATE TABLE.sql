CREATE DATABASE KINHDOANHDIENTHOAI6
GO
USE KINHDOANHDIENTHOAI6
GO

-- TẠO TÀI KHOẢN 

CREATE TABLE TAIKHOAN(
	   MaUS INT IDENTITY(1,1) NOT NULL,
       TaiKhoan varchar(30) PRIMARY KEY,
	   MatKhau varchar(30) not null,
	   PhanLoai varchar(6),
       CMND VARCHAR(12) unique,
	   TenUS NVARCHAR(30),
	   SDT VARCHAR(13) unique,
	   DiaChi NVARCHAR(100),
	   Email varchar(50) unique not null,
	   GioiTinh NVARCHAR(5),
	   NgaySinh DATE
)
GO
SET IDENTITY_INSERT TAIKHOAN OFF
insert into TAIKHOAN(TaiKhoan,MatKhau,PhanLoai,CMND,TenUS,SDT,DiaChi,Email,GioiTinh,NgaySinh) values ('admin','123456','ADMIN','215534321','Admin','03516248346','Thủ Đức','admin@gmail.com','Nam','2000-03-03')
insert into TAIKHOAN(TaiKhoan,MatKhau,PhanLoai,CMND,TenUS,SDT,DiaChi,Email,GioiTinh,NgaySinh) values ('quangphuc','111','KH','215211231','Nguyễn Quang Phúc','03152348123','Quảng Nam','nguyenquangphuc@gmail.com','Nam','2002-03-23')
insert into TAIKHOAN(TaiKhoan,MatKhau,PhanLoai,CMND,TenUS,SDT,DiaChi,Email,GioiTinh,NgaySinh) values ('minhtri','222','KH','211251234','Lê Minh Trí','03516661254','Phan Thiết','leminhtri@gmail.com','Nam','2001-02-15')
insert into TAIKHOAN(TaiKhoan,MatKhau,PhanLoai,CMND,TenUS,SDT,DiaChi,Email,GioiTinh,NgaySinh) values ('minhduc','333','KH','21122222','Trần Minh Đức','0351223145','Phan Thiết','tranminhduc@gmail.com','Nam','2001-02-15')
GO
--TẠO HÃNG SẢN XUẤT

CREATE TABLE HANGSX(
      MaHang INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  TenHang NVARCHAR(20),
	  DiaChi NVARCHAR(100)
	  )
GO
set identity_insert HANGSX off;
insert into HANGSX(TenHang,DiaChi) values('SamSung','Hàn Quốc'), ('Apple','USA'),('Oppo','Hàn Quốc'),('Xiaomi','Trung Quốc'),('Realme','Trung Quốc'),('ViVo','Trung Quốc'),('Huiwei','Trung Quốc'), ('Sony', 'Nhật Bản')
go

--Tạo bảng sản phẩm
CREATE TABLE SANPHAM(
      MaSP VARCHAR(6) PRIMARY KEY NOT NULL,
	  TenSP NVARCHAR(20),
	  SoLuong INT,
	  DonGiaNhap INT,
	  DonGiaBan INT,
	  MauSac NVARCHAR(20),
	  BOXULY NVARCHAR(50),
	  BoNho INT,
	  RAM INT,
	  HDH NVARCHAR(20),
	  NamSX DATE,
	  MaHangSX INT REFERENCES HANGSX(MaHang)ON DELETE SET NULL ON UPDATE CASCADE,
	  NhaCC NVARCHAR(20),
	  KichThuoc FLOAT,
	  CAM_TRUOC float ,
	  CAM_SAU float,
	  TGBaoHanh NVARCHAR(10),
	  GhiChu NVARCHAR(30),
	  HinhAnh NVARCHAR(MAX)
	  )
GO
--insert into SANPHAM(MaSP,TenSP,SoLuong,DonGiaNhap,DonGiaBan,MauSac,BOXULY,BoNho,RAM,HDH,NamSX,MaHangSX,NhaCC,KichThuoc,CAM_TRUOC,CAM_SAU,TGBaoHanh,GhiChu,HinhAnh) 
insert into SANPHAM values('sp01','SamSung A50',3,6000000,7000000,'Trang','Snapdragon 678',128,8,'Android 11','2022-05-05',1,'FPT',6.43,13,32,'12','','samsung-galaxy-a50.jpg')
insert into SANPHAM values('sp010','SamSung Z Fold 4',7,40000000,43000000,'Xám Đen','SnapDroGon 999',256,18,'Androi','2022-12-05',1,'Thế Giới Di Động',8.2,16.1,12.6,'12', '','SamSung_Z_Fold_4_Green_Gray.png')
insert into SANPHAM values('sp011','Iphone 11 Pro Max',12,16000000,17900000,'Xám','SD',512,8,'IOS 16','2022-12-05',2,'FPT',6.6,16,11.2,'12','','iphone_11_pro_max_64gb_8.jpg')
insert into SANPHAM values('sp02','Iphone 11',8,15000000,17000000,'Xanh Lục','MediaTek Dimensity 999',256,8,'IOS','2022-05-10',2,'Hoàng Hà Mobile',6.1,12,12,'12','','iPhone-11.jpeg')
insert into SANPHAM values('sp03','Oppo A97',8,6500000,7200000,'Xanh Ngọc','Snapdragon 680',128,8,'Androi 11','2022-05-15',3,'The Gioi Di Dong',6.5,16,50,'12','','oppo-a97.jpg')
insert into SANPHAM values('sp04','ViVo V25E',5,9000000,9500000,'Vang','MediaTek Dimensity 900 5G',128,8,'Android 12','2022-05-10',6,'FPT',6.44,50,64,'12','','vivo-v25e-vang-thumb.jpg')
insert into SANPHAM values('sp05','RedMi Note11S 5G',6,5600000,6200000,'Xanh Hồng','MediaTek Dimensity 810 5G',128,6,'Androi 11','2022-05-15',5,'The Gioi Di Dong',6.6,50,13,'12','','xiaomi-redmi-note-11s-5g-lam-hong.jpg')
insert into SANPHAM values('sp09','Iphone 14 Pro Max',6,30000000,32500000,'Tím','SnapDragon 777',256	,18,'IOS 16','2020-10-29',2,'FPT',7,16,12,'12','','iPhone-14-Pro-Max.jpeg')
GO

CREATE TABLE DONHANG(
      MaDH INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  Ngayban DATE,
	  TaiKhoan varchar(30) REFERENCES TAIKHOAN(TaiKhoan) ON DELETE SET NULL ON UPDATE CASCADE,
	  TongTien INT
	  )
GO

--set identity_insert DONHANG off; insert into DONHANG(Ngayban,TaiKhoan, TongTien) values( null, null, null)
set identity_insert DONHANG off; insert into DONHANG(Ngayban,TaiKhoan, TongTien) values('2022-11-20',  'quangphuc', 0)
set identity_insert DONHANG off; insert into DONHANG(Ngayban,TaiKhoan, TongTien) values('2022-11-30',  'minhtri', 0)
set identity_insert DONHANG off; insert into DONHANG(Ngayban,TaiKhoan, TongTien) values('2022-12-5',  'minhtri', 0)
GO
CREATE TABLE CHITIETDH(
	MaCTDH int identity(1,1) Primary key,
    MaDH INT REFERENCES DONHANG(MaDH)  ON DELETE CASCADE ON UPDATE CASCADE,
	MaSP VARCHAR(6) REFERENCES SANPHAM(MaSP) ON DELETE SET NULL ON UPDATE CASCADE,
	SoLuong INT,
	DonGia INT,
	ThanhTien INT
	)
GO

insert into CHITIETDH(MaDH, MaSP, SoLuong, DonGia,ThanhTien) values(1, 'sp01', 1, 7000000,  7000000)
insert into CHITIETDH(MaDH, MaSP, SoLuong, DonGia,ThanhTien) values(1, 'sp02', 1, 17000000,  17000000)
insert into CHITIETDH(MaDH, MaSP, SoLuong, DonGia,ThanhTien) values(2, 'sp02', 2, 17000000, 34000000)
insert into CHITIETDH(MaDH, MaSP, SoLuong, DonGia,ThanhTien) values(3, 'sp09', 1, 32500000, 32500000)
GO
