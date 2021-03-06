SET XACT_ABORT, NOCOUNT ON;

INSERT INTO dbo.PriceHeader (PriceHeaderId, PriceName, PriceDescrip)
VALUES (1, N'Standard', N'სტანდარტული'), (2, N'Discount', N'ფასდაკლება')

-- ყველა ზონაზე შემთხვევითი ფასის დაყენება
INSERT INTO dbo.PriceLine (PriceHeaderId, BodyPartId, Price)
SELECT ph.PriceHeaderId, bp.BodyPartId, ABS(CHECKSUM(NEWID()) / 10000000)
FROM dbo.PriceHeader ph
	CROSS JOIN dbo.BodyPart bp

SET IDENTITY_INSERT EpiManager2015.dbo.Customer ON;
INSERT INTO EpiManager2015.dbo.Customer
	(CustomerId, MobileNumber, FullName, Gender, Note, PriceHeaderId, PriceExpiryDate) 
SELECT 
	c.CustomerId, c.MobileNumber, c.FullName, c.Gender, c.Note, c.PriceHeaderId, c.PriceExpiryDate 
FROM EpiManager2015_Data.dbo.Customer c
SET IDENTITY_INSERT EpiManager2015.dbo.Customer OFF;


SET IDENTITY_INSERT EpiManager2015.dbo.Appointment ON;
INSERT INTO 
	EpiManager2015.dbo.Appointment (AppointmentId, [Date], CustomerId, CustomerNeverCame, StraightVisit, UserId, IntendPrice, ActualPrice ) 
SELECT AppointmentId, [Date], CustomerId, CustomerNeverCame, StraightVisit, UserId, IntendPrice, ActualPrice 
FROM EpiManager2015_Data.dbo.Appointment;
SET IDENTITY_INSERT EpiManager2015.dbo.Appointment OFF;

INSERT INTO EpiManager2015.dbo.AppointmentTarget 
	(AppointmentId, BodyPartId, ImpulsesUsed)
SELECT 
	at.AppointmentId, at.BodyPartId, at.ImpulsesUsed 
FROM EpiManager2015_Data.dbo.AppointmentTarget at
