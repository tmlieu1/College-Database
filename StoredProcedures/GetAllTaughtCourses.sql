USE [BlackBoard Premium]
GO

/****** Object:  StoredProcedure [dbo].[GetAllTaughtCourses]    Script Date: 2021-03-13 9:28:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllTaughtCourses]
	@InstructorID nvarchar(50)
AS
BEGIN
	BEGIN TRANSACTION [TXGetAllTaughtCourses]
	BEGIN TRY
		SELECT
			*
		FROM [dbo].CourseView
		WHERE @InstructorID = InstructorID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION [TXGetAllTaughtCourses]
	END CATCH
END;
GO

