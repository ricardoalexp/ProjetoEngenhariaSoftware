using ClinicaTerapeutica.Data.Gerais;
using ClinicaTerapeutica.Data.GestorPesquisas.Pesquisas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Utilitarios
{
    public class ExecutorPesquisas
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

        public IResultadoQuery ResultadoObterConsultasPaciente(int id)
        {
            querySelecionada = new QueryObterConsultasPaciente(id);
            return ExecutarQuery(querySelecionada);
        }
        public IResultadoQuery ResultadoObterConsultasTerapeuta(int id)
        {
            querySelecionada = new QueryObterConsultasTerapeuta(id);
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
        public IResultadoQuery ResultadoObterPrescricoesPaciente(int id)
        {
            querySelecionada = new QueryObterPrescricoesPaciente(id);
            return ExecutarQuery(querySelecionada);
        }
        public IResultadoQuery ResultadoObterPrescricoesTerapeuta(int id)
        {
            querySelecionada = new QueryObterPrescricoesTerapeuta(id);
            return ExecutarQuery(querySelecionada);
        }
        public IResultadoQuery ResultadoPodeEliminarConsulta(int idConsulta)
        {
            querySelecionada = new QueryPrescricoesDeConsulta(idConsulta);
            return ExecutarQuery(querySelecionada);
        }
        public IResultadoQuery ResultadoObterMedicamentos()
        {
            querySelecionada = new QueryObterMedicamentos();
            return ExecutarQuery(querySelecionada);
        }
        public IResultadoQuery ResultadoObterTratamentos()
        {
            querySelecionada = new QueryObterTratamentos();
            return ExecutarQuery(querySelecionada);
        }
        public IResultadoQuery ResultadoObterExercicios()
        {
            querySelecionada = new QueryObterExercicios();
            return ExecutarQuery(querySelecionada);
        }
        public IResultadoQuery ResultadoObterMedicamentosDePrescricao(int idPrescricao)
        {
            querySelecionada = new QueryObterMedicamentosPrescricao(idPrescricao);
            return ExecutarQuery(querySelecionada);
        }
        public IResultadoQuery ResultadoObterTratamentosDePrescricao(int idPrescricao)
        {
            querySelecionada = new QueryObterTratamentosPrescricao(idPrescricao);
            return ExecutarQuery(querySelecionada);
        }
        public IResultadoQuery ResultadoObterExerciciosDePrescricao(int idPrescricao)
        {
            querySelecionada = new QueryObterExerciciosPrescricao(idPrescricao);
            return ExecutarQuery(querySelecionada);
        }

    }
}
