INSERT INTO Instructor (InstructorID, InstructorName, DepartmentID, Gender, Username, Password) Values ('00-0000000', 'Bill Bur', '86-669-4756', 'M', 'bbur91', '2cf24dba5fb0a30e26e83b2ac5b9e29e1b161e5c1fa7425e73043362938b9824');
INSERT INTO Classroom (Location, Capacity) VALUES ('9-158', 40);
INSERT INTO Sections (SectionID, InstructorID, CourseID, TimeslotID, Location, SectionName, EnrolledStudents, MaximumStudents, Semester, Year, Start_Time, End_Time) 
Values ('36-683-5205', '00-0000000', '92-106-8125', 3, '9-158', 'AS04', 1, 40, 'Winter', 2021, '12:00:00', '12:50:00');
INSERT INTO Teaches (InstructorID, SectionID) VALUES ('00-0000000', '36-683-5205');
INSERT INTO Takes (SectionID, StudentID) VALUES ('36-683-5205', '01-0810720');
INSERT INTO Sections(SectionID, InstructorID, CourseID, TimeslotID, Location, SectionName, EnrolledStudents, MaximumStudents, Semester, Year, Start_Time, End_Time) 
	VALUES ('01-216-1592', '00-0000000', '64-796-9991', 2, '9-158', 'AS03', 0, 40, 'Winter', 2022, '1:00:00', '1:50:00');
INSERT INTO Teaches (InstructorID, SectionID) VALUES ('00-0000000', '01-216-1592');
UPDATE Sections SET Start_Time = '13:00:00', End_Time = '13:50:00' WHERE SectionID = '01-216-1592';