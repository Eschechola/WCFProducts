CREATE TABLE [dbo].[Products] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [name]        VARCHAR (40)  NULL,
    [description] VARCHAR (MAX) NULL,
    [price]       DECIMAL (18)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

