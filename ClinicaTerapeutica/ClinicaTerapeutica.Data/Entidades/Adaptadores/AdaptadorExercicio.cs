using ClinicaTerapeutica.Data.Entidades.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.Entidades.Adaptadores
{
    class AdaptadorExercicio : IAdaptadorExercicio
    {
        public List<Exercicio> DeSqlParaExercicios(MySqlDataReader dadosQuery)
        {
            return Converter(dadosQuery);
        }
        public List<Exercicio> Converter(MySqlDataReader dadosQuery)
        {
            if (dadosQuery.HasRows)
            {
                List<Exercicio> lista = new List<Exercicio>();
                Exercicio exercicio;
                while (dadosQuery.Read())
                {
                    exercicio = new Exercicio();
                    exercicio.Id = Convert.ToInt32(dadosQuery.GetString("id"));
                    exercicio.Nome = dadosQuery.GetString("nome");
                    exercicio.Privado = dadosQuery.GetString("privado").Equals("1") ? true : false;
                    exercicio.Descricao = dadosQuery.GetString("descricao");
                    exercicio.Duracao = Convert.ToInt32(dadosQuery.GetString("duracao"));
                    lista.Add(exercicio);
                }
                return lista;
            }
            else { return new List<Exercicio>(); }
        }
    }
}
