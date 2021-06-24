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
            int result = executorInsercoes.ResultadoInserirExercicioEmPrescricao(idPrescricao,idExercicio).ObterResultado();

            return result == 0 ? true : false;
        }

        public bool RegistarMedicamentoEmPrescricao(int idPrescricao, int idMedicamento)
        {
            executorInsercoes = new();
            int result = executorInsercoes.ResultadoInserirMedicamentoEmPrescricao(idPrescricao, idMedicamento).ObterResultado();

            return result == 0 ? true : false;
        }

        public bool RegistarTratamentoEmPrescricao(int idPrescricao, int idTratamento)
        {
            executorInsercoes = new();
            int result = executorInsercoes.ResultadoInserirTratamentoEmPrescricao(idPrescricao, idTratamento).ObterResultado();

            return result == 0 ? true : false;
        }
    }
}
