using ClinicaTerapeutica.Data.Gerais;
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
        public InsercaoPaciente(string nome, string password, string dataNascimento, string email, int telefone)
        {
            this.query = "INSERT INTO utilizador VALUES (null,'" + nome + "','" + password + "','" + dataNascimento + "','" + email + "'," + telefone + "); INSERT INTO paciente VALUES(LAST_INSERT_ID());";
        }

        public string ObterQuery()
        {
            return query;
        }
    }
}
