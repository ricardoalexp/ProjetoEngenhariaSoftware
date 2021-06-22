using MySql.Data.MySqlClient;
using System;

namespace ClinicaTerapeutica.Data
{
    public sealed class ConectorBDMySQL
    {
        private static string conexao = "datasource=127.0.0.1;port=3306;username=root;password=;database=clinicdb;";
        private static MySqlConnection ConexaoBD { get; set; }

        private static ConectorBDMySQL instance = null;
        public static ConectorBDMySQL GetInstance
        {
            get
            {                
                if (instance == null)
                    instance = new ConectorBDMySQL();
                return instance;
            }
        }

        public MySqlConnection GetConnection()
        {
            if (ConexaoBD != null)
            {
                ConexaoBD.Close();
            }
            ConexaoBD = new MySqlConnection(conexao);
            ConexaoBD.Open();
            return ConexaoBD;
        }

        private ConectorBDMySQL() { }
    }
}


