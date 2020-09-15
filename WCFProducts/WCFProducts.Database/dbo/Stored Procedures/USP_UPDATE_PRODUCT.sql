﻿CREATE PROCEDURE USP_UPDATE_PRODUCT
	@ID INT,
	@NAME VARCHAR(40),
	@DESCRIPTION VARCHAR(MAX),
	@PRICE DECIMAL
AS
	SET NOCOUNT ON;

	UPDATE [dbo].[Products]
	SET
		[name] = @NAME,
		[description] = @DESCRIPTION,
		[price] = @PRICE
	WHERE
		[id] = @ID