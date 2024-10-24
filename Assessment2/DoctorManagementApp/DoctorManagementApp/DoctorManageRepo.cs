using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorManagementApp
{
    public class DoctorManageRepo
    {
        private string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DoctorManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public DoctorManageRepo()
        {
            CreatePatientTable();
            CreateDoctorTable();
        }

        private void ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void CreatePatientTable()
        {
            string createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Patients' AND xtype='U')
            BEGIN
                CREATE TABLE Patients (
                    PatientID INT PRIMARY KEY IDENTITY(1,1),
                    Name NVARCHAR(100) NOT NULL,
                    Age INT NOT NULL,
                    Gender NVARCHAR(10) NOT NULL,
                    MedicalCondition NVARCHAR(200) NULL
                );
            END";
            ExecuteQuery(createTableQuery);
        }
        private void CreateDoctorTable()
        {
            string createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Doctors' AND xtype='U')
            BEGIN
                CREATE TABLE Doctors (
                    DoctorID INT PRIMARY KEY IDENTITY(1,1),
                    Name NVARCHAR(100) NOT NULL,
                    Specialization NVARCHAR(100) NOT NULL,
                    PatientID INT NULL,
                    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID)
                );
            END";
            ExecuteQuery(createTableQuery);
        }

        private void ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(parameters);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void AddPatient(Patient patient)
        {
            string query = "INSERT INTO Patients (Name, Age, Gender, MedicalCondition) VALUES (@Name, @Age, @Gender, @MedicalCondition)";
            ExecuteNonQuery(query, new SqlParameter[]
            {
                new SqlParameter("@Name", patient.Name),
                new SqlParameter("@Age", patient.Age),
                new SqlParameter("@Gender", patient.Gender),
                new SqlParameter("@MedicalCondition", patient.MedicalCondition)
            });
        }

        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            string query = "SELECT * FROM Patients";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patients.Add(new Patient
                        {
                            PatientID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Age = reader.GetInt32(2),
                            Gender = reader.GetString(3),
                            MedicalCondition = reader.GetString(4)
                        });
                    }
                }
            }
            return patients;
        }

        public void UpdatePatient(Patient patient)
        {
            string query = "UPDATE Patients SET Name = @Name, Age = @Age, Gender = @Gender, MedicalCondition = @MedicalCondition WHERE PatientID = @PatientID";
            ExecuteNonQuery(query, new SqlParameter[]
            {
                new SqlParameter("@Name", patient.Name),
                new SqlParameter("@Age", patient.Age),
                new SqlParameter("@Gender", patient.Gender),
                new SqlParameter("@MedicalCondition", patient.MedicalCondition),
                new SqlParameter("@PatientID", patient.PatientID)
            });
        }

        public void DeletePatient(int patientID)
        {
            string query = "DELETE FROM Patients WHERE PatientID = @PatientID";
            ExecuteNonQuery(query, new SqlParameter[]
            {
                new SqlParameter("@PatientID", patientID)
            });
        }

        public void AddDoctor(Doctor doctor)
        {
            string query = "INSERT INTO Doctors (Name, Specialization, PatientID) VALUES (@Name, @Specialization, @PatientID)";
            ExecuteNonQuery(query, new SqlParameter[]
            {
                new SqlParameter("@Name", doctor.Name),
                new SqlParameter("@Specialization", doctor.Specialization),
                new SqlParameter("@PatientID", doctor.PatientID)
            });
        }

        public List<Doctor> GetDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            string query = "SELECT * FROM Doctors";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        doctors.Add(new Doctor
                        {
                            DoctorID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Specialization = reader.GetString(2),
                            PatientID = reader.GetInt32(3)
                        });
                    }
                }
            }
            return doctors;
        }

        public void UpdateDoctor(Doctor doctor)
        {
            string query = "UPDATE Doctors SET Name = @Name, Specialization = @Specialization, PatientID = @PatientID WHERE DoctorID = @DoctorID";
            ExecuteNonQuery(query, new SqlParameter[]
            {
                new SqlParameter("@Name", doctor.Name),
                new SqlParameter("@Specialization", doctor.Specialization),
                new SqlParameter("@PatientID", doctor.PatientID),
                new SqlParameter("@DoctorID", doctor.DoctorID)
            });
        }

        public void DeleteDoctor(int doctorID)
        {
            string query = "DELETE FROM Doctors WHERE DoctorID = @DoctorID";
            ExecuteNonQuery(query, new SqlParameter[]
            {
                new SqlParameter("@DoctorID", doctorID)
            });
        }
    }
}


