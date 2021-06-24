using ClinicaTerapeutica.Data.GestorRegistos.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos.Registadores
{
    class RegistadorItensEmPrescricoes : IRegistadorItensEmPrescricoes
    {
        private ExecutorInsercoes executorInsercoes;

        public bool RegistarExerciciosEmPrescricao(int idPrescricao, int idExercicio)
        {
            executorInsercoes = new();
            return executorInsercoes.
        }

        public bool RegistarMedicamentoEmPrescricao(int idPrescricao, int idMedicamento)
        {
            throw new NotImplementedException();
        }

        public bool RegistarTratamentoEmPrescricao(int idPrescricao, int idTratamento)
        {
            throw new NotImplementedException();
        }
    }
}
