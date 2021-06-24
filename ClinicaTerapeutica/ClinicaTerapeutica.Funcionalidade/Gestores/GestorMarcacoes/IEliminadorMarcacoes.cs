using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorMarcacoes
{
    public interface IEliminadorMarcacoes
    {
        bool EliminarConsulta(int idConsulta);
    }
}
