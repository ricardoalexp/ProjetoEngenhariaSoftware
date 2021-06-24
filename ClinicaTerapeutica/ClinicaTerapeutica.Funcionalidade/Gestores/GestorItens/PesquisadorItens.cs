using ClinicaTerapeutica.Data.Entidades.Modelos;
using ClinicaTerapeutica.Data.GestorPesquisas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorItens
{
    class PesquisadorItens : IPesquisadorItens
    {
        private GestorPesquisas gestorPesquisas;

        public List<Exercicio> ObterExercicios()
        {
            gestorPesquisas = new();
            return gestorPesquisas.ObterPesquisadorItens().ObterExercicios();
        }

        public List<Exercicio> ObterExerciciosPrescricao(int idPrescricao)
        {
            gestorPesquisas = new();
            return gestorPesquisas.ObterPesquisadorItens().ObterExerciciosPrescricao(idPrescricao);
        }

        public List<Medicamento> ObterMedicamentos()
        {
            gestorPesquisas = new();
            return gestorPesquisas.ObterPesquisadorItens().ObterMedicamentos();
        }

        public List<Medicamento> ObterMedicamentosPrescricao(int idPrescricao)
        {
            gestorPesquisas = new();
            return gestorPesquisas.ObterPesquisadorItens().ObterMedicamentosPrescricao(idPrescricao);
        }

        public List<Tratamento> ObterTratamentos()
        {
            gestorPesquisas = new();
            return gestorPesquisas.ObterPesquisadorItens().ObterTratamentos();
        }

        public List<Tratamento> ObterTratamentosPrescricao(int idPrescricao)
        {
            gestorPesquisas = new();
            return gestorPesquisas.ObterPesquisadorItens().ObterTratamentosPrescricao(idPrescricao);
        }
    }
}
