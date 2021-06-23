using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos.Registadores
{
    public interface IRegistadorPrescricoes
    {
        bool RegistarPrescricao(string validade, string comentario, int idConsulta);
    }
}
