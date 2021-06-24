using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Pesquisas
{
    class QueryObterMedicamentosPrescricao : IQuery
    {
        private string query;
        public QueryObterMedicamentosPrescricao(int idPrescricao)
        {
            query = "SELECT medicamento.* FROM medicamento,prescricao,prescricao_has_medicamento WHERE medicamento.id = prescricao_has_medicamento.medicamento_id AND prescricao.id = prescricao_has_medicamento.prescricao_id AND prescricao.id = '" + idPrescricao + "'";
        }
        public string ObterQuery()
        {
            return this.query;
        }
    }
}
