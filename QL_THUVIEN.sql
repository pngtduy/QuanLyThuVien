USE [QL_THUVIEN]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 12/25/2021 6:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[TenDN] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
	[Quyen] [int] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[TenDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dausach]    Script Date: 12/25/2021 6:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dausach](
	[MaDauSach] [varchar](50) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[TacGia] [nvarchar](50) NULL,
	[NhaXB] [nvarchar](50) NULL,
	[NamXB] [varchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[NgayNhap] [date] NULL,
	[MaLoai] [varchar](50) NULL,
 CONSTRAINT [PK_Dausach] PRIMARY KEY CLUSTERED 
(
	[MaDauSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Docgia]    Script Date: 12/25/2021 6:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Docgia](
	[MaDocGia] [varchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
 CONSTRAINT [PK_Docgia] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loaisach]    Script Date: 12/25/2021 6:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loaisach](
	[MaLoai] [varchar](50) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Loaisach] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phieumuon]    Script Date: 12/25/2021 6:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieumuon](
	[MaPhieuMuon] [varchar](50) NOT NULL,
	[NgayMuon] [date] NULL,
	[NgayTraDuKien] [date] NULL,
	[MaThe] [varchar](50) NULL,
	[MaSach] [varchar](50) NULL,
 CONSTRAINT [PK_Phieumuon] PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phieutra]    Script Date: 12/25/2021 6:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieutra](
	[MaPhieuTra] [varchar](50) NOT NULL,
	[MaThe] [varchar](50) NULL,
	[MaSach] [varchar](50) NULL,
	[NgayTra] [date] NULL,
 CONSTRAINT [PK_Phieutra] PRIMARY KEY CLUSTERED 
(
	[MaPhieuTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 12/25/2021 6:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [varchar](50) NOT NULL,
	[TinhTrangSach] [nvarchar](50) NULL,
	[MaDauSach] [varchar](50) NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thedocgia]    Script Date: 12/25/2021 6:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thedocgia](
	[MaThe] [varchar](50) NOT NULL,
	[NgayLap] [date] NULL,
	[NgayHetHan] [date] NULL,
	[MaDocGia] [varchar](50) NULL,
 CONSTRAINT [PK_Thedocgia] PRIMARY KEY CLUSTERED 
(
	[MaThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([TenDN], [MatKhau], [Quyen]) VALUES (N'admin', N'AZICOnu9cyUFFvBp3xi1AA==', 0)
INSERT [dbo].[Account] ([TenDN], [MatKhau], [Quyen]) VALUES (N'duyduy', N'gnzLDuqKcGxMNKFokfhOew==', 1)
INSERT [dbo].[Account] ([TenDN], [MatKhau], [Quyen]) VALUES (N'thanhduy', N'4QrcOUm6Wau+VuBX8g+IPg==', 1)
INSERT [dbo].[Account] ([TenDN], [MatKhau], [Quyen]) VALUES (N'thanhduy123', N'4QrcOUm6Wau+VuBX8g+IPg==', 1)
INSERT [dbo].[Account] ([TenDN], [MatKhau], [Quyen]) VALUES (N'thanhduyp', N'4QrcOUm6Wau+VuBX8g+IPg==', 1)
GO
INSERT [dbo].[Dausach] ([MaDauSach], [TenSach], [TacGia], [NhaXB], [NamXB], [SoLuong], [DonGia], [NgayNhap], [MaLoai]) VALUES (N'DS001', N'Phân tích thiết kế hệ thống', N'Trần Kim Hương', N'ĐHCT', N'2019', 5, 35000, CAST(N'2020-01-16' AS Date), N'L001')
INSERT [dbo].[Dausach] ([MaDauSach], [TenSach], [TacGia], [NhaXB], [NamXB], [SoLuong], [DonGia], [NgayNhap], [MaLoai]) VALUES (N'DS002', N'Cơ sở dữ liệu', N'Trần Kim Hương', N'ĐHCT', N'2018', 5, 25000, CAST(N'2021-12-04' AS Date), N'L002')
INSERT [dbo].[Dausach] ([MaDauSach], [TenSach], [TacGia], [NhaXB], [NamXB], [SoLuong], [DonGia], [NgayNhap], [MaLoai]) VALUES (N'DS003', N'Lập trình hướng đối tượng', N'Nguyễn Văn Linh', N'Đại học Cần Thơ', N'2008', 10, 40000, CAST(N'2021-12-04' AS Date), N'L001')
INSERT [dbo].[Dausach] ([MaDauSach], [TenSach], [TacGia], [NhaXB], [NamXB], [SoLuong], [DonGia], [NgayNhap], [MaLoai]) VALUES (N'DS004', N'Lập trình web với PHP', N'Nguyễn Văn Linh', N'Đại học Cần Thơ', N'2018', 5, 30000, CAST(N'2020-07-12' AS Date), N'L002')
INSERT [dbo].[Dausach] ([MaDauSach], [TenSach], [TacGia], [NhaXB], [NamXB], [SoLuong], [DonGia], [NgayNhap], [MaLoai]) VALUES (N'DS005', N'Bài giảng công tác xã hội với cá nhân', N'Nguyễn Thị Bích Hưng', N'ĐHĐT', N'2021', 5, 30000, CAST(N'2020-07-12' AS Date), N'L005')
INSERT [dbo].[Dausach] ([MaDauSach], [TenSach], [TacGia], [NhaXB], [NamXB], [SoLuong], [DonGia], [NgayNhap], [MaLoai]) VALUES (N'DS006', N'Bài giảng Công nghệ Web', N'Trần Kim Hương', N'ĐHĐT', N'2021', 10, 30000, CAST(N'2021-12-20' AS Date), N'L005')
INSERT [dbo].[Dausach] ([MaDauSach], [TenSach], [TacGia], [NhaXB], [NamXB], [SoLuong], [DonGia], [NgayNhap], [MaLoai]) VALUES (N'DS007', N'Bài giảng hệ cơ sở tri thức', N'Lê Minh Thư', N'ĐHĐT', N'2021', 5, 25000, CAST(N'2021-12-20' AS Date), N'L005')
INSERT [dbo].[Dausach] ([MaDauSach], [TenSach], [TacGia], [NhaXB], [NamXB], [SoLuong], [DonGia], [NgayNhap], [MaLoai]) VALUES (N'DS008', N'Bài giảng phương pháp nghiên cứu khoa học', N'Lương Thái Ngọc', N'Đại học Cần Thơ', N'2018', 5, 30000, CAST(N'2020-07-12' AS Date), N'L002')
INSERT [dbo].[Dausach] ([MaDauSach], [TenSach], [TacGia], [NhaXB], [NamXB], [SoLuong], [DonGia], [NgayNhap], [MaLoai]) VALUES (N'DS009', N'Luật cờ vua', N'Tổng cục thể thao', N'TDTT', N'1997', 10, 10000, CAST(N'2020-12-22' AS Date), N'L003')
INSERT [dbo].[Dausach] ([MaDauSach], [TenSach], [TacGia], [NhaXB], [NamXB], [SoLuong], [DonGia], [NgayNhap], [MaLoai]) VALUES (N'DS010', N'Luật bình đẳng giới', N'Bùi Việt Bắc', N'Hồng Đức', N'2013', 10, 17000, CAST(N'2019-05-14' AS Date), N'L003')
INSERT [dbo].[Dausach] ([MaDauSach], [TenSach], [TacGia], [NhaXB], [NamXB], [SoLuong], [DonGia], [NgayNhap], [MaLoai]) VALUES (N'DS011', N'Bộ luật tố tụng hình sự', N'Bùi Việt Bắc', N'Hồng Đức', N'2013', 5, 50000, CAST(N'2019-04-14' AS Date), N'L003')
GO
INSERT [dbo].[Docgia] ([MaDocGia], [HoTen], [NgaySinh], [GioiTinh], [DiaChi]) VALUES (N'DG001', N'Phạm Nguyễn Thanh Duy', CAST(N'2000-01-09' AS Date), N'Nam', N'Sa Đéc')
INSERT [dbo].[Docgia] ([MaDocGia], [HoTen], [NgaySinh], [GioiTinh], [DiaChi]) VALUES (N'DG002', N'Võ Thị Bích Trăm', CAST(N'2000-12-24' AS Date), N'Nữ', N'Hồng Ngự')
INSERT [dbo].[Docgia] ([MaDocGia], [HoTen], [NgaySinh], [GioiTinh], [DiaChi]) VALUES (N'DG003', N'Cẩm Thu', CAST(N'2000-01-02' AS Date), N'Nữ', N'Cao Lãnh')
INSERT [dbo].[Docgia] ([MaDocGia], [HoTen], [NgaySinh], [GioiTinh], [DiaChi]) VALUES (N'DG004', N'Hồng Ngọc', CAST(N'2021-12-07' AS Date), N'Nữ', N'Hồng Ngự')
INSERT [dbo].[Docgia] ([MaDocGia], [HoTen], [NgaySinh], [GioiTinh], [DiaChi]) VALUES (N'DG005', N'Duy Khang', CAST(N'2000-07-01' AS Date), N'Nam', N'Bến Tre')
GO
INSERT [dbo].[Loaisach] ([MaLoai], [TenLoai]) VALUES (N'L001', N'Công nghệ thông tin')
INSERT [dbo].[Loaisach] ([MaLoai], [TenLoai]) VALUES (N'L002', N'Kinh tế')
INSERT [dbo].[Loaisach] ([MaLoai], [TenLoai]) VALUES (N'L003', N'Pháp luật')
INSERT [dbo].[Loaisach] ([MaLoai], [TenLoai]) VALUES (N'L004', N'Chính trị')
INSERT [dbo].[Loaisach] ([MaLoai], [TenLoai]) VALUES (N'L005', N'Giáo trình - Bài giảng')
INSERT [dbo].[Loaisach] ([MaLoai], [TenLoai]) VALUES (N'L006', N'Khoa học công nghệ ')
INSERT [dbo].[Loaisach] ([MaLoai], [TenLoai]) VALUES (N'L007', N'Văn học nghệ thuật')
INSERT [dbo].[Loaisach] ([MaLoai], [TenLoai]) VALUES (N'L008', N'Truyện - Tiểu thuyết')
INSERT [dbo].[Loaisach] ([MaLoai], [TenLoai]) VALUES (N'L009', N'Sách thiếu nhi')
INSERT [dbo].[Loaisach] ([MaLoai], [TenLoai]) VALUES (N'L010', N'Sách tâm lý')
INSERT [dbo].[Loaisach] ([MaLoai], [TenLoai]) VALUES (N'L011', N'Sách tham khảo')
GO
INSERT [dbo].[Phieumuon] ([MaPhieuMuon], [NgayMuon], [NgayTraDuKien], [MaThe], [MaSach]) VALUES (N'PM001', CAST(N'2021-04-12' AS Date), CAST(N'2021-05-11' AS Date), N'T002', N'S002')
INSERT [dbo].[Phieumuon] ([MaPhieuMuon], [NgayMuon], [NgayTraDuKien], [MaThe], [MaSach]) VALUES (N'PM002', CAST(N'2021-04-12' AS Date), CAST(N'2021-05-27' AS Date), N'T002', N'S001')
GO
INSERT [dbo].[Phieutra] ([MaPhieuTra], [MaThe], [MaSach], [NgayTra]) VALUES (N'PT001', N'T002', N'S002', CAST(N'2021-12-04' AS Date))
INSERT [dbo].[Phieutra] ([MaPhieuTra], [MaThe], [MaSach], [NgayTra]) VALUES (N'PT002', N'T001', N'S001', CAST(N'2021-12-05' AS Date))
GO
INSERT [dbo].[Sach] ([MaSach], [TinhTrangSach], [MaDauSach]) VALUES (N'S001', N'Còn ', N'DS003')
INSERT [dbo].[Sach] ([MaSach], [TinhTrangSach], [MaDauSach]) VALUES (N'S002', N'Còn ', N'DS001')
INSERT [dbo].[Sach] ([MaSach], [TinhTrangSach], [MaDauSach]) VALUES (N'S003', N'Còn ', N'DS005')
INSERT [dbo].[Sach] ([MaSach], [TinhTrangSach], [MaDauSach]) VALUES (N'S004', N'Đang mượn', N'DS007')
INSERT [dbo].[Sach] ([MaSach], [TinhTrangSach], [MaDauSach]) VALUES (N'S005', N'Còn', N'DS005')
INSERT [dbo].[Sach] ([MaSach], [TinhTrangSach], [MaDauSach]) VALUES (N'S006', N'Đang mượn', N'DS007')
INSERT [dbo].[Sach] ([MaSach], [TinhTrangSach], [MaDauSach]) VALUES (N'S007', N'Còn', N'DS006')
INSERT [dbo].[Sach] ([MaSach], [TinhTrangSach], [MaDauSach]) VALUES (N'S008', N'Còn', N'DS008')
INSERT [dbo].[Sach] ([MaSach], [TinhTrangSach], [MaDauSach]) VALUES (N'S009', N'Đang mượn', N'DS009')
GO
INSERT [dbo].[Thedocgia] ([MaThe], [NgayLap], [NgayHetHan], [MaDocGia]) VALUES (N'T001', CAST(N'2021-04-12' AS Date), CAST(N'2022-03-12' AS Date), N'DG001')
INSERT [dbo].[Thedocgia] ([MaThe], [NgayLap], [NgayHetHan], [MaDocGia]) VALUES (N'T002', CAST(N'2021-04-12' AS Date), CAST(N'2022-03-12' AS Date), N'DG002')
GO
ALTER TABLE [dbo].[Dausach]  WITH CHECK ADD  CONSTRAINT [FK_Dausach_Loaisach] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[Loaisach] ([MaLoai])
GO
ALTER TABLE [dbo].[Dausach] CHECK CONSTRAINT [FK_Dausach_Loaisach]
GO
ALTER TABLE [dbo].[Phieumuon]  WITH CHECK ADD  CONSTRAINT [FK_Phieumuon_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[Phieumuon] CHECK CONSTRAINT [FK_Phieumuon_Sach]
GO
ALTER TABLE [dbo].[Phieumuon]  WITH CHECK ADD  CONSTRAINT [FK_Phieumuon_Thedocgia] FOREIGN KEY([MaThe])
REFERENCES [dbo].[Thedocgia] ([MaThe])
GO
ALTER TABLE [dbo].[Phieumuon] CHECK CONSTRAINT [FK_Phieumuon_Thedocgia]
GO
ALTER TABLE [dbo].[Phieutra]  WITH CHECK ADD  CONSTRAINT [FK_Phieutra_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[Phieutra] CHECK CONSTRAINT [FK_Phieutra_Sach]
GO
ALTER TABLE [dbo].[Phieutra]  WITH CHECK ADD  CONSTRAINT [FK_Phieutra_Thedocgia] FOREIGN KEY([MaThe])
REFERENCES [dbo].[Thedocgia] ([MaThe])
GO
ALTER TABLE [dbo].[Phieutra] CHECK CONSTRAINT [FK_Phieutra_Thedocgia]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_Dausach] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[Dausach] ([MaDauSach])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_Dausach]
GO
ALTER TABLE [dbo].[Thedocgia]  WITH CHECK ADD  CONSTRAINT [FK_Thedocgia_Docgia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[Docgia] ([MaDocGia])
GO
ALTER TABLE [dbo].[Thedocgia] CHECK CONSTRAINT [FK_Thedocgia_Docgia]
GO
