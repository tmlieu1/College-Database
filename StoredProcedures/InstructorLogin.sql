-- Login Procedure for Instructors
CREATE PROCEDURE InstructorLogin
	@Username nvarchar(50),
	@Password nvarchar(100)
AS
	BEGIN TRANSACTION [TXInstructorLogin]
	BEGIN TRY
		SELECT 
			i.Username, 
			i.Password
		FROM [BlackBoard Premium].dbo.Instructor AS i
		WHERE i.Username = @Username AND i.Password = @Password
		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION [TXInstructorLogin]
	END CATCH
GO