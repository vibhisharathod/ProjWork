//using Dapper;
//using System;
//using System.Configuration;
//using System.Data;
//using System.Data.SqlClient;

//namespace Veritas.DataAccess.Sql
//{
//    public class DapperDatabaseContext : DbContext
//    {
//        private static readonly string ConnectionString = Convert.ToString(ConfigurationManager.ConnectionStrings["Veritas"]);

//        private static IDbConnection _connection;

//        / <summary>
//        /     Initializes a new instance of the<see cref="DapperDatabaseContext" /> class.
//        / </summary>
//        public DapperDatabaseContext()
//        {
//            OpenConnection();
//        }

//        / <summary>
//        /     Opens the connection.
//        / </summary>
//        private static void OpenConnection()
//        {
//            _connection = new SqlConnection(ConnectionString);
//        }

//        / <summary>
//        /     Gets the connection.
//        / </summary>
//        / <value>The connection.</value>
//        public IDbConnection Connection
//        {
//            get { return _connection; }
//        }

//    }

//}
