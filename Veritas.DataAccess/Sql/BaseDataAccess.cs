using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Veritas.DataAccess.Sql
{
    public abstract class BaseDataAccess
    {
        protected IDbConnection CreateVeritasConnection()
        {   
            IDbConnection Veritasdb = new SqlConnection(ConfigurationManager.ConnectionStrings["Veritas"].ToString());
            return Veritasdb;
        }
    }
}
