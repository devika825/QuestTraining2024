CREATE DATABASE PatientsHistory

CREATE TABLE PatientsDetails(
id INT IDENTITY(1,1) PRIMARY KEY,
first_name VARCHAR(50) NOT NULL,
last_name VARCHAR(50) NOT NULL,
gender CHAR(1) CHECK (gender IN ('M', 'F', 'Other')),
age INT CHECK (age > 0 AND age < 120),
email VARCHAR(100) UNIQUE,
created_at DATETIME DEFAULT GETDATE()
)

CREATE TABLE  PatientsAppointments (
    id INT IDENTITY(1,1) PRIMARY KEY,
    patient_id INT FOREIGN KEY REFERENCES PatientsDetails(id),
    appointment_date DATE CHECK (appointment_date >= CAST(GETDATE() AS DATE)),
    appointment_time TIME NOT NULL,
    reason_for_visit VARCHAR(255) NOT NULL,
    doctor_name VARCHAR(100) NOT NULL,
    created_at DATETIME DEFAULT GETDATE()
);

INSERT INTO PatientsDetails (first_name, last_name, gender, age, email)
VALUES 
('John', 'Doe', 'M', 30, 'john.doe@example.com'),
('Jane', 'Smith', 'F', 25, 'jane.smith@example.com'),
('Michael', 'Brown', 'M', 40, 'michael.brown@example.com'),
('Emily', 'Davis', 'F', 35, 'emily.davis@example.com'),
('Sarah', 'Wilson', 'M', 28, 'sarah.wilson@example.com');

INSERT INTO PatientsAppointments (patient_id, appointment_date, appointment_time, reason_for_visit, doctor_name)
VALUES 
(11, '2024-10-15', '10:30:00', 'Regular check-up', 'Dr. Smith'),
(12, '2024-10-16', '11:00:00', 'Flu symptoms', 'Dr. Johnson'),
(13, '2024-10-17', '14:00:00', 'Follow-up visit', 'Dr. Brown'),
(14, '2024-10-18', '09:00:00', 'Dental check-up', 'Dr. Davis'),
(15, '2024-10-19', '13:30:00', 'Skin rash', 'Dr. Wilson');

