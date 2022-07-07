CREATE PROCEDURE dbo.SectionExists
	@SectionID nvarchar(50)
AS
BEGIN
	BEGIN TRANSACTION [TXSectionExists]
	BEGIN TRY
		SELECT COUNT(SectionID) AS SectionExists 
		FROM [BlackBoard Premium].[dbo].[Sections]
		WHERE SectionID LIKE @SectionID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION [TXSectionExists]
	END CATCH
END
GO