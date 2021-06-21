using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorQueries.Queries
{
    class QueryAutenticarPaciente : IQuery
    {
        private string query;
        public QueryAutenticarPaciente(int idPaciente, string password)
        {
            query = "SELECT * FROM utilizador,paciente WHERE utilizador.id = paciente.utilizador_id AND utilizador.id = " + idPaciente + " AND utilizador.password = '" + password + "'";
        }
        public string ObterQuery()
        {
            return this.query;
        }
    }
}
