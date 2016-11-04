CREATE TABLE [dbo].[Table]
(
	[UserName] NVARCHAR(50) NOT NULL, 
    [CorrectAns] INT NULL, 
    [WrongAns] INT NULL, 
    [TImeTaken] INT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([UserName]) 
)
