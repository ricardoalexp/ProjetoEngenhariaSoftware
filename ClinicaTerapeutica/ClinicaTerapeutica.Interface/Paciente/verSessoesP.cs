using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaTerapeutica.Interface.Paciente
{
    public partial class VerSessoesP : Form
    {
        public VerSessoesP()
        {
            InitializeComponent();
        }

        private void titleTratamentos_Click(object sender, EventArgs e)
        {

        }

        private void voltarAtras_Click(object sender, EventArgs e) //Volta atrás para o menu inicial do paciente
        {
            //Transita para o menu inicial do paciente
            this.Hide();
            MenuInicialP menu = new MenuInicialP();
            menu.ShowDialog();
            this.Close();
        }

        private void listTratamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
