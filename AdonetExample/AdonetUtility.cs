using Microsoft.Data.SqlClient;

namespace AdonetExample
{
    internal class AdonetUtility : IDisposable
    {
        private readonly SqlConnection _connection;
        public AdonetUtility(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public void Dispose()
        {
            _connection.Dispose();
        }

        public void ExecuteCommand(string commandText, Dictionary<string, object> parameters = null)
        {
            using SqlCommand command = CreateCommand(commandText, parameters);
            var affected = command.ExecuteNonQuery();
            Console.WriteLine(affected);
        }

        public List<Dictionary<string, object>> ExecuteQuery(string commandText, Dictionary<string, object> parameters = null)
        {
            using SqlCommand command = CreateCommand(commandText, parameters);
            using SqlDataReader reader = command.ExecuteReader();
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            while (reader.Read())
            {
                Dictionary<string, object> row = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row.Add(reader.GetName(i), reader.GetValue(i));
                }
                result.Add(row);
            }
            return result;
        }

        private SqlCommand CreateCommand(string sql, Dictionary<string, object> parameters)
        {
            SqlCommand command = new SqlCommand(sql, _connection);
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    command.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
                }
            }
            if (command.Connection.State != System.Data.ConnectionState.Open)
            {
                command.Connection.Open();
            }
            return command;
        }
    }
}