CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NCHAR(50) NULL, 
    [LastName] NCHAR(50) NULL, 
    [UserName] NCHAR(50) NULL, 
    [Email] NCHAR(50) NULL, 
    [Password] NCHAR(10) NULL
)
