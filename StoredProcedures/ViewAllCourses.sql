USE [BlackBoard Premium]
GO

/****** Object:  StoredProcedure [dbo].[ViewAllCourses]    Script Date: 2021-03-14 10:34:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Alex Creencia>
-- Create date: <March 08, 2022>
-- Description:	<This Stored Procedure gets a list of all possible courses to teach from the Courses table. This is one of the few procedures that 
--               Does NOT use our materialized Views, because this does not search existing SECTIONS but existing COURSES>
-- =============================================
CREATE PROCEDURE [dbo].[ViewAllCourses] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	BEGIN TRANSACTION [TXViewAllCourses]

	BEGIN TRY
		SELECT * FROM Courses 
		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION [TXViewAllCourses]
	END CATCH

	SET NOCOUNT ON;

END
GO

