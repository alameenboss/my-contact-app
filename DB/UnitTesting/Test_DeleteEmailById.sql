DECLARE	@return_value int

EXEC	@return_value	= [dbo].DeleteEmailById
		@EmailId = 4

SELECT	'Return Value' = @return_value

GO