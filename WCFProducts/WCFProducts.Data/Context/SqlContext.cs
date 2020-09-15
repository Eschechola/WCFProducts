using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WCFProducts.Data.Context
{
    public class SqlContext : IDisposable
    {

        private readonly SqlConnection _connection;

        public SqlContext()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlServerConnectionString"].ConnectionString);
            _connection.Open();
        }

        private void Fill(string procedureName, out SqlCommand command, Dictionary<string, dynamic> parammeters = null)
        {
            command = new SqlCommand(procedureName, _connection);
            command.CommandType = CommandType.StoredProcedure;

            if (parammeters != null)
                foreach (var parammeter in parammeters)
                    command.Parameters.AddWithValue(parammeter.Key, parammeter.Value);
        }

        public async Task ExecuteProcedure(string procedureName, Dictionary<string, dynamic> parammeters = null)
        {
            SqlCommand command;

            Fill(procedureName, out command, parammeters);

            await command.ExecuteNonQueryAsync();
        }

        public async Task<SqlDataReader> ExecuteProcedureWithReader(string procedureName, Dictionary<string, dynamic> parammeters = null)
        {
            SqlCommand command;

            Fill(procedureName, out command, parammeters);

            await command.ExecuteNonQueryAsync();

            return await command.ExecuteReaderAsync();
        }

        public void Dispose()
        {
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
        }
    }
}
