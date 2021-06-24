
using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Pesquisas
{
    class QueryObterTratamentosPrescricao :IQuery
    {
        private string query;
        public QueryObterTratamentosPrescricao(int idPrescricao)
        {
            query = "SELECT tratamento.* FROM tratamento,prescricao,prescricao_has_tratamento WHERE tratamento.id = prescricao_has_tratamento.tratamento_id AND prescricao.id = prescricao_has_tratamento.prescricao_id AND prescricao.id = '" + idPrescricao + "'";
        }
        public string ObterQuery()
        {
            return this.query;
        }
    }
}
