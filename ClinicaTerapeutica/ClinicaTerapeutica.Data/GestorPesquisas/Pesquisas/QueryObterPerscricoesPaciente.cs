using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Pesquisas
{
    class QueryObterPerscricoesPaciente : IQuery
    {

        private string query;

        public QueryObterPerscricoesPaciente(int id)
        {
            query = "SELECT* FROM prescricao, consulta WHERE consulta.id = prescricao.consulta_id AND paciente_utilizador_id = " + id;
        }

        public string ObterQuery()
        {
            return this.query;
        }
    }
}