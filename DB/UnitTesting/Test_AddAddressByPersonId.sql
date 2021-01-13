DECLARE	@return_value int

EXEC	@return_value	= [dbo].AddAddressByPersonId
		@Line1		= 'Line1',
		@Line2		= 'Line2',
		@City		= 'City',
		@State		= 'State',
		@PinCode	= '123123',
		@PersonId	= 1,
		@CreatedBy	= 1

SELECT	'Return Value' = @return_value

GO