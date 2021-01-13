CREATE PROCEDURE [dbo].[GetPersonById]
@PersonId int
AS
BEGIN
	SET NOCOUNT ON;

	Select P.Id,P.FirstName,P.LastName,P.CreatedAt,P.UpdatedAt 
	From Person P
	Where Id = @PersonId

	Select A.Id,A.Line1,A.Line2,A.City,A.State,A.PinCode,A.CreatedBy,A.CreatedAt,A.UpdatedBy,A.UpdatedAt
	from [Address] A
	Where A.PersonId = @PersonId

	Select P.Id,P.Number,P.IsPrimary,P.CreatedBy,P.CreatedAt,P.UpdatedBy,P.UpdatedAt
	from [Phone] P
	Where P.PersonId = @PersonId

	Select E.Id,E.Email,E.CreatedBy,E.CreatedAt,E.UpdatedBy,E.UpdatedAt
	from [Email] E
	Where E.PersonId = @PersonId

END
GO
