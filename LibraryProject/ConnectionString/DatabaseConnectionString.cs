using System.Data;
using System.Data.SqlClient;

namespace LibraryProject.ConnectionString
{
    public static class DatabaseConnectionString
    {
        // Connection string değerini sabit bir string olarak tut
        public static string ConnStr =
            "Server=localhost;Initial Catalog=CSharpLibraryDb;Integrated Security=true";

        public static IDbConnection GetConnection()
        {
            return new SqlConnection(ConnStr);
        }
    }
}