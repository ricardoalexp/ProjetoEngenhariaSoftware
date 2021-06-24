using ClinicaTerapeutica.Data.Entidades.Modelos;
using ClinicaTerapeutica.Data.GestorPesquisas.Utilitarios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.Entidades.Adaptadores
{
    internal class AdaptadorConsulta : IAdaptadorConsulta
    {
        private ExecutorPesquisas executorPesquisas;
        private List<Consulta> consultasPaciente;

        public List<Consulta> DeSqlParaConsultas(MySqlDataReader dadosQuery)
        {
            return Converter(dadosQuery);
        }

        public List<Consulta> Converter(MySqlDataReader dadosQuery)
        {
            if (dadosQuery.HasRows)
            {
                List<Consulta> lista = new List<Consulta>();
                Consulta consulta;
                while (dadosQuery.Read())
                {
                    consulta = new Consulta();
                    consulta.Id = Convert.ToInt32(dadosQuery.GetString("id"));
                    consulta.Duracao = Convert.ToInt32(dadosQuery.GetString("duracao"));
                    consulta.Data = dadosQuery.GetString("data");
                    consulta.IdPaciente = Convert.ToInt32(dadosQuery.GetString("paciente_utilizador_id"));
                    consulta.IdTerapeuta = Convert.ToInt32(dadosQuery.GetString("terapeuta_utilizador_id"));

                    lista.Add(consulta);
                }
                return lista;

            } else { return new List<Consulta>(); }            
        }
    }
}
