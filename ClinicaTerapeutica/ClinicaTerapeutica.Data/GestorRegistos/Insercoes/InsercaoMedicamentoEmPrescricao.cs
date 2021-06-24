using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos.Insercoes
{
    class InsercaoMedicamentoEmPrescricao : IQuery
    {
        private string query;
        public InsercaoMedicamentoEmPrescricao(int idPrescricao, int idMedicamento)
        {
            this.query = "INSERT INTO prescricao_has_medicamento VALUES (" + idPrescricao + "," + idMedicamento + ");";
        }

        public string ObterQuery()
        {
            return query;
        }
    }
}
