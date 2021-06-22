using ClinicaTerapeutica.Funcionalidade.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.CriadorDeUtilizadores
{
    public interface IRegistadorUtilizadores
    {
        Paciente RegistarPaciente(string nome, string password, string dataNascimento, string email, int telefone);

        Paciente RegistarTerapeuta(string nome, string password, string dataNascimento, string email, int telefone);
    }
}
