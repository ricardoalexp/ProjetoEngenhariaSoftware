using ClinicaTerapeutica.Data.Entidades.Adaptadores;
using ClinicaTerapeutica.Data.Entidades.Modelos;
using ClinicaTerapeutica.Data.GestorPesquisas.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Pesquisadores
{
    class PesquisadorItens : IPesquisadorItens
    {
        private ExecutorPesquisas executorPesquisas;
        public List<Exercicio> ObterExercicios()
        {
            executorPesquisas = new ExecutorPesquisas();
            IAdaptadorExercicio adaptador = new AdaptadorExercicio();

            return adaptador.DeSqlParaExercicios(executorPesquisas.ResultadoObterExercicios().ObterResultado());
        }

        public List<Exercicio> ObterExerciciosPrescricao(int idPrescricao)
        {
            executorPesquisas = new ExecutorPesquisas();
            IAdaptadorExercicio adaptador = new AdaptadorExercicio();

            return adaptador.DeSqlParaExercicios(executorPesquisas.ResultadoObterExerciciosDePrescricao(idPrescricao).ObterResultado());
        }

        public List<Medicamento> ObterMedicamentos()
        {
            executorPesquisas = new ExecutorPesquisas();
            IAdaptadorMedicamento adaptador = new AdaptadorMedicamento();

            return adaptador.DeSqlParaMedicamentos(executorPesquisas.ResultadoObterMedicamentos().ObterResultado());
        }

        public List<Tratamento> ObterTratamentos()
        {
            executorPesquisas = new ExecutorPesquisas();
            IAdaptadorTratamento adaptador = new AdaptadorTratamento();

            return adaptador.DeSqlParaTratamentos(executorPesquisas.ResultadoObterTratamentos().ObterResultado());
        }

        public List<Tratamento> ObterTratamentosPrescricao(int idPrescricao)
        {
            executorPesquisas = new ExecutorPesquisas();
            IAdaptadorTratamento adaptador = new AdaptadorTratamento();

            return adaptador.DeSqlParaTratamentos(executorPesquisas.ResultadoObterTratamentosDePrescricao(idPrescricao).ObterResultado());
        }

        List<Medicamento> IPesquisadorItens.ObterMedicamentosPrescricao(int idPrescricao)
        {
            executorPesquisas = new ExecutorPesquisas();
            IAdaptadorMedicamento adaptador = new AdaptadorMedicamento();

            return adaptador.DeSqlParaMedicamentos(executorPesquisas.ResultadoObterMedicamentosDePrescricao(idPrescricao).ObterResultado());
        }
    }
}
