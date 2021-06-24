using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos.Registadores
{
    interface IRegistadorItensEmPrescricoes
    {
        bool RegistarMedicamentoEmPrescricao(int idPrescricao, int idMedicamento);
        bool RegistarTratamentoEmPrescricao(int idPrescricao, int idTratamento);
        bool RegistarExerciciosEmPrescricao(int idPrescricao, int idExercicio);
    }
}
