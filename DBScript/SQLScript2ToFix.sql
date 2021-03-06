USE [KoontabiDB]
GO
/****** Object:  Table [dbo].[ProductDetails]    Script Date: 10/12/2015 00:36:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDetails](
	[ProductDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[UnitPrice1] [money] NULL,
	[UnitPrice2] [money] NULL,
	[UnitPrice3] [money] NULL,
	[ProductCost] [money] NOT NULL,
	[BodegaID] [int] NOT NULL,
	[TaxID] [int] NULL,
	[Stock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductDetailsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Municipalities]    Script Date: 10/12/2015 00:36:50 ******/
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
/****** Object:  Table [dbo].[Kardex]    Script Date: 10/12/2015 00:36:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kardex](
	[KardexID] [int] IDENTITY(1,1) NOT NULL,
	[BodegaID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[RegisterDate] [datetime] NOT NULL,
	[TypeOfMove] [nvarchar](30) NOT NULL,
	[KardexIn] [float] NULL,
	[KardexOut] [float] NULL,
	[KardexStock] [float] NOT NULL,
	[LastBalance] [float] NULL,
	[AverageCost] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[KardexID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 10/12/2015 00:36:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoices](
	[InvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNumber] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[InvoiceDate] [datetime] NOT NULL,
	[BodegaID] [int] NOT NULL,
	[TypeOfPayID] [int] NOT NULL,
	[TaxID] [int] NULL,
	[DisCount] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceDetails]    Script Date: 10/12/2015 00:36:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetails](
	[InvoiceDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[KardexID] [int] NOT NULL,
	[TaxID] [int] NULL,
	[Discount] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[InvoiceDetailsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 10/12/2015 00:36:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](30) NOT NULL,
	[DocumentIdentity] [nvarchar](15) NOT NULL,
	[EmpUserName] [nvarchar](30) NULL,
	[EmpPassword] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[DocumentIdentity] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10/12/2015 00:36:50 ******/
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
	[DocumentID] [nvarchar](11) NULL,
	[Address1] [nvarchar](max) NOT NULL,
	[Address2] [nvarchar](max) NULL,
	[ProvinceID] [int] NULL,
	[MunicipalityID] [int] NULL,
	[Phone1] [nvarchar](10) NOT NULL,
	[Phone2] [nvarchar](10) NULL,
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CustomerCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 10/12/2015 00:36:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryCode] [nvarchar](15) NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [Unique_CategoryCode] UNIQUE NONCLUSTERED 
(
	[CategoryCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bodega]    Script Date: 10/12/2015 00:36:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bodega](
	[BodegaID] [int] IDENTITY(1,1) NOT NULL,
	[BodegaName] [nvarchar](100) NOT NULL,
	[BodegaAddress] [nvarchar](100) NULL,
	[Phone] [nvarchar](15) NULL,
	[IndustrialRegistration] [nvarchar](20) NULL,
	[Email] [nvarchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[BodegaID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Units]    Script Date: 10/12/2015 00:36:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Units](
	[UnitID] [int] IDENTITY(1,1) NOT NULL,
	[UnitDescription] [varchar](100) NOT NULL,
	[Abbreviation] [nchar](6) NULL,
PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TypeOfPay]    Script Date: 10/12/2015 00:36:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfPay](
	[TypeOfPayID] [int] IDENTITY(1,1) NOT NULL,
	[Abbreviation] [nvarchar](10) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TypeOfPayID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Taxes]    Script Date: 10/12/2015 00:36:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taxes](
	[TaxID] [int] IDENTITY(1,1) NOT NULL,
	[Abbreviation] [nvarchar](7) NOT NULL,
	[TaxDescription] [nvarchar](max) NOT NULL,
	[TaxValue] [numeric](7, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TaxID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [Unique_Abbreviation] UNIQUE NONCLUSTERED 
(
	[Abbreviation] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provinces]    Script Date: 10/12/2015 00:36:50 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_getAllMunicipalitiesById]    Script Date: 10/12/2015 00:36:52 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetAllCustomerRadGridShowData]    Script Date: 10/12/2015 00:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetAllCustomerRadGridShowData]
as 
	SELECT CustomerID,CustomerCode,CompanyName,
	CompanyOwner,ContactName,Phone1,Phone2,Cellphone FROM Customers
	WHERE  NOT Customers.State = 4
	ORDER BY CustomerID DESC
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetAllCategories]    Script Date: 10/12/2015 00:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_GetAllCategories]
AS
	SELECT CategoryID,CategoryCode,CategoryName,Description FROM Categories
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetAllBodega]    Script Date: 10/12/2015 00:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Sp_GetAllBodega]
AS
SELECT * FROM Bodega 
ORDER BY BodegaName asc
GO
/****** Object:  StoredProcedure [dbo].[sp_ExitCustomerCode]    Script Date: 10/12/2015 00:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ExitCustomerCode] 
@CustomerCode nvarchar(15)
as
DECLARE @CodeResult int
SELECT @CodeResult =1  FROM Customers
WHERE CustomerCode = @CustomerCode
IF @CodeResult = 1
 /* Si existe un codigo esto se ejecuta de lo contrario el else*/
	SELECT 1 AS Code
