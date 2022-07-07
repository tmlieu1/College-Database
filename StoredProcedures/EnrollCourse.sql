CREATE PROCEDURE EnrollCourse (
	@StudentID nvarchar(50),
	@CourseID nvarchar(50),
	@SectionID nvarchar(50),
	-- Parameters for section registration --
	@Semester nvarchar(50),
	@Year nvarchar(50),
	@StartTime time(0),
	@EndTime time(0),
	@TimeslotID int,
	-- Return result of procedure --
	@Success int OUTPUT
)
AS
BEGIN
	DECLARE
		@PrereqsTotal AS tinyint,
		@PrereqsCurr AS tinyint,
		@DBCurrentStud AS int,
		@DBMaximumStud AS int,
		@HasPrereq AS bit,
		@HasSpace AS bit = 0,
		@NumOverlap AS int = 0

	BEGIN TRANSACTION [TXEnrollCourse]
	BEGIN TRY
		-- Check prerequisites --
		IF NOT EXISTS(SELECT * FROM Takes WHERE @StudentID=StudentID AND @SectionID=SectionID)
		BEGIN

				-- Check timeslot overlap --
			SELECT @NumOverlap = COUNT(*) FROM 
			(
				SELECT s.TimeslotID, s.Start_Time, s.End_Time FROM [BlackBoard Premium].[dbo].[Sections] AS s
					JOIN [BlackBoard Premium].[dbo].[CourseList] AS cl ON s.SectionID = cl.SectionID
					WHERE cl.StudentID = @StudentID AND
					(s.Semester = @Semester AND s.Year = @Year) AND
					s.TimeslotID = @TimeslotID AND 
					(
						(s.Start_Time BETWEEN @StartTime AND @EndTime) OR
						(s.End_Time BETWEEN @StartTime AND @EndTime) OR
						(s.Start_Time < @StartTime AND s.End_Time > @EndTime) OR
						(s.Start_Time >= @StartTime AND s.End_Time <= @EndTime)
					)
			) AS OverlapCheck

			IF @NumOverlap = 0
			BEGIN
					-- Total prereq courses --
				SELECT @PrereqsTotal = COUNT(*)
					FROM [BlackBoard Premium].[dbo].[Prereq] AS p
					WHERE p.CourseID = @CourseID

					-- Number of prereqs satisfied --
				SELECT @PrereqsCurr = COUNT(*)
					FROM [BlackBoard Premium].[dbo].[CourseList] AS cl
					JOIN [BlackBoard Premium].[dbo].[Prereq] AS p ON cl.CourseID = p.PrereqID
					WHERE p.CourseID = @CourseID AND cl.StudentID = @StudentID

					-- Set the HasPrereq based on whether we have matches --
				SET @HasPrereq = (SELECT 
					CASE WHEN @PrereqsTotal = @PrereqsCurr THEN  1
					ELSE 0
					END)
			END
			

			-- Check enrolled < max --
			SELECT @DBCurrentStud = EnrolledStudents, @DBMaximumStud = MaximumStudents
			FROM [Blackboard Premium].[dbo].[Sections]
			WHERE SectionID = @SectionID

			IF @HasPrereq = 1
			BEGIN
				IF @DBCurrentStud < @DBMaximumStud
				BEGIN
					SET @HasSpace = 1
					PRINT 'Sufficient Space found, get in here!'
				END
				ELSE
				BEGIN
					SET @HasSpace = 0
					SET @Success = -1
					PRINT 'This section is now full.'
				END
			END
			

			-- Prereqs satisfied, insert and and update --
			IF @HasSpace = 1
			BEGIN
				INSERT INTO [BlackBoard Premium].[dbo].[Takes] VALUES (
					@StudentID,
					@SectionID
				)
				UPDATE [BlackBoard Premium].[dbo].[Sections]
				SET EnrolledStudents = EnrolledStudents + 1
				WHERE SectionID = @SectionID
				SET @Success = 0
			END
			IF @NumOverlap != 0
			BEGIN
				-- There is an overlap
				SET @Success = -3
			END
			ELSE IF @HasPrereq != 1
			BEGIN
				-- Prereqs not met
				SET @Success = -2
			END
			ELSE IF @HasSpace != 1
			BEGIN
				-- No space
				SET @Success = -4
			END
			COMMIT TRANSACTION
		END
		ELSE
		BEGIN
			-- already enrolled
			SET @Success = -1
			COMMIT TRANSACTION
		END
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION [TxEnrollCourse]
	END CATCH
END;
GO
	