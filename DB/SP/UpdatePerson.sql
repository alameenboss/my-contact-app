CREATE PROCEDURE [dbo].[UpdatePerson]
(
@FirstName varchar(100),
@LastName varchar(100),
@Id int
)
AS
BEGIN
	SET NOCOUNT ON;
	Update [dbo].[Person]
	Set [FirstName]		= @FirstName,
		[LastName]		= @LastName,
		[UpdatedAt]		= GETDATE()
	Where	[Id]		= @Id
   
END
GO
