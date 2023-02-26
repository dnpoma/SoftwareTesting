using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;
        public ConnectionToSql()
        {
            connectionString = "Server=KENNETHET\\SQLEXPRESS; DataBase=SEGURIDAD_GRUPO1; integrated security=true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
