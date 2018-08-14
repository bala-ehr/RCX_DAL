USE [db_1]
GO

DECLARE	@return_value Int,
		@Items rolepermissionstable

EXEC	@return_value = [dbo].[rcsp_security_fillrolepermissions]
		@Items = @Items

SELECT	@return_value as 'Return Value'

GO
