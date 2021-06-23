using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.Entidades.Modelos
{
    public class Utilizador
    {
        public int Id { get; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
    }
}
