﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.Entidades.Modelos
{
    public class Utilizador
    {
        private int Id { get; }
        private string Nome { get; set; }
        private string DataNascimento { get; set; }
        private string Email { get; set; }
        private int Telefone { get; set; }
    }
}
