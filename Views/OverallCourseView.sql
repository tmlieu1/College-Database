USE [BlackBoard Premium]
GO

CREATE VIEW CourseView
	WITH SCHEMABINDING AS
	SELECT
		s.SectionID AS SectionID,
		c.CourseID AS CourseID,
		s.TimeslotID AS TimeslotID,
		c.CourseName AS CourseName,
		s.SectionName AS SectionName,
		s.EnrolledStudents AS Enrolled,
		s.MaximumStudents AS Capacity,
		s.Location AS Location,
		c.Credits AS Credits,
		i.InstructorID AS InstructorID,
		i.InstructorName AS InstructorName,
		s.Start_Time AS Start_Time,
		s.End_Time AS End_Time,
		s.Semester AS Semester,
		s.Year AS Year
	FROM [dbo].Courses as c
	INNER JOIN [dbo].Sections AS s ON s.CourseID = c.CourseID
	INNER JOIN [dbo].Teaches as te ON te.SectionID = s.SectionID
	INNER JOIN [dbo].Instructor AS i ON i.InstructorID = te.InstructorID
GO

CREATE UNIQUE CLUSTERED INDEX IdxViewID
	ON [dbo].CourseView (SectionID)

CREATE NONCLUSTERED INDEX IdxViewSemYear
	ON [dbo].CourseView (Semester, Year)
GO