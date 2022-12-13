use KINHDOANHDIENTHOAI6
go

CREATE FUNCTION DANGNHAP(@TaiKhoan nvarchar(50),@MatKhau nvarchar(50))
RETURNS TABLE 
AS
   RETURN( select * from TAIKHOAN where TaiKhoan=@TaiKhoan and MatKhau=@MatKhau)
GO

create procedure QuenMatKhau
@Email varchar(50),@MatKhau varchar(30),@MatKhau_ReType varchar(30)
as 
  begin
      if (@MatKhau = @MatKhau_ReType)
		begin 
		  if (@Email not in (select Email from TAIKHOAN))
			begin 
				print(N'Email không chính xác!')       
			end
		  else
			begin
				update TAIKHOAN set MatKhau=@MatKhau where Email=@Email
				print(N'Đổi mật khẩu thành công!')
			end
		end
	  else
		begin
			print(N' Mật khẩu nhập không trùng nhau!')
		end
  end 
go

CREATE PROCEDURE XOATAIKHOAN
@TaiKhoan varchar(30)
AS
BEGIN
	IF exists(select TaiKhoan from DONHANG where TaiKhoan=@TaiKhoan)
		BEGIN
			PRINT(N'Không thể xóa tài khoản!')
		END
	ELSE
		BEGIN
			DELETE FROM TAIKHOAN WHERE TaiKhoan=@TaiKhoan
			PRINT(N'Xóa tài khoản thành công!')
		END
END
GO

CREATE TRIGGER CHECK_DANGKY ON TAIKHOAN
INSTEAD OF INSERT
AS
BEGIN
	IF EXISTS (SELECT * FROM inserted WHERE TaiKhoan IN (SELECT TaiKhoan FROM TAIKHOAN)) 
	 BEGIN
	  PRINT(N'Tên tài khoản đã tồn tại!')
	 END
    ELSE
	 BEGIN 
	    IF EXISTS (SELECT * FROM inserted WHERE CMND IN (SELECT CMND FROM TAIKHOAN)) 
		 BEGIN 
		   PRINT(N'CMND đã tồn tại!')
		 END
		ELSE
		 BEGIN 
		       IF EXISTS (SELECT * FROM inserted WHERE Email IN (SELECT Email FROM TAIKHOAN))
		          BEGIN 
		           PRINT(N'Email đã tồn tại!')
		          END
			   ELSE
			     BEGIN 
					IF EXISTS (SELECT * FROM inserted WHERE SDT IN (SELECT SDT FROM TAIKHOAN))
						BEGIN 
						  PRINT(N'Số điện thoại đã tồn tại')
						END
					ELSE
						BEGIN
						   SET IDENTITY_INSERT TAIKHOAN Off
						   INSERT INTO TAIKHOAN(TaiKhoan,MatKhau,PhanLoai,CMND,TenUS,SDT,DiaChi,Email,GioiTinh,NgaySinh)
						   SELECT TaiKhoan,MatKhau,PhanLoai,CMND,TenUS,SDT,DiaChi,Email,GioiTinh,NgaySinh
						   FROM inserted
						   PRINT(N'Đăng ký tài khoản thành công!')
						END
				 END
		 END
	END
END
GO

CREATE PROCEDURE DANGKYTAIKHOAN 
	@TaiKhoan varchar(30),
	@MatKhau varchar(30),
	@PhanLoai varchar(6),
	@CMND VARCHAR(12) ,
	@TenUS NVARCHAR(30),
	@SDT VARCHAR(13) ,
	@DiaChi NVARCHAR(100),
	@Email varchar(50) ,
	@GioiTinh NVARCHAR(5),
	@NgaySinh DATE
AS
BEGIN 
	SET IDENTITY_INSERT TAIKHOAN OFF
	insert into TAIKHOAN(TaiKhoan,MatKhau,PhanLoai,CMND,TenUS,SDT,DiaChi,Email,GioiTinh,NgaySinh) 
	values (@TaiKhoan,@MatKhau,@PhanLoai,@CMND,@TenUS,@SDT,@DiaChi,@Email,@GioiTinh,@NgaySinh)
END
GO

