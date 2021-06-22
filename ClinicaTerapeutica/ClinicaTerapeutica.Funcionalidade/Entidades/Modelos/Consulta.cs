using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Entidades.Modelos
{
    class Consulta
    {
        private int Id { get; set; }
        private int Duracao { get; set; }
        private string Data { get; set; }
        private int Hora { get; set; }
        private int idPaciente { get; set; }
        private int idTerapeuta { get; set; }
    }
}
