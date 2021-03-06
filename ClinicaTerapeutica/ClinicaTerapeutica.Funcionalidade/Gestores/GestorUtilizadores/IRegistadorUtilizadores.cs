using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorUtilizadores
{
    public interface IRegistadorUtilizadores
    {
        bool RegistarPaciente(string nome, string password, string dataNascimento, string email, int telefone);
        bool RegistarTerapeuta(string nome, string password, string dataNascimento, string email, int telefone);
    }
}
