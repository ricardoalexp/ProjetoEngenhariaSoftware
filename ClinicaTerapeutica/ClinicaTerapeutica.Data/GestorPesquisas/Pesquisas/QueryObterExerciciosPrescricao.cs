using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Pesquisas
{
    class QueryObterExerciciosPrescricao :IQuery
    {
        private string query;
        public QueryObterExerciciosPrescricao(int idPrescricao)
        {
            query = "SELECT exercicio.* FROM exercicio,prescricao,prescricao_has_exercicio WHERE exercicio.id = prescricao_has_exercicio.exercicio_id AND prescricao.id = prescricao_has_exercicio.prescricao_id AND prescricao.id = '" + idPrescricao + "'";
        }
        public string ObterQuery()
        {
            return this.query;
        }
    }
}
