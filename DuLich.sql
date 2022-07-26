create database QLDulich
go
use QLDulich
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DuLich](
	[Mã du lịch] [nvarchar](10) NOT NULL,
	[Tên] [nvarchar](200) NULL,
	[Nơi khởi hành] [nvarchar](50) NULL,
	[Nơi đến] [nvarchar](50) NULL,
	[Điểm đến] [nvarchar](50) NULL,
	[Thời gian] [nvarchar](50) NULL,
	[Giá] [float] NULL,
 CONSTRAINT [PK_DuLich] PRIMARY KEY CLUSTERED 
(
	[Mã du lịch] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

insert into DuLich values (N'HP01',N'Du lịch Miền Trung: Hải Phòng - Đà Nẵng - Bà Nà - Hội An - Huế - Quảng Bình 4 Ngày', N'Hải Phòng',N'Hội An', N'Du lịch Miền Trung', N'4 Ngày 3 Đêm', N'2950000')
insert into DuLich values (N'HP02',N'Du lịch Đà Nẵng: Trọn Gói :Hải Phòng - Đà Nẵng - Sơn Trà - Bà Nà - Cù Lao Chàm - Galina - Hội An 3 Ngày + Vé Máy Bay', N'Hải Phòng',N'Đà Nẵng', N'Du lịch Miền Trung', N'4 Ngày 3 Đêm', N'2950000')
insert into DuLich values (N'HP03',N'Du lịch: Hải Phòng – Hạ Long – Cát Bà 3 ngày 2 đêm', N'Hải Phòng',N'Hạ Long', N'Du lịch Hạ Long', N'3 Ngày 2 Đêm', N'4790000')
insert into DuLich values (N'HP04',N'Du lịch: Hải Phòng – Hạ Long – Tuần Châu 2 ngày 1 đêm', N'Hải Phòng',N'Hạ Long', N'Du lịch Hạ Long', N'2 Ngày 1 Đêm', N'3150000')
insert into DuLich values (N'HP05',N'Du lịch: Hải Phòng – Hạ Long 1 ngày', N'Hải Phòng',N'Hạ Long', N'Du lịch Hạ Long', N'1 Ngày', N'1590000')
insert into DuLich values (N'HP06',N'Du lịch: Hải Phòng – Ninh Bình - Hoa Lư – Tam Cốc 1 ngày', N'Hải Phòng',N'Ninh Bình', N'Du lịch Ninh Bình', N'1 Ngày',N'1890000')
insert into DuLich values (N'HP07',N'Du lịch: Hải Phòng – Ninh Bình - Bái Đính – Tràng An 1 ngày', N'Hải Phòng',N'Ninh Bình', N'Du lịch Ninh Bình', N'1 Ngày', N'990000')
insert into DuLich values (N'HP08',N'Du lịch: Hải Phòng – Sapa – Cát Cát – Hàm Rồng 3 ngày 3 đêm', N'Hải Phòng',N'Sapa', N'Du lịch Sapa', N'3 Ngày 3 Đêm', N'3030000')
insert into DuLich values (N'HP09',N'Du lịch: Hải Phòng – Sapa – Hạ Long 4 ngày 4 đêm', N'Hải Phòng',N'Sapa', N'Du lịch Sapa', N'4 Ngày 4 Đêm', N'5250000')
insert into DuLich values (N'HP10',N'Du lịch: Hải Phòng – Nha Trang – Đà Lạt 5 ngày', N'Hải Phòng',N'Nha Trang', N'Du lịch Nha Trang', N'5 Ngày 4 Đêm', N'4100000')
insert into DuLich values (N'HP11',N'Du lịch: Hải Phòng – Nha Trang – Đà Lạt – Sài Gòn – Mũi Né 8 ngày', N'Hải Phòng',N'Đà Lạt', N'Du lịch Nha Trang', N'8 Ngày 7 Đêm', N'7600000')
insert into DuLich values (N'HN01',N'Du lịch: Hà Nội - Hạ Long Du thuyền 5 sao Paradise 2 ngày 1 đêm', N'Hà Nội',N'Hạ Long', N'Du lịch Hạ Long', N'2 Ngày 1 Đêm', N'2590000')

Insert into DuLich values (N'HP12',N'Du lịch: Hải Phòng – Đà Lạt 3 ngày',N'Hải Phòng',N'Đà Lạt',N'Du lịch Đà Lạt',N'3 Ngày 2 Đêm',N'3950000')
Insert into DuLich values (N'HP13',N'Du lịch: Hải Phòng – Mũi Né 3 ngày ',N'Hải Phòng',N'Mũi Né',N'Du lịch Mũi Né',N'3 Ngày 2 Đêm',N'4200000')
Insert into DuLich values (N'HP14',N'Du lịch: Hải Phòng – Sài Gòn – Mũi Né 4 ngày',N'Hải Phòng',N'Sài Gòn',N'Du lịch Sài Gòn - Mũi Né',N'4 Ngày 3 Đêm',N'4900000')
Insert into DuLich values (N'HP15',N'Du lịch: Hải Phòng – Phú Quốc – Vinpearland 3 ngày',N'Hải Phòng',N'Phú Quốc',N'Du lịch Phú Quốc',N'3 Ngày 2 Đêm',N'3190000')
Insert into DuLich values (N'HP16',N'Du lịch: Hải Phòng – Côn Đảo 3 ngày',N'Hải Phòng',N'Côn Đảo',N'Du lịch Côn Đảo',N'3 Ngày 2 Đêm',N'3100000')
Insert into DuLich values (N'HP17',N'Du lịch: Hải Phòng – Sài Gòn – Mỹ Tho – Cần Thơ – Chợ Nổi 5 ngày',N'Hải Phòng',N'Cần Thơ',N'Du lịch Sài Gòn – Cần Thơ',N'5 Ngày 4 Đêm',N'4500000')
Insert into DuLich values (N'HP18',N'Du lịch: Hải Phòng - Sài Gòn – Mỹ Tho – Cần Thơ – Chợ nổi Cái Răng 4 Ngày',N'Hải Phòng',N'Sài Gòn',N'Sài Gòn – Cần Thơ',N'4 Ngày 3 Đêm',N'3850000')

Insert into DuLich values (N'HN02',N'Du lịch Na Hang: Hà Nội - Tuyên Quang - Na Hang 2 Ngày',N'Hà Nội',N'Tuyên Quang',N'Du lịch Tuyên Quang',N'2 Ngày 1 Đêm',N'1950000')
Insert into DuLich values (N'HN03',N'Du lịch Cao Bằng: Hà Nội - Cao Bằng - Pác Bó - Thác Bản Giốc - Ngườm Ngao 2 Ngày',N'Hà Nội',N'Cao Bằng',N'Du lịch Cao Bằng - Pác Bó',N'2 Ngày 2 Đêm',N'2050000')
Insert into DuLich values (N'HN04',N'Du lịch Quy Nhơn: Hà Nội - Quy Nhơn - Tuy Hòa 4 ngày',N'Hà Nội',N'Quy Nhơn',N'Du lịch Quy Nhơn - Tuy Hòa',N'4 Ngày 3 Đêm',N'3990000')
Insert into DuLich values (N'HN05',N'Du lịch Phú Quốc: Hà Nội - Phú Quốc 4 Ngày',N'Hà Nội',N'Phú Quốc',N'Du lịch Phú Quốc',N'4 Ngày 3 Đêm',N'3990000')
Insert into DuLich values (N'HN06',N'Du lịch Nha Trang: Hà Nội- Nha Trang - Miền Cát Trắng 3 Ngày',N'Hà Nội',N'Nha Trang',N'Du lịch Nha Trang',N'3 Ngày 2 Đêm',N'4690000')
Insert into DuLich values (N'HN07',N'Du lịch Hạ Long: Du thuyền 5 sao - Khám Phá Vịnh Lan Hạ / Đảo Cát Bà',N'Hà Nội',N'Hạ Long',N'Du lịch Hạ Long',N'2 Ngày 1 Đêm',N'1990000')
Insert into DuLich values (N'HN08',N'Du lịch Hạ Long - Cát Bà 2 Ngày',N'Hà Nội',N'Hạ Long',N'Du lịch Hạ Long - Cát Bà',N'2 Ngày 1 Đêm',N'1550000')
Insert into DuLich values (N'HN09',N'Du lịch Miền Trung: Hà Nội - Đà Nẵng - Sơn Trà - Bà Nà - Hội An 3 Ngày',N'Hà Nội',N'Đà Nẵng',N'Du lịch Miền Trung',N'3 Ngày 2 Đêm',N'3790000')
Insert into DuLich values (N'HN10',N'Du lịch Miền Trung: Hà Nội - Đà Nẵng - Bà Nà - Hội An - Huế - Quảng Bình : Động Phong Nha/ Thiên Đường 4 Ngày',N'Hà Nội',N'Huế',N'Du lịch Miền Trung',N'4 Ngày 3 Đêm',N'5890000')
Insert into DuLich values (N'HN11',N'Du lịch Sapa: Hà Nội - Sapa - Fansipan - Bản Cát Cát 2 Ngày ',N'Hà Nội',N'Sapa',N'Du lịch Sapa',N'2 Ngày 1 Đêm',N'2390000')
Insert into DuLich values (N'HN12',N'Du lịch Sapa: Hà Nội - Sapa - Hàm Rồng - Bản Cát Cát 2 Ngày ',N'Hà Nội',N'Sapa',N'Du lịch Sapa',N'2 Ngày 1 Đêm',N'1550000')
Insert into DuLich values (N'HN13',N'Du lịch Phong Nha - Quảng Bình 3N4Đ: Hà Nội - Đồng Hới - Biển Nhật Lệ - Động Phong Nha - Động Thiên Đường',N'Hà Nội',N'Phong Nha',N'Du lịch Miền Trung',N'3 Ngày 4 Đêm',N'3990000')
Insert into DuLich values (N'HN14',N'Du lịch Nha Trang - Đà Lạt : Hà Nội - Nha Trang - Đà Lạt 5 Ngày ',N'Hà Nội',N'Đà Lạt',N'Du lịch Nha Trang',N'5 Ngày 4 Đêm',N'5990000')
Insert into DuLich values (N'HN15',N'Du lịch Đà Lạt: Hà Nội - Đà Lạt Thành Phố Ngàn Hoa 3 Ngày ',N'Hà Nội',N'Đà Lạt',N'Du lịch Đà Lạt',N'3 Ngày 2 Đêm',N'4790000')
Insert into DuLich values (N'HN16',N'Du lịch Miền Nam : Hà Nội - Sài Gòn - Vũng Tàu - Đại Nam 4 Ngày ',N'Hà Nội',N'Vũng Tàu',N'Du lịch Vũng Tàu',N'4 Ngày 3 Đêm',N'5390000')
Insert into DuLich values (N'HN17',N'Du lịch Đà Lạt: Hà Nội - Đà Lạt Thành Phố Ngàn Hoa 3 Ngày ',N'Hà Nội',N'Đà Lạt',N'Du lịch Đà Lạt',N'3 Ngày 2 Đêm',N'4790000')

Insert into DuLich values (N'HCM01',N'Du Lịch Phú Quốc : Sài Gòn - Phú Quốc - Sunworld Hòn Thơm 3 Ngày ',N'Hồ Chí Minh',N'Phú Quốc',N'Du lịch Phú Quốc',N'3 Ngày 3 Đêm',N'2290000')

Insert into DuLich values (N'HCM02',N'Du Lịch Phú Quốc: Sài Gòn - Phú Quốc 3N2Đ Trọn Gói Vinpearl Resort 5 Sao + Vé Máy Bay',N'Hồ Chí Minh',N'Phú Quốc',N'Du lịch Phú Quốc',N'3 Ngày 2 Đêm',N'6590000')
Insert into DuLich values (N'HCM03',N'Du Lịch Phú Quốc: Sài Gòn - Phú Quốc - Câu Cá & Ngắm San Hô 3 Ngày + Vé Máy Bay',N'Hồ Chí Minh',N'Phú Quốc',N'Du lịch Phú Quốc',N'3 Ngày 2 Đêm',N'3390000')
Insert into DuLich values (N'HCM04',N'Du Lịch Hạ Long: Sài Gòn - Hạ Long Du thuyền 5 sao & Khách sạn 6 sao Dát Vàng Golden Lake ',N'Hồ Chí Minh',N'Hạ Long',N'Du lịch Hạ Long',N'3 Ngày 2 Đêm',N'5590000')
Insert into DuLich values (N'HCM05',N'Du Lịch Hạ Long: Sài Gòn - Hạ Long 4N3Đ - Du thuyền 5 sao & Vinpearl Hạ Long resort 5 sao',N'Hồ Chí Minh',N'Hạ Long',N'Du lịch Hạ Long',N'4 Ngày 3 Đêm',N'4990000')
Insert into DuLich values (N'HCM06',N'Du Lịch Miền Trung: Sài Gòn - Đà Nẵng - Bà Nà - Hội An - Huế - Quảng Bình 4 Ngày + Vé Máy Bay',N'Hồ Chí Minh',N'Đà Nẵng',N'Du lịch Miền Trung',N'4 Ngày 3 Đêm',N'4990000')
Insert into DuLich values (N'HCM07',N'Du Lịch Miền Trung: Sài Gòn- Đà Nẵng - Hội An 3 Ngày + Vé Máy Bay',N'Hồ Chí Minh',N'Đà Nẵng',N'Du lịch Đà Nẵng Hội An',N'3 Ngày 2 Đêm',N'3699000')
Insert into DuLich values (N'HCM08',N'Du Lịch Miền Trung: Trọn Gói: Sài Gòn - Đà Nẵng - Sơn Trà - Bà Nà - Hội An - Huế 4 Ngày + Vé Máy Bay',N'Hồ Chí Minh',N'Đà Nẵng',N'Du lịch Miền Trung',N'4 Ngày 3 Đêm',N'5290000')
Insert into DuLich values (N'HCM09',N'Du Lịch Sapa: Sài Gòn - Hà Nội - Sapa - FANSIPAN 4 Ngày 3 Đêm - Tour Đặc Biệt Kích Cầu',N'Hồ Chí Minh',N'Sapa',N'Du lịch Sapa',N'4 Ngày 3 Đêm',N'3990000')
Insert into DuLich values (N'HCM10',N'Du Lịch Sapa: Sài Gòn - Hà Nội - Sapa - Cát Cát - Hàm Rồng 4 Ngày',N'Hồ Chí Minh',N'Sapa',N'Du lịch Sapa',N'4 Ngày 3 Đêm',N'2550000')
Insert into DuLich values (N'HCM11',N'Du Lịch Sapa: Sài Gòn - Hà Nội - Sapa - Cát Cát - Hàm Rồng - Bằng Ôtô 3 Ngày',N'Hồ Chí Minh',N'Sapa',N'Du lịch Sapa',N'3 Ngày 2 Đêm',N'2050000')
Insert into DuLich values (N'HCM12',N'Du Lịch Sapa: Sài Gòn - Hà Nội - Sapa - Cát Cát - Hàm Rồng - Bằng Tàu 2 Ngày 3 Đêm',N'Hồ Chí Minh',N'Sapa',N'Du lịch Sapa',N'2 Ngày 3 Đêm',N'1790000')
Insert into DuLich values (N'HCM13',N'Du Lịch Đà Lạt: Sài Gòn - Đà Lạt - Thành Phố Ngàn Hoa 4 Ngày 3 Đêm',N'Hồ Chí Minh',N'Đà Lạt',N'Du lịch Đà Lạt',N'4 Ngày 3 Đêm',N'2590000')
Insert into DuLich values (N'HCM14',N'Du Lịch Đà Lạt: Sài Gòn - Đà Lạt - Xứ Sở Sương Mù 3 Ngày 2 Đêm',N'Hồ Chí Minh',N'Đà Lạt',N'Du lịch Đà Lạt',N'3 Ngày 2 Đêm',N'1890000')
Insert into DuLich values (N'HCM15',N'Du Lịch Liên Tuyến: Phan Thiết - Nha Trang - Đà Lạt 6 Ngày 5 Đêm',N'Hồ Chí Minh',N'Đà Lạt',N'Du lịch Liên Tuyến',N'6 Ngày 5 Đêm',N'6050000')
Insert into DuLich values (N'HCM16',N'Du Lịch Liên Tuyến: Phan Thiết - Nha Trang - Đà Lạt 6 Ngày 5 Đêm',N'Hồ Chí Minh',N'Nha Trang',N'Du lịch Liên Tuyến',N'6 Ngày 5 Đêm',N'6050000')
Insert into DuLich values (N'HCM17',N'Du Lịch Nha Trang:Sài Gòn - Nha Trang - Đảo Tôm Hùm Bình Ba 3N3Đ',N'Hồ Chí Minh',N'Nha Trang',N'Du lịch Nha Trang',N'3 Ngày 3 Đêm',N'2290000')
Insert into DuLich values (N'HCM18',N'Du Lịch Nha Trang - Đà Lạt 5 Ngày 4 Đêm',N'Hồ Chí Minh',N'Nha Trang',N'Du lịch Nha Trang',N'5 Ngày 4 Đêm',N'3290000')
Insert into DuLich values (N'HCM19',N'Du Lịch Nha Trang: Sài Gòn - Nha Trang 3N4Đ - Trải Nghiệm Xe lửa Golden Train Cao Cấp & Nghỉ Vinpearl 5 Sao',N'Hồ Chí Minh',N'Nha Trang',N'Du lịch Nha Trang',N'3 Ngày 4 Đêm',N'4590000')
Insert into DuLich values (N'HCM20',N'Du Lịch Phú Quốc: Sài Gòn - Phú Quốc - Câu Cá & Ngắm San Hô 3 Ngày + Vé Máy Bay',N'Hồ Chí Minh',N'Phú Quốc',N'Du lịch Phú Quốc',N'3 Ngày 2 Đêm',N'3390000')
Insert into DuLich values (N'HCM21',N'Du Lịch Phú Quốc: Sài Gòn - Phú Quốc 4N3Đ Trọn Gói + Vé Máy Bay',N'Hồ Chí Minh',N'Phú Quốc',N'Du lịch Phú Quốc',N'4 Ngày 3 Đêm',N'3990000')
Insert into DuLich values (N'HCM22',N'Du Lịch Vũng Tàu: Sài Gòn - Vũng Tàu - Bến Du Thuyền Marina - Cánh Đồng Cừu - Vườn Hoa Thạch Thảo 1 Ngày',N'Hồ Chí Minh',N'Vũng Tàu',N'Du lịch Vũng Tàu',N'1 Ngày',N'550000')
Insert into DuLich values (N'HCM23',N'Du Lịch Vũng Tàu: Sài Gòn - Khoáng Nóng Thiên Nhiên Bình Châu Resort 2 Ngày',N'Hồ Chí Minh',N'Vũng Tàu',N'Du lịch Vũng Tàu',N'2 Ngày 1 Đêm',N'1520000')