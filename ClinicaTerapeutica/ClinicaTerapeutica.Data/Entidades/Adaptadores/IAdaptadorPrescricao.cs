using ClinicaTerapeutica.Data.Entidades.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.Entidades.Adaptadores
{
    interface IAdaptadorPrescricao
    {
        List<Prescricao> DeSqlParaPrescricoes(MySqlDataReader dadosQuery);
    }
}
