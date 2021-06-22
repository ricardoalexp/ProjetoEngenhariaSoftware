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
            string queryAlterada = query.ObterQuery() + "SELECT LAST_INSERT_ID()";
            MySqlConnection conexao = ConectorBDMySQL.GetInstance.GetConnection();
            MySqlCommand commandDatabase = new MySqlCommand(queryAlterada, conexao);

            int newId;
            if((newId = Convert.ToInt32(commandDatabase.ExecuteScalar())) > 0)
            {
                return new ResultadoInsercao(newId);
            }
            else
            {
                return new ResultadoInsercao(0);
            }
        }
        public IResultadoQuery ResultadoObterConsultasPaciente(int id)
        {
            querySelecionada = new QueryObterConsultasPaciente(id);
            return ExecutarQuery(querySelecionada);
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

        public IResultadoInsercao ResultadoInserirPaciente(string nome, string password, string dataNascimento, string email, int telefone)
        {
            querySelecionada = new InsercaoPaciente(nome, password, dataNascimento, email, telefone);
            return ExecutarInsercao(querySelecionada);
        }

        public IResultadoInsercao ResultadoInserirTerapeuta(string nome, string password, string dataNascimento, string email, int telefone)
        {
            querySelecionada = new InsercaoTerapeuta(nome, password, dataNascimento, email, telefone);
            return ExecutarInsercao(querySelecionada);
        }

    }
}
