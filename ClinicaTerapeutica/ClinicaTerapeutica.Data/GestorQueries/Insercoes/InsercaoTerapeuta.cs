using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorQueries.Insercoes
{
    class InsercaoTerapeuta :IQuery
    {
        private string query;
        public InsercaoTerapeuta(int id)
        {
            this.query = "INSERT INTO paciente VALUES (" + id + ");";
        }
        public string ObterQuery()
        {
            return query;
        }
    }
}
