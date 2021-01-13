DECLARE	@return_value int

EXEC	@return_value	= [dbo].GetPhoneByPersonId
		@PersonId				= 1

SELECT	'Return Value' = @return_value