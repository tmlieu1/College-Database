-- Created By Tyson Hoang
CREATE PROCEDURE InstructorDropCourse (
	@InstructorID nvarchar(50),
	@SectionID nvarchar(50)
)
AS
BEGIN
	BEGIN TRANSACTION [TXIDropCourse]
	BEGIN TRY
		-- Remove all students currently enrolled in this course
		DELETE
		FROM [BlackBoard Premium].[dbo].[Takes]
		WHERE SectionID = @SectionID

		-- Remove the course from Teaches
		DELETE
		FROM [BlackBoard Premium].[dbo].[Teaches]
		WHERE InstructorID = @InstructorID and SectionID = @SectionID

		-- Remove the Section from Sections
		DELETE
		FROM [BlackBoard Premium].[dbo].[Sections]
		WHERE SectionID = @SectionID

		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION [TXIDropCourse]
	END CATCH
END