/******* HELPERS *******
************************

IF OBJECT_ID('dbo.migr_CustomersAndAppoints') IS NOT NULL
	DROP TABLE [dbo].[migr_CustomersAndAppoints]
GO
CREATE TABLE [dbo].[migr_CustomersAndAppoints](
	[dt] [datetime] NULL,
	[fullName] [nvarchar](100) NULL,
	[tel] [nvarchar](50) NULL,
	[bodyPartMigrIds] [nvarchar](50) NULL,
	[priceDecoupled] [nvarchar](50) NULL,
	[impulsesDecoupled] [nvarchar](200) NULL,
	[UserName] [nvarchar](50) NULL,
	[Note] [nvarchar](400) NULL
) ON [PRIMARY]
GO

CREATE FUNCTION [dbo].[SplitString] 
(
    @str nvarchar(max), 
    @separator char(1)
)
returns table
AS
return (
with tokens(p, a, b) AS (
    select 
        cast(1 as bigint), 
        cast(1 as bigint), 
        charindex(@separator, @str)
    union all
    select
        p + 1, 
        b + 1, 
        charindex(@separator, @str, b + 1)
    from tokens
    where b > 0
)
select
    p-1 ItemIndex,
    substring(
        @str, 
        a, 
        case when b > 0 then b-a ELSE LEN(@str) end) 
    AS Item
from tokens
);
GO
*/

SET XACT_ABORT ON;
GO

INSERT INTO dbo.PriceHeader (PriceHeaderId, PriceName, PriceDescrip)
VALUES (1, N'Standard', N'სტანდარტული'), (2, N'Discount', N'ფასდაკლება')

-- ყველა ზონაზე შემთხვევითი ფასის დაყენება
INSERT INTO dbo.PriceLine (PriceHeaderId, BodyPartId, Price)
SELECT ph.PriceHeaderId, bp.BodyPartId, ABS(CHECKSUM(NEWID()) / 10000000)
FROM dbo.PriceHeader ph
	CROSS JOIN dbo.BodyPart bp
GO

DECLARE
	@priceId INT = (SELECT PriceHeaderId FROM dbo.PriceHeader WHERE PriceName = 'Discount')

INSERT INTO dbo.Customer (MobileNumber, FullName, Gender, PriceHeaderId)
SELECT tel, fullName, 'F', @priceId FROM dbo.migr_CustomersAndAppoints
GO

INSERT INTO dbo.Appointment ([Date], CustomerId, IntendPrice, ActualPrice, CustomerNeverCame, StraightVisit, UserId)
SELECT
	m.dt, 
	(SELECT CustomerId FROM dbo.Customer WHERE FullName = m.fullName) AS CustomerId,
	(SELECT SUM(CAST(Item AS MONEY)) FROM dbo.SplitString(priceDecoupled, ';')) AS IntendPrice,
	(SELECT SUM(CAST(Item AS MONEY)) FROM dbo.SplitString(priceDecoupled, ';')) AS ActualPrice,
	0 AS CustomerNeverCame, 
	NULL AS StraightVisit,
	CASE UserName WHEN N'ნონა' THEN 1 ELSE 2 END AS UserId
FROM dbo.migr_CustomersAndAppoints m

---

; WITH coupled1 AS (
	SELECT a.AppointmentId, c.Item AS BodyPartId, c.ItemIndex
	FROM dbo.Appointment a
		INNER JOIN dbo.migr_CustomersAndAppoints migr ON a.[Date] = migr.dt
		CROSS APPLY dbo.SplitString(migr.bodyPartMigrIds, ';') c
),
coupled2 AS (
	SELECT a.AppointmentId, c.Item AS Impulse, c.ItemIndex
	FROM dbo.Appointment a
		INNER JOIN dbo.migr_CustomersAndAppoints migr ON a.[Date] = migr.dt
		CROSS APPLY dbo.SplitString(migr.impulsesDecoupled, ';') c
)
INSERT INTO dbo.AppointmentTarget (AppointmentId, BodyPartId, ImpulsesUsed)
SELECT coupled1.AppointmentId, coupled1.BodyPartId, NULLIF(LTRIM(coupled2.Impulse), '')
FROM coupled1
	LEFT JOIN coupled2 ON coupled1.AppointmentId = coupled2.AppointmentId AND coupled1.ItemIndex = coupled2.ItemIndex
GO