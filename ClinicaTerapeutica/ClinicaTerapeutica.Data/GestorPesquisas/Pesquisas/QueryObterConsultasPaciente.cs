using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Pesquisas
{
    class QueryObterConsultasPaciente : IQuery
    {
        private string query;

        public QueryObterConsultasPaciente(int idPaciente)
        {
            query = "SELECT * FROM consulta WHERE paciente_utilizador_id = " + idPaciente;
        }

        public string ObterQuery()
        {
            return this.query;
        }
    }
}
