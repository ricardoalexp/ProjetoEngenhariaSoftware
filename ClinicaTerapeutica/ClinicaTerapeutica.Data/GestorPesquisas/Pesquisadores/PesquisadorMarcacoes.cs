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
    class PesquisadorMarcacoes : IPesquisadorMarcacoes
    {
        private ExecutorPesquisas executorPesquisas;
        public List<Consulta> ObterConsultasPaciente(int id)
        {
            IAdaptadorConsulta adaptador = new AdaptadorConsulta();
            executorPesquisas = new ExecutorPesquisas();

            return adaptador.DeSqlParaConsultas(executorPesquisas.ResultadoObterConsultasPaciente(id).ObterResultado());
        }

        public bool PodeEliminarConsulta(int idConsulta)
        {
            executorPesquisas = new ExecutorPesquisas();
            return executorPesquisas.ResultadoPodeEliminarConsulta(idConsulta).ObterResultado().HasRows ? false : true;
        }
    }
}
