using ClinicaTerapeutica.Data.GestorEliminacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorMarcacoes
{
    class EliminadorMarcacoes : IEliminadorMarcacoes
    {
        private GestorEliminacoes gestorEliminacoes;
        public bool EliminarConsulta(int idConsulta)
        {
            gestorEliminacoes = new GestorEliminacoes();
            return gestorEliminacoes.ObterEliminadorMarcacoes().EliminarConsulta(idConsulta);
        }
    }
}
