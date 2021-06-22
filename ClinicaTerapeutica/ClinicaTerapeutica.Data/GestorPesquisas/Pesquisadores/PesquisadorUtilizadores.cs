using ClinicaTerapeutica.Data.GestorPesquisas.Utilitarios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Pesquisadores
{
    class PesquisadorUtilizadores : IPesquisadorUtilizadores
    {
        private ExecutorPesquisas executorPesquisas;
        private MySqlDataReader dadosQuery;

        public bool VerificarLoginPaciente(int id, string password)
        {
            executorPesquisas = new ExecutorPesquisas();
            dadosQuery = executorPesquisas.ResultadoAutenticarPaciente(id, password).ObterResultado();

            return dadosQuery.HasRows ? true : false;
        }

        public bool VerificarLoginTerapeuta(int id, string password)
        {
            executorPesquisas = new ExecutorPesquisas();
            dadosQuery = executorPesquisas.ResultadoAutenticarTerapeuta(id, password).ObterResultado();

            return dadosQuery.HasRows ? true : false;
        }
    }
}
