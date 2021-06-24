using ClinicaTerapeutica.Data.Entidades.Modelos;
using ClinicaTerapeutica.Data.GestorPesquisas.Pesquisadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.Entidades.Decoradores
{
    public class PrescricaoParaMenu : DecoradorPrescricao
    {
        public PrescricaoParaMenu(Prescricao prescricao) : base(prescricao) { }

        public override string ObterDescricao()
        {
            return prescricao.ObterDescricao() + "\n" + AdicionarExercicios() + AdicionarMedicamentos() + AdicionarTratamentos();
        }

        public string AdicionarTratamentos()
        {
            IPesquisadorItens pesquisador = new PesquisadorItens();
            List<Tratamento> lista = pesquisador.ObterTratamentosPrescricao(prescricao.Id);

            string texto = "";
            if (lista.Count > 0)
            {
                texto += "\nTratamentos:\n\n";
                for (int i = 0; i < lista.Count; i++)
                {
                    texto += lista[i].ToString() + "\n";
                }

            } 
            return texto;
        }
        public string AdicionarMedicamentos()
        {
            IPesquisadorItens pesquisador = new PesquisadorItens();
            List<Medicamento> lista = pesquisador.ObterMedicamentosPrescricao(prescricao.Id);

            string texto = "";
            if (lista.Count > 0)
            {
                texto += "\nMedicamentos:\n\n";
                for (int i = 0; i < lista.Count; i++)
                {
                    texto += lista[i].ToString() + "\n";
                }

            }
            return texto;
        }
        public string AdicionarExercicios()
        {
            IPesquisadorItens pesquisador = new PesquisadorItens();
            List<Exercicio> lista = pesquisador.ObterExerciciosPrescricao(prescricao.Id);

            string texto = "";
            if (lista.Count > 0)
            {
                texto += "\nExercicios:\n\n";
                for (int i = 0; i < lista.Count; i++)
                {
                    texto += lista[i].ToString() + "\n";
                }

            }
            return texto;
        }
    }
}
