CREATE PROCEDURE [dbo].[DeleteEmailById]
(
@EmailId int
)
AS
BEGIN
	SET NOCOUNT ON;

	Delete From [dbo].[Email] Where [Id] = @EmailId
END
GO
