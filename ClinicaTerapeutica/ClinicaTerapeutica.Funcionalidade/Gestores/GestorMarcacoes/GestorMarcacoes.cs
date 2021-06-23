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

        IRegistadorMarcacoes registadorMarcacoes;

        public IPesquisadorMarcacoes ObterPesquisadorMarcacoes()
        {
            if (pesquisadorMarcacoes == null)
            {
                pesquisadorMarcacoes = new PesquisadorMarcacoes();
            }
            return pesquisadorMarcacoes;
        }

        public IRegistadorMarcacoes ObterRegistadorMarcacoes()
        {
            if (registadorMarcacoes == null)
            {
                registadorMarcacoes = new RegistadorMarcacoes();
            }
            return registadorMarcacoes;
        }
    }
}
