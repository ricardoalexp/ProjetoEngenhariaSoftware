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
    public partial class PerscricaoT : Form
    {
        public PerscricaoT()
        {
            InitializeComponent();
        }

        private void voltarAtras_Click(object sender, EventArgs e) //Volta atrás para o menu Ver Prescrições
        {
            //Transita para o menu Ver Prescrições
            this.Hide();
            VerPerscricoesT menu = new VerPerscricoesT();
            menu.ShowDialog();
            this.Close();
        }
    }
}
