CREATE TABLE [dbo].[Books] (
    [Id]     INT            IDENTITY (1, 1) NOT NULL,
    [Name]   NVARCHAR (100) NOT NULL,
    [Author] NVARCHAR (100) NULL,
    [Year]   INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

