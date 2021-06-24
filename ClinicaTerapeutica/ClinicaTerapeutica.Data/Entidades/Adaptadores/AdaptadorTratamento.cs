using ClinicaTerapeutica.Data.Entidades.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.Entidades.Adaptadores
{
    class AdaptadorTratamento : IAdaptadorTratamento
    {
        public List<Tratamento> DeSqlParaTratamentos(MySqlDataReader dadosQuery)
        {
            return Converter(dadosQuery);
        }
        public List<Tratamento> Converter(MySqlDataReader dadosQuery)
        {
            if (dadosQuery.HasRows)
            {
                List<Tratamento> lista = new List<Tratamento>();
                Tratamento tratamento;
                while (dadosQuery.Read())
                {
                    tratamento = new Tratamento();
                    tratamento.Id = Convert.ToInt32(dadosQuery.GetString("id"));
                    tratamento.Nome = dadosQuery.GetString("nome");
                    tratamento.Privado = dadosQuery.GetString("privado").Equals("1") ? true : false;
                    tratamento.Descricao = dadosQuery.GetString("descricao");
                    tratamento.NumeroSessoes = Convert.ToInt32(dadosQuery.GetString("num_sessoes"));
                    lista.Add(tratamento);
                }
                return lista;
            }
            else { return new List<Tratamento>(); }
        }
    }
}
