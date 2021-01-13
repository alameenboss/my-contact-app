CREATE PROCEDURE [dbo].[DeletePersonById]
(
@PersonId int
)
AS
BEGIN
	SET NOCOUNT ON;

	Delete From [dbo].[Phone] Where [PersonId] = @PersonId
	Delete From [dbo].[Email] Where [PersonId] = @PersonId
	Delete From [dbo].[Address] Where [PersonId] = @PersonId
	Delete From [dbo].[Person] Where [Id] = @PersonId

END
GO

