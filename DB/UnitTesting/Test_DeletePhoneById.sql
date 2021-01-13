DECLARE	@return_value int

EXEC	@return_value	= [dbo].DeletePhoneById
		@PhoneId = 3

SELECT	'Return Value' = @return_value

GO