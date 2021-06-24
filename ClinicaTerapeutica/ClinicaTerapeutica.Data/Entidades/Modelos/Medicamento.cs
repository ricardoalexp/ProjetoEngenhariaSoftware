using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.Entidades.Modelos
{
    public class Medicamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Privado { get; set; }
        public string Descricao { get; set; }
        public int Dosagem { get; set; }
        public int Duracao { get; set; }
        public override string ToString()
        {
            return Nome + ": " + Dosagem + "mg, " + Duracao + "dias, " + Descricao;
        }

    }
    
}