create procedure DOIMATKHAU_TK
@TaiKhoan varchar(50),@MatKhauCu varchar(50),@MatKhauMoi varchar(30),@XacNhanMatKhau varchar(30)
as 
Begin
   IF EXISTS (SELECT * FROM TAIKHOAN WHERE TaiKhoan=@TaiKhoan and MatKhau=@MatKhauCu)
	BEGIN
	  IF (@MatKhauMoi = @XacNhanMatKhau AND @MatKhauCu != @MatKhauMoi)
		begin
			update TAIKHOAN set MatKhau=@MatKhauMoi where TaiKhoan=@TaiKhoan
			print(N'Đổi mật khẩu thành công!')
		end
	  ELSE
	    BEGIN
	        print(N'Xác nhận mật khẩu không chính xác!')
		END
	END
  ELSE
	Begin
		PRINT(N'Mật khẩu cũ không chính xác!') 
	End
End 
GO

CREATE TRIGGER CHECK_CHINHSUA ON TAIKHOAN
FOR UPDATE
AS
BEGIN
	DECLARE @TaiKhoan varchar(30),@CMND VARCHAR(12),@TenUS NVARCHAR(30),@SDT VARCHAR(13),@DiaChi NVARCHAR(100),@Email varchar(50),@GioiTinh NVARCHAR(5),@NgaySinh DATE
	IF EXISTS (SELECT * FROM inserted WHERE TaiKhoan IN (SELECT TaiKhoan FROM TAIKHOAN)) 
	 BEGIN 
		SET @TaiKhoan = (select TaiKhoan from inserted)
		SET @CMND = (select CMND from inserted)
		SET @TenUS = (select TenUS from inserted)
		SET @SDT = (select SDT from inserted)
		SET @DiaChi = (select DiaChi from inserted)
		SET @Email = (select Email from inserted)
		SET @GioiTinh = (select GioiTinh from inserted)
		SET @NgaySinh = (select NgaySinh from inserted)
	 	UPDATE TAIKHOAN SET TenUS=@TenUS,CMND=@CMND,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,SDT=@SDT,DiaChi=@DiaChi,Email=@Email where TaiKhoan=@TaiKhoan
	   	PRINT(N'Cập nhật tài khoản thành công!')
	 END
	ELSE
	 BEGIN 
		PRINT(N'Tài khoản không tồn tại!')
	    ROLLBACK TRANSACTION
	 END	  
END
GO

CREATE PROCEDURE CHINHSUATAIKHOAN
       @TaiKhoan varchar(30),
       @CMND VARCHAR(12) ,
	   @TenUS NVARCHAR(30),
	   @SDT VARCHAR(13) ,
	   @DiaChi NVARCHAR(100),
	   @Email varchar(50) ,
	   @GioiTinh NVARCHAR(5),
	   @NgaySinh DATE
as
 BEGIN
   UPDATE TAIKHOAN SET TenUS=@TenUS,CMND=@CMND,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,SDT=@SDT,DiaChi=@DiaChi,Email=@Email where TaiKhoan=@TaiKhoan
   	   	--PRINT(N'Cập nhật tài khoản thành công!')
 END
GO

CREATE VIEW XEMKHACHHANG AS
select MaUS, TenUS, CMND, NgaySinh, GioiTinh, SDT, DiaChi, Email, TaiKhoan, MatKhau, PhanLoai from TAIKHOAN where PhanLoai = 'KH'
GO

CREATE VIEW XEMADMIN AS
select MaUS, TenUS, CMND, NgaySinh, GioiTinh, SDT, DiaChi, Email, TaiKhoan, MatKhau, PhanLoai from TAIKHOAN where PhanLoai = 'ADMIN'
GO

CREATE VIEW XEMSANPHAM AS
select sp.MaSP,sp.TenSP, sp.MaHangSX, hsx.TenHang, sp.SoLuong, sp.DonGiaNhap, sp.DonGiaBan, sp.MauSac, sp.KichThuoc,
		sp.BoNho, sp.BOXULY, sp.RAM, sp.HDH, sp.CAM_TRUOC, sp.CAM_SAU, sp.NamSX, sp.NhaCC, sp.TGBaoHanh, sp.GhiChu, sp.HinhAnh
from SANPHAM sp join HANGSX hsx 
on sp.MaHangSX = hsx.MaHang
GO

