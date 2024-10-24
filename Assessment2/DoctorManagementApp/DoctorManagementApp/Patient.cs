using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorManagementApp
{
   public class Patient
    {
        private ManageDB dbManage = new ManageDB();
        public int PatientID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MedicalCondition { get; set; }

        public override string ToString()
        {
            return $"ID: {PatientID}, Name: {Name}, Age: {Age}, Gender: {Gender}, Medical Condition: {MedicalCondition}";
        }

        public void AddPatient(Patient patient)
        {
            string query = "INSERT INTO Patients (Name, Age, Gender, MedicalCondition) VALUES (@Name, @Age, @Gender, @MedicalCondition)";
            dbManage.ExecuteNonQuery(query, new SqlParameter[]
            {
                new SqlParameter("@Name", patient.Name),
                new SqlParameter("@Age", patient.Age),
                new SqlParameter("@Gender", patient.Gender),
                new SqlParameter("@MedicalCondition", patient.MedicalCondition ?? (object)DBNull.Value)
            });
        }

        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            string query = "SELECT * FROM Patients";
            using (SqlConnection connection = dbManage.GetConnection())
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
                            MedicalCondition = reader.IsDBNull(4) ? null : reader.GetString(4)
                        });
                    }
                }
            }
            return patients;
        }

        public void UpdatePatient(Patient patient)
        {
            string query = "UPDATE Patients SET Name = @Name, Age = @Age, Gender = @Gender, MedicalCondition = @MedicalCondition WHERE PatientID = @PatientID";
            dbManage.ExecuteNonQuery(query, new SqlParameter[]
            {
                new SqlParameter("@Name", patient.Name),
                new SqlParameter("@Age", patient.Age),
                new SqlParameter("@Gender", patient.Gender),
                new SqlParameter("@MedicalCondition", patient.MedicalCondition ?? (object)DBNull.Value),
                new SqlParameter("@PatientID", patient.PatientID)
            });
        }

        public void DeletePatient(int patientID)
        {
            string query = "DELETE FROM Patients WHERE PatientID = @PatientID";
            dbManage.ExecuteNonQuery(query, new SqlParameter[]
            {
                new SqlParameter("@PatientID", patientID)
            });
        }
    }
}
