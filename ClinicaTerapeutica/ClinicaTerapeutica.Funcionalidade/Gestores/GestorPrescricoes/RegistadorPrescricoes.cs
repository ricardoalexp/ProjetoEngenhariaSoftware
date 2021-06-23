using ClinicaTerapeutica.Data.GestorRegistos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorPrescricoes
{
    class RegistadorPrescricoes : IRegistadorPrescricoes
    {
        private GestorRegistos gestorRegistos;

        public bool RegistarPrescricao(string validade, string comentario, int idConsulta)
        {
            gestorRegistos = new GestorRegistos();

            return gestorRegistos.ObterRegistadorPrescricoes().RegistarPrescricao(validade, comentario, idConsulta);
        }
    }
}
