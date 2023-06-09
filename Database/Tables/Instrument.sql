﻿CREATE TABLE [dbo].[Instrument]
(
	[InstrumentId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] NVARCHAR(256) NOT NULL, 
    [Picture] VARBINARY(MAX) NULL,
    [Description] NVARCHAR(MAX) NULL,
    [Measure] NVARCHAR(32) NOT NULL, 
    [Price] MONEY NOT NULL,
    [Currency] CHAR(3) NOT NULL,
    [InstrumentTypeId] INT NOT NULL, 
    [GostId] INT NULL,
    [CreatedAt] DATETIME2 NULL, 
    [UpdatedAt] DATETIME2 NULL, 

    CONSTRAINT FK_Instrument_Gost FOREIGN KEY(GostId) REFERENCES [Gost](GostId),
    CONSTRAINT FK_Instrument_InstrumentType FOREIGN KEY(InstrumentTypeId) REFERENCES [InstrumentType](InstrumentTypeId)
    -- UNIQUE TBD
)
