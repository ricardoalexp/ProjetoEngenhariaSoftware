
using ClinicaTerapeutica.Data.GestorRegistos.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorRegistos.Registadores
{
    class RegistadorUtilizadores : IRegistadorUtilizadores
    {
        private ExecutorInsercoes executorInsercoes;

        public bool RegistarPaciente(string nome, string password, string dataNascimento, string email, int telefone)
        {
            
            executorInsercoes = new ExecutorInsercoes();

            int result = executorInsercoes.ResultadoInserirPaciente(nome, password, dataNascimento, email, telefone).ObterResultado();

            return result == 0 ? true : false;
        }

        public bool RegistarTerapeuta(string nome, string password, string dataNascimento, string email, int telefone)
        {
            executorInsercoes = new ExecutorInsercoes();

            int result = executorInsercoes.ResultadoInserirTerapeuta(nome, password, dataNascimento, email, telefone).ObterResultado();

            return result == 0 ? true : false;
        }
        private bool VerificarExistenciaEmail(string email)
        {
            return false;
        }
    }
}
