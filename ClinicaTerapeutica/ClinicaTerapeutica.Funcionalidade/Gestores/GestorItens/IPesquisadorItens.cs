﻿using ClinicaTerapeutica.Data.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Funcionalidade.Gestores.GestorItens
{
    public interface IPesquisadorItens
    {
        List<Medicamento> ObterMedicamentos();
        List<Tratamento> ObterTratamentos();
        List<Exercicio> ObterExercicios();
        List<Medicamento> ObterMedicamentosPrescricao(int idPrescricao);
        List<Tratamento> ObterTratamentosPrescricao(int idPrescricao);
        List<Exercicio> ObterExerciciosPrescricao(int idPrescricao);
    }
}
