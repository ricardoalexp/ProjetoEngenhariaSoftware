using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorQueries.Queries
{
    class QueryAutenticarTerapeuta : IQuery

    {
        private string query;
        public QueryAutenticarTerapeuta(int idTerapeuta, string password)
        {
            query = "SELECT * FROM utilizador,terapeuta WHERE utilizador.id = terapeuta.utilizador_id AND utilizador.id = " + idTerapeuta + " AND utilizador.password = '" + password + "'";
        }
        public string ObterQuery()
        {
            return this.query;
        }
    }
}
