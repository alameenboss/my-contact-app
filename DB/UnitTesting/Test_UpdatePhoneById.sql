DECLARE	@return_value int

EXEC	@return_value	= [dbo].UpdatePhoneById
		@Number ='45345',
		@IsPrimary =1,
		@PersonId = 1,
		@Id = 3,
		@UpdateBy  =2

SELECT	'Return Value' = @return_value

GO