using ClinicaTerapeutica.Data.Entidades.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.Entidades.Adaptadores
{
    internal interface IAdaptadorConsulta
    {
        List<Consulta> DeSqlParaConsultas(MySqlDataReader dadosQuery);
    }
}