CREATE TRIGGER CHECK_THEMSANPHAM ON SANPHAM
INSTEAD OF INSERT
AS
BEGIN
	IF EXISTS (SELECT * FROM inserted WHERE MaSP IN (SELECT MaSP FROM SANPHAM))
		BEGIN
			PRINT(N'Mã sản phẩm đã tồn tại!')
		END
	ELSE
		BEGIN
		    INSERT INTO SANPHAM
			SELECT MaSP,TenSP,SoLuong,DonGiaNhap,DonGiaBan,MauSac,BOXULY,BoNho,RAM,HDH,NamSX,MaHangSX,NhaCC,KichThuoc,CAM_TRUOC,CAM_SAU,TGBaoHanh,GhiChu,HinhAnh
			FROM inserted
			PRINT(N'Thêm mới sản phẩm thành công!')
		END
END
GO

CREATE PROCEDURE THEMSANPHAM
      @MaSP VARCHAR(6),
	  @TenSP NVARCHAR(20),
	  @SoLuong INT,
	  @DonGiaNhap INT,
	  @DonGiaBan INT,
	  @MauSac NVARCHAR(20),
	  @BOXULY NVARCHAR(50),
	  @BoNho INT,
	  @RAM INT,
	  @HDH NVARCHAR(20),
	  @NamSX DATE,
	  @MaHangSX INT,
	  @NhaCC NVARCHAR(20),
	  @KichThuoc FLOAT,
	  @CAM_TRUOC float ,
	  @CAM_SAU float,
	  @TGBaoHanh NVARCHAR(10),
	  @GhiChu NVARCHAR(30),
	  @HinhAnh NVARCHAR(MAX)
AS 
 BEGIN
   insert into SANPHAM(MaSP,TenSP,SoLuong,DonGiaNhap,DonGiaBan,MauSac,BOXULY,BoNho,RAM,HDH,NamSX,MaHangSX,NhaCC,KichThuoc,CAM_TRUOC,CAM_SAU,TGBaoHanh,GhiChu,HinhAnh) 
   values(@MaSP,@TenSP,@SoLuong,@DonGiaNhap,@DonGiaBan,@MauSac,@BOXULY,@BoNho,@RAM,@HDH,@NamSX,@MaHangSX,@NhaCC,@KichThuoc,@CAM_TRUOC,@CAM_SAU,@TGBaoHanh,@GhiChu,@HinhAnh)
 END
GO

CREATE TRIGGER CAPNHATSANPHAM ON SANPHAM
AFTER UPDATE
AS
BEGIN
	declare @GiaBan int,@MaSP varchar(6),@MaDH int
	set @GiaBan = (select DonGiaBan from inserted)
	set @MaSP   = (select MaSP  from inserted)
	set @MaDH   = (select MaDH from DONHANG where MaDH=@MaDH)
	update CHITIETDH set  ThanhTien=(@GiaBan * SoLuong),DonGia=@GiaBan where MaSP=@MaSP
	update DONHANG   set TongTien = (select (SUM(ThanhTien)) as Tong  from CHITIETDH where MaDH=@MaDH) where MaDH=@MaDH
END
GO
----
CREATE PROCEDURE CAPNHAT_SANPHAM
      @MaSP VARCHAR(6),
	  @TenSP NVARCHAR(20),
	  @SoLuong INT,
	  @DonGiaNhap INT,
	  @DonGiaBan INT,
	  @MauSac NVARCHAR(20),
	  @BOXULY NVARCHAR(50),
	  @BoNho INT,
	  @RAM INT,
	  @HDH NVARCHAR(20),
	  @NamSX DATE,
	  @MaHangSX INT,
	  @NhaCC NVARCHAR(20),
	  @KichThuoc FLOAT,
	  @CAM_TRUOC float ,
	  @CAM_SAU float,
	  @TGBaoHanh NVARCHAR(10),
	  @GhiChu NVARCHAR(30),
	  @HinhAnh NVARCHAR(MAX)
AS 
BEGIN
	IF EXISTS(select MaSP from SANPHAM where MaSP=@MaSP)
		BEGIN
			UPDATE SANPHAM SET
			  TenSP=@TenSP ,
			  SoLuong=@SoLuong ,
			  DonGiaNhap =@DonGiaNhap ,
			  DonGiaBan=@DonGiaBan,
			  MauSac=@MauSac,
			  BOXULY=@BOXULY ,
			  BoNho=@BoNho ,
			  RAM=@RAM ,
			  HDH=@HDH ,
			  NamSX=@NamSX ,
			  MaHangSX=@MaHangSX ,
			  NhaCC=@NhaCC ,
			  KichThuoc=@KichThuoc ,
			  CAM_TRUOC=@CAM_TRUOC  ,
			  CAM_SAU=@CAM_SAU ,
			  TGBaoHanh=@TGBaoHanh ,
			  GhiChu=@GhiChu ,
			  HinhAnh=@HinhAnh 
			  WHERE MaSP=@MaSP
			  PRINT(N'Cập nhật sản phẩm thành công!')
		END
	ELSE
		BEGIN
			PRINT(N'Mã sản phẩm không tồn tại!')
		END
END
GO

 -----
CREATE PROCEDURE XOASANPHAM 
@MaSP varchar(6) 
AS
BEGIN
	IF NOT EXISTS(select MaSP from CHITIETDH where MaSP=@MaSP)
		BEGIN
		   DELETE FROM SANPHAM WHERE SANPHAM.MaSP = @MaSP
		   	PRINT(N'Xóa sản phẩm thành công!')
		END
	ELSE
		BEGIN
			PRINT(N'Không thể xóa sản phẩm!')
		END
END
GO

CREATE PROCEDURE TIMSANPHAM 
@TenSP varchar(6), @MaHangSX int 
AS
BEGIN
	IF EXISTS(select TenSP, MaHangSX from SANPHAM where TenSP=@TenSP and MaHangSX=@MaHangSX)
		BEGIN
		   select sp.MaSP, sp.TenSP, hsx.TenHang, sp.MauSac, sp.KichThuoc, sp.BoNho, sp.RAM
			from SANPHAM sp join HANGSX hsx 
			on sp.MaHangSX = hsx.MaHang
			where sp.TenSP=@TenSP and sp.MaHangSX=@MaHangSX
		END
	ELSE
		BEGIN
			PRINT(N'Sản phẩm hết hàng!')
		END
END
GO

CREATE PROCEDURE CHITIETSANPHAM 
@MaSP varchar(6)
AS
BEGIN
	select sp.MaSP,sp.TenSP, sp.MaHangSX, hsx.TenHang, sp.SoLuong, sp.DonGiaNhap, sp.DonGiaBan, sp.MauSac, sp.KichThuoc,
		sp.BoNho, sp.BOXULY, sp.RAM, sp.HDH, sp.CAM_TRUOC, sp.CAM_SAU, sp.NamSX, sp.NhaCC, sp.TGBaoHanh, sp.GhiChu, sp.HinhAnh
	from SANPHAM sp join HANGSX hsx 
	on sp.MaHangSX = hsx.MaHang
	where sp.MaSP=@MaSP
END
GO
------   DONHANG
CREATE VIEW XEMDONHANG
AS
SELECT dh.MaDH, dh.Ngayban, dh.TaiKhoan, tk.TenUS, dh.TongTien FROM DONHANG dh JOIN TAIKHOAN tk ON dh.TaiKhoan = tk.TaiKhoan
GO

CREATE PROC XEMDONHANG_KHACHHANG
@TaiKhoan varchar(30)
AS
BEGIN
	SELECT dh.MaDH, dh.Ngayban, dh.TaiKhoan, tk.TenUS, dh.TongTien FROM DONHANG dh JOIN TAIKHOAN tk ON dh.TaiKhoan = tk.TaiKhoan
	 where dh.TaiKhoan = @TaiKhoan
END
GO

CREATE TRIGGER CHECK_THEMDONHANG
ON DONHANG
INSTEAD OF INSERT 
AS
 BEGIN
    IF EXISTS (SELECT * FROM inserted WHERE MaDH IN (SELECT MaDH FROM DONHANG))
	   BEGIN 
	      PRINT(N'Trùng mã hóa đơn!')
	   END
	ELSE
	    BEGIN
		  SET IDENTITY_INSERT DONHANG OFF
		  INSERT INTO DONHANG
		  SELECT Ngayban,TaiKhoan,TongTien
		  FROM inserted
		END

 END
 GO
 ---------------
CREATE PROCEDURE THEMDONHANG
@Ngayban DATE,@TaiKhoan VARCHAR(30), @TongTien INT
AS
BEGIN 
    IF(@Ngayban='' AND @TaiKhoan='')
    BEGIN 
	  PRINT(N'Nhập ngày bán và tài khoản!')
	END
   ELSE
    BEGIN
	   INSERT INTO DONHANG(Ngayban,TaiKhoan, TongTien) values(@Ngayban,@TaiKhoan,@TongTien)
	   PRINT(N'Thêm đơn hàng mới thành công!')
	END
END
GO

----------------
CREATE PROCEDURE SUADONHANG
@MaDH INT, @Ngayban DATE,@TaiKhoan VARCHAR(30), @TongTien INT
AS
BEGIN
   UPDATE DONHANG set Ngayban=@Ngayban,TaiKhoan=@TaiKhoan,TongTien=@TongTien where MaDH=@MaDH
   PRINT(N'Cập nhật đơn hàng thành công!')
END
GO
---------------
CREATE PROCEDURE XOADONHANG
@MaDH INT
AS
BEGIN
	DELETE DONHANG WHERE DONHANG.MaDH =@MaDH
    PRINT(N'Xóa đơn hàng thành công!')
END
GO

-------------- HÃNG SẢN XUẤT 
 CREATE PROCEDURE THEMHANGSX
 @TenHang nvarchar(20),@DiaChi nvarchar(100)
 AS
  BEGIN
  IF(@TenHang='' AND @DiaChi='')
    BEGIN
	  PRINT(N'Nhập tên và địa chỉ hãng sản xuất!')
	END
   ELSE
     BEGIN
	   set identity_insert HANGSX off; insert into HANGSX(TenHang,DiaChi) values(@TenHang,@DiaChi)
	   PRINT(N'Thêm mới hãng sản xuất thành công!')
	 END
  END
GO
----------- 
CREATE PROCEDURE CAPNHATHANGSX
@MaHang int, @TenHang nvarchar(20),@DiaChi nvarchar(100)
 AS
  BEGIN
  IF(@TenHang='' AND @DiaChi='')
    BEGIN
	  PRINT(N'Nhập tên và địa chỉ hãng sản xuất!')
	END
   ELSE
     BEGIN
	    update HANGSX set TenHang=@TenHang,DiaChi=@DiaChi where MaHang=@MaHang
		PRINT(N'Cập nhật hãng sản xuất thành công!')
	 END
  END
  GO
---------
CREATE PROCEDURE XOAHANGSX
@MaHang int 
AS
  BEGIN
	IF NOT EXISTS(select MaHangSX from SANPHAM where MaHangSX=@MaHang)
	BEGIN
	    DELETE HANGSX WHERE MaHang=@MaHang
		PRINT(N'Xóa hãng sản xuất thành công!')
	END
	ELSE
	BEGIN
		PRINT(N'Không thể xóa hãng sản xuất!')
	END
  END
  GO

-------- 
CREATE PROC XEMCHITIETDONHANG
@MaDH INT
AS
BEGIN
	SELECT ctdh.MaCTDH, ctdh.MaDH, ctdh.MaSP, sp.TenSP, ctdh.SoLuong, ctdh.DonGia, ctdh.ThanhTien  FROM CHITIETDH ctdh JOIN SANPHAM sp ON ctdh.MaSP = sp.MaSP WHERE ctdh.MaDH = @MaDH
END
GO


CREATE PROCEDURE THEM_CHITIETDONHANG
@MaDH int,@MaSP varchar(6),@SoLuong int,@DonGia int,@ThanhTien INT
AS
BEGIN
	declare @SoLuongSP int
	set @SoLuongSP = (select SoLuong from SANPHAM where MaSP=@MaSP)
	if(@SoLuongSP >= @SoLuong)
		begin
			insert into CHITIETDH(MaDH, MaSP, SoLuong, DonGia,ThanhTien) values(@MaDH, @MaSP, @SoLuong,@DonGia,@ThanhTien)
			update SANPHAM set SoLuong = (SoLuong - @SoLuong) where MaSP=@MaSP
			update DONHANG set TongTien = ( select (SUM(ThanhTien)) as Tong  from CHITIETDH where MaDH=@MaDH) where MaDH=@MaDH
			PRINT(N'Thêm sản phẩm mới vào đơn hàng thành công!')
		end
	else
		begin
			PRINT(N'Số lượng sản phẩm trong kho không đủ!')
		end
END
GO
----------
CREATE PROCEDURE CAPNHAT_CHITIETDONHANG 
@MaCTDH int,@MaDH int,@MaSP varchar(6),@SoLuong int,@DonGia int,@ThanhTien INT
AS
BEGIN
	declare @SoLuongCu int, @SoLuongKho int
	set @SoLuongCu = (select SoLuong from CHITIETDH where MaCTDH=@MaCTDH)
	set @SoLuongKho = (select SoLuong from SANPHAM where MaSP=@MaSP)
	if((@SoLuongKho + (@SoLuongCu - @SoLuong)) >= 0)
		begin
			update SANPHAM set SoLuong = (SoLuong + (@SoLuongCu - @SoLuong)) where MaSP=@MaSP
			update CHITIETDH set @MaSP=@MaSP,SoLuong=@SoLuong,DonGia=@DonGia,ThanhTien=@ThanhTien where MaCTDH=@MaCTDH
			update DONHANG   set TongTien = ( select (SUM(ThanhTien)) as Tong  from CHITIETDH where MaDH=@MaDH) where MaDH=@MaDH
			print(N'Cập nhật sản phẩm thành công!')
		end
	else
		begin
			print(N'Số lượng sản phẩm trong kho không đủ!')
		end
END
GO


---------
CREATE PROCEDURE XOA_CHITIETDONHANG
@MaCTDH int
AS
BEGIN
	declare @SoLuongCTDH int, @MaSP varchar(6), @MaDH int
	set @SoLuongCTDH = (select SoLuong from CHITIETDH where MaCTDH=@MaCTDH)
	set @MaSP = (select MaSP from CHITIETDH where MaCTDH=@MaCTDH)
	set @MaDH = (select MaDH from CHITIETDH where MaCTDH=@MaCTDH)

	update SANPHAM set SoLuong = (SoLuong + @SoLuongCTDH) where MaSP=@MaSP
    DELETE CHITIETDH WHERE MaCTDH=@MaCTDH
	update DONHANG set TongTien = ( select (SUM(ThanhTien)) as Tong  from CHITIETDH where MaDH=@MaDH) where MaDH=@MaDH
	print(N'Xóa sản phẩm trong đơn hành thành công!')
END
GO

---------------------- Mua hàng
CREATE FUNCTION TIMKIEMSANPHAM(@HangSX int,@TenSP nvarchar(50))
RETURNS TABLE
AS
RETURN ( SELECT * FROM SANPHAM WHERE TenSP LIKE CONCAT('%',@TenSP,'%') and MaHangSX=@HangSX)
GO

--------------------------
CREATE PROCEDURE  MUAHANG 
@MaDH int,@MaSP varchar(6),@TenSP nvarchar(20),@SoLuong int,@DonGia int,@ThanhTien INT,@NgayBan Date,@Taikhoan nvarchar(40),@TongTien int
AS
 BEGIN
   set identity_insert DONHANG off; insert into DONHANG(Ngayban,TaiKhoan, TongTien) values( @NgayBan, @Taikhoan, null)
   insert into CHITIETDH(MaDH, MaSP, SoLuong, DonGia,ThanhTien) values(@MaDH, @MaSP, @SoLuong,@DonGia,@ThanhTien)
 END
GO

CREATE PROC ThongKeDoanhSo
@TuNgay DATE, @DenNgay DATE
AS
BEGIN
	SELECT Ngayban, SUM(TongTien) as TongTien FROM DONHANG WHERE Ngayban >= @TuNgay AND Ngayban <= @DenNgay GROUP BY Ngayban
END
GO

CREATE PROC ThongKeSanPhamBanChay
@TuNgay DATE, @DenNgay DATE
AS
BEGIN
	select T.MaSP, T.TenSP, SUM(T.SoLuong) as SoLuong 
	from (select CTDH.MaSP, SP.TenSP, CTDH.SoLuong, DH.Ngayban 
		from CHITIETDH CTDH
		inner join SANPHAM SP on CTDH.MaSP = SP.MaSP 
		inner join DONHANG DH on DH.MaDH = CTDH.MaDH 
		where DH.Ngayban >= @TuNgay and DH.Ngayban <= @DenNgay) 
		as T group by T.MaSP, T.TenSP
END
GO

CREATE PROC ThongKeSanPhamHetHang
AS
BEGIN
	select MaSP, TenSP, SoLuong from SANPHAM
END
GO
CREATE PROC TIMKIEM_SANPHAM 
@MaSP varchar(6)
AS
BEGIN
	select * from XEMSANPHAM where MaSP = @MaSP
END
GO