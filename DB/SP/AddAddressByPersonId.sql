CREATE PROCEDURE [dbo].[AddAddressByPersonId]
(
@Line1 varchar(200),
@Line2 varchar(200),
@City varchar(100),
@State varchar(100),
@PinCode varchar(10),
@PersonId int,
@CreatedBy int
)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Address]
	([Line1],[Line2],[City],[State],[PinCode],[PersonId],[CreatedBy],[CreatedAt],[UpdatedBy],[UpdatedAt])
	VALUES
	(@Line1,@Line2,@City,@State,@PinCode,@PersonId,@CreatedBy,GETDATE(),@CreatedBy,GETDATE())
   
END
GO
