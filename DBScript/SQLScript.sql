USE [master]
GO
/****** Object:  Database [KoontabiDB]    Script Date: 09/08/2015 00:47:53 ******/
CREATE DATABASE [KoontabiDB] ON  PRIMARY 
( NAME = N'KoontabiDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\KoontabiDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'KoontabiDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\KoontabiDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [KoontabiDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KoontabiDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KoontabiDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [KoontabiDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [KoontabiDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [KoontabiDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [KoontabiDB] SET ARITHABORT OFF
GO
ALTER DATABASE [KoontabiDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [KoontabiDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [KoontabiDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [KoontabiDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [KoontabiDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [KoontabiDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [KoontabiDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [KoontabiDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [KoontabiDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [KoontabiDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [KoontabiDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [KoontabiDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [KoontabiDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [KoontabiDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [KoontabiDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [KoontabiDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [KoontabiDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [KoontabiDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [KoontabiDB] SET  READ_WRITE
GO
ALTER DATABASE [KoontabiDB] SET RECOVERY SIMPLE
GO
ALTER DATABASE [KoontabiDB] SET  MULTI_USER
GO
ALTER DATABASE [KoontabiDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [KoontabiDB] SET DB_CHAINING OFF
GO
USE [KoontabiDB]
GO
/****** Object:  Table [dbo].[Provinces]    Script Date: 09/08/2015 00:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provinces](
	[ProvinceID] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Zone] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProvinceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllProvinces]    Script Date: 09/08/2015 00:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getAllProvinces]
as
	begin 
		SELECT 0 AS ProvinceID ,' Seleccione....' AS Name UNION ALL
		SELECT  ProvinceID,Name FROM dbo.Provinces as p
		ORDER BY Name ASC
	end
GO
/****** Object:  Table [dbo].[Municipalities]    Script Date: 09/08/2015 00:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Municipalities](
	[MunicipalityID] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[ProvinceID] [int] NULL,
 CONSTRAINT [PK__municipa__8D313B0207020F21] PRIMARY KEY CLUSTERED 
(
	[MunicipalityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 09/08/2015 00:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerCode] [nvarchar](15) NOT NULL,
	[CompanyName] [nvarchar](50) NOT NULL,
	[CompanyOwner] [nvarchar](50) NULL,
	[ContactName] [nvarchar](50) NOT NULL,
	[DocumentID] [nvarchar](12) NOT NULL,
	[Address1] [nvarchar](max) NOT NULL,
	[Address2] [nvarchar](max) NULL,
	[ProvinceID] [int] NULL,
	[MunicipalityID] [int] NULL,
	[Phone1] [nvarchar](12) NOT NULL,
	[Phone2] [nvarchar](12) NULL,
	[Cellphone] [nvarchar](12) NULL,
	[Email] [nvarchar](max) NULL,
	[BusinessRegistration] [nvarchar](20) NULL,
	[TaxRegistration] [nvarchar](20) NULL,
	[State] [int] NOT NULL,
	[DateAdmission] [datetime] NULL,
	[Birthday] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UN_CustomerCode] UNIQUE NONCLUSTERED 
(
	[CustomerCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllMunicipalitiesById]    Script Date: 09/08/2015 00:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getAllMunicipalitiesById]
	@id int
as
	begin 
		SELECT 0 as MunicipalityID,' Seleccione...' as Name UNION ALL
		SELECT MunicipalityID,Name FROM Municipalities
		WHERE ProvinceID = @id
		ORDER BY Name
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllCustomerRadGridShowData]    Script Date: 09/08/2015 00:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetAllCustomerRadGridShowData]
as 
	SELECT CustomerID,CustomerCode,CompanyName,
	CompanyOwner,ContactName,Phone1,Phone2,Cellphone FROM Customers
	ORDER BY CompanyName
GO
/****** Object:  Default [DF__Provinces__ZONE__22AA2996]    Script Date: 09/08/2015 00:47:54 ******/
ALTER TABLE [dbo].[Provinces] ADD  DEFAULT ('') FOR [Zone]
GO
/****** Object:  ForeignKey [FK_Provinces_HasMany_Municipalities]    Script Date: 09/08/2015 00:47:55 ******/
ALTER TABLE [dbo].[Municipalities]  WITH CHECK ADD  CONSTRAINT [FK_Provinces_HasMany_Municipalities] FOREIGN KEY([ProvinceID])
REFERENCES [dbo].[Provinces] ([ProvinceID])
GO
ALTER TABLE [dbo].[Municipalities] CHECK CONSTRAINT [FK_Provinces_HasMany_Municipalities]
GO
/****** Object:  ForeignKey [FK_Municipality]    Script Date: 09/08/2015 00:47:55 ******/
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Municipality] FOREIGN KEY([MunicipalityID])
REFERENCES [dbo].[Municipalities] ([MunicipalityID])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Municipality]
GO
/****** Object:  ForeignKey [FK_Province]    Script Date: 09/08/2015 00:47:55 ******/
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Province] FOREIGN KEY([ProvinceID])
REFERENCES [dbo].[Provinces] ([ProvinceID])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Province]
GO
