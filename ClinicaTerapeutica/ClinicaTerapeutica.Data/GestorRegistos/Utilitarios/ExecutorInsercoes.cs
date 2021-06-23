using ClinicaTerapeutica.Data.Gerais;
using ClinicaTerapeutica.Data.GestorQueries;
using ClinicaTerapeutica.Data.GestorQueries.Insercoes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos.Utilitarios
{
    class ExecutorInsercoes
    {
        IQuery querySelecionada;

        private IResultadoInsercao ExecutarInsercao(IQuery query)
        {
            string queryAlterada = query.ObterQuery() + "SELECT LAST_INSERT_ID()";
            MySqlConnection conexao = ConectorBDMySQL.GetInstance.GetConnection();
            MySqlCommand commandDatabase = new MySqlCommand(queryAlterada, conexao);

            int newId;
            if ((newId = Convert.ToInt32(commandDatabase.ExecuteScalar())) > 0)
            {
                return new ResultadoInsercao(newId);
            }
            else
            {
                return new ResultadoInsercao(0);
            }
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
        public IResultadoInsercao ResultadoInserirConsulta(int duracao, string data, int hora, int idPaciente, int idTerapeuta)
        {
            return null;
        }
    }
}
