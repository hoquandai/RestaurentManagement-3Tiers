USE [master]
GO
CREATE DATABASE [QLQuanAn] ON  PRIMARY 
( NAME = N'QLQuanAn', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.LEO\MSSQL\DATA\QLQuanAn.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLQuanAn_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.LEO\MSSQL\DATA\QLQuanAn_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLQuanAn] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLQuanAn].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLQuanAn] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QLQuanAn] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QLQuanAn] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QLQuanAn] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QLQuanAn] SET ARITHABORT OFF
GO
ALTER DATABASE [QLQuanAn] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QLQuanAn] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QLQuanAn] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QLQuanAn] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QLQuanAn] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QLQuanAn] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QLQuanAn] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QLQuanAn] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QLQuanAn] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QLQuanAn] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QLQuanAn] SET  DISABLE_BROKER
GO
ALTER DATABASE [QLQuanAn] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QLQuanAn] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QLQuanAn] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QLQuanAn] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QLQuanAn] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QLQuanAn] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QLQuanAn] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QLQuanAn] SET  READ_WRITE
GO
ALTER DATABASE [QLQuanAn] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QLQuanAn] SET  MULTI_USER
GO
ALTER DATABASE [QLQuanAn] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QLQuanAn] SET DB_CHAINING OFF
GO
USE [QLQuanAn]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanAn](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[address] [nvarchar](100) NULL,
	[opentime] [nchar](6) NULL,
	[closetime] [nchar](6) NULL,
 CONSTRAINT [PK_QuanAn] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[QuanAn] ON
INSERT [dbo].[QuanAn] ([id], [name], [address], [opentime], [closetime]) VALUES (1, N'Buzza Pizza tại E mart Gò Vấp', N'tầng trệt Emart Gò Vấp, 366 đường Phan Văn Trị, phường 5, quận Gò Vấp, TP Hồ Chí Minh', N'10:00 ', N'22:30 ')
INSERT [dbo].[QuanAn] ([id], [name], [address], [opentime], [closetime]) VALUES (2, N'Nhà hàng Beefsteak TiTi Vũ Huy Tấn', N'67/4/118 đường Vũ Huy Tấn, phường 3, quận Bình Thạnh, TP Hồ Chí Minh', N'10:00 ', N'21:30 ')
INSERT [dbo].[QuanAn] ([id], [name], [address], [opentime], [closetime]) VALUES (3, N'Quán Nhật Osaka tại Nguyễn Thời Trung', N'số 64 đường Nguyễn Thời Trung, phường 6, quận 5, TPHCM', N'11:00 ', N'22:00 ')
INSERT [dbo].[QuanAn] ([id], [name], [address], [opentime], [closetime]) VALUES (4, N'Quán bún bò Huế Bùi Thị Xuân', N'số 262 Bis Cống Quỳnh, quận 1, TPHCM (ngã 3 Bùi Thị Xuân)', N'15:00 ', N'21:00 ')
INSERT [dbo].[QuanAn] ([id], [name], [address], [opentime], [closetime]) VALUES (5, N'Quán bún mắm 61 Cô Giang', N'hẻm 61 Cô Giang, phường Cầu Ông Lãnh, quận 1, TPHCM', N'15:00 ', N'22:00 ')
INSERT [dbo].[QuanAn] ([id], [name], [address], [opentime], [closetime]) VALUES (6, N'Quán cơm trộn 2 Cô tại Lê Văn Sỹ', N'số 250 Lê Văn Sỹ, phường 1, quận Tân Bình, TPHCM', N'09:30 ', N'22:00 ')
INSERT [dbo].[QuanAn] ([id], [name], [address], [opentime], [closetime]) VALUES (7, N'Quán lẩu mắm Bà Dú tại Trần Khắc Chân', N'số 19 đường Trần Khắc Chân, phường Tân Định, quận 1, TPHCM', N'09:00 ', N'23:00 ')
SET IDENTITY_INSERT [dbo].[QuanAn] OFF
