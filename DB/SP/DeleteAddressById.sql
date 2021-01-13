CREATE PROCEDURE [dbo].[DeleteAddressById]
(
@AddressId int
)
AS
BEGIN
	SET NOCOUNT ON;

	Delete From [dbo].[Address] Where [Id] = @AddressId
END
GO
