
using ClinicaTerapeutica.Data.GestorRegistos.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos.Registadores
{
    class RegistadorMarcacoes : IRegistadorMarcacoes
    {
        private ExecutorInsercoes executorQueries;

        public bool RegistarConsulta(int duracao, string data, int hora, int idPaciente, int idTerapeuta)
        {
            executorQueries = new ExecutorInsercoes();

            int result = executorQueries.ResultadoInserirConsulta(duracao, data, hora, idPaciente, idTerapeuta).ObterResultado();

            return result == 0 ? true : false;
        }
    }
}
