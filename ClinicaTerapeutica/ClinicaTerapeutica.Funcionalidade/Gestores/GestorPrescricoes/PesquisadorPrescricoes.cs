using ClinicaTerapeutica.Data.Entidades.Modelos;
using ClinicaTerapeutica.Data.GestorPesquisas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorPrescricoes
{
    class PesquisadorPrescricoes : IPesquisadorPrescricoes
    {
        private GestorPesquisas gestorPesquisas;

        public List<Prescricao> ObterPrescricoesPaciente(int id)
        {
            gestorPesquisas = new GestorPesquisas();
            return gestorPesquisas.ObterPesquisadorPrescricoes().ObterPrescricoesPaciente(id);
        }

        public List<Prescricao> ObterPrescricoesTerapeuta(int id)
        {
            gestorPesquisas = new GestorPesquisas();
            return gestorPesquisas.ObterPesquisadorPrescricoes().ObterPrescricoesTerapeuta(id);
        }
    }
}
