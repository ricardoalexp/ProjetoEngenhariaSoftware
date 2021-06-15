using ClinicaTerapeutica.Data.GestorQueries;
using ClinicaTerapeutica.Data.GestorQueries.Queries;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Autenticador
{
    public class Autenticador
    {
        private ExecutorQueries executorQueries;
        private MySqlDataReader dadosQuery;

        public Autenticador()
        {
            executorQueries = new ExecutorQueries();
        }
        public bool AutenticarPaciente(int id, string password)
        {
            dadosQuery = executorQueries.ObterResultadoQuery(new QueryAutenticarPaciente(id, password));
            bool result = dadosQuery.HasRows ? true : false;

            return result;

        }
        public bool AutenticarTerapeuta(int id, string password)
        {
            dadosQuery = executorQueries.ObterResultadoQuery(new QueryAutenticarTerapeuta(id, password));
            bool result = dadosQuery.HasRows ? true : false;

            return result;
        }
    }
}
