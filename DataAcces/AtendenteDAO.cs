using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DataAcces
{
    public class AtendenteDAO : ConnectionFactory
    {
        public DataTable CarregarDadosAtendente()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT CODREP, NOMREP FROM E090REP";
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable result = new DataTable();
                    result.Load(reader);
                    return result;
                }
            }
        }
    }
}
