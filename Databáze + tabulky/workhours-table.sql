CREATE TABLE [dbo].[WorkHours]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1), 
    [Employee] INT NOT NULL FOREIGN KEY REFERENCES Employees(id), 
    [Contract] INT NOT NULL FOREIGN KEY REFERENCES [Contract](id), 
    [Worktypes] INT NOT NULL FOREIGN KEY REFERENCES Worktypes(id),
    [hours] INT NOT NULL, 
    [insertdate] DATE NOT NULL, 
    [insertuser] INT NOT NULL FOREIGN KEY REFERENCES [User](id),
)