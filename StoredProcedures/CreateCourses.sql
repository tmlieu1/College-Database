USE [BlackBoard Premium]
GO

/****** Object:  StoredProcedure [dbo].[InsertCourse]    Script Date: 2021-03-13 6:27:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertCourse] (
	@SectionID nvarchar(50),
	@InstructorID nvarchar(50),
	@CourseID nvarchar(50),
	@TimeSlotID int,
	@Location nvarchar(50),
	@SectionName nvarchar(50),
	@MaximumStudents int,
	@Semester nvarchar(50),
	@Year int,
	@Start_Time time(0),
	@End_Time time(0),
	-- result to determine whether class already exists or was successful --
	@result int OUTPUT
)
AS
BEGIN
	DECLARE 
	@NumOverlap AS int = 0
	BEGIN TRANSACTION [TXInsertCourse]
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM Sections WHERE @InstructorID=InstructorID and @CourseID = CourseID and @Semester = Semester and @Year = Year)
			BEGIN
				SELECT @NumOverlap = COUNT(*) FROM 
				(
					SELECT s.TimeslotID, s.Start_Time, s.End_Time FROM [BlackBoard Premium].[dbo].[Sections] AS s
						JOIN [BlackBoard Premium].[dbo].[CourseView] AS cl ON s.SectionID = cl.SectionID
						WHERE cl.InstructorID = @InstructorID AND
						(s.Semester = @Semester AND s.Year = @Year) AND
						s.TimeslotID = @TimeslotID AND 
						(
							(s.Start_Time BETWEEN @Start_Time AND @End_Time) OR
							(s.End_Time BETWEEN @Start_Time AND @End_Time) OR
							(s.Start_Time < @Start_Time AND s.End_Time > @End_Time) OR
							(s.Start_Time >= @Start_Time AND s.End_Time <= @End_Time)
						)
				) AS OverlapCheck
				IF @NumOverlap = 0
					BEGIN
						INSERT INTO [BlackBoard Premium].[dbo].[Sections] VALUES (
							@SectionID,
							@InstructorID,
							@CourseID,
							@TimeSlotID,
							@Location,
							@SectionName,
							0,
							@MaximumStudents,
							@Semester,
							@Year,
							@Start_Time,
							@End_Time);
						INSERT INTO [BlackBoard Premium].[dbo].[Teaches] VALUES (
						@InstructorID, @SectionID);
						SET @result = 1
						COMMIT TRANSACTION
					END
				IF @NumOverlap != 0
				BEGIN
					-- There is a time overlap
				SET @result = 3
				COMMIT TRANSACTION
				END
			END
		ELSE
		BEGIN
			-- section already exists as a duplicate the instructor already teaches --
			SET @result = 2
			COMMIT TRANSACTION
		END
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION [TXInsertCourse]
	END CATCH
END;
GO

