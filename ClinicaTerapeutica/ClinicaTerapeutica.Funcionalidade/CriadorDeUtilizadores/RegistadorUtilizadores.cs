using ClinicaTerapeutica.Data.GestorQueries;
using ClinicaTerapeutica.Funcionalidade.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.CriadorDeUtilizadores
{
    public class RegistadorUtilizadores
    {
        private ExecutorQueries executorQueries;

        public Paciente RegistarPaciente(string nome, string password, string dataNascimento, string email, int telefone)
        {
            if (VerificarExistenciaEmail(email)) { return new Paciente(); }

            int result = executorQueries.ResultadoInserirUtilizador(nome, password, dataNascimento, email, telefone).ObterResultado();
            if(result == 0)
            {
                return new Paciente();
            }
            else {  }
        }
        private bool VerificarExistenciaEmail(string email)
        {
            return false;
        }
    }
}
