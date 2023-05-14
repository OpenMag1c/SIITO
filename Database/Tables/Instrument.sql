CREATE TABLE [dbo].[Instrument]
(
	[InstrumentId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] NVARCHAR(256) NOT NULL, 
    [Code] NVARCHAR(32) NOT NULL, 
    [Dimensions] NVARCHAR(32) NOT NULL, 
    [Picture] VARBINARY(MAX) NOT NULL, 
    [Measure] NVARCHAR(32) NOT NULL, 
    [Price] MONEY NOT NULL, 
    [InstrumentTypeId] INT NOT NULL, 
    [GostId] INT NOT NULL,
    [CreatedAt] DATETIME2 NULL, 
    [UpdatedAt] DATETIME2 NULL, 

    CONSTRAINT FK_Instrument_Gost FOREIGN KEY(GostId) REFERENCES [Gost](GostId),
    CONSTRAINT FK_Instrument_InstrumentType FOREIGN KEY(InstrumentTypeId) REFERENCES [InstrumentType](InstrumentTypeId)
    -- UNIQUE TBD
)
