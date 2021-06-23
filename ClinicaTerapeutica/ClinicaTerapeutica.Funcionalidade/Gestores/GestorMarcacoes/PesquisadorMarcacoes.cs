using ClinicaTerapeutica.Data.Entidades.Modelos;
using ClinicaTerapeutica.Data.GestorPesquisas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorMarcacoes
{
    class PesquisadorMarcacoes : IPesquisadorMarcacoes
    {
        GestorPesquisas gestorPesquisas;
        public List<Consulta> ObterConsultasPaciente(int id)
        {
            gestorPesquisas = new();

            return gestorPesquisas.ObterPesquisadorMarcacoes().ObterConsultasPaciente(id);
        }
    }
}
