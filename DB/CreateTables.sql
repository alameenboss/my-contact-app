CREATE TABLE [Person] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [FirstName] varchar(100),
  [LastName] varchar(100),
  [CreatedAt] datetime,
  [UpdatedAt] datetime
)
GO

CREATE TABLE [Address] (
  [Id] Int PRIMARY KEY IDENTITY(1, 1),
  [Line1] varchar(200),
  [Line2] varchar(200),
  [City] varchar(100),
  [State] varchar(100),
  [PinCode] varchar(10),
  [PersonId] int,
  [CreatedBy] int,
  [CreatedAt] datetime,
  [UpdatedBy] int,
  [UpdatedAt] datetime
)
GO



CREATE TABLE [Phone] (
  [Id] Int PRIMARY KEY IDENTITY(1, 1),
  [Number] varchar(20),
  [IsPrimary] bit,
  [PersonId] int,
  [CreatedBy] int,
  [CreatedAt] datetime,
  [UpdatedBy] int,
  [UpdatedAt] datetime
)
GO

CREATE TABLE [Email] (
  [Id] Int PRIMARY KEY IDENTITY(1, 1),
  [Email] [varchar](50) NULL,
  [PersonId] int,
  [CreatedBy] int,
  [CreatedAt] datetime,
  [UpdatedBy] int,
  [UpdatedAt] datetime
)
GO

ALTER TABLE [Address] ADD FOREIGN KEY ([PersonId]) REFERENCES [Person] ([Id])
GO

ALTER TABLE [Phone] ADD FOREIGN KEY ([PersonId]) REFERENCES [Person] ([Id])
GO

ALTER TABLE [Email] ADD FOREIGN KEY ([PersonId]) REFERENCES [Person] ([Id])
GO