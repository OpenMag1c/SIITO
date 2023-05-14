CREATE TABLE [dbo].[InstrumentType]
(
	[InstrumentTypeId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] NVARCHAR(256) NOT NULL,

	CONSTRAINT UQ_InstrumentType_Name UNIQUE([Name])
)
