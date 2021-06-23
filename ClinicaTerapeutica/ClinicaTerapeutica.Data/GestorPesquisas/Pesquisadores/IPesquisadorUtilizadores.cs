using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Pesquisadores
{
    public interface IPesquisadorUtilizadores
    {
        bool VerificarLoginPaciente(int id, string password);

        bool VerificarLoginTerapeuta(int id, string password);
    }
}
