using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorItens
{
    
    public class GestorItens
    {
        private IPesquisadorItens pesquisadorItens;

        public IPesquisadorItens ObterPesquisadorItens()
        {
            if (pesquisadorItens == null)
            {
                pesquisadorItens = new PesquisadorItens();
            }
            return pesquisadorItens;
        }
    }
}
