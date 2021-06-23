using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorMarcacoes
{
    public class GestorMarcacoes
    {
        IPesquisadorMarcacoes pesquisadorMarcacoes;

        public IPesquisadorMarcacoes ObterPesquisadorMarcacoes()
        {
            if (pesquisadorMarcacoes == null)
            {
                pesquisadorMarcacoes = new PesquisadorMarcacoes();
            }
            return pesquisadorMarcacoes;
        }         
    }
}
