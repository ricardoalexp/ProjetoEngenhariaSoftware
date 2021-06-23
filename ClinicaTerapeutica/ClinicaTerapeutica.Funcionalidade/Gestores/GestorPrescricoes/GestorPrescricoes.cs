using ClinicaTerapeutica.Data.GestorRegistos.Registadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorPrescricoes
{
    class GestorPrescricoes
    {
        private IRegistadorPrescricoes registadorPrescricoes;

        public IRegistadorPrescricoes ObterRegistadorPrescricoes()
        {
            if (registadorPrescricoes == null)
            {
                registadorPrescricoes = new RegistadorPrescricoes();
            }
            return registadorPrescricoes;
        }
    }
}
