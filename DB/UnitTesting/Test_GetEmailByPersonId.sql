DECLARE	@return_value int

EXEC	@return_value	= [dbo].GetEmailByPersonId
		@PersonId				= 1

SELECT	'Return Value' = @return_value