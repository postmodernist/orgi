﻿CREATE PROCEDURE [dbo].[UpdateRecordInTable]
	@P_tableName nvarchar(50) = null,
	@P_columnsString nvarchar(MAX) = null,
	@P_Id bigint = null
AS
BEGIN
	SET NOCOUNT ON;
	
	declare @V_table nvarchar(50) = null
	if (@P_tableName is not null)
		select @V_table = QUOTENAME( TABLE_NAME )
		FROM INFORMATION_SCHEMA.TABLES
		WHERE TABLE_NAME = @P_tableName

	declare @V_sql as nvarchar(MAX) = null
	if (@V_table is not null and @P_columnsString is not null and @P_Id is not null)
		select @V_sql = 'update ' + @V_table + ' set ' + @P_columnsString + ' where Id = ' + @P_Id + '; select 1;'

	if(@V_sql is not null)
		exec(@V_sql)
	else
		select -1;
END