using ClinicaTerapeutica.Interface.Paciente;
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
    public partial class MenuInicialT : Form
    {
        public MenuInicialT()
        {
            InitializeComponent();
        }

        private void logOut_Click(object sender, EventArgs e) //Logout
        {
            //Transita para o menu Inicio Sessao
            this.Hide();
            InicioSessao menu = new InicioSessao();
            menu.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //Criar Utilizador
        {
            //Transita para o menu Criar Utilizador
            this.Hide();
            CriarUtilizadorT menu = new CriarUtilizadorT();
            menu.ShowDialog();
            this.Close();
        }

        private void marcarConsulta_Click(object sender, EventArgs e) // Marcar Consulta
        {
            //Transita para o menu Criar Utilizador
            this.Hide();
            MarcarConsultaT menu = new MarcarConsultaT();
            menu.ShowDialog();
            this.Close();
        }

        private void verConsultas_Click(object sender, EventArgs e) //Ver Consultas
        {
            //Transita para o menu Ver Consultas
            this.Hide();
            VerConsultasT menu = new VerConsultasT();
            menu.ShowDialog();
            this.Close();
        }

        private void verPerscricoes_Click(object sender, EventArgs e) //Ver Perscricoes
        {
            //Transita para o menu Ver Perscricoes
            this.Hide();
            VerPerscricoesT menu = new VerPerscricoesT();
            menu.ShowDialog();
            this.Close();
        }

        private void verTratamentos_Click(object sender, EventArgs e) //Ver Tratamentos
        {
            //Transita para o menu Ver Tratamentos
            this.Hide();
            VerTratamentosT menu = new VerTratamentosT();
            menu.ShowDialog();
            this.Close();
        }

        private void verSessoes_Click(object sender, EventArgs e) //Ver Sessões
        {
            //Transita para o menu Ver Sessões
            this.Hide();
            VerSessoesT menu = new VerSessoesT();
            menu.ShowDialog();
            this.Close();
        }
    }
}
