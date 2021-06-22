using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos.Utilitarios
{
    class ResultadoInsercao : IResultadoInsercao
    {
        private int newId;
        public ResultadoInsercao(int newId)
        {
            this.newId = newId;
        }
        public int ObterResultado()
        {
            return newId;
        }
    }
}
