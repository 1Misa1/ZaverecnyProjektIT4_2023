CREATE TABLE [dbo].[Login] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [UserName] VARCHAR (20)    NOT NULL,
    [Password] VARBINARY (256) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([UserName] ASC)
);

