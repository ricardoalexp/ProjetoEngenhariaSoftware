using ClinicaTerapeutica.Data.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorMarcacoes
{
    public interface IPesquisadorMarcacoes
    {
        List<Consulta> ObterConsultasPaciente(int id);
    }
}
