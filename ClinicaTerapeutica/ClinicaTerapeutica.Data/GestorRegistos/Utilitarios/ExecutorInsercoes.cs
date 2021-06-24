using ClinicaTerapeutica.Data.Gerais;
using ClinicaTerapeutica.Data.GestorRegistos.Insercoes;
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
            try
            {
                if ((newId = Convert.ToInt32(commandDatabase.ExecuteScalar())) > 0)
                {
                    return new ResultadoInsercao(newId);
                }
                else
                {
                    return new ResultadoInsercao(0);
                }
            }
            catch
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
            querySelecionada = new InsercaoConsulta(duracao, data, hora, idPaciente, idTerapeuta);
            return ExecutarInsercao(querySelecionada);
        }
        public IResultadoInsercao ResultadoInserirPrescricao(string validade, string comentario, int idConsulta)
        {
            querySelecionada = new InsercaoPrescricao(validade,comentario,idConsulta);
            return ExecutarInsercao(querySelecionada);
        }
        public IResultadoInsercao ResultadoInserirMedicamentoEmPrescricao(int idPrescricao, int idMedicamento)
        {
            querySelecionada = new InsercaoMedicamentoEmPrescricao(idPrescricao,idMedicamento);
            return ExecutarInsercao(querySelecionada);
        }
        public IResultadoInsercao ResultadoInserirTratamentoEmPrescricao(int idPrescricao, int idTratamento)
        {
            querySelecionada = new InsercaoTratamentoEmPrescricao(idPrescricao,idTratamento);
            return ExecutarInsercao(querySelecionada);
        }
        public IResultadoInsercao ResultadoInserirExercicioEmPrescricao(int idPrescricao, int idExercicio)
        {
            querySelecionada = new InsercaoExercicioEmPrescricao(idPrescricao,idExercicio);
            return ExecutarInsercao(querySelecionada);
        }
    }
}
