using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos.Insercoes
{
    class InsercaoPrescricao : IQuery
    {
        private string query;

        public InsercaoPrescricao(string validade, string comentario, int idConsulta)
        {
            this.query = "INSERT INTO prescricao VALUES (null,1,'" + validade + "','" + comentario + "'," + idConsulta + ");";
        }
        public string ObterQuery()
        {
            return this.query;
        }
    }
}
