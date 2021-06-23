using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos.Registadores
{
    public interface IRegistadorMarcacoes
    {
        bool RegistarConsulta(int duracao, string data, int hora,int idPaciente, int idTerapeuta);

        // bool RegistarSessao(int idPaciente, int idTerapeuta, int idTratamento, string email, int telefone);
    }
}
