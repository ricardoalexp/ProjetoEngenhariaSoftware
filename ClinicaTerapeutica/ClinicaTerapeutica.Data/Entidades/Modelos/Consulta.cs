using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.Entidades.Modelos
{
    public class Consulta : Modelo
    {
        public int Id { get; set; }
        public int Duracao { get; set; }
        public string Data { get; set; }
        public int Hora { get; set; }
        public int IdPaciente { get; set; }
        public int IdTerapeuta { get; set; }

        public override string ToString()
        {
            string texto = "";
            texto += "Id: " + Id + ", data: " + Data;
            return texto;
        }
    }
}
