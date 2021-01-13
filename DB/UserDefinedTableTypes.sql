
CREATE TYPE [dbo].[UT_Address] AS TABLE 
(
	[Line1] varchar(200),
	[Line2] varchar(200),
	[City] varchar(100),
	[State] varchar(100),
	[PinCode] varchar(10)
)
GO

CREATE TYPE [dbo].[UT_Phone] AS TABLE 
(
	[Number] varchar(20),
	[IsPrimary] bit
)
GO

CREATE TYPE [dbo].[UT_Email] AS TABLE 
(
	[Email] [varchar](50) NULL
)
GO