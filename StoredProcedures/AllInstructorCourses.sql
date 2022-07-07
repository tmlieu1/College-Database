CREATE PROCEDURE dbo.GetAllTeacherCourses
AS
BEGIN
	BEGIN TRANSACTION [TXGetAllTeacherCourses]
	BEGIN TRY
		SELECT DISTINCT
			InstructorID,
			InstructorName,
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
		ROLLBACK TRANSACTION [TXGetAllTeacherCourses]
	END CATCH
END
GO
