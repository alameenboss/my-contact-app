CREATE PROCEDURE [dbo].[UpdatePhoneById]
@Number varchar(20),
@IsPrimary bit,
@PersonId int,
@Id int,
@UpdateBy int
AS
BEGIN
	SET NOCOUNT ON;

	Update [dbo].[Phone]
	Set [Number]		= @Number,
		[IsPrimary]		= @IsPrimary,
		[PersonId]		= @PersonId,
		[UpdatedBy]		= @UpdateBy,
		[UpdatedAt]		= GETDATE()
	Where	[Id]		= @Id
   
END
GO
