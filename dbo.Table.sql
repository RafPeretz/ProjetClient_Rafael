CREATE TABLE [dbo].[Table_Client]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY , 
    [FirstName] NCHAR(50) NULL, 
    [LastName] NCHAR(50) NULL, 
    [PhoneNumber] INT NULL, 
    [Age] INT NULL, 
    [PostalCode] INT NULL
)
