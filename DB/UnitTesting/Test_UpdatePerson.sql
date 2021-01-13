DECLARE	@return_value int

EXEC	@return_value	= [dbo].[UpdatePerson]
		@FirstName		= N'sdfsdfsd',
		@LastName		= N'asdasdasda',
		@Id				= 1

SELECT	'Return Value' = @return_value