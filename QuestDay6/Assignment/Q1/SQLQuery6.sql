CREATE TABLE StudentsCourses (
    StudentID INT PRIMARY KEY,
    StudentName VARCHAR(255),
    CourseID INT,
    CourseName VARCHAR(255),
    CourseFee DECIMAL(10, 2),
    EnrollmentDate DATE
);

INSERT INTO StudentsCourses (StudentID, StudentName, CourseID, CourseName, CourseFee, EnrollmentDate)
VALUES 
(1, 'John Doe', 101, 'Mathematics', 1500.00, '2024-01-15'),
(2, 'Jane Smith', 102, 'Science', 1600.00, '2024-02-10'),
(3, 'Michael Brown', 103, 'English', 1300.00, '2024-03-05'),
(4, 'Emily Davis', 104, 'History', 1400.00, '2024-04-20'),
(5, 'Sarah Wilson', 105, 'Mathematics', 1500.00, '2024-01-18'),
(6, 'David Clark', 106, 'Science', 1600.00, '2024-02-12'),
(7, 'Alice Johnson', 107, 'Art', 1400.00, '2024-01-25'),
(8, 'Robert Garcia', 108, 'Physical Education', 1200.00, '2024-02-15'),
(9, 'Linda Martinez', 109, 'Computer Science', 1700.00, '2024-03-01'),
(10, 'James Wilson', 110, 'Biology', 1600.00, '2024-03-20')

Select CourseName,COUNT(StudentID) AS Total_Student_Enrolled from StudentsCourses group by CourseName; 

Select CourseName,SUM(CourseFee) AS Total_Fee_Collected from studentsCourses group by CourseName;

Select TOP 1 CourseName, COUNT(StudentID) AS TotalEnrollments from StudentsCourses GROUP BY CourseName ORDER BY TotalEnrollments DESC



