CREATE TABLE [dbo].[Customer] (
    [ID]    INT        NOT NULL,
    [Day]   NCHAR (10) NOT NULL,
    [Month] NCHAR (10) NOT NULL,
    [Money] NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Customer_Customer] FOREIGN KEY ([ID]) REFERENCES [dbo].[Customer] ([ID])
);

