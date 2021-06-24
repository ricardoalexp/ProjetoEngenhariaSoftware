using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorEliminacoes.Eliminacoes
{
    internal class EliminacaoConsulta : IQuery
    {
        private string query;

        public EliminacaoConsulta(int idConsulta)
        {
            this.query = "DELETE FROM consulta WHERE consulta.id =" + idConsulta ;
        }
        public string ObterQuery()
        {
            return query;
        }
    }
}
