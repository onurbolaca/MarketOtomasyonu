USE [master]
GO
/****** Object:  Database [MarketOtomasyon]    Script Date: 10/25/2020 10:09:11 PM ******/
CREATE DATABASE [MarketOtomasyon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'marketOtomasyon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019\MSSQL\DATA\marketOtomasyon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'marketOtomasyon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019\MSSQL\DATA\marketOtomasyon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MarketOtomasyon] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MarketOtomasyon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MarketOtomasyon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET ARITHABORT OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MarketOtomasyon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MarketOtomasyon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MarketOtomasyon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MarketOtomasyon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET RECOVERY FULL 
GO
ALTER DATABASE [MarketOtomasyon] SET  MULTI_USER 
GO
ALTER DATABASE [MarketOtomasyon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MarketOtomasyon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MarketOtomasyon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MarketOtomasyon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MarketOtomasyon] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MarketOtomasyon', N'ON'
GO
ALTER DATABASE [MarketOtomasyon] SET QUERY_STORE = OFF
GO
USE [MarketOtomasyon]
GO
/****** Object:  UserDefinedFunction [dbo].[MarketsDebtSums]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Onur Bolaca Ado.NET Market Otomasyonu>
-- Create date: <09.07.20, 08.42>
-- Description:	<Aynı Supplier ile ilişkili olan tüm Market Debt ve Supplier Debt hücrelerini bulur, bu hücreleri toplayarak tek bir değişkene atar. Bu durumda iki kolondan 2 adet değişken olması gerekir. ,>
-- Örn; Toplam borcu Sql tarafında bir değişkene atayıp, diğer Supplier genel bilgileriyle birlikte bu borçları da aynı anda ekrana yazdırmak
-- =============================================
CREATE FUNCTION [dbo].[MarketsDebtSums]
(
	-- Add the parameters for the function here
	@SupplierId int
)
RETURNS decimal(18,2)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @answer decimal(18,2)

	SET @answer = 0

	-- Add the T-SQL statements to compute the return value here
	SELECT @answer = SUM(MarketsDebt) FROM SupplierAccounts WHERE SupplierId = @SupplierId 

	-- Return the result of the function 
	RETURN @answer

END
GO
/****** Object:  UserDefinedFunction [dbo].[SuppliersDebtSums]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Onur Bolaca Ado.NET Market Otomasyonu>
-- Create date:  <09.07.20, 09.22>
-- Description:	<Aynı Supplier ile ilişkili olan tüm Market Debt ve Supplier Debt hücrelerini bulur, bu hücreleri toplayarak tek bir değişkene atar. Bu durumda iki kolondan 2 adet değişken olması gerekir. ,>
-- Örn; Toplam borcu Sql tarafında bir değişkene atayıp, diğer Supplier genel bilgileriyle birlikte bu borçları da aynı anda ekrana yazdırmak
-- =============================================
CREATE FUNCTION [dbo].[SuppliersDebtSums]
(
	-- Add the parameters for the function here
	@SupplierId int
)
RETURNS decimal(18,2)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @answer decimal(18,2)

	SET @answer = 0

	-- Add the T-SQL statements to compute the return value here
	SELECT @answer = SUM(SuppliersDebt) FROM SupplierAccounts WHERE SupplierId = @SupplierId 

	-- Return the result of the function 
	RETURN @answer

END
GO
/****** Object:  Table [dbo].[Stocks]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stocks](
	[StockId] [int] IDENTITY(1,1) NOT NULL,
	[StockDescription] [nvarchar](50) NOT NULL,
	[StockBarcode] [nvarchar](50) NOT NULL,
	[KdvRate] [int] NOT NULL,
	[BuyingPrice] [decimal](18, 2) NOT NULL,
	[SellingPrice] [decimal](18, 2) NOT NULL,
	[QuantityPerUnit] [nvarchar](50) NOT NULL,
	[UnitsInStock] [decimal](7, 0) NOT NULL,
	[UnitsInOrder] [int] NOT NULL,
	[MinStockLevel] [int] NOT NULL,
 CONSTRAINT [PK_Stocks] PRIMARY KEY CLUSTERED 
(
	[StockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[StockId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Products_StockId] UNIQUE NONCLUSTERED 
(
	[StockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ProductsString]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ProductsString]
AS
SELECT        P.ProductName, S.StockBarcode, S.SellingPrice, S.QuantityPerUnit
FROM            dbo.Products AS P INNER JOIN
                         dbo.Stocks AS S ON P.StockId = S.StockId
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[ContactName] [nvarchar](50) NULL,
	[ContactTitle] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Region] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[TaxNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierAccounts]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierAccounts](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[SupplierId] [int] NOT NULL,
	[MarketsDebt] [decimal](18, 2) NULL,
	[SuppliersDebt] [decimal](18, 2) NULL,
	[OrderDate] [datetime] NOT NULL,
	[ProductId] [int] NOT NULL,
	[OrderQuantity] [decimal](7, 0) NOT NULL,
	[TotalPrice] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_SupplierAccounts] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[FirmaDetay]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[FirmaDetay]
AS
SELECT        dbo.Suppliers.CompanyName, dbo.Suppliers.ContactName, dbo.Products.ProductName, dbo.SupplierAccounts.MarketsDebt, dbo.SupplierAccounts.SuppliersDebt, dbo.SupplierAccounts.OrderDate, 
                         dbo.SupplierAccounts.ProductId, dbo.SupplierAccounts.OrderQuantity, dbo.SupplierAccounts.TotalPrice, dbo.SupplierAccounts.SupplierId
FROM            dbo.Products INNER JOIN
                         dbo.SupplierAccounts ON dbo.Products.ProductId = dbo.SupplierAccounts.ProductId INNER JOIN
                         dbo.Suppliers ON dbo.SupplierAccounts.SupplierId = dbo.Suppliers.SupplierId
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerDebts]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerDebts](
	[DebtId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[DebtQuantity] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_CustomerDebts] PRIMARY KEY CLUSTERED 
(
	[DebtId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NULL,
	[City] [nvarchar](20) NULL,
	[Region] [nvarchar](20) NULL,
	[PostalCode] [nvarchar](20) NULL,
	[Phone] [nvarchar](11) NOT NULL,
	[SocialNumber] [nvarchar](20) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DailyReports]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DailyReports](
	[ReportId] [int] IDENTITY(1,1) NOT NULL,
	[ReportDate] [date] NOT NULL,
	[OnCredit] [decimal](18, 2) NOT NULL,
	[CashSales] [decimal](18, 2) NULL,
	[CardSales] [decimal](18, 2) NULL,
	[GivenToSupplier] [decimal](18, 2) NOT NULL,
	[Discounts] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_DailyReports] PRIMARY KEY CLUSTERED 
(
	[ReportId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeesId] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[Title] [nvarchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[HireDate] [date] NULL,
	[Address] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Region] [nvarchar](50) NOT NULL,
	[PostalCode] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NOT NULL,
	[SellingPrice] [decimal](18, 2) NOT NULL,
	[Quantity] [int] NOT NULL,
	[TotalRowPrice] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[CustomersId] [int] NULL,
	[EmployeesId] [int] NULL,
	[OrderDate] [datetime] NOT NULL,
	[PaymentMethod] [nvarchar](40) NOT NULL,
	[CashSales] [decimal](18, 2) NULL,
	[CardSales] [decimal](18, 2) NULL,
	[DiscountRate] [smallint] NULL,
	[TotalOrderPrice] [decimal](18, 2) NOT NULL,
	[ReceiptId] [int] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receipts]    Script Date: 10/25/2020 10:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipts](
	[ReceiptId] [int] IDENTITY(1,1) NOT NULL,
	[ReceiptNo] [nvarchar](max) NULL,
 CONSTRAINT [PK_Receipts] PRIMARY KEY CLUSTERED 
(
	[ReceiptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Table_1_CategoryName]    Script Date: 10/25/2020 10:09:11 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Table_1_CategoryName] ON [dbo].[Categories]
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CustomerDebts_CustomerId]    Script Date: 10/25/2020 10:09:11 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CustomerDebts_CustomerId] ON [dbo].[CustomerDebts]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Table_1_ProductName]    Script Date: 10/25/2020 10:09:11 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Table_1_ProductName] ON [dbo].[Products]
(
	[ProductName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Suppliers_CompanyName]    Script Date: 10/25/2020 10:09:11 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Suppliers_CompanyName] ON [dbo].[Suppliers]
(
	[CompanyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CustomerDebts]  WITH CHECK ADD  CONSTRAINT [FK_CustomerDebts_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[CustomerDebts] CHECK CONSTRAINT [FK_CustomerDebts_Customers]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_OrderDetails] FOREIGN KEY([OrderDetailId])
REFERENCES [dbo].[OrderDetails] ([OrderDetailId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_OrderDetails]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products_ProductId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_CustomersId] FOREIGN KEY([CustomersId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_CustomersId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_EmployeesId] FOREIGN KEY([EmployeesId])
REFERENCES [dbo].[Employees] ([EmployeesId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_EmployeesId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Stocks_StockId] FOREIGN KEY([StockId])
REFERENCES [dbo].[Stocks] ([StockId])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Stocks_StockId]
GO
ALTER TABLE [dbo].[SupplierAccounts]  WITH CHECK ADD  CONSTRAINT [FK_SupplierAccounts_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[SupplierAccounts] CHECK CONSTRAINT [FK_SupplierAccounts_Products_ProductId]
GO
ALTER TABLE [dbo].[SupplierAccounts]  WITH CHECK ADD  CONSTRAINT [FK_SupplierAccounts_Suppliers_SupplierId] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Suppliers] ([SupplierId])
GO
ALTER TABLE [dbo].[SupplierAccounts] CHECK CONSTRAINT [FK_SupplierAccounts_Suppliers_SupplierId]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[48] 4[14] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Products"
            Begin Extent = 
               Top = 78
               Left = 220
               Bottom = 242
               Right = 390
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SupplierAccounts"
            Begin Extent = 
               Top = 39
               Left = 484
               Bottom = 260
               Right = 654
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Suppliers"
            Begin Extent = 
               Top = 27
               Left = 731
               Bottom = 260
               Right = 904
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FirmaDetay'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FirmaDetay'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[64] 4[4] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "P"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 209
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "S"
            Begin Extent = 
               Top = 11
               Left = 303
               Bottom = 288
               Right = 583
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductsString'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductsString'
GO
USE [master]
GO
ALTER DATABASE [MarketOtomasyon] SET  READ_WRITE 
GO
