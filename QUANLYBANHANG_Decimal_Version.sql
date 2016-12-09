USE [master]
GO
/****** Object:  Database [QUANLYBANHANG]    Script Date: 02/10/2016 09:36:53 ******/
CREATE DATABASE [QUANLYBANHANG]
 

GO
ALTER DATABASE [QUANLYBANHANG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYBANHANG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYBANHANG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QUANLYBANHANG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYBANHANG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QUANLYBANHANG] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYBANHANG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYBANHANG] SET DB_CHAINING OFF 
GO
USE [QUANLYBANHANG]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 02/10/2016 09:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[IDHD] [varchar](30) NOT NULL,
	[IDSP] [int] NOT NULL,
	[GiaBan] [decimal] (18,4) NULL,
	[SoLuong] [decimal] (18,1) NULL,
	[ThanhTien] [decimal] (18,4) NULL,
	[DonViTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC,
	[IDSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 02/10/2016 09:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[IDHD] [varchar](30) NOT NULL,
	[IDKH] [int] NULL,
	[NgayLap] [datetime] NULL,
	[TienHang] decimal (18,4) NULL,
	[TienThue] decimal (18,4) NULL,
	[TongTien] decimal (18,4) NULL,
	[NguoiMuaHang] [nvarchar](255) NULL,
	[HinhThucThanhToan] [nvarchar](20) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 02/10/2016 09:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[IDKH] [int] IDENTITY(1,1) NOT NULL,
	[TenDonVi] [nvarchar](255) NOT NULL,
	[MaSoThue] [varchar](20) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[SoTaiKhoan] [varchar](50) NULL,
	[SDT] [varchar](20) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[IDKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 02/10/2016 09:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[IDSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [nvarchar](255) NULL,
	[DonGia] [decimal] (18,4) NULL,
	[DonViTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[IDSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]




GO
USE [master]
GO
ALTER DATABASE [QUANLYBANHANG] SET  READ_WRITE 
GO
