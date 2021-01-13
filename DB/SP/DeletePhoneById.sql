CREATE PROCEDURE [dbo].[DeletePhoneById]
(
@PhoneId int
)
AS
BEGIN
	SET NOCOUNT ON;

	Delete from [dbo].[Phone] Where [Id] = @PhoneId
   
END
GO
