using ClinicaTerapeutica.Data.Gerais;
using ClinicaTerapeutica.Data.GestorEliminacoes.Eliminacoes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.GestorEliminacoes.Utilitarios
{
    class ExecutorEliminacoes
    {
        IQuery querySelecionada;

        private IResultadoEliminacao ExecutarEliminacao()
        {

            MySqlConnection conexao = ConectorBDMySQL.GetInstance.GetConnection();
            MySqlCommand commandDatabase = new MySqlCommand(querySelecionada.ObterQuery(), conexao);

            int rows;
            try
            {
                if ((rows = commandDatabase.ExecuteNonQuery()) > 0)
                {
                    return new ResultadoEliminacao(true);
                }
                else
                {
                    return new ResultadoEliminacao(false);
                }
            }
            catch
            {
                return new ResultadoEliminacao(false);
            }
            
        }

        public IResultadoEliminacao EliminarConsulta(int idConsulta)
        {
            querySelecionada = new EliminacaoConsulta(idConsulta);
            return ExecutarEliminacao();
        }
    }
}
