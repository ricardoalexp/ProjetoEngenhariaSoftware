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

        public MySqlDataReader ExecutarQuery(IQuery query)
        {
            MySqlDataReader leitorQuery = null;
            MySqlCommand commandDatabase = new MySqlCommand(query.GetQueryResult(), conexao);
            leitorQuery = commandDatabase.ExecuteReader();

            return leitorQuery;
        }
    }
}
