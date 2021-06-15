using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaTerapeutica.Data.GestorQueries.Queries
{
    public class QueryObterPessoa : IQuery
    {
        private string query;

        public QueryObterPessoa(string nome)
        {
            query = "SELECT * FROM utilizador WHERE nome = '" + nome + "'";
        }

        public string GetQueryResult()
        {
            return this.query;
        }
    }
}
