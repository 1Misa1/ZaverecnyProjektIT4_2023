CREATE TABLE [dbo].[Contract]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [customer] NVARCHAR(50) NOT NULL, 
    [description] NTEXT NOT NULL
)