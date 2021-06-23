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
    }
}
