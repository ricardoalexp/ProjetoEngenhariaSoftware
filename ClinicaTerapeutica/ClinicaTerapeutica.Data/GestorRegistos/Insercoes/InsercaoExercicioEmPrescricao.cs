using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos.Insercoes
{
    class InsercaoExercicioEmPrescricao :IQuery
    {
        private string query;
        public InsercaoExercicioEmPrescricao(int idPrescricao, int idExercicio)
        {
            this.query = "INSERT INTO prescricao_has_medicamento VALUES (" + idPrescricao + "," + idExercicio + ");";
        }

        public string ObterQuery()
        {
            return query;
        }
    }
}
