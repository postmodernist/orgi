CREATE TABLE [dbo].[Projects](
	[Id] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
	[Name] NVARCHAR(50),
	[Description] NVARCHAR(50);
	[ColorMarker] NVARCHAR(12);
	[IsFavorite] BIT,
	[DisplayAs] NVARCHAR(12);
	[SubProjectId] UNIQUEIDENTIFIER 
);