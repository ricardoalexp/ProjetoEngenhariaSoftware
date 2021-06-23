using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaTerapeutica.Data.Gerais
{
    public interface IQuery
    {
        string ObterQuery();
    }
}
