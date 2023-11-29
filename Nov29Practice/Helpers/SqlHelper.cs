using Microsoft.Data.SqlClient;
using System.Data;


namespace Nov29Practice.Helpers
{
    public static class SqlHelper
    {
        private const string _connectionString = @"Server=DESKTOP-MV8SC5T\SQLEXPRESS;Database=PracticeNov29;TrustServerCertificate=True;Encrypt=False;Trusted_Connection=True";
        public async static Task<DataTable> GetDatasAsync(string query)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            DataTable dt = new DataTable();
            using SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            sda.Fill(dt);
            await connection.CloseAsync();
            return dt;
        }
        public static int Exec(string query)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            using SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
