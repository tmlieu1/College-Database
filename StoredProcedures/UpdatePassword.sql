/*
	UpdatePassword
	PURPOSE: Updates a user's password with provided username and current password.
	USAGE  : EXEC UpdatePassword 'Student', 'MaryAnn', 'j0kin'
			 EXEC UpdatePassword 'Instructor', 'georgem', '0451'

	- Fetch the student's data (ID, Password)
	- Compare the old password in DB with one submitted
		- If true, update the old password with the new one
		- If false, do not proceed with the transaction

	KNOWN ISSUES:
	- The procedure doesn't print an error if it didn't find the user from the table.
*/
CREATE PROCEDURE UpdatePassword (
	@UserType nvarchar(20),			-- Type of User ("Students"/"Instructor")
	@UserName nvarchar(100),		-- Username of the user
	@OldPassword nvarchar(100),		-- Submitted Password (for verification)
	@NewPassword nvarchar(100)		-- Requested new Pass
)
AS
BEGIN
	DECLARE
		@DBName nvarchar(100),		-- Name from Database
		@DBPass nvarchar(100)		-- Pass from Database

	BEGIN TRANSACTION [TXUpdateStudentPassword]
	BEGIN TRY
		
		-- Get data based on requested table.
		IF @UserType = 'Instructor'
		BEGIN
			SELECT @DBName = Username, @DBPass = Password
			FROM [BlackBoard Premium].[dbo].[Instructor]
			WHERE Username = @UserName
		END
		ELSE
		BEGIN
			SELECT @DBName = Username, @DBPass = Password
			FROM [BlackBoard Premium].[dbo].Students
			WHERE Username = @UserName
		END
		
		-- Update password with matching credentials.
		IF @DBPass = @OldPassword
		BEGIN
			IF @UserType = 'Instructor'
			BEGIN
				UPDATE [BlackBoard Premium].[dbo].[Instructor]
				SET Password = @NewPassword
				WHERE Username = @UserName
			END
			ELSE
			BEGIN
				UPDATE [BlackBoard Premium].[dbo].[Students]
				SET Password = @NewPassword
				WHERE Username = @UserName
			END
		END
		ELSE
			PRINT '[UpdatePassword] < ! > Password Authentication failed: Incorrect Password';
			
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION [TXUpdateStudentPassword]
		PRINT '[UpdatePassword] < ! > Password Authentication failed: Transaction failed, must Rollback.';
	END CATCH
END