CREATE TABLE [dbo].[Worktypes]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NVARCHAR(50) NOT NULL, 
    [description] TEXT NOT NULL
)