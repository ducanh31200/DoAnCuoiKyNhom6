USE [QuanLyProject]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/29/2020 12:42:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[TenDangNhap] [nchar](50) NOT NULL,
	[MatKhau] [nchar](50) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 6/29/2020 12:42:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[ID] [int] NOT NULL,
	[TenProject] [nvarchar](50) NOT NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resource]    Script Date: 6/29/2020 12:42:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resource](
	[ID] [int] NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[VaiTro] [nvarchar](50) NULL,
	[SoDienThoai] [nchar](20) NULL,
	[Mail] [nchar](50) NULL,
	[IDTask] [int] NULL,
 CONSTRAINT [PK_Resource] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 6/29/2020 12:42:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
	[ID] [int] NOT NULL,
	[IDProject] [int] NULL,
	[IDResource] [int] NULL,
	[TenCongViec] [nvarchar](50) NULL,
	[MoTa] [nvarchar](max) NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
 CONSTRAINT [PK_Task_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Account] ([TenDangNhap], [MatKhau]) VALUES (N'                                                  ', N'                                                  ')
INSERT [dbo].[Account] ([TenDangNhap], [MatKhau]) VALUES (N'ducanh                                            ', N'123                                               ')
INSERT [dbo].[Account] ([TenDangNhap], [MatKhau]) VALUES (N'nhatbinh                                          ', N'123                                               ')
INSERT [dbo].[Account] ([TenDangNhap], [MatKhau]) VALUES (N'trunghieu                                         ', N'123                                               ')
INSERT [dbo].[Account] ([TenDangNhap], [MatKhau]) VALUES (N'tuidayne                                          ', N'hongphaitui                                       ')
INSERT [dbo].[Project] ([ID], [TenProject], [NgayBatDau], [NgayKetThuc]) VALUES (2, N'234', CAST(N'2020-06-25T13:15:11.000' AS DateTime), CAST(N'2020-06-28T13:15:11.000' AS DateTime))
INSERT [dbo].[Project] ([ID], [TenProject], [NgayBatDau], [NgayKetThuc]) VALUES (3, N'1', CAST(N'2020-06-29T17:24:43.000' AS DateTime), CAST(N'2020-06-30T17:24:43.000' AS DateTime))
INSERT [dbo].[Resource] ([ID], [Ten], [NgaySinh], [VaiTro], [SoDienThoai], [Mail], [IDTask]) VALUES (2, N'2', CAST(N'2020-06-24T09:16:19.243' AS DateTime), N'2', N'2                   ', N'2                                                 ', NULL)
INSERT [dbo].[Resource] ([ID], [Ten], [NgaySinh], [VaiTro], [SoDienThoai], [Mail], [IDTask]) VALUES (4, N'trung hieu', CAST(N'2020-06-24T09:45:10.830' AS DateTime), N'6', N'1                   ', N'1                                                 ', NULL)
INSERT [dbo].[Resource] ([ID], [Ten], [NgaySinh], [VaiTro], [SoDienThoai], [Mail], [IDTask]) VALUES (5, N'nhat binh', CAST(N'2020-06-24T09:45:18.497' AS DateTime), N'3', N'123                 ', N'123                                               ', NULL)
INSERT [dbo].[Task] ([ID], [IDProject], [IDResource], [TenCongViec], [MoTa], [NgayBatDau], [NgayKetThuc]) VALUES (3, 2, 4, N'1', N'1', CAST(N'2020-06-25T13:17:04.000' AS DateTime), CAST(N'2020-06-28T13:17:04.000' AS DateTime))
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_Task] FOREIGN KEY([IDTask])
REFERENCES [dbo].[Task] ([ID])
GO
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_Task]
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Project] FOREIGN KEY([IDProject])
REFERENCES [dbo].[Project] ([ID])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Project]
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Resource] FOREIGN KEY([IDResource])
REFERENCES [dbo].[Resource] ([ID])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Resource]
GO
