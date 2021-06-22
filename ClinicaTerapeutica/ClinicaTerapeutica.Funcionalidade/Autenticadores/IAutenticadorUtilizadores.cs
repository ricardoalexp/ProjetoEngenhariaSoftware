using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Autenticadores
{
    public interface IAutenticadorUtilizadores
    {
        bool AutenticarPaciente(int id, string password);
        bool AutenticarTerapeuta(int id, string password);
    }
}
