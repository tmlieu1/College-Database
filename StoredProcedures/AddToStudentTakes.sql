CREATE PROCEDURE dbo.AddToStudentTakes
	@StudentID nvarchar(50),
	@SectionID nvarchar(50),
	@Added int OUTPUT
AS
IF NOT EXISTS(SELECT * FROM Takes WHERE @StudentID=StudentID AND @SectionID=SectionID)
BEGIN
	BEGIN TRANSACTION [TXAddToStudentsTakes]
	BEGIN TRY
		INSERT Takes(StudentID, SectionID)
		VALUES (@StudentID, @SectionID)
		COMMIT TRANSACTION
		SELECT @Added = 0
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION [TXAddToStudentsTakes]
	END CATCH
END
ELSE
	SELECT @Added = -1;
GO