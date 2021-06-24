using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Pesquisas
{
    class QueryObterExercicios : IQuery
    {
        private string query;

        public QueryObterExercicios()
        {
            query = "SELECT * FROM exercicio";
        }

        public string ObterQuery()
        {
            return this.query;
        }
    }
}
