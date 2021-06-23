﻿using ClinicaTerapeutica.Data.Gerais;
using ClinicaTerapeutica.Data.GestorPesquisas.Pesquisas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaTerapeutica.Data.GestorPesquisas.Utilitarios
{
    public class ExecutorPesquisas
    {
        private IQuery querySelecionada;

        private IResultadoQuery ExecutarQuery(IQuery query)
        {
            MySqlConnection conexao = ConectorBDMySQL.GetInstance.GetConnection();
            MySqlCommand commandDatabase = new MySqlCommand(query.ObterQuery(), conexao);
            MySqlDataReader leitorQuery = commandDatabase.ExecuteReader();

            IResultadoQuery resultado = new ResultadoQuery(leitorQuery);

            return resultado;
        }

        public IResultadoQuery ResultadoObterConsultasPaciente(int id)
        {
            querySelecionada = new QueryObterConsultasPaciente(id);
            return ExecutarQuery(querySelecionada);
        }

        public IResultadoQuery ResultadoAutenticarPaciente(int id, string password)
        {
            querySelecionada = new QueryAutenticarPaciente(id, password);
            return ExecutarQuery(querySelecionada);
        }
        
        public IResultadoQuery ResultadoAutenticarTerapeuta(int id, string password)
        {
            querySelecionada = new QueryAutenticarTerapeuta(id, password);
            return ExecutarQuery(querySelecionada);
        }
    }
}
