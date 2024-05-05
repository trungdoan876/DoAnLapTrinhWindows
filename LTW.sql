--database new
CREATE DATABASE LTW
--Sản Phẩm

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
	MoTaSanPham nvarchar(max),
	NganhHang nvarchar (100),
	TinhTrang varchar(10),
	DangBan nvarchar(50), --chưa đăng bán, đã đăng bán
	MaNguoiBan nchar(10), --REFERENCES NguoiBan(Ma),
	DiaChi nvarchar(100),
	SoLuong int, --số lượng sản phẩm có sẵn
)
GO
--Người Bán
CREATE TABLE NguoiBan
(
	Ma nchar(10), --ten tai khoan
	MatKhau nchar(100),
    Ten nvarchar(100),
    SDT char(10) UNIQUE, 
    NgaySinh DATE,
    GioiTinh nvarchar(10),
    CCCD char(20),
    DiaChi nvarchar(100),
    MoTaShop nvarchar(max),
    Hinh varbinary(max),
	PRIMARY KEY(Ma)
);
GO
--Người Mua
CREATE TABLE NguoiMua
(
	Ma nchar(10), --ten tai khoan 
	Ten nvarchar(100),
	MatKhau varchar(100),
	NgaySinh DATE,
	GioiTinh nvarchar(10),
	CCCD char(20),
	DiaChi nvarchar(100), 
	SDT char(10) UNIQUE,
	Hinh varbinary(max),
	PRIMARY KEY(Ma)
);
CREATE TABLE GioHang
(
	MaNguoiMua nchar(10) REFERENCES NguoiMua(Ma),
	MaSanPham nchar(10), --REFERENCES SanPham(MaSanPham),
	TenSanPham nvarchar(100),
	GiaBan nvarchar(100),
	SoLuong int,--số lượng thêm vào
	MaNguoiBan nchar(10),
	TrangThaiSP bit, --chọn để đặt hàng --nút tick
	Hinh varbinary(max),
	--PRIMARY KEY(MaNguoiMua,MaNguoiBan)
)
GO
--Sản phẩm Yêu Thích 
CREATE TABLE YeuThich
(
	MaNguoiBan nchar(10) REFERENCES NguoiBan(Ma),
	MaNguoiMua nchar(10) REFERENCES NguoiMua(Ma),
	MaSanPham nchar(10) REFERENCES SanPham(MaSanPham),
	PRIMARY KEY(MaNguoiMua,MaSanPham)
)
GO
--Người mua đặt hàng -> Tạo đơn hàng mới
CREATE TABLE DonHang
(
	MaDonHang char(20) primary key,
	MaNguoiBan nchar(10) REFERENCES NguoiBan(Ma),
	MaNguoiMua nchar(10) REFERENCES NguoiMua(Ma),
	TongTien decimal(10,3),
	NgayDatHang DateTime,
	TrangThaiDonHangNM nvarchar(100),
	TrangThaiDonHangNB nvarchar(100),--da xac nhan,...
)
GO
--Mỗi đơn hàng có nhiều sản phẩm ->Chi tiết đơn hàng
Create table ChiTietDonHang
(
	MaDonHang char(20) REFERENCES DonHang(MaDonHang),
	MaSanPham nchar(10) REFERENCES SanPham(MaSanPham),
	TenSanPham nvarchar(100),
	SoLuong int, --so luong moi san pham mua
	GiaTien decimal(10,3), --gia tien moi san pham
	PRIMARY KEY (MaDonHang,MaSanPham)
)
--Thêm nhiều hình vào Sản phẩm
CREATE TABLE HinhAnh
(
	id int identity(1,1),
	MaSanPham nchar(10), --REFERENCES SanPham(MaSanPham),
	Hinh varbinary(max)
)
GO
--Người Mua Đánh giá
CREATE TABLE DanhGia
(
	MaNguoiMua nchar(10),
	MaSanPham nchar(10), --REFERENCES SanPham(MaSanPham),
	Sao float,
	SaoNguoiBan float,
	SaoGiaoHang float,
	NhanXet nvarchar(max),
	NgayDanhGia Datetime,
)
--Thêm nhiều hình khi đánh giá
CREATE TABLE HinhDanhGia
(
	id int identity(1,1),
	MaNguoiMua nchar(10), --REFERENCES NguoiMua(Ma),
	MaSanPham nchar(10), --REFERENCES SanPham(MaSanPham),
	NgayDanhGia Datetime,
	Hinh varbinary(max)
)
--so sánh tên sản phẩm và ngành hàng
--tìm kiếm theo ngành hàng
--tần suất tìm kiếm
--Tìm kiếm nhiều ->Hiện những sản phẩm cùng ngành hàng
CREATE TABLE TimKiem
(
	--MaSanPham nchar(10),
	--TenSanPham nvarchar(100),
	MaNguoiMua nchar(10),
	TanSuatTimKiem int,
	NganhHang nvarchar (100),
	primary key(NganhHang,MaNguoiMua)
)
--Truy cập vào 1 sản phẩm nhiều lần ->Hiện ra các sản phẩm tương tự/cùng ngành hàng trước
CREATE TABLE TanSuatTruyCap 
(
	--MaSanPham nchar(10),
	--TenSanPham nvarchar(100),
	MaNguoiMua nchar(10),
	TanSuatTruyCap int,
	NganhHang nvarchar (100),
	primary key(NganhHang,MaNguoiMua)
)
GO
--Thống kê tất cả số sản phẩm bán ra trong tháng của năm hiện tại theo MaNguoiBan
 --giao hàng thành công ->sản phẩm bán ra +1
 CREATE TABLE ThongKeSP
 (
	MaNguoiBan nchar(10),
	NgayDatHang DateTime, --ngay san pham ban ra
	SoLanBan int,
 )
 --tính số lần bán hàng theo tháng trong 1 năm
SELECT 
    MONTH(NgayDatHang) AS ThangTrongNam,
    SoLanBan 
FROM 
    ThongKeSP
WHERE 
    YEAR(NgayDatHang) = 2024
ORDER BY 
    ThangTrongNam;
GO
--dùng cho biểu đồ tròn, chọn 5 sản phẩm có lượt mua cao nhất
CREATE TABLE LuotMuaSanPham
(
	MaSanPham  nchar(10),
	MaNguoiBan nchar(10),
	LuotMua int,
	primary key(MaSanPham,MaNguoiBan)
)
