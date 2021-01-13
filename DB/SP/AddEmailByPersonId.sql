CREATE PROCEDURE [dbo].[AddEmailByPersonId]
(
@Email varchar(50),
@PersonId int,
@CreatedBy int
)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Email]
	([Email],[PersonId],[CreatedBy],[CreatedAt],[UpdatedBy],[UpdatedAt])
	VALUES
	(@Email,@PersonId,@CreatedBy,GETDATE(),@CreatedBy,GETDATE())
   
END
GO
