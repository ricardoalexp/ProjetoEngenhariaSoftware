using ClinicaTerapeutica.Data.GestorRegistos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorMarcacoes
{
    class RegistadorMarcacoes : IRegistadorMarcacoes
    {
        private GestorRegistos gestorRegistos;
        public bool RegistarConsulta(int duracao, string data, int hora, int idPaciente, int idTerapeuta)
        {
            gestorRegistos = new GestorRegistos();

            return gestorRegistos.ObterRegistadorMarcacoes().RegistarConsulta(duracao, data, hora, idPaciente, idTerapeuta);
        }
    }
}
