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
    class AdaptadorPrescricao : IAdaptadorPrescricao
    {
        public List<Prescricao> DeSqlParaPrescricoes(MySqlDataReader dadosQuery)
        {
            return Converter(dadosQuery);
        }
        public List<Prescricao> Converter(MySqlDataReader dadosQuery)
        {
            if (dadosQuery.HasRows)
            {
                List<Prescricao> lista = new List<Prescricao>();
                Prescricao prescricao;
                while (dadosQuery.Read())
                {
                    prescricao = new Prescricao();
                    prescricao.Id = Convert.ToInt32(dadosQuery.GetString("id"));
                    prescricao.Privado = dadosQuery.GetString("duracao").Equals("1") ? true : false ;
                    prescricao.Validade = dadosQuery.GetString("validade");
                    prescricao.Comentario = dadosQuery.GetString("comentario");
                    prescricao.IdConsulta = Convert.ToInt32(dadosQuery.GetString("consulta_id"));

                    lista.Add(prescricao);
                }
                return lista;
            }
            else { return new List<Prescricao>(); }
        }
    }
}
