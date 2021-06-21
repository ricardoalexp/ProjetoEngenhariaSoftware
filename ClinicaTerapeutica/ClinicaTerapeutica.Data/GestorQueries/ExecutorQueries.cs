using ClinicaTerapeutica.Data.GestorQueries.Queries;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaTerapeutica.Data.GestorQueries
{
    public class ExecutorQueries
    {
        private MySqlConnection conexao;

        private IQuery query;
        public ExecutorQueries()
        {
            conexao = ConectorBDMySQL.ConexaoBD;
        }

        private IResultadoQuery ExecutarQuery(IQuery query)
        {

            MySqlCommand commandDatabase = new MySqlCommand(query.ObterQuery(), conexao);
            MySqlDataReader leitorQuery = commandDatabase.ExecuteReader();

            IResultadoQuery resultado = new ResultadoQuery(leitorQuery);

            return resultado;
        }

        public IResultadoQuery ResultadoAutenticarPaciente(int id, string password)
        {
            query = new QueryAutenticarPaciente(id, password);
            return ExecutarQuery(query);
        }
        public IResultadoQuery ResultadoAutenticarTerapeuta(int id, string password)
        {
            query = new QueryAutenticarPaciente(id, password);
            return ExecutarQuery(query);
        }
    }
}
