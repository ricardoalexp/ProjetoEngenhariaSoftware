﻿using ClinicaTerapeutica.Data.Entidades.Decoradores;
using ClinicaTerapeutica.Data.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorPrescricoes
{
    public interface IPrestadorDeUtilitarios
    {
        PrescricaoParaMenu ObterDecoradorPrescricaoParaMenu(Prescricao prescricao);
    }
}
