CREATE TABLE [dbo].[Cars] (
    [Id]          INT         IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT         NULL,
    [ColorId]     INT         NULL,
    [ModelYear]   INT         NULL,
    [DailyPrice]  INT         NULL,
    [Description] NCHAR (100) NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Brands] (
    [Id]        INT         IDENTITY (1, 1) NOT NULL,
    [BrandId]   INT         NULL,
    [BrandName] NCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Colors] (
    [Id]        INT         IDENTITY (1, 1) NOT NULL,
    [ColorName] NCHAR (100) NULL,
    [ColorId]   INT         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Customers] (
    [UserId]      INT         NOT NULL,
    [CompanyName] NCHAR (100) NULL,
    [CustomerId]  INT         IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustomerId] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

CREATE TABLE [dbo].[Rentals] (
    [Id]         INT         IDENTITY (1, 1) NOT NULL,
    [CarId]      INT         NULL,
    [CustomerId] INT         NULL,
    [RentDate]   NCHAR (100) NULL,
    [ReturnDate] NCHAR (100) NULL,
    CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([Id]),
    FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId])
);

CREATE TABLE [dbo].[Users] (
    [Id]        INT         IDENTITY (1, 1) NOT NULL,
    [FirstName] NCHAR (100) NULL,
    [LastName]  NCHAR (100) NULL,
    [EMail]     NCHAR (100) NULL,
    [Password]  INT         NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);
