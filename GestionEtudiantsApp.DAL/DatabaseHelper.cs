using System.Configuration;
using System.Data.SqlClient;

namespace GestionEtudiantsApp.DAL
{
    public static class DatabaseHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                ConfigurationManager.ConnectionStrings["cnx"].ConnectionString
            );
        }
    }
}
