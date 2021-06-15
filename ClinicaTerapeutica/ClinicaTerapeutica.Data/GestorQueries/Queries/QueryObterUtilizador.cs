using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaTerapeutica.Data.GestorQueries.Queries
{
    public class QueryObterUtilizador : IQuery
    {
        private string query;

        public QueryObterUtilizador(string nome)
        {
            query = "SELECT * FROM utilizador WHERE nome = '" + nome + "'";
        }

        public string ObterQuery()
        {
            return this.query;
        }
    }
}
