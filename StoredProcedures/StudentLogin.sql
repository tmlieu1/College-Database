-- Get Student's login details
CREATE PROCEDURE StudentLogin
	@Username nvarchar(50),
	@Password nvarchar(100)
AS
	BEGIN TRANSACTION [TXStudentLogin]
	BEGIN TRY
		SELECT 
			st.Username, 
			st.Password,
			st.StudentID
		FROM [BlackBoard Premium].dbo.Students AS st
		WHERE st.Username = @Username AND st.Password = @Password
		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION [TXStudentLogin]
	END CATCH
GO