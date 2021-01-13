CREATE PROCEDURE [dbo].[GetEmailByPersonId]
(
@PersonId int
)
AS
BEGIN
	SET NOCOUNT ON;

	Select E.Id,E.Email,E.CreatedBy,E.CreatedAt,E.UpdatedBy,E.UpdatedAt
	from [Email] E
	Where E.PersonId = @PersonId

   
END
GO
