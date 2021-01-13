DECLARE	@return_value int

EXEC	@return_value	= [dbo].GetPersons

SELECT	'Return Value' = @return_value