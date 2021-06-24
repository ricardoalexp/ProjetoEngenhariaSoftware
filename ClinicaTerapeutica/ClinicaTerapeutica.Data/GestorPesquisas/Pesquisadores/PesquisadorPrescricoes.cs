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
    class PesquisadorPrescricoes : IPesquisadorPrescricoes
    {
        private ExecutorPesquisas executorPesquisas;

        public List<Prescricao> ObterPrescricoesPaciente(int id)
        {
            executorPesquisas = new ExecutorPesquisas();
            IAdaptadorPrescricao adaptador = new AdaptadorPrescricao();

            return adaptador.DeSqlParaPrescricoes(executorPesquisas.ResultadoObterPrescricoesPaciente(id).ObterResultado());
        }
        public List<Prescricao> ObterPrescricoesTerapeuta(int id)
        {
            executorPesquisas = new ExecutorPesquisas();
            IAdaptadorPrescricao adaptador = new AdaptadorPrescricao();

            return adaptador.DeSqlParaPrescricoes(executorPesquisas.ResultadoObterPrescricoesTerapeuta(id).ObterResultado());
        }
    }
}
