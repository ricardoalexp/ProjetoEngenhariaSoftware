using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos.Insercoes
{
    class InsercaoTratamentoEmPrescricao :IQuery
    {
        private string query;
        public InsercaoTratamentoEmPrescricao(int idPrescricao, int idTratamento)
        {
            this.query = "INSERT INTO prescricao_has_tratamento VALUES (" + idPrescricao + "," + idTratamento + ");";
        }

        public string ObterQuery()
        {
            return query;
        }
    }
}
