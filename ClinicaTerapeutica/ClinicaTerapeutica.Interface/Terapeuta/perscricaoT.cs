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
    {        public PerscricaoT()
        {
            //Arranjar!
        }

        public PerscricaoT(int idPrescricao)
        {
            int id = idPrescricao;
            InitializeComponent();
            MessageBox.Show("Prescrição " + id + " selecionada");
        }

        private void voltarAtras_Click(object sender, EventArgs e) //Volta atrás para o menu Ver Prescrições
        {
            //Transita para o menu Ver Prescrições
            this.Hide();
            VerPerscricoesT menu = new VerPerscricoesT();
            menu.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarMedicamento_Click(object sender, EventArgs e)
        {

        }

        private void listBoxprescricao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
