using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhProje_marketOtomasyonu
{
    class csCustomTables
    {

        string dboSuppliersDebtSums = @"USE [MarketOtomasyon]
GO
/****** Object:  UserDefinedFunction [dbo].[SuppliersDebtSums]    Script Date: 9/7/2020 9:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Onur Bolaca Ado.NET Market Otomasyonu>
-- Create date:  <09.07.20, 09.22>
-- Description:	<Aynı Supplier ile ilişkili olan tüm Market Debt ve Supplier Debt hücrelerini bulur, bu hücreleri toplayarak tek bir değişkene atar.Bu durumda iki kolondan 2 adet değişken olması gerekir. ,>
-- Örn; Toplam borcu Sql tarafında bir değişkene atayıp, diğer Supplier genel bilgileriyle birlikte bu borçları da aynı anda ekrana yazdırmak
-- =============================================
ALTER FUNCTION[dbo].[SuppliersDebtSums]
		(
	-- Add the parameters for the function here
	@SupplierId int
)
RETURNS decimal (18,2)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @answer decimal (18,2)

	SET @answer = 0

	-- Add the T-SQL statements to compute the return value here
	SELECT @answer = SUM(SuppliersDebt) FROM SupplierAccounts WHERE SupplierId = @SupplierId

	-- Return the result of the function
	RETURN @answer

END
";


		string dboMarketsDebtSums = @"USE [MarketOtomasyon]
GO
/****** Object:  UserDefinedFunction [dbo].[MarketsDebtSums]    Script Date: 9/7/2020 9:35:08 AM ******/
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
ALTER FUNCTION [dbo].[MarketsDebtSums]
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
";

    }
}
