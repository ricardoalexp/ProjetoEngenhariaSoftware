using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Pesquisas
{
    class QueryObterMedicamentos : IQuery
    {
        private string query;

        public QueryObterMedicamentos()
        {
            query = "SELECT * FROM medicamento";
        }

        public string ObterQuery()
        {
            return this.query;
        }
    }
}
