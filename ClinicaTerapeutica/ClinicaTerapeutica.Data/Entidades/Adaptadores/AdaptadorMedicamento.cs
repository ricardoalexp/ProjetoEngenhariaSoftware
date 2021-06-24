using ClinicaTerapeutica.Data.Entidades.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.Entidades.Adaptadores
{
    class AdaptadorMedicamento : IAdaptadorMedicamento
    {
        public List<Medicamento> DeSqlParaMedicamentos(MySqlDataReader dadosQuery)
        {
            return Converter(dadosQuery);
        }
        public List<Medicamento> Converter(MySqlDataReader dadosQuery)
        {
            if (dadosQuery.HasRows)
            {
                List<Medicamento> lista = new List<Medicamento>();
                Medicamento medicamento;
                while (dadosQuery.Read())
                {
                    medicamento = new Medicamento();
                    medicamento.Id = Convert.ToInt32(dadosQuery.GetString("id"));
                    medicamento.Nome = dadosQuery.GetString("nome");
                    medicamento.Privado = dadosQuery.GetString("privado").Equals("1") ? true : false;
                    medicamento.Descricao = dadosQuery.GetString("descricao");
                    medicamento.Dosagem = Convert.ToInt32(dadosQuery.GetString("dosagem"));
                    medicamento.Duracao = Convert.ToInt32(dadosQuery.GetString("duracao"));
                    lista.Add(medicamento);
                }
                return lista;
            }
            else { return new List<Medicamento>(); }
        }
    }
}
