CREATE PROCEDURE [dbo].[UpdateAddressById]
(
@Line1 varchar(200),
@Line2 varchar(200),
@City varchar(100),
@State varchar(100),
@PinCode varchar(10),
@PersonId int,
@Id int,
@UpdateBy int
)
AS
BEGIN
	SET NOCOUNT ON;
	Update [dbo].[Address]
	Set [Line1]			=	@Line1,
		[Line2]			=	@Line2,
		[City]			=	@City,
		[State]			=	@State,
		[PinCode]		=	@PinCode,
		[PersonId]		=	@PersonId,
		[UpdatedBy]		=	@UpdateBy,
		[UpdatedAt]		=	GETDATE()
	Where	[Id]		=	@Id
   
END
GO
