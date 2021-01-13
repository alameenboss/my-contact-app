CREATE PROCEDURE [dbo].[UpdateEmailById]
@Email varchar(50),
@PersonId int,
@Id int,
@UpdateBy int
AS
BEGIN
	SET NOCOUNT ON;

   Update [dbo].[Email]
	Set [Email]			=	@Email,
		[PersonId]		=	@PersonId,
		[UpdatedBy]		=	@UpdateBy,
		[UpdatedAt]		=	GETDATE()
	Where	[Id]		=	@Id
END
GO
