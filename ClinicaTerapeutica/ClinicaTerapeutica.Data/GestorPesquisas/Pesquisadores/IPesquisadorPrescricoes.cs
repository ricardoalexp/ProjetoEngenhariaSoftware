using ClinicaTerapeutica.Data.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Pesquisadores
{
    public interface IPesquisadorPrescricoes
    {
        List<Prescricao> ObterPrescricoesPaciente(int id);

        List<Prescricao> ObterPrescricoesTerapeuta(int id);
    }
}
