create database CHBQA
USE [CHBQA]
GO
/****** Object:  Table [dbo].[CT_DDH]    Script Date: 3/30/2022 12:55:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_DDH](
	[id_ddh] [int] NOT NULL,
	[id_sp] [int] NOT NULL,
	[sl] [int] NULL,
	[dongia] [int] NULL,
 CONSTRAINT [PK_CT_DDH] PRIMARY KEY CLUSTERED 
(
	[id_ddh] ASC,
	[id_sp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DDH]    Script Date: 3/30/2022 12:55:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DDH](
	[id_ddh] [int] IDENTITY(1,1) NOT NULL,
	[trang_thai] [int] NULL,
	[tong_tien] [int] NULL,
	[id_kh] [int] NULL,
	[sdt_kh] [varchar](15) NULL,
	[email_kh] [varchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[note] [nvarchar](200) NULL,
	[tg_tao] [date] NULL,
	[tg_giao] [date] NULL,
 CONSTRAINT [PK_DDH] PRIMARY KEY CLUSTERED 
(
	[id_ddh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 3/30/2022 12:55:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[id_kh] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[sdt] [varchar](15) NULL,
	[email] [varchar](50) NULL,
	[taikhoan] [varchar](50) NULL,
	[matkhau] [varchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[id_kh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiHang]    Script Date: 3/30/2022 12:55:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHang](
	[id_lh] [int] IDENTITY(1,1) NOT NULL,
	[ten_lh] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiHang] PRIMARY KEY CLUSTERED 
(
	[id_lh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QTV]    Script Date: 3/30/2022 12:55:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QTV](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[taikhoan] [varchar](10) NULL,
	[matkhau] [varchar](20) NULL,
 CONSTRAINT [PK_QTV] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 3/30/2022 12:55:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[id_sp] [int] IDENTITY(1,1) NOT NULL,
	[id_lh] [int] NULL,
	[giaban] [int] NULL,
	[gianhap] [int] NULL,
	[sl] [int] NULL,
	[tg_tao] [date] NULL,
	[isdelete] [bit] NULL,
	[ten_sp] [nvarchar](50) NULL,
	[hinh1] [varchar](100) NULL,
	[hinh2] [varchar](100) NULL,
	[hinh3] [varchar](100) NULL,
	[hinh4] [varchar](100) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[id_sp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CT_DDH] ([id_ddh], [id_sp], [sl], [dongia]) VALUES (0, 0, 1, 100)
INSERT [dbo].[CT_DDH] ([id_ddh], [id_sp], [sl], [dongia]) VALUES (0, 1, 1, 100)
GO
SET IDENTITY_INSERT [dbo].[DDH] ON 

INSERT [dbo].[DDH] ([id_ddh], [trang_thai], [tong_tien], [id_kh], [sdt_kh], [email_kh], [diachi], [note], [tg_tao], [tg_giao]) VALUES (1, 1, 200, 0, N'0123456789', N'ghost', N'ghost', N'giao hàng cẩn thận', CAST(N'2021-10-10' AS Date), CAST(N'2021-10-15' AS Date))
SET IDENTITY_INSERT [dbo].[DDH] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([id_kh], [ten], [sdt], [email], [taikhoan], [matkhau], [diachi]) VALUES (0, N'đoàn nguyễn chí thiện', N'0123455678', N'ghost', N'ghost', N'ghost', N'khánh hoà')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiHang] ON 

INSERT [dbo].[LoaiHang] ([id_lh], [ten_lh]) VALUES (0, N'áo khoác')
INSERT [dbo].[LoaiHang] ([id_lh], [ten_lh]) VALUES (1, N'áo thun')
SET IDENTITY_INSERT [dbo].[LoaiHang] OFF
GO
SET IDENTITY_INSERT [dbo].[QTV] ON 

INSERT [dbo].[QTV] ([id], [taikhoan], [matkhau]) VALUES (0, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[QTV] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([id_sp], [id_lh], [giaban], [gianhap], [sl], [tg_tao], [isdelete], [ten_sp], [hinh1], [hinh2], [hinh3], [hinh4]) VALUES (0, 0, 100, 10, 100, CAST(N'2022-03-22' AS Date), 0, N'Áo khoác hình đại bàng', N'/Content/images/aodaibang.jpg', N'/Content/images/aodaibang1.jpg', N'/Content/images/aodaibang2.jpg', N'/Content/images/aodaibang3.jpg')
INSERT [dbo].[SanPham] ([id_sp], [id_lh], [giaban], [gianhap], [sl], [tg_tao], [isdelete], [ten_sp], [hinh1], [hinh2], [hinh3], [hinh4]) VALUES (1, 1, 200, 20, 50, CAST(N'2022-03-23' AS Date), 0, N'Áo thun', N'/Content/images/aothun.jpg', N'/Content/images/aothun1.jpg', NULL, NULL)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
