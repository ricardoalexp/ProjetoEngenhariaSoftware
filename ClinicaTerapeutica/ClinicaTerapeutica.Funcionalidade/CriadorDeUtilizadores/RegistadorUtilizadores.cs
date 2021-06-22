using ClinicaTerapeutica.Data.GestorQueries;
using ClinicaTerapeutica.Funcionalidade.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.CriadorDeUtilizadores
{
    class RegistadorUtilizadores : IRegistadorUtilizadores
    {
        private ExecutorQueries executorQueries;

        public Paciente RegistarPaciente(string nome, string password, string dataNascimento, string email, int telefone)
        {
            executorQueries = new ExecutorQueries();
            if (VerificarExistenciaEmail(email)) { return new Paciente(); }

            int result = executorQueries.ResultadoInserirPaciente(nome, password, dataNascimento, email, telefone).ObterResultado();
            if(result == 0)
            {
                return new Paciente();
            }
            else { return new Paciente(); } //alterar
        }

        public Paciente RegistarTerapeuta(string nome, string password, string dataNascimento, string email, int telefone)
        {
            executorQueries = new ExecutorQueries();
            if (VerificarExistenciaEmail(email)) { return new Paciente(); }

            int result = executorQueries.ResultadoInserirTerapeuta(nome, password, dataNascimento, email, telefone).ObterResultado();
            if (result == 0)
            {
                return new Paciente();
            }
            else { return new Paciente(); } //alterar
        }
        private bool VerificarExistenciaEmail(string email)
        {
            return false;
        }
    }
}
