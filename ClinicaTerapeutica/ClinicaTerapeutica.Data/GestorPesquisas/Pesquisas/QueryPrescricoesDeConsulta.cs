using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Pesquisas
{
    class QueryPrescricoesDeConsulta : IQuery
    {
        private string query;

        public QueryPrescricoesDeConsulta(int idConsulta)
        {
            this.query = "SELECT * FROM prescricao WHERE consulta_id = " + idConsulta;
        }

        public string ObterQuery()
        {
            return query;
        }
    }
}
