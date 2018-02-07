use master

CREATE DATABASE DbRent

go


use DbRent

go

CREATE TABLE [dbo].[Persons] (
    [PersonId]  INT           IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (50) NOT NULL,
    [LastName]  NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([PersonId] ASC)
);


go

CREATE TABLE [dbo].[Products] (
    [ProductId]    INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50) NOT NULL,
    [PricePerHour] DECIMAL (18)  NOT NULL,
    [BarCode]      VARCHAR (100) NULL,
    [ProductType]  SMALLINT      NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductId] ASC)
);



go