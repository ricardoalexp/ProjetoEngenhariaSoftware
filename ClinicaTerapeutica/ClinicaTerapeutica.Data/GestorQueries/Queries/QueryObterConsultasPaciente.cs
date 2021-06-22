using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorQueries.Queries
{
    class QueryObterConsultasPaciente : IQuery
    {
        private string query;

        public QueryObterConsultasPaciente(int id)
        {
            query = "SELECT * FROM consulta WHERE paciente_utilizador_id = " + id;
        }

        public string ObterQuery()
        {
            return this.query;
        }
    }
}
