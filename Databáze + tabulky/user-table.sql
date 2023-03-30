CREATE TABLE [dbo].[User] (
    [Id]           INT              IDENTITY (1, 1) NOT NULL,
    [name]         NVARCHAR (50)    NOT NULL,
    [passwordhash] VARBINARY (1024) NOT NULL,
    [passwordsalt] VARBINARY (1024) NOT NULL,
    [role]         INT              DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([role]) REFERENCES [dbo].[Role] ([id])
);