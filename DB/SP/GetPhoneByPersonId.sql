CREATE PROCEDURE [dbo].[GetPhoneByPersonId]
(
@PersonId int
)	
AS
BEGIN
	SET NOCOUNT ON;
	Select P.Id,P.Number,P.IsPrimary,P.CreatedBy,P.CreatedAt,P.UpdatedBy,P.UpdatedAt
	from [Phone] P
	Where P.PersonId = @PersonId

   
END
GO
