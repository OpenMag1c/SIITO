CREATE TABLE [dbo].[Osnastka]
(
	[OsnastkaId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] NVARCHAR(256) NOT NULL,
    [Price] MONEY NOT NULL,
    [Currency] CHAR(3) NOT NULL,
    [Description] NVARCHAR(MAX) NULL, 
    [Picture] VARBINARY(MAX) NULL, 
    [OsnastkaTypeId] INT NOT NULL,
    [CreatedAt] DATETIME2 NULL, 
    [UpdatedAt] DATETIME2 NULL, 

    CONSTRAINT FK_Osnastka_OsnastkaType FOREIGN KEY(OsnastkaTypeId) REFERENCES [OsnastkaType](OsnastkaTypeId)
    -- UNIQUE TBD
)
