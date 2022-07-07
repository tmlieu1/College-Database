CREATE PROCEDURE StudentDropCourse (
	@StudentID nvarchar(50),
	@CourseID nvarchar(50),
	@SectionID nvarchar(50)
)
AS
BEGIN
	BEGIN TRANSACTION [TXSDropCourse]
	BEGIN TRY
		-- Delete entry to Student's Takes table
		DELETE
		FROM [BlackBoard Premium].[dbo].[Takes]
		WHERE StudentID = @StudentID and SectionID = @SectionID

		-- Decrement currently enrolled students by 1
		UPDATE [BlackBoard Premium].[dbo].[Sections]
		SET EnrolledStudents = EnrolledStudents - 1
		WHERE SectionID = @SectionID

		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION [TXSDropCourse]
	END CATCH
END