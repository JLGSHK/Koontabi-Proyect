CREATE TABLE [Bodega] (
[BodegaID] int NOT NULL IDENTITY(1,1),
[BodegaName] nvarchar(100) COLLATE Modern_Spanish_CI_AS NOT NULL DEFAULT ('Inicial'),
[BodegaAddress] nvarchar(100) COLLATE Modern_Spanish_CI_AS NULL,
[Phone] nvarchar(15) COLLATE Modern_Spanish_CI_AS NULL,
[IndustrialRegistration] nvarchar(20) COLLATE Modern_Spanish_CI_AS NULL,
[Email] nvarchar(60) COLLATE Modern_Spanish_CI_AS NULL,
CONSTRAINT [PK__Bodega__37A29A756EF57B66] PRIMARY KEY ([BodegaID]) 
)
GO

CREATE TABLE [Categories] (
[CategoryID] int NOT NULL IDENTITY(1,1),
[CategoryCode] nvarchar(15) COLLATE Modern_Spanish_CI_AS NOT NULL,
[CategoryName] nvarchar(100) COLLATE Modern_Spanish_CI_AS NOT NULL,
[Description] nvarchar(100) COLLATE Modern_Spanish_CI_AS NULL,
CONSTRAINT [PK__Categori__19093A2B6A30C649] PRIMARY KEY ([CategoryID]) ,
CONSTRAINT [Unique_CategoryCode] UNIQUE ([CategoryCode] ASC)
)
GO

CREATE TABLE [Customers] (
[CustomerID] int NOT NULL IDENTITY(1,1),
[CustomerCode] nvarchar(15) COLLATE Modern_Spanish_CI_AS NOT NULL,
[CompanyName] nvarchar(50) COLLATE Modern_Spanish_CI_AS NOT NULL,
[CompanyOwner] nvarchar(50) COLLATE Modern_Spanish_CI_AS NULL,
[ContactName] nvarchar(50) COLLATE Modern_Spanish_CI_AS NOT NULL,
[DocumentID] nvarchar(11) COLLATE Modern_Spanish_CI_AS NULL,
[Address1] nvarchar(MAX) COLLATE Modern_Spanish_CI_AS NOT NULL,
[Address2] nvarchar(MAX) COLLATE Modern_Spanish_CI_AS NULL,
[ProvinceID] int NULL,
[MunicipalityID] int NULL,
[Phone1] nvarchar(10) COLLATE Modern_Spanish_CI_AS NOT NULL,
[Phone2] nvarchar(10) COLLATE Modern_Spanish_CI_AS NULL,
[Cellphone] nvarchar(12) COLLATE Modern_Spanish_CI_AS NULL,
[Email] nvarchar(MAX) COLLATE Modern_Spanish_CI_AS NULL,
[BusinessRegistration] nvarchar(20) COLLATE Modern_Spanish_CI_AS NULL,
[TaxRegistration] nvarchar(20) COLLATE Modern_Spanish_CI_AS NULL,
[State] int NOT NULL,
[DateAdmission] datetime NULL,
[Birthday] date NULL,
CONSTRAINT [PK__Customer__A4AE64B8628FA481] PRIMARY KEY ([CustomerID]) ,
CONSTRAINT [Unique_CustomerCode] UNIQUE ([CustomerCode] ASC)
)
GO

CREATE TABLE [Employees] (
[EmployeeID] int NOT NULL IDENTITY(1,1),
[FullName] nvarchar(30) COLLATE Modern_Spanish_CI_AS NOT NULL,
[DocumentIdentity] nvarchar(15) COLLATE Modern_Spanish_CI_AS NOT NULL,
[EmpUserName] nvarchar(30) COLLATE Modern_Spanish_CI_AS NULL,
[EmpPassword] nvarchar(MAX) COLLATE Modern_Spanish_CI_AS NULL,
CONSTRAINT [PK__Employee__7AD04FF15BE2A6F2] PRIMARY KEY ([EmployeeID]) ,
CONSTRAINT [UQ__Employee__BF62343D5EBF139D] UNIQUE ([DocumentIdentity] ASC)
)
GO

CREATE TABLE [InvoiceDetails] (
[InvoiceDetailsID] int NOT NULL IDENTITY(1,1),
[InvoiceID] int NOT NULL,
[ProductDetailID] int NOT NULL,
[UnitPrice] money NOT NULL,
[Quantity] int NOT NULL,
[KardexID] int NOT NULL,
[TaxID] int NULL,
[Discount] float(53) NULL,
CONSTRAINT [PK__InvoiceD__9F18B3E55812160E] PRIMARY KEY ([InvoiceDetailsID]) 
)
GO

CREATE TABLE [Invoices] (
[InvoiceID] int NOT NULL IDENTITY(1,1),
[InvoiceNumber] int NOT NULL,
[CustomerID] int NOT NULL,
[EmployeeID] int NOT NULL,
[InvoiceDate] datetime NOT NULL,
[BodegaID] int NOT NULL,
[TypeOfPayID] int NOT NULL,
[TaxID] int NULL,
[DisCount] float(53) NULL,
CONSTRAINT [PK__Invoices__D796AAD55441852A] PRIMARY KEY ([InvoiceID]) ,
CONSTRAINT [Unique_InvoiceNumber] UNIQUE ([InvoiceNumber])
)
GO

CREATE TABLE [Kardex] (
[KardexID] int NOT NULL IDENTITY(1,1),
[ProductDetailsID] int NOT NULL,
[RegisterDate] datetime NOT NULL,
[TypeOfMove] nvarchar(30) COLLATE Modern_Spanish_CI_AS NOT NULL,
[KardexIn] float(53) NULL,
[KardexOut] float(53) NULL,
[KardexStock] float(53) NOT NULL,
[LastCost] float(53) NULL,
[AverageCost] float(53) NULL,
CONSTRAINT [PK__Kardex__81CAADE15070F446] PRIMARY KEY ([KardexID]) 
)
GO

CREATE TABLE [Municipalities] (
[MunicipalityID] int NOT NULL,
[Name] varchar(50) COLLATE Modern_Spanish_CI_AS NULL,
[ProvinceID] int NULL,
CONSTRAINT [PK__municipa__8D313B0207020F21] PRIMARY KEY ([MunicipalityID]) 
)
GO

CREATE TABLE [ProductDetails] (
[ProductDetailsID] int NOT NULL IDENTITY(1,1),
[ProductID] int NOT NULL,
[UnitPrice1] money NULL,
[UnitPrice2] money NULL,
[UnitPrice3] money NULL,
[ProductCost] money NOT NULL,
[BodegaID] int NOT NULL,
[TaxID] int NULL,
[Stock] int NOT NULL DEFAULT ((0)),
CONSTRAINT [PK__ProductD__2991D8BF4AB81AF0] PRIMARY KEY ([ProductDetailsID]) 
)
GO

CREATE TABLE [Products] (
[ProductID] int NOT NULL IDENTITY(1,1),
[ProductCode] nvarchar(30) COLLATE Modern_Spanish_CI_AS NOT NULL,
[ProductName] nvarchar(100) COLLATE Modern_Spanish_CI_AS NOT NULL,
[Description] nvarchar(MAX) COLLATE Modern_Spanish_CI_AS NULL,
[CategoryID] int NULL,
[Images] image NULL,
[UnitID] int NULL,
[State] bit NOT NULL DEFAULT ((1)),
[InvoiceWithoutStock] bit NOT NULL DEFAULT ((1)),
[InvoiceWithPrice] int NULL,
CONSTRAINT [PK__Products__B40CC6ED07C12930] PRIMARY KEY ([ProductID]) ,
CONSTRAINT [Unique_ProductCode] UNIQUE ([ProductCode] ASC)
)
GO

CREATE TABLE [Provinces] (
[ProvinceID] int NOT NULL,
[Name] nvarchar(50) COLLATE Modern_Spanish_CI_AS NULL,
[Zone] nvarchar(20) COLLATE Modern_Spanish_CI_AS NOT NULL DEFAULT '',
CONSTRAINT [PK__Province__FD0A6FA37F2BE32F] PRIMARY KEY ([ProvinceID]) 
)
GO

CREATE TABLE [Taxes] (
[TaxID] int NOT NULL IDENTITY(1,1),
[Abbreviation] nvarchar(7) COLLATE Modern_Spanish_CI_AS NOT NULL,
[TaxDescription] nvarchar(MAX) COLLATE Modern_Spanish_CI_AS NOT NULL,
[TaxValue] numeric(7,2) NOT NULL,
CONSTRAINT [PK__Taxes__711BE08C7A672E12] PRIMARY KEY ([TaxID]) ,
CONSTRAINT [Unique_Abbreviation] UNIQUE ([Abbreviation] ASC)
)
GO

