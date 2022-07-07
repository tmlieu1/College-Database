CREATE PROCEDURE SearchCourseName (
	@SearchText nvarchar(50)
)
AS
BEGIN
	BEGIN TRANSACTION [TXSearchCourseName]
	BEGIN TRY		
		SELECT CourseName, InstructorName, Start_Time, End_Time, Location, SectionName, EnrolledStudents, MaximumStudents
		FROM
			(SELECT CourseID, CourseName
			FROM Courses
			WHERE CourseName LIKE '%' + @SearchText + '%') as c, 
			(Select InstructorID, InstructorName
			from Instructor) as i,
			Sections as s
		WHERE s.CourseID = c.CourseID and s.InstructorID = i.InstructorID
		ORDER BY CourseName
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION [TXSearchCourseName]
	END CATCH
END