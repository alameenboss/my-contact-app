DECLARE	@InputAddress [dbo].[UT_Address]
DECLARE	@InputEmail [dbo].[UT_Email]
DECLARE	@InputPhone [dbo].[UT_Phone]

Insert into @InputAddress Values 
('asdasdas','asdasd','asdasd','asdasd','4534345'),
('asdasd','asdasd','asdadasdwewqd','tyrtyr','345345')
Insert into @InputEmail Values 
('test1@gmail.com'),
('test2@live.in'),
('test3@gmail.com')
Insert into @InputPhone Values 
('456456456',1),
('6546456',0)


DECLARE	@return_value int

EXEC	@return_value	= [dbo].[AddPerson]
		@FirstName		= N'test',
		@LastName		= N'test',
		@Address	= @InputAddress,
		@Email		= @InputEmail,
		@Phone		= @InputPhone

SELECT	'Return Value' = @return_value

GO
