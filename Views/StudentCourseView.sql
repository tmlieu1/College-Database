-- List of all courses students have taken in all years.
USE [BlackBoard Premium]
GO

CREATE VIEW CourseList
	WITH SCHEMABINDING AS
	SELECT
		st.StudentID AS StudentID,
		st.StudentName AS StudentName,
		c.CourseID AS CourseID,
		s.SectionID AS SectionID,
		s.TimeslotID AS TimeslotID,
		s.Start_Time AS Start_Time,
		s.End_Time AS End_Time,
		c.CourseName AS CourseName, 
		s.SectionName AS SectionName,
		i.InstructorID AS InstructorID,
		i.InstructorName AS InstructorName,
		c.Credits AS Credits,
		s.Semester AS Semester,
		s.Year AS Year
	FROM [dbo].Courses AS c
	INNER JOIN [dbo].Sections AS s ON s.CourseID = c.CourseID
	INNER JOIN [dbo].Takes AS t ON t.SectionID = s.SectionID
	INNER JOIN [dbo].Teaches AS te ON te.SectionID = s.SectionID
	INNER JOIN [dbo].Students AS st on st.StudentID = t.StudentID
	INNER JOIN [dbo].Instructor AS i ON i.InstructorID = te.InstructorID
GO

CREATE UNIQUE CLUSTERED INDEX IdxID
	ON [dbo].CourseList (StudentID, CourseID, SectionID)
GO

CREATE NONCLUSTERED INDEX IdxSemYear
	ON [dbo].CourseList (Semester, Year)
GO