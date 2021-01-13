CREATE PROCEDURE [dbo].[AddPhoneByPersonId]
(
@Number varchar(20),
@IsPrimary bit,
@PersonId int,
@CreatedBy int
)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Phone]
	([Number],[IsPrimary],[PersonId],[CreatedBy],[CreatedAt],[UpdatedBy],[UpdatedAt])
	VALUES
	(@Number,@IsPrimary,@PersonId,@CreatedBy,GETDATE(),@CreatedBy,GETDATE())
   
END
GO
