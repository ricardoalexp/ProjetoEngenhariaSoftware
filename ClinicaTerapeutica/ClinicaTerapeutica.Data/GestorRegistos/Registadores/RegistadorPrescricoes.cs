using ClinicaTerapeutica.Data.GestorRegistos.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos.Registadores
{
    internal class RegistadorPrescricoes : IRegistadorPrescricoes
    {
        private ExecutorInsercoes executorInsercoes;
        public bool RegistarPrescricao(string validade, string comentario, int idConsulta)
        {
            executorInsercoes = new ExecutorInsercoes();

            int result = executorInsercoes.ResultadoInserirPrescricao(validade, comentario, idConsulta).ObterResultado();
            return result == 0 ? true : false;
        }
    }
}
