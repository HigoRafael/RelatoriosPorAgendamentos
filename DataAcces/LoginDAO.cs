using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    using System;
    using System.Security.Cryptography;
    using MySql.Data.MySqlClient;

    public class LoginDAO : ConnectionFactoryMySQL
    {
        byte[] salt = new byte[16];

        public byte[] GerarSaltAleatorio()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }


        public bool VerifyPassword(string usuario, string senhaFornecida)
        {
            
            using (var connection = GetConnection())
            {
                string query = $"SELECT lg_atendente, sh_atendente FROM sd_atendente WHERE lg_atendente = '{usuario}'";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] hashArmazenado = (byte[])reader["sh_atendente"];
                            string saltString = Convert.ToBase64String(salt);
                            using (var pbkdf2 = new Rfc2898DeriveBytes(senhaFornecida, Encoding.UTF8.GetBytes(saltString), 10000))
                            {
                                byte[] hashFornecido = pbkdf2.GetBytes(20);
                                for (int i = 0; i < 20; i++)
                                {
                                    if (hashArmazenado[i + 16] != hashFornecido[i])
                                    {
                                        return false;
                                    }
                                }
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
    }
}
