using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Entidades
{
    class Paciente : Utilizador
    {
        private bool vazio;

        public Paciente()
        {
            this.vazio = true;
        }
        private List<int> Doencas { get; set; }

        public bool EstaVazio()
        {
            return vazio;
        }

        public void ConcluirConstrucao()
        {
            this.vazio = false;
        }
    }
}
