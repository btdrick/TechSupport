using System.Data.SqlClient;

namespace TechSupport
{
    /// <summary>
    /// Get a connection object.
    /// </summary>
    public static class TechSupportDBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=TechSupport;" +
                "Integrated Security=True";


            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }       
    }
}
