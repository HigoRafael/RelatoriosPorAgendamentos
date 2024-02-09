using MySql.Data.MySqlClient;

namespace DataAcces
{
    public abstract class ConnectionFactoryMySQL
    {
        private const String serverDB = "mysqlmaxxisystem.soft4.com.br";
        private const String dataBase = "saas_maxxisystem";
        private const String user = "bi_maxxisystem";
        private const String senha = "bfxJ5r*E*_4S.nVq";
        private readonly string connectionString;

        public ConnectionFactoryMySQL()
        {
            connectionString = $"server={serverDB}; database='{dataBase}'; uid='{user}';  password='{senha}'";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
