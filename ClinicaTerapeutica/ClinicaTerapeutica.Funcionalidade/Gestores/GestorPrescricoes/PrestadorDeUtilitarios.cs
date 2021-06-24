using ClinicaTerapeutica.Data.Entidades.Decoradores;
using ClinicaTerapeutica.Data.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorPrescricoes
{
    class PrestadorDeUtilitarios : IPrestadorDeUtilitarios
    {
        public PrescricaoParaMenu ObterDecoradorPrescricaoParaMenu(Prescricao prescricao)
        {
            return new PrescricaoParaMenu(prescricao);
        }
    }
}
