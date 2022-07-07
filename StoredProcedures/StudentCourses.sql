CREATE PROCEDURE dbo.GetStudentCourses
	@StudentID nvarchar(50),
	@Semester nvarchar(50) = NULL,
	@Year nvarchar(50) = NULL
AS
BEGIN
	BEGIN TRANSACTION [TXGetStudentCourses]
	BEGIN TRY
		SELECT 
			StudentID,
			StudentName,
			CourseID,
			SectionID,
			CourseName,
			SectionName,
			Semester,
			Year
		FROM [BlackBoard Premium].[dbo].[CourseList]
		WHERE StudentID LIKE @StudentID AND
			( Semester LIKE @Semester OR @Semester is NULL) AND
			( Year LIKE @Year OR @Year is NULL)
		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION [TXGetStudentCourses]
	END CATCH
END
GO