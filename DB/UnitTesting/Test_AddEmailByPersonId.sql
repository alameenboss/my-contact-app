DECLARE	@return_value int

EXEC	@return_value	= [dbo].AddEmailByPersonId
		@Email ='fsdfsd@gmial.com',
		@PersonId =1,
		@CreatedBy  =1

SELECT	'Return Value' = @return_value

GO