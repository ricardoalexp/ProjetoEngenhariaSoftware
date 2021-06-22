using ClinicaTerapeutica.Data.GestorRegistos.Registadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos
{
    public class GestorRegistos
    {
        IRegistadorUtilizadores registadorUtilizadores;

        IRegistadorMarcacoes registadorMarcacoes;

        public IRegistadorUtilizadores ObterRegistadorUtilizadores()
        {
            if (registadorUtilizadores == null)
            {
                registadorUtilizadores = new RegistadorUtilizadores();
            }
            return registadorUtilizadores;
        }
    }
}
