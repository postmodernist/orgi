CREATE TABLE [dbo].[Users] (
 [Id] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
 [Name] NVARCHAR(50),
 [Email] NVARCHAR(50),
 [Password] NVARCHAR(258),
 [BirthDate] DATETIME,
 [RegisterAt] DATETIME 
);