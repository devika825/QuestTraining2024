using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorManagementApp
{
  public class Doctor
    {

        private ManageDB dbManage = new ManageDB();
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int? PatientID { get; set; }

        public override string ToString()
        {
            return $"ID: {DoctorID}, Name: {Name}, Specialization: {Specialization}, Assigned Patient ID: {PatientID}";
        }

        public void AddDoctor(Doctor doctor)
        {
            string query = "INSERT INTO Doctors (Name, Specialization, PatientID) VALUES (@Name, @Specialization, @PatientID)";
            dbManage.ExecuteNonQuery(query, new SqlParameter[]
            {
                new SqlParameter("@Name", doctor.Name),
                new SqlParameter("@Specialization", doctor.Specialization),
                new SqlParameter("@PatientID", (object)doctor.PatientID ?? DBNull.Value)
            });
        }

        public List<Doctor> GetDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            string query = "SELECT * FROM Doctors";
            using (SqlConnection connection = dbManage.GetConnection())
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
                            PatientID = reader.IsDBNull(3) ? null : (int?)reader.GetInt32(3)
                        });
                    }
                }
            }
            return doctors;
        }

        public void UpdateDoctor(Doctor doctor)
        {
            string query = "UPDATE Doctors SET Name = @Name, Specialization = @Specialization, PatientID = @PatientID WHERE DoctorID = @DoctorID";
            dbManage.ExecuteNonQuery(query, new SqlParameter[]
            {
                new SqlParameter("@Name", doctor.Name),
                new SqlParameter("@Specialization", doctor.Specialization),
                new SqlParameter("@PatientID", (object)doctor.PatientID ?? DBNull.Value),
                new SqlParameter("@DoctorID", doctor.DoctorID)
            });
        }

        public void DeleteDoctor(int doctorID)
        {
            string query = "DELETE FROM Doctors WHERE DoctorID = @DoctorID";
            dbManage.ExecuteNonQuery(query, new SqlParameter[]
            {
                new SqlParameter("@DoctorID", doctorID)
            });
        }
    }
}
