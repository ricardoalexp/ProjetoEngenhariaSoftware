using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.Entidades.Modelos
{
    class Terapeuta
    {
        private bool vazio;
        enum DiaSemana
        {
            Segunda,
            Terca,
            Quarta,
            Quinta,
            Sexta,
            Sabado
        }

        public Terapeuta()
        {
            this.vazio = true;
        }

        private int horaEntrada;
        private int horaSaida;
        private DiaSemana diaFolga;

        public bool EstaVazio()
        {
            return vazio;
        }
    }
}
