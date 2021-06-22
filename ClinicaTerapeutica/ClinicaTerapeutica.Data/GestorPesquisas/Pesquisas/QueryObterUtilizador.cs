using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Pesquisas
{
    class QueryObterUtilizador : IQuery
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
