using ClinicaTerapeutica.Data.GestorQueries;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Autenticadores
{
    class AutenticadorUtilizadores : IAutenticadorUtilizadores
    {
        private ExecutorQueries executorQueries;
        private MySqlDataReader dadosQuery;

        public AutenticadorUtilizadores()
        {
            executorQueries = new ExecutorQueries();
        }
        public bool AutenticarPaciente(int id, string password)
        {
            dadosQuery = executorQueries.ResultadoAutenticarPaciente(id, password).ObterResultado();
            bool result = dadosQuery.HasRows ? true : false;

            return result;

        }
        public bool AutenticarTerapeuta(int id, string password)
        {
            dadosQuery = executorQueries.ResultadoAutenticarTerapeuta(id, password).ObterResultado();
            bool result = dadosQuery.HasRows ? true : false;

            return result;
        }
    }
}
