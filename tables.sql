CREATE TABLE [dbo].[Colors] (
    [Id]        INT         IDENTITY (1, 1) NOT NULL,
    [ColorName] NCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Cars] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT          NULL,
    [ColorId]     INT          NULL,
    [ModelYear]   INT          NULL,
    [DailyPrice]  INT          NULL,
    [Description] VARCHAR (50) NULL,
    [Findeks]     INT          NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[CarImages] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [CarId]     INT            NULL,
    [ImagePath] NVARCHAR (MAX) NULL,
    [Date]      DATETIME2 (7)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Brands] (
    [Id]        INT         IDENTITY (1, 1) NOT NULL,
    [BrandName] NCHAR (100) NULL,
    CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[UserOperationClaims] (
    [Id]               INT IDENTITY (1, 1) NOT NULL,
    [UserId]           INT NULL,
    [OperationClaimId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Rentals] (
    [Id]            INT      IDENTITY (1, 1) NOT NULL,
    [CarId]         INT      NULL,
    [CustomerId]    INT      NULL,
    [RentStartDate] DATETIME NULL,
    [RentEndDate]   DATETIME NULL,
    [ReturnDate]    DATETIME NULL,
    CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Payments] (
    [Id]           INT        IDENTITY (1, 1) NOT NULL,
    [CardNumber]   INT        NULL,
    [ExpiryDate]   NCHAR (20) NULL,
    [SecurityCode] INT        NULL,
    [UserId]       INT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[OperationClaims] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (250) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Customers] (
    [UserId]      INT         NOT NULL,
    [CompanyName] NCHAR (100) NULL,
    [CustomerId]  INT         IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

CREATE TABLE [dbo].[Users] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (50)    NOT NULL,
    [LastName]     VARCHAR (50)    NOT NULL,
    [Email]        VARCHAR (50)    NOT NULL,
    [PasswordHash] VARBINARY (500) NOT NULL,
    [PasswordSalt] VARBINARY (500) NOT NULL,
    [Status]       BIT             NOT NULL,
    [Findeks]      INT             NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);




