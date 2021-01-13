Select * from [dbo].[Person] Where Id = 1
Select * from [dbo].[Address] Where PersonId = 1
Select * from [dbo].[Email] Where PersonId = 1
Select * from [dbo].[Phone] Where PersonId = 1

Delete from [dbo].[Person];DBCC CHECKIDENT ('Person', RESEED, 0)
Delete from [dbo].[Address];DBCC CHECKIDENT ('Address', RESEED, 0)
Delete from [dbo].[Email];DBCC CHECKIDENT ('Email', RESEED, 0)
Delete from [dbo].[Phone];DBCC CHECKIDENT ('Phone', RESEED, 0)