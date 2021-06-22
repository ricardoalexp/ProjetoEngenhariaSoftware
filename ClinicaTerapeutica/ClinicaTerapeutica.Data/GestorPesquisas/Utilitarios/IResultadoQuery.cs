using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Utilitarios
{
    public interface IResultadoQuery
    {
        MySqlDataReader ObterResultado();
    }
}
