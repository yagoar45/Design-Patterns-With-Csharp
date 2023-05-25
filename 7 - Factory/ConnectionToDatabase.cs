

using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns._7___Factory
{
    public class ConnectionToDatabase
    {
        //IDbConnection connection = new SqlConnection();
        //connection.ConnectionString = "User=root;Password=12345;Server=localhost;Database=testdb"
        //connection.Open();

        public void CreateCommandForDb()
        {
            var connection = new ConnectionFactory().GetConnection();


            IDbCommand command = connection.CreateCommand();
            command.CommandText = "select * from table";
        }
    }
}
