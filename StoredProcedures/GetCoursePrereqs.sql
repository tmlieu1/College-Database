CREATE PROCEDURE dbo.CheckPrereqs
	@StudentID nvarchar(50),
	@CourseID nvarchar(50)
AS
BEGIN
	BEGIN TRANSACTION [TXCheckPrereqs]
	BEGIN TRY
		SELECT	
			CourseID, 
			CourseName 
		FROM CourseList
		WHERE StudentID = @StudentID

		SELECT 
			p.PrereqID AS PrereqID,
			c.CourseName AS CourseName
		FROM [BlackBoard Premium].[dbo].[Prereq] AS p
		INNER JOIN [BlackBoard Premium].[dbo].[Courses] AS c ON p.PrereqID = c.CourseID
		WHERE p.CourseID LIKE @CourseID
		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION [TXCheckPrereqs]
	END CATCH
END
GO