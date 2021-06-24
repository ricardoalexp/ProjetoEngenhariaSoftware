using ClinicaTerapeutica.Data.GestorEliminacoes.Eliminadores;
using ClinicaTerapeutica.Data.GestorEliminacoes.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorEliminacoes
{
    public class GestorEliminacoes
    {
        private IEliminadorMarcacoes eliminadorMarcacoes;

        public IEliminadorMarcacoes ObterEliminadorMarcacoes()
        {
            if (eliminadorMarcacoes == null)
            {
                eliminadorMarcacoes = new EliminadorMarcacoes();
            }
            return eliminadorMarcacoes;
        }
    }
}