CREATE TABLE [TypeOfPay] (
[TypeOfPayID] int NOT NULL IDENTITY(1,1),
[Abbreviation] nvarchar(10) COLLATE Modern_Spanish_CI_AS NOT NULL,
[Description] nvarchar(MAX) COLLATE Modern_Spanish_CI_AS NOT NULL,
CONSTRAINT [PK__TypeOfPa__55A9C13076969D2E] PRIMARY KEY ([TypeOfPayID]) 
)
GO

CREATE TABLE [Units] (
[UnitID] int NOT NULL IDENTITY(1,1),
[UnitDescription] varchar(100) COLLATE Modern_Spanish_CI_AS NOT NULL,
[Abbreviation] nchar(6) COLLATE Modern_Spanish_CI_AS NULL,
CONSTRAINT [PK__Units__44F5EC9572C60C4A] PRIMARY KEY ([UnitID]) 
)
GO


ALTER TABLE [Products] ADD CONSTRAINT [FK_Category] FOREIGN KEY ([CategoryID]) REFERENCES [Categories] ([CategoryID])
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'', 
'TABLE', N'Products', 
'CONSTRAINT', N'FK_Category')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'RELACION CON LA TABLA CATEGORIA, MUCHOS PRODUCTO TIENEN UNA CATEGORIA'
, @level0type = 'SCHEMA', @level0name = N''
, @level1type = 'TABLE', @level1name = N'Products'
, @level2type = 'CONSTRAINT', @level2name = N'FK_Category'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'RELACION CON LA TABLA CATEGORIA, MUCHOS PRODUCTO TIENEN UNA CATEGORIA'
, @level0type = 'SCHEMA', @level0name = N''
, @level1type = 'TABLE', @level1name = N'Products'
, @level2type = 'CONSTRAINT', @level2name = N'FK_Category'
GO
ALTER TABLE [ProductDetails] ADD CONSTRAINT [FK_Product] FOREIGN KEY ([ProductID]) REFERENCES [Products] ([ProductID])
GO
ALTER TABLE [Kardex] ADD CONSTRAINT [FK_ProductDetails] FOREIGN KEY ([ProductDetailsID]) REFERENCES [ProductDetails] ([ProductDetailsID])
GO
ALTER TABLE [ProductDetails] ADD CONSTRAINT [FK_Tax] FOREIGN KEY ([TaxID]) REFERENCES [Taxes] ([TaxID])
GO
ALTER TABLE [ProductDetails] ADD CONSTRAINT [FK_Bodega] FOREIGN KEY ([BodegaID]) REFERENCES [Bodega] ([BodegaID])
GO
ALTER TABLE [Products] ADD CONSTRAINT [FK_Unit] FOREIGN KEY ([UnitID]) REFERENCES [Units] ([UnitID])
GO
ALTER TABLE [Customers] ADD CONSTRAINT [FK_Municipality] FOREIGN KEY ([MunicipalityID]) REFERENCES [Municipalities] ([MunicipalityID])
GO
ALTER TABLE [Customers] ADD CONSTRAINT [FK_Province] FOREIGN KEY ([ProvinceID]) REFERENCES [Provinces] ([ProvinceID])
GO
ALTER TABLE [Invoices] ADD CONSTRAINT [FK_Bodega2] FOREIGN KEY ([BodegaID]) REFERENCES [Bodega] ([BodegaID])
GO
ALTER TABLE [Invoices] ADD CONSTRAINT [FK_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [Customers] ([CustomerID])
GO
ALTER TABLE [Invoices] ADD CONSTRAINT [FK_Employee] FOREIGN KEY ([EmployeeID]) REFERENCES [Employees] ([EmployeeID])
GO
ALTER TABLE [Invoices] ADD CONSTRAINT [FK_Tax2] FOREIGN KEY ([TaxID]) REFERENCES [Taxes] ([TaxID])
GO
ALTER TABLE [Invoices] ADD CONSTRAINT [FK_TypeOfPay] FOREIGN KEY ([TypeOfPayID]) REFERENCES [TypeOfPay] ([TypeOfPayID])
GO
ALTER TABLE [InvoiceDetails] ADD CONSTRAINT [FK_Invoice] FOREIGN KEY ([InvoiceID]) REFERENCES [Invoices] ([InvoiceID])
GO
ALTER TABLE [InvoiceDetails] ADD CONSTRAINT [FK_Kardex] FOREIGN KEY ([KardexID]) REFERENCES [Kardex] ([KardexID])
GO

