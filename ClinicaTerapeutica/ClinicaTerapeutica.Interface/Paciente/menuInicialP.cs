using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaTerapeutica.Interface.Paciente;

namespace ClinicaTerapeutica.Interface
{
    public partial class MenuInicialP : Form
    {
        public MenuInicialP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Ver consultas
        {
            //Transita para o menu Ver consultas
            this.Hide();
            VerConsultasP menu = new VerConsultasP();
            menu.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e) //Marcar consulta
        {
            //Transita para o menu Marcar consulta
            this.Hide();
            MarcarConsultaP menu = new MarcarConsultaP();
            menu.ShowDialog();
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e) //Ver tratamentos
        {
            //Transita para o menu Ver tratamentos
            this.Hide();
            VerTratamentosP menu = new VerTratamentosP();
            menu.ShowDialog();
            this.Close();
        }

        private void button1_Click_3(object sender, EventArgs e) //Ver Sessões
        {
            //Transita para o menu Ver Sessões
            this.Hide();
            VerSessoesP menu = new VerSessoesP();
            menu.ShowDialog();
            this.Close();
        }

        private void verPerscricoes_Click(object sender, EventArgs e) //Ver perscriçoes
        {
            //Transita para o menu Ver perscrições
            this.Hide();
            VerPerscricoesP menu = new VerPerscricoesP();
            menu.ShowDialog();
            this.Close();
        }

        private void logOut_Click(object sender, EventArgs e) //Logout
        {
            //Transita para o menu de Inicio de Sessão
            this.Hide();
            InicioSessao menu = new InicioSessao();
            menu.ShowDialog();
            this.Close();
        }
        
        private void label1_Click(object sender, EventArgs e) //Não faz nada!!!
        {

        }

    }
}
