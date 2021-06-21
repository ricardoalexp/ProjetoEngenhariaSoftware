using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorQueries
{
    class ResultadoQuery : IResultadoQuery
    {
        private MySqlDataReader leitorQuery;

        public ResultadoQuery(MySqlDataReader leitor)
        {
            this.leitorQuery = leitor;
        }
        public MySqlDataReader ObterResultado()
        {
            return leitorQuery;
        }
    }
}
