using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorEliminacoes.Utilitarios
{
    class ResultadoEliminacao : IResultadoEliminacao
    {
        private bool resultado;

        public ResultadoEliminacao(bool resultado)
        {
            this.resultado = resultado;
        }
        public bool ObterResultado()
        {
            return this.resultado;
        }
    }
}
