CREATE DATABASE StudentManagementSystem

CREATE TABLE StudentHistory(
id INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(50) NOT NULL,            
LastName VARCHAR(50) NOT NULL,             
Age INT CHECK (Age > 0 AND Age < 120),     
Email VARCHAR(100) UNIQUE, 
Phone_number VARCHAR(20)
)

CREATE TABLE Subjects(
SubjectId BIGINT PRIMARY KEY IDENTITY,
SubjectCode VARCHAR(50) NOT NULL, 
SubjectName VARCHAR(50) NOT NULL,         
)


CREATE TABLE EXAM (
ExamID INT PRIMARY KEY IDENTITY,  
MinMark INT ,          
MaxMark INT,     
);


CREATE TABLE MARKS (
MarkID INT PRIMARY KEY IDENTITY,     
StudentID INT,                           
ExamID INT,                                
SubjectID BIGINT,                             
Mark INT CHECK (Mark >= 0),               
CONSTRAINT FK_std_id FOREIGN KEY (StudentID) REFERENCES StudentHistory(id),  
CONSTRAINT FK_ex_id FOREIGN KEY (ExamID) REFERENCES EXAM(ExamID),           
CONSTRAINT FK_sub_id FOREIGN KEY (SubjectId) REFERENCES Subjects(SubjectId)
);

INSERT INTO StudentHistory(FirstName, LastName, Age, Email, Phone_number) VALUES
('Alice', 'Johnson', 21, 'alice.johnson@example.com', '123-456-7890'),
('Bob', 'Smith', 22, 'bob.smith@example.com', '987-654-3210'),
('Charlie', 'Brown', 19, 'charlie.brown@example.com', '555-555-5555'),
('Daisy', 'Miller', 20, 'daisy.miller@example.com', '444-444-4444'),
('Eve', 'Davis', 23, 'eve.davis@example.com', '666-666-6666');

SELECT * FROM StudentHistory

INSERT INTO Subjects (SubjectCode, SubjectName)
VALUES 
('MATH101', 'Mathematics'),
('SCI102', 'Science'),
('HIST103', 'History'),
('LIT104', 'Literature'),
('CS105', 'Computer Science'),
('ENG106', 'English'),
('PHY107', 'Physics'),
('CHEM108', 'Chemistry');

Select * from Subjects


INSERT INTO EXAM (MinMark, MaxMark)
VALUES 
(0, 100),  
(10, 50),   
(0, 75),   
(20, 80),   
(5, 90);   



INSERT INTO MARKS (StudentID, ExamID, SubjectID, Mark)
VALUES 
(1, 1, 1, 85),   -- Student 1 received 85 marks in Exam 1 for Subject 1
(2, 1, 2, 75),   -- Student 2 received 75 marks in Exam 1 for Subject 2
(1, 2, 1, 90),   -- Student 1 received 90 marks in Exam 2 for Subject 1
(3, 1, 3, 65),   -- Student 3 received 65 marks in Exam 1 for Subject 3
(2, 2, 2, 55);   -- Student 2 received 55 marks in Exam 2 for Subject 2


SELECT 
    sh.FirstName, 
    sh.LastName, 
    s.SubjectName, 
    m.Mark 
FROM 
    MARKS m
INNER JOIN 
    StudentHistory sh ON m.StudentID = sh.id
INNER JOIN 
    Subjects s ON m.SubjectID = s.SubjectId;










SELECT 
    sh.FirstName,
    sh.LastName,
    s.SubjectName,
    m.Mark
FROM 
    MARKS m
INNER JOIN 
    Subjects s ON m.SubjectID = s.SubjectId
INNER JOIN 
    StudentHistory sh ON m.StudentID = sh.id
WHERE 
    s.SubjectName = 'Mathematics';








SELECT 
    sh.FirstName,
    sh.LastName,
    s.SubjectName,
    e.ExamID,
   m.Mark,
   s.subjectid
FROM 
    MARKS m
INNER JOIN 
    StudentHistory sh ON m.StudentID = sh.id
INNER JOIN 
    EXAM e ON m.ExamID = e.ExamID
INNER JOIN 
    Subjects s ON m.SubjectID = s.SubjectId
WHERE 
    sh.id = 3



	Select * from marks where SubjectID = (select SubjectID from Subjects where SubjectCode = 'MATH101')