USE [BlackBoard Premium]
GO

/****** Object:  StoredProcedure [dbo].[GetInstructorDetails]    Script Date: 2021-03-14 10:34:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetInstructorDetails]
	@Username nvarchar(50),
	@Password nvarchar(100)
AS
BEGIN
	BEGIN TRANSACTION [TXGetInstructorDetails]
	BEGIN TRY
		SELECT
			*
		FROM
			Instructor
		WHERE
			Instructor.Username=@Username and
			Instructor.Password=@Password;
		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION [TXGetInstructorDetails]
	END CATCH
END;
GO

