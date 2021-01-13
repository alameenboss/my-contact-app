CREATE PROCEDURE [dbo].[GetPersons]
	
AS
BEGIN
	SET NOCOUNT ON;

	Select Id,FirstName,LastName,CreatedAt,UpdatedAt
	from Person
   
END
GO
