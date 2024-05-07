using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    

    public class SubjectDataAccess
    {
        private string connectionString;

        public SubjectDataAccess(string connectionString= "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=employess;Integrated Security=True;Encrypt=False")
        {
            this.connectionString = connectionString;
        }

        public int GetSubjectIndex(string subjectName)
        {
            int subjectIndex = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT status_id FROM Statuses WHERE status_name = @SubjectName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SubjectName", subjectName);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        subjectIndex = Convert.ToInt32(result);
                    }
                }
            }

            return subjectIndex;
        }

        public List<string> GetColumnValues(string tableName, string columnName)
        {
            List<string> columnValues = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM {tableName}";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int columnIndex = reader.GetOrdinal(columnName); // Получаем индекс столбца по его имени

                        while (reader.Read())
                        {
                            string value = reader.GetString(columnIndex);
                            columnValues.Add(value);
                        }
                    }
                }
            }

            return columnValues;
        }

    }
}
