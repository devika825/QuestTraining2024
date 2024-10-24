using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorManagementApp
{
    public class ManageDB
    {
        private string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DoctorManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public void ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(parameters);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }
    }
}
