-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Alex Creencia>
-- Create date: <March 12>
-- Description:	<Checks whether the SectionName exists>
-- =============================================
CREATE PROCEDURE dbo.SectionNameExists
(
		@SectionName nvarchar(50),
		@CourseID nvarchar(50),
		@Semester nvarchar(50),
		@Year int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	BEGIN TRANSACTION [TXSectionNameExists]
	BEGIN TRY
	SELECT COUNT(SectionName) as SectionNameExists
		FROM Sections
		WHERE SectionName LIKE @SectionName and
		CourseID LIKE @CourseID and 
		Semester LIKE @Semester and
		Year LIKE @Year
		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION [TXSectionNameExists]
	END CATCH

	SET NOCOUNT ON;
END
GO
