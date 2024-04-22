CREATE TABLE SanPham 
(
	Hinh varbinary(max),
	MaSanPham nchar(10) PRIMARY KEY,
	TenSanPham nvarchar(100),
	GiaBan decimal(10,3),
	GiaGoc nvarchar(100),
	XuatXu nvarchar(100),
	TGDSD nvarchar(100),
	NgayDang DATE,
	MoTaSanPham NVARCHAR(1000),
	NganhHang nvarchar (100),
	TinhTrang varchar(10),
	DangBan bit,
	MaNguoiBan nchar(10) REFERENCES NguoiBan (Ma),
	DiaChi NVARCHAR(100),
	SoLuong int, --so luong san pham san co
)
drop table SanPham
UpDAte SanPham set TinhTrang = '56%'  Where MaSanPham = 'SP10' 
GO
select* from SanPham
INSERT INTO NguoiBan VALUES('NB01','123', N'Nguyễn Văn A', 093546342, '1999-12-10', N'Nam', 048304000448, N'TPHCM', null, N'Cửa hàng có một loạt các sản phẩm từ các thương hiệu nổi tiếng đến những nhãn hiệu độc lập, mang đến sự đa dạng và lựa chọn cho khách hàng. Bạn có thể tìm thấy từ trang phục hàng ngày đến trang phục dành cho các dịp đặc biệt, từ trang phục công sở đến trang phục dạo phố.', null);
INSERT INTO NguoiBan VALUES('NB02','123', N'Nguyễn Văn B', 093824641, '1999-12-10', N'Nữ', 048304000498, N'TPHCM', null, N'Ở đây bạn sẽ tìm thấy đủ loại đồ ăn vặt từ khô, chua, ngọt đến mặn, đáp ứng mọi sở thích và khẩu vị của khách hàng. Từ các loại snack truyền thống đến những món ăn vặt mang hơi hướng hiện đại và sáng tạo, có đủ để làm hài lòng cả những người khó tính nhất.', null);
GO
--DELETE FROM SanPham WHERE DangBan =0;
INSERT INTO SanPham VALUES (NULL,'SP1',N'Sách Cây cam ngọt của tôi',80.000,'110.000',null,N'2 tháng',GETDATE(),N'Cây cam ngọt của tôi kể về Zezé – một cậu bé 5 tuổi sống trong một gia đình nghèo khó có nhiều anh chị em ở Brazil. Đó là hành trình của nỗi đau, của tình yêu thương và hơn hết, của tâm hồn trẻ thơ đơn sơ, giàu trí tưởng tượng nhưng cũng đầy tổn thương. Những câu chuyện xung quanh Zezé, đi học, chuyển nhà, mối quan hệ với gia đình và những người bạn: cây cam ngọt sau vườn và Ông Bồ, một người bằng xương bằng thịt chứ không chỉ trong tưởng tượng của Zezé. Với văn phong trong trẻo dễ chịu, mình bật cười trước những câu hỏi ngây ngô của Zezé, nhíu mày với những trò nghịch ngợm nhưng cũng khóc nhiều vì những tổn thương mà đáng lẽ ra một đứa bé 5 tuổi không và tuyệt đối không thể có.','Sach', '90%',0,'NB01','TPHCM',1)
INSERT INTO SanPham VALUES (null,'SP2',N'Son dưỡng',90.000,'150.000',N'Việt Nam',N'2 tuần',GETDATE(),N'Son dưỡng thường chứa các thành phần dưỡng ẩm như dầu hạt jojoba, dầu hạt dừa, sáp ong, hoặc bơ hạt mỡ. Ngoài ra, chúng cũng có thể bổ sung vitamin E và các chất chống oxy hóa khác để bảo vệ môi khỏi tác động của tia UV và môi trường', N'Mỹ phẩm', '60%',0,'NB01','TPHCM',2)
INSERT INTO SanPham VALUES (null, 'SP3',N'Máy tính',20.000 ,'30.000.000',N'Thái Lan', N'5 tháng',GETDATE(),N'Bề mặt của máy thường làm từ nhựa, kim loại hoặc hợp kim nhôm, tạo cảm giác chắc chắn và sang trọng. Trên mặt trước của máy, bạn thường sẽ thấy các cổng kết nối như cổng USB, cổng âm thanh, và có thể một ổ đĩa quang để đọc đĩa CD/DVD. Màn hình hiển thị thông tin và các phím bấm để tương tác cũng là một phần quan trọng của máy tính.',N'Học tập','90%',0,'NB02','TPHCM',2)
INSERT INTO SanPham VALUES (null, 'SP4',N'Coca cola',200.000 ,'1.000.000',N'Thái Lan', N'5 tháng',GETDATE(),N'Coca-Cola thường được mô tả là một loại đồ uống giải khát sảng khoái, với hương vị cân đối giữa vị ngọt và vị chua, và có một chút axit. Hương vị đặc trưng này đã làm cho Coca-Cola trở thành một loại đồ uống được yêu thích trên toàn thế giới suốt hơn một thế kỷ qua.',N'Nước uống','100%',0,'NB02','TPHCM',3)
GO
--DROP TABLE NguoiBan
CREATE TABLE NguoiBan
(
	Ma nchar(10), --ten tai khoan
	MatKhau nchar(100),
    Ten NVARCHAR(100),
    SDT char(10),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    CCCD char(20),
    DiaChi NVARCHAR(100),
    Email NVARCHAR(100),
    MoTaShop NVARCHAR(1000),
    Hinh varbinary(max),
	PRIMARY KEY(Ma)
);
select * from NguoiBan
CREATE TABLE NguoiMua
(
	Ma nchar(10), --ten tai khoan 
	Ten nvarchar(100),
	MatKhau varchar(100),
	NgaySinh DATE,
	GioiTinh nchar(10),
	CCCD char(20),
	DiaChi nvarchar(200), 
	SDT char(10),
	Email varchar(50),
	Hinh varbinary(max),
	MaDonHang char(10),
	PRIMARY KEY(Ma)
)
INSERT INTO NguoiMua VALUES ('NM01',N'Nguyễn Thị B','123456','1990-03-20','Nu','27839293',N'484 Lê Văn Việt, phường Tăng Nhơn Phú A, Hồ Chí Minh','0192837283',null,null,null);
GO
select * from NguoiMua
--DROP TABLE NguoiMua
--DROP TABLE GioHang
select * from GioHang
CREATE TABLE GioHang
(
	MaSanPham nchar(10),
	TenSanPham nvarchar(100),
	GiaBan nvarchar(100),
	SoLuong int,
	MaNguoiMua nchar(10),
	MaNguoiBan nchar(10),
	TrangThaiSP bit,
	Hinh varbinary(max)
)
GO
--drop table YeuThich
CREATE TABLE YeuThich
(
	MaNguoiBan nchar(10),
	MaNguoiMua nchar(10),
	MaSanPham nchar(10),
	PRIMARY KEY(MaNguoiMua,MaSanPham)
)
select * from YeuThich
SELECT SanPham.Hinh,SanPham.MaSanPham as MaSP, SanPham.TenSanPham as TenSP, SanPham.GiaBan as GiaBan, SanPham.TinhTrang as TinhTrang, SanPham.SoLuong as SL FROM GioHang, SanPham WHERE GioHang.MaSanPham = SanPham.MaSanPham and MaNguoiMua = 'NM01'
select SanPham.TenSanPham as TenSP, SanPham.GiaBan as GiaBan, SanPham.TinhTrang as TinhTrang
from GioHang, SanPham WHERE GioHang.MaSanPham = SanPham.MaSanPham and MaNguoiMua = 'NM01'
SELECT * From GioHang WHERE TrangThaiSP = 1 and MaNguoiMua ='NM01'
--Bang don hang khi mua san pham tao don hang moi
--drop table donhang
CREATE TABLE DonHang
(
	MaDonHang int identity(1,1),
	MaNguoiBan nchar(10),
	MaNguoiMua nchar(10),
	MaSanPham nchar(10),
	TenSanPham nvarchar(100),
	SoLuongSP int, --so luong moi san pham them vao gio hang
	GiaBan nvarchar(100),
	TongTien nvarchar(100),
	TrangThai nvarchar(100)
	primary key (MaDonHang,MaNguoiBan,MaNguoiMua)
)
select * from DonHang
SELECT SanPham.MaNguoiBan,SanPham.Hinh,SanPham.MaSanPham as MaSP, SanPham.TenSanPham as 
TenSP, SanPham.GiaBan as GiaBan, SanPham.TinhTrang as TinhTrang, SanPham.SoLuong as SL 
FROM GioHang, SanPham WHERE GioHang.MaSanPham = SanPham.MaSanPham and MaNguoiMua = 'NM01'
 
SELECT SanPham.MaNguoiBan as maNB,SanPham.Hinh,SanPham.MaSanPham as MaSP, SanPham.TenSanPham as TenSP, SanPham.GiaBan as GiaBan, SanPham.TinhTrang as TinhTrang, SanPham.SoLuong as SL 
FROM GioHang, SanPham WHERE GioHang.MaSanPham = SanPham.MaSanPham and MaNguoiMua ='NM01'
select * from sanpham
--delete from sanpham where manguoiban ='NB01'
SELECT SanPham.Hinh as Hinh, SanPham.TenSanPham as TenSP, SanPham.GiaBan as GiaBan, SanPham.GiaGoc as GiaGoc, SanPham.DiaChi as DiaChi, YeuThich.MaSanPham as MaSP FROM YeuThich,SanPham WHERE YeuThich.MaSanPham = SanPham.MaSanPham and MaNguoiMua = 'NM01'

SELECT SanPham.Hinh as Hinh, SanPham.TenSanPham as TenSP, SanPham.GiaBan as GiaBan, SanPham.GiaGoc as GiaGoc, SanPham.DiaChi as DiaChi, YeuThich.MaSanPham as MaSP
                    FROM YeuThich,SanPham WHERE YeuThich.MaSanPham = SanPham.MaSanPham and MaNguoiMua = 'NM01'
SELECT SanPham.MaNguoiBan as maNB,SanPham.Hinh,SanPham.MaSanPham as MaSP, SanPham.TenSanPham as TenSP, SanPham.GiaBan as GiaBan, SanPham.TinhTrang as TinhTrang, SanPham.GiaGoc as GiaGoc, SanPham.DiaChi as DiaChi, SanPham.SoLuong as SL, GioHang.SoLuong as SLMua, GioHang.TrangThaiSP as TrangThai FROM GioHang, SanPham WHERE GioHang.MaSanPham = SanPham.MaSanPham and MaNguoiMua = 'NM01'
select GioHang.MaNguoiMua, GioHang.MaSanPham, NguoiMua.TenNguoiMua as ten, NguoiMua.DiaChi as diachi FROM GioHang, NguoiMua WHERE GioHang.MaNguoiMua = NguoiMua.MaNguoiMua AND NguoiMua.MaNguoiMua ='NM01'
GO
CREATE TABLE DonHang
(
	MaDonHang char(20),
	MaNguoiBan nchar(10),
	MaNguoiMua nchar(10),
	TongTien nvarchar(100),
	NgayDatHang DateTime,
	TrangThaiDonHang nvarchar(100), --da xac nhan,...
)
Create table ChiTietDonHang
(
	MaDonHang char(10),
	MaSanPham nchar(10),
	--so luong sp
	GiaTien char(10)
)
CREATE TABLE HinhAnh
(
	id int identity(1,1),
	MaSanPham nchar(10),
	Hinh varbinary(max)
)
select * from HinhAnh