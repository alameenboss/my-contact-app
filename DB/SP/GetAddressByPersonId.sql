CREATE PROCEDURE [dbo].[GetAddressByPersonId]
(
@PersonId int
)
AS
BEGIN
	SET NOCOUNT ON;
	Select A.Id,A.Line1,A.Line2,A.City,A.State,A.PinCode,A.CreatedBy,A.CreatedAt,A.UpdatedBy,A.UpdatedAt
	from [Address] A
	Where A.PersonId = @PersonId
   
END
GO
