CREATE PROCEDURE [dbo].[AddPerson]
(
	@FirstName VARCHAR(100),
	@LastName VARCHAR(100),
	@Address [dbo].[UT_Address] Readonly,
	@Email [dbo].[UT_Email] Readonly,
	@Phone [dbo].[UT_Phone] Readonly
)	
AS
BEGIN

	SET NOCOUNT ON;
	Declare @PersonId int 
	Declare @CreatedBy int 
	Declare @CeatedDate DateTime =  GETDATE()
	
	INSERT INTO [dbo].[Person]
	([FirstName],[LastName],[CreatedAt],[UpdatedAt])
	Values(
	@FirstName,@LastName,@CeatedDate,@CeatedDate
	)

	select @PersonId = Scope_Identity() 

	Set @CreatedBy = @PersonId

	INSERT INTO [dbo].[Address]
	([Line1],[Line2],[City],[State],[PinCode],[PersonId],[CreatedBy],[CreatedAt],[UpdatedBy],[UpdatedAt])
	Select
	Line1,Line2,City,State,PinCode,@PersonId,@CreatedBy,@CeatedDate,@CreatedBy,@CeatedDate
	From @Address

	INSERT INTO [dbo].[Phone]
	([Number],[IsPrimary],[PersonId],[CreatedBy],[CreatedAt],[UpdatedBy],[UpdatedAt])
	SELECT
	Number,IsPrimary,@PersonId,@CreatedBy,@CeatedDate,@CreatedBy,@CeatedDate
	From @Phone

	INSERT INTO [dbo].[Email]
	([Email],[PersonId],[CreatedBy],[CreatedAt],[UpdatedBy],[UpdatedAt])
	SELECT
	Email,@PersonId,@CreatedBy,@CeatedDate,@CreatedBy,@CeatedDate
	From @Email

	return @PersonId 
   
END
GO
