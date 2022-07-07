CREATE PROCEDURE dbo.GetAllStudentCourses
AS
BEGIN
	BEGIN TRANSACTION [TXGetAllStudentCourses]
	BEGIN TRY
		SELECT DISTINCT
			StudentID,
			StudentName,
			CourseID,
			SectionID,
			CourseName,
			SectionName,
			Semester,
			Year
		FROM [BlackBoard Premium].[dbo].[CourseList]
		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION [TXGetAllStudentCourses]
	END CATCH
END
GO