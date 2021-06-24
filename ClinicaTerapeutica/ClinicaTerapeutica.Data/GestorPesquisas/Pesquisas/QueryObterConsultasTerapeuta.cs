using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Pesquisas
{
    class QueryObterConsultasTerapeuta :IQuery
    {
        private string query;

        public QueryObterConsultasTerapeuta(int id)
        {
            query = "SELECT* FROM consulta WHERE terapeuta_utilizador_id = " + id;
        }

        public string ObterQuery()
        {
            return this.query;
        }
    }
}