ELSE
	SELECT 0 AS Code
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/12/2015 00:36:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [nvarchar](30) NOT NULL,
	[ProductName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CategoryID] [int] NULL,
	[Images] [image] NULL,
	[UnitID] [int] NULL,
	[State] [bit] NOT NULL,
	[InvoiceWithoutStock] [bit] NOT NULL,
	[InvoiceWithPrice] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [Unique_ProductCode] UNIQUE NONCLUSTERED 
(
	[ProductCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetCategories]    Script Date: 10/12/2015 00:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Sp_GetCategories]
AS
	SELECT  0 AS CategoryID,'Seleccione..' as CategoryName UNION ALL
	SELECT CategoryID,CategoryName FROM Categories
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllProvinces]    Script Date: 10/12/2015 00:36:52 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_Taxes]    Script Date: 10/12/2015 00:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Sp_Taxes]
as
	SELECT 0 AS TaxID,'Seleccione..' as TaxDescription
	UNION ALL
	SELECT TaxID,TaxDescription FROM Taxes
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetUnits]    Script Date: 10/12/2015 00:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Sp_GetUnits]
as
SELECT 0 AS UnitID, 'Seleccione...' as UnitDescription
UNION ALL
SELECT UnitID,UnitDescription FROM Units
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetProductByID]    Script Date: 10/12/2015 00:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*SELECT * FROM Products
SELECT * FROM ProductDetails
SELECT * FROM Kardex*/

CREATE PROCEDURE [dbo].[Sp_GetProductByID]
@ProductID INT
AS
BEGIN
SELECT 
			p.ProductID,
			p.ProductCode,
			p.ProductName,
			p.Description,
			pd.ProductCost,
			k.KardexIn,
			c.CategoryID,
			u.UnitID,
			pd.UnitPrice1,
			pd.UnitPrice2,
			pd.UnitPrice3,
			p.InvoiceWithPrice,
			p.InvoiceWithoutStock,
			p.State,
			t.TaxID,
			k.KardexID,
			pd.ProductDetailsID,
			Pd.BodegaID
						
FROM Products p
INNER JOIN ProductDetails pd
ON p.ProductID = pd.ProductID
INNER JOIN Kardex k
ON p.ProductID = k.ProductID 
LEFT JOIN Categories c
ON p.CategoryID = c.CategoryID
LEFT JOIN Units u
ON P.UnitID = U.UnitID
LEFT JOIN Taxes t
ON pd.TaxID = t.TaxID
WHERE k.TypeOfMove LIKE '%Inventario Inicial%'
AND p.ProductID = @ProductID
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetAllProducts]    Script Date: 10/12/2015 00:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_GetAllProducts]
AS
	BEGIN
	SELECT   p.ProductName,
				 p.ProductID,
				p.ProductCode,
			  c.CategoryName,
			 pd.UnitPrice1,
			 pd.ProductCost,
			k.KardexStock
FROM Products  p
LEFT JOIN
Categories c
ON
p.CategoryID = c.CategoryID
INNER JOIN
ProductDetails pd
ON
p.ProductID = pd.ProductID
INNER JOIN 
Kardex k
ON
p.ProductID = k.ProductID
WHERE 
k.KardexStock = (SELECT MAX(KardexStock) FROM Kardex kd WHERE kd.ProductID = p.ProductID)
ORDER BY p.ProductName ASC
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_ValidateProductCodeIfExit]    Script Date: 10/12/2015 00:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_ValidateProductCodeIfExit]
	@ProductCode nvarchar(30)
AS
	
BEGIN
	SELECT TOP 1 1 FROM Products
	WHERE ProductCode = @ProductCode
	END
GO
/****** Object:  Default [DF__Bodega__BodegaNa__797309D9]    Script Date: 10/12/2015 00:36:50 ******/
ALTER TABLE [dbo].[Bodega] ADD  DEFAULT ('Inicial') FOR [BodegaName]
GO
/****** Object:  Default [DF__ProductDe__Stock__08B54D69]    Script Date: 10/12/2015 00:36:50 ******/
ALTER TABLE [dbo].[ProductDetails] ADD  DEFAULT ((0)) FOR [Stock]
GO
/****** Object:  Default [DF__Products__State__01142BA1]    Script Date: 10/12/2015 00:36:50 ******/
ALTER TABLE [dbo].[Products] ADD  DEFAULT ((1)) FOR [State]
GO
/****** Object:  Default [DF__Products__Invoic__02084FDA]    Script Date: 10/12/2015 00:36:50 ******/
ALTER TABLE [dbo].[Products] ADD  DEFAULT ((1)) FOR [InvoiceWithoutStock]
GO
/****** Object:  Default [DF__Provinces__ZONE__22AA2996]    Script Date: 10/12/2015 00:36:50 ******/
ALTER TABLE [dbo].[Provinces] ADD  DEFAULT ('') FOR [Zone]
GO
/****** Object:  ForeignKey [FK_Product_ToUnit]    Script Date: 10/12/2015 00:36:50 ******/
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Product_ToUnit] FOREIGN KEY([UnitID])
REFERENCES [dbo].[Units] ([UnitID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Product_ToUnit]
GO
