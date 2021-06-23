using ClinicaTerapeutica.Data.GestorRegistos.Registadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos
{
    public class GestorRegistos
    {
        private IRegistadorUtilizadores registadorUtilizadores;

        private IRegistadorMarcacoes registadorMarcacoes;

        private IRegistadorPrescricoes registadorPrescricoes;

        public IRegistadorUtilizadores ObterRegistadorUtilizadores()
        {
            if (registadorUtilizadores == null)
            {
                registadorUtilizadores = new RegistadorUtilizadores();
            }
            return registadorUtilizadores;
        }
        public IRegistadorMarcacoes ObterRegistadorMarcacoes()
        {
            if (registadorMarcacoes == null)
            {
                registadorMarcacoes = new RegistadorMarcacoes();
            }
            return registadorMarcacoes;
        }
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
