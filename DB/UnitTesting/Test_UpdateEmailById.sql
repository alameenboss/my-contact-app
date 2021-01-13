DECLARE	@return_value int

EXEC	@return_value	= [dbo].UpdateEmailById
		@Email ='rrrrrrrrrrrr@gmial.com',
		@PersonId =1,
		@Id = 4,
		@UpdateBy  =2

SELECT	'Return Value' = @return_value

GO