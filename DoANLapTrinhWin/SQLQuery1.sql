﻿DROP TABLE SanPham
CREATE TABLE SanPham (
	Hinh varbinary(max),
	MaSanPham nchar(10) PRIMARY KEY,
	TenSanPham nvarchar(100),
	GiaBan int,
	GiaGoc int,
	XuatXu nvarchar(100),
	ThoiGianDaSuDung nvarchar(100),
	NgayDang DATE,
	MoTaSanPham NVARCHAR(1000),
	NganhHang nvarchar (100),
	TinhTrang varchar(10),
	MaNguoiBan nchar(10),
)
INSERT INTO SanPham VALUES (NULL,'SP1',N'Sách Cây cam ngọt của tôi',80000,110000,null,N'2 tháng',GETDATE(),N'Cây cam ngọt của tôi kể về Zezé – một cậu bé 5 tuổi sống trong một gia đình nghèo khó có nhiều anh chị em ở Brazil. Đó là hành trình của nỗi đau, của tình yêu thương và hơn hết, của tâm hồn trẻ thơ đơn sơ, giàu trí tưởng tượng nhưng cũng đầy tổn thương. Những câu chuyện xung quanh Zezé, đi học, chuyển nhà, mối quan hệ với gia đình và những người bạn: cây cam ngọt sau vườn và Ông Bồ, một người bằng xương bằng thịt chứ không chỉ trong tưởng tượng của Zezé. Với văn phong trong trẻo dễ chịu, mình bật cười trước những câu hỏi ngây ngô của Zezé, nhíu mày với những trò nghịch ngợm nhưng cũng khóc nhiều vì những tổn thương mà đáng lẽ ra một đứa bé 5 tuổi không và tuyệt đối không thể có.','Sach', '90%','NB01')
INSERT INTO SanPham VALUES (null,'SP2',N'Son dưỡng',90000,150000,N'Việt Nam',N'2 tuần',GETDATE(),N'Son dưỡng thường chứa các thành phần dưỡng ẩm như dầu hạt jojoba, dầu hạt dừa, sáp ong, hoặc bơ hạt mỡ. Ngoài ra, chúng cũng có thể bổ sung vitamin E và các chất chống oxy hóa khác để bảo vệ môi khỏi tác động của tia UV và môi trường', N'Mỹ phẩm', '60%','NB01')
INSERT INTO SanPham VALUES (null, 'SP3',N'Máy tính',20000000 ,10000000,N'Thái Lan', N'5 tháng',GETDATE(),N'Bề mặt của máy thường làm từ nhựa, kim loại hoặc hợp kim nhôm, tạo cảm giác chắc chắn và sang trọng. Trên mặt trước của máy, bạn thường sẽ thấy các cổng kết nối như cổng USB, cổng âm thanh, và có thể một ổ đĩa quang để đọc đĩa CD/DVD. Màn hình hiển thị thông tin và các phím bấm để tương tác cũng là một phần quan trọng của máy tính.',N'Học tập','90%','NB02')
Select * from SanPham
GO
CREATE TABLE NguoiBan
(
	TenTaiKhoan Nchar(100),
	MatKhau nchar(100),
    MaNguoiBan NCHAR(10) PRIMARY KEY,
    Ten NVARCHAR(100),
    SDT CHAR(20),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    CMNDorCCCD char(30),
    DiaChi NVARCHAR(100),
    Email NVARCHAR(100),
    MoTaShop NVARCHAR(1000),
    Hinh varbinary(max)
);
Select * from NguoiBan

INSERT INTO NguoiBan VALUES('Nb1','123','NB01', N'Nguyễn Văn A', '093546342', '1999-12-10', N'Nam', 048304000448, N'TPHCM', null, N'Cửa hàng có một loạt các sản phẩm từ các thương hiệu nổi tiếng đến những nhãn hiệu độc lập, mang đến sự đa dạng và lựa chọn cho khách hàng. Bạn có thể tìm thấy từ trang phục hàng ngày đến trang phục dành cho các dịp đặc biệt, từ trang phục công sở đến trang phục dạo phố.', null);
INSERT INTO NguoiBan VALUES('Nb2','123','NB02', N'Nguyễn Văn B', '093824641', '1999-12-10', N'Nữ', 048304000498, N'TPHCM', null, N'Ở đây bạn sẽ tìm thấy đủ loại đồ ăn vặt từ khô, chua, ngọt đến mặn, đáp ứng mọi sở thích và khẩu vị của khách hàng. Từ các loại snack truyền thống đến những món ăn vặt mang hơi hướng hiện đại và sáng tạo, có đủ để làm hài lòng cả những người khó tính nhất.', null);

