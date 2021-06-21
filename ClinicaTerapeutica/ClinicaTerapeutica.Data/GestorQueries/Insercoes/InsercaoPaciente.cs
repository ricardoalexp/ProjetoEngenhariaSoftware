using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorQueries.Insercoes
{
    class InsercaoPaciente : IQuery
    {
        private string query;
        public InsercaoPaciente(int id)
        {
            this.query = "INSERT INTO paciente VALUES (" + id + ");";
        }
        public string ObterQuery()
        {
            return query;
        }
    }
}
