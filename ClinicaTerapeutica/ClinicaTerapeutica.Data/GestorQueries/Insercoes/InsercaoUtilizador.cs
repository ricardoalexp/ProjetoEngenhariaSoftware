using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorQueries.Insercoes
{
    class InsercaoUtilizador : IQuery
    {
        private string query;
        public InsercaoUtilizador(string nome,string password, string dataNascimento, string email, int telefone)
        {
            this.query = "INSERT INTO utilizador VALUES (null,'" + nome + "','" + password + "','" + dataNascimento + "','" + email + "'," + telefone + ");";
        }
        public string ObterQuery()
        {
            return query;
        }
    }
}
