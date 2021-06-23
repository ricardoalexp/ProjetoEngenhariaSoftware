using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.Entidades.Modelos
{
    public class Prescricao
    {
        public int Id { get; set; }
        public bool Privado { get; set; }
        public string Validade { get; set; }
        public string Comentario { get; set; }
        public int IdConsulta { get; set; }

        public override string ToString()
        {
            string text = "";

            text = "Id : " + Id + ", Consulta: " + IdConsulta + " val.: " + Validade + " - " + Comentario;

            return text;
        }
    }

}
