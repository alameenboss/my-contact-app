DECLARE	@return_value int

EXEC	@return_value	= [dbo].UpdateAddressById
		@Line1		= 'LineU1',
		@Line2		= 'Lineu2',
		@City		= 'Cityu',
		@State		= 'Stateu',
		@PinCode	= '123',
		@PersonId	= 1,
		@Id			=  3,
		@UpdateBy	= 1

SELECT	'Return Value' = @return_value

GO