USE [BlackBoard Premium]
GO

CREATE PROCEDURE dbo.GetAvailableClassrooms
	@Semester nvarchar(50),
	@Year int,
	@StartTime time(0),
	@EndTime time(0),
	@TimeslotID int
AS
BEGIN
	BEGIN TRANSACTION [TXGetAvailableClassrooms]
	BEGIN TRY
		SELECT
			c.Location
			FROM [BlackBoard Premium].[dbo].[Classroom] AS c
			WHERE c.Location NOT IN
				-- Select locations not present in the Semester & Year --
				(SELECT s.Location FROM [BlackBoard Premium].[dbo].[Sections] AS s
				WHERE (s.Semester = @Semester AND s.Year = @Year) AND 
				s.TimeslotID = @TimeslotID AND (
					-- Check for overlaps --
					(s.Start_Time BETWEEN @StartTime AND @EndTime) OR
					(s.End_Time BETWEEN @StartTime AND @EndTime) OR
					(s.Start_Time < @StartTime AND s.End_Time > @EndTime) OR
					(s.Start_Time >= @StartTime AND s.End_Time <= @EndTime)
					)
				)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION [TXGetAvailableClassrooms]
	END CATCH
END;
GO