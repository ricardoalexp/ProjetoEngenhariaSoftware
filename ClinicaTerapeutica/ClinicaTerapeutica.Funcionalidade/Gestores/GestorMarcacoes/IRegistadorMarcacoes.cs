using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorMarcacoes
{
    public interface IRegistadorMarcacoes
    {
        bool RegistarConsulta(int duracao, string data, int hora, int idPaciente, int idTerapeuta);
    }
}
