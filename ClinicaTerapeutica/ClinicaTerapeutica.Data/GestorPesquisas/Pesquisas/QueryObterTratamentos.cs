using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Pesquisas
{
    class QueryObterTratamentos : IQuery
    {
        private string query;

        public QueryObterTratamentos()
        {
            query = "SELECT * FROM tratamento";
        }

        public string ObterQuery()
        {
            return this.query;
        }
    }
}
