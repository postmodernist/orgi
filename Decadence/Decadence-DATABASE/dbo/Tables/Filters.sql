CREATE TABLE [dbo].[Filters](
[Id] INT PRIMARY KEY,
[Name] NVARCHAR (50) NOT NULL,
[Condition] NVARCHAR(128) NOT NULL,
);