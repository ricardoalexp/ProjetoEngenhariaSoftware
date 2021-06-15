using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaTerapeutica.Data.GestorQueries
{
    public class ExecutorQueries
    {
        private MySqlConnection conexao;
        public ExecutorQueries()
        {
            conexao = ConectorBDMySQL.ConexaoBD;
        }

        public MySqlDataReader ObterResultadoQuery(IQuery query)
        {
            MySqlCommand commandDatabase = new MySqlCommand(query.ObterQuery(), conexao);
            MySqlDataReader leitorQuery = commandDatabase.ExecuteReader();

            return leitorQuery;
        }
    }
}
