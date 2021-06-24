using ClinicaTerapeutica.Data.GestorRegistos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorItens
{
    class RegistadorItens : IRegistadorItens
    {
        private GestorRegistos gestorRegistos;
        public bool RegistarExerciciosEmPrescricao(int idPrescricao, int idExercicio)
        {
            gestorRegistos = new();
            return gestorRegistos.ObterRegistadorItens().RegistarExerciciosEmPrescricao(idPrescricao, idExercicio);
        }

        public bool RegistarMedicamentoEmPrescricao(int idPrescricao, int idMedicamento)
        {
            gestorRegistos = new();
            return gestorRegistos.ObterRegistadorItens().RegistarMedicamentoEmPrescricao(idPrescricao, idMedicamento);
        }

        public bool RegistarTratamentoEmPrescricao(int idPrescricao, int idTratamento)
        {
            gestorRegistos = new();
            return gestorRegistos.ObterRegistadorItens().RegistarTratamentoEmPrescricao(idPrescricao, idTratamento);
        }
    }
}
