using MySql.Data.MySqlClient;
using System;

namespace ClinicaTerapeutica.Data
{
    public class ConectorBDMySQL
    {
        private static string conexao = "datasource=127.0.0.1;port=3306;username=root;password=;database=clinicdb;";
        public static MySqlConnection ConexaoBD { get; }

        static ConectorBDMySQL()
        {
            ConexaoBD = new MySqlConnection(conexao);
            ConexaoBD.Open();
        }
    }
}
