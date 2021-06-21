using ClinicaTerapeutica.Data.GestorQueries.Queries;
using ClinicaTerapeutica.Data.GestorQueries.Insercoes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaTerapeutica.Data.GestorQueries
{
    public class ExecutorQueries
    {
        private IQuery querySelecionada;

        private IResultadoQuery ExecutarQuery(IQuery query)
        {
            MySqlConnection conexao = ConectorBDMySQL.GetInstance.GetConnection();
            MySqlCommand commandDatabase = new MySqlCommand(query.ObterQuery(), conexao);
            MySqlDataReader leitorQuery = commandDatabase.ExecuteReader();

            IResultadoQuery resultado = new ResultadoQuery(leitorQuery);

            return resultado;
        }
        private IResultadoInsercao ExecutarInsercao(IQuery query)
        {
            string queryAlterada = query.ObterQuery() + "SELECT CAST(scope_identity() AS int)";
            MySqlConnection conexao = ConectorBDMySQL.GetInstance.GetConnection();
            MySqlCommand commandDatabase = new MySqlCommand(queryAlterada, conexao);

            int newId;
            if((newId = (int)commandDatabase.ExecuteScalar()) > 0)
            {
                return new ResultadoInsercao(newId);
            }
            else
            {
                return new ResultadoInsercao(0);
            }
        }

        public IResultadoQuery ResultadoAutenticarPaciente(int id, string password)
        {
            querySelecionada = new QueryAutenticarPaciente(id, password);
            return ExecutarQuery(querySelecionada);
        }

        public IResultadoQuery ResultadoAutenticarTerapeuta(int id, string password)
        {
            querySelecionada = new QueryAutenticarTerapeuta(id, password);
            return ExecutarQuery(querySelecionada);
        }

        public IResultadoInsercao ResultadoInserirUtilizador(string nome, string password, string dataNascimento, string email, int telefone)
        {
            querySelecionada = new InsercaoUtilizador(nome, password, dataNascimento, email, telefone);
            return ExecutarInsercao(querySelecionada);
        }

    }
}
