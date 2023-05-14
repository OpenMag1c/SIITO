CREATE TABLE [dbo].[OsnastkaType]
(
	[OsnastkaTypeId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] NVARCHAR(256) NOT NULL,

	CONSTRAINT UQ_OsnastkaType_Name UNIQUE([Name])
)
