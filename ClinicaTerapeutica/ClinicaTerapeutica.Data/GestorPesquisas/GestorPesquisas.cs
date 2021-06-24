using ClinicaTerapeutica.Data.GestorPesquisas.Pesquisadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas
{
    public class GestorPesquisas
    {
        IPesquisadorUtilizadores pesquisadorUtilizadores;

        IPesquisadorMarcacoes pesquisadorMarcacoes;

        IPesquisadorPrescricoes pesquisadorPrescricoes;

        IPesquisadorItens pesquisadorItens;

        public IPesquisadorUtilizadores ObterPesquisadorUtilizadores()
        {
            if (pesquisadorUtilizadores == null)
            {
                pesquisadorUtilizadores = new PesquisadorUtilizadores();
            }
            return pesquisadorUtilizadores;
        }
        public IPesquisadorMarcacoes ObterPesquisadorMarcacoes()
        {
            if (pesquisadorMarcacoes == null)
            {
                pesquisadorMarcacoes = new PesquisadorMarcacoes();
            }
            return pesquisadorMarcacoes;
        }
        public IPesquisadorPrescricoes ObterPesquisadorPrescricoes()
        {
            if (pesquisadorPrescricoes == null)
            {
                pesquisadorPrescricoes = new PesquisadorPrescricoes();
            }
            return pesquisadorPrescricoes;
        }
        public IPesquisadorItens ObterPesquisadorItens()
        {
            if (pesquisadorItens == null)
            {
                pesquisadorItens = new PesquisadorItens();
            }
            return pesquisadorItens;
        }

    }
}
