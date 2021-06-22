using ClinicaTerapeutica.Funcionalidade.Autenticadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorUtilizadores
{
    public class GestorUtilizadores
    {
        IAutenticadorUtilizadores autenticadorUtilizadores;

        IRegistadorUtilizadores registadorUtilizadores;

        public IAutenticadorUtilizadores ObterAutenticadorUtilizadores()
        {
            if(autenticadorUtilizadores == null)
            {
                autenticadorUtilizadores = new AutenticadorUtilizadores();
            }
            return autenticadorUtilizadores;
        }
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
