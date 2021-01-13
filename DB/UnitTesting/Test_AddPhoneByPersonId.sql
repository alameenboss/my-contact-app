DECLARE	@return_value int

EXEC	@return_value	= [dbo].AddPhoneByPersonId
		@Number ='4534534534',
		@IsPrimary =1,
		@PersonId =1,
		@CreatedBy =1

SELECT	'Return Value' = @return_value

GO