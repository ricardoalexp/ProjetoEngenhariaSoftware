using ClinicaTerapeutica.Data.GestorRegistos.Registadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorPrescricoes
{
    public class GestorPrescricoes
    {
        private IRegistadorPrescricoes registadorPrescricoes;

        private IPesquisadorPrescricoes pesquisadorPrescricoes;

        private IPrestadorDeUtilitarios prestadorDeUtilitarios;
        public IRegistadorPrescricoes ObterRegistadorPrescricoes()
        {
            if (registadorPrescricoes == null)
            {
                registadorPrescricoes = new RegistadorPrescricoes();
            }
            return registadorPrescricoes;
        }
        public IPesquisadorPrescricoes ObterPesquisadorPrescricoes()
        {
            if (pesquisadorPrescricoes == null)
            {
                pesquisadorPrescricoes = new PesquisadorPrescricoes();
            }
            return pesquisadorPrescricoes;
        }
        public IPrestadorDeUtilitarios ObterPrestadorDeUtilitarios()
        {
            if (prestadorDeUtilitarios == null)
            {
                prestadorDeUtilitarios = new PrestadorDeUtilitarios();
            }
            return prestadorDeUtilitarios;
        }
    }
}
