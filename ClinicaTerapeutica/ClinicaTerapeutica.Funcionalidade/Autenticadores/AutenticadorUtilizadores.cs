using ClinicaTerapeutica.Data.GestorPesquisas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Autenticadores
{
    class AutenticadorUtilizadores : IAutenticadorUtilizadores
    {
        private GestorPesquisas gestorPesquisas;
        
        public AutenticadorUtilizadores()
        {
            gestorPesquisas = new GestorPesquisas();
        }
        public bool AutenticarPaciente(int id, string password)
        {
            return  gestorPesquisas.ObterPesquisadorUtilizadores().VerificarLoginPaciente(id, password);

        }
        public bool AutenticarTerapeuta(int id, string password)
        {

            return gestorPesquisas.ObterPesquisadorUtilizadores().VerificarLoginTerapeuta(id,password);
        }
    }
}
