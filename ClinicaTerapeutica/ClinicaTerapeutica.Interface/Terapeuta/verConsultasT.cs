using ClinicaTerapeutica.Data.Entidades.Modelos;
using ClinicaTerapeutica.Funcionalidade.Gestores.GestorMarcacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaTerapeutica.Interface.Terapeuta
{
    public partial class VerConsultasT : Form
    {
        private int idTerapeuta;
        private List<Consulta> consultas;

        public VerConsultasT()
        {
            InitializeComponent();
            idTerapeuta = DadosUtilizador.IdUtilizador;
            listaConsultas();
        }

        private void voltarAtras_Click(object sender, EventArgs e) //Volta atrás para o menu inicial do Terapeuta
        {
            //Transita para o menu inicial do Terapeuta
            this.Hide();
            MenuInicialT menu = new MenuInicialT();
            menu.ShowDialog();
            this.Close();
        }

        //---------------------Métodos----------------------------

        private void listaConsultas()
        {
            GestorMarcacoes gestorMarcacoes = new GestorMarcacoes();
            consultas = gestorMarcacoes.ObterPesquisadorMarcacoes().ObterConsultasTerapeuta(idTerapeuta);

            if (consultas.Count != 0)
            {
                for (int i = 0; i < consultas.Count; i++)
                {
                    listBox1.Items.Add(consultas[i].ToString());
                }
            }
            else { listBox1.Items.Add("Não tem consultas marcadas"); }
        }
    }
}
