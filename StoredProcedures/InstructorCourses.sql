CREATE PROCEDURE dbo.GetTeacherCourses
	@InstructorID nvarchar(50),
	@Semester nvarchar(50) = NULL,
	@Year nvarchar(50) = NULL
AS
BEGIN
	BEGIN TRANSACTION [TXGetTeacherCourses]
	BEGIN TRY
		SELECT
			InstructorID,
			InstructorName,
			CourseID,
			SectionID,
			CourseName,
			SectionName,
			Semester,
			Year
		FROM [BlackBoard Premium].[dbo].[CourseList]
		WHERE InstructorID LIKE @InstructorID AND
			( Semester LIKE @Semester OR @Semester is NULL) AND
			( Year LIKE @Year OR @Year is NULL)
		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION [TXGetTeacherCourses]
	END CATCH
END
GO