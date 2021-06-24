using ClinicaTerapeutica.Data.GestorEliminacoes.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorEliminacoes.Eliminadores
{
    class EliminadorMarcacoes : IEliminadorMarcacoes
    {
        private ExecutorEliminacoes executorEliminacoes;
        public bool EliminarConsulta(int idConsulta)
        {
            executorEliminacoes = new ExecutorEliminacoes();

            return executorEliminacoes.EliminarConsulta(idConsulta).ObterResultado();
        }
    }
}
