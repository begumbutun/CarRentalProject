CREATE TABLE [dbo].[Rents] (
    [RentId]          INT            IDENTITY (1, 1) NOT NULL,
    [CarId]     INT            NOT NULL,
    [CustomerId]     INT         NOT   NULL,
    [RentDate]   INT            NOT NULL,
    [ReturnDate]  DECIMAL (18)   NOT NULL,
    PRIMARY KEY CLUSTERED ([RentId] ASC),
    );