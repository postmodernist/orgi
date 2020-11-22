CREATE TABLE [dbo].[Projects](
	[Id] INT PRIMARY KEY ,
	[Name] NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(50),
	[ColorMarker] NVARCHAR(12) NOT NULL,
	[IsFavorite] BIT NOT NULL,
	[DisplayAs] NVARCHAR(12) NOT NULL,
	[SubProjectId] UNIQUEIDENTIFIER 
);