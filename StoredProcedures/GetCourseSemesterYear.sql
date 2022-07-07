CREATE PROCEDURE dbo.GetCourseSemesterYear
	@Semester nvarchar(50),
	@Year int
AS
BEGIN
	BEGIN TRANSACTION [TXGetCourseSemesterYear]
	BEGIN TRY
		SELECT *
		FROM [BlackBoard Premium].[dbo].[CourseView]
		WHERE @Year = Year and @Semester = Semester
		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION [TXGetCourseSemesterYear]
	END CATCH
END
GO