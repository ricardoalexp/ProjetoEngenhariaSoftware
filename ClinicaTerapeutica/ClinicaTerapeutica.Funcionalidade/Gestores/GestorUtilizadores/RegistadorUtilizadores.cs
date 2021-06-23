using ClinicaTerapeutica.Data.GestorRegistos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorUtilizadores
{
    class RegistadorUtilizadores : IRegistadorUtilizadores
    {
        private GestorRegistos gestorRegistos;
        public bool RegistarPaciente(string nome, string password, string dataNascimento, string email, int telefone)
        {
            gestorRegistos = new GestorRegistos();
            return gestorRegistos.ObterRegistadorUtilizadores().RegistarPaciente(nome, password, dataNascimento, email, telefone);
        }
        public bool RegistarTerapeuta(string nome, string password, string dataNascimento, string email, int telefone)
        {
            gestorRegistos = new GestorRegistos();
            return gestorRegistos.ObterRegistadorUtilizadores().RegistarTerapeuta(nome, password, dataNascimento, email, telefone);
        }
    }
}
