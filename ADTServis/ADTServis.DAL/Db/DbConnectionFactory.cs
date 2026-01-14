using System.Configuration;
using MySql.Data.MySqlClient;

namespace ADTServis.DAL.Db
{
    public static class DbConnectionFactory
    {
        public static MySqlConnection Create() 
        {
            var cs = ConfigurationManager
                .ConnectionStrings["MyDb"]
                .ConnectionString;

            return new MySqlConnection(cs);
        }
    }
}
