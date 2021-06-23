using ClinicaTerapeutica.Data.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos.Insercoes
{
    class InsercaoConsulta : IQuery
    {
        private string query;
        public InsercaoConsulta(int duracao, string data, int hora, int idPaciente, int idTerapeuta)
        {
            this.query = "INSERT INTO consulta VALUES (null," + duracao + ",'" + data + "'," + hora + "," + idPaciente + "," + idTerapeuta + ");";
        }

        public string ObterQuery()
        {
            return query;
        }
    }
}
