﻿
CREATE PROCEDURE USP_SELECT_ALL_PRODUCTS
AS
	SET NOCOUNT ON;

	SELECT * FROM [dbo].[Products];