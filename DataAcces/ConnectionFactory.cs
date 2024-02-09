using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAcces
{
    public abstract class ConnectionFactory
    {
        private const String serverDB = "SUPORTE-MAXXI\\SQLEXPRESS";
        private const String dataBase = "ERP";
        private const String user = "sa";
        private const String senha = "suportemaxxi";
        private readonly string connectionString;

        public ConnectionFactory()
        {
            connectionString = $"server={serverDB}; database='{dataBase}'; uid='{user}';  password='{senha}'";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
