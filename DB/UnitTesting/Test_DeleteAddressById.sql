DECLARE	@return_value int

EXEC	@return_value	= [dbo].DeleteAddressById
		@AddressId			=  3

SELECT	'Return Value' = @return_value

GO