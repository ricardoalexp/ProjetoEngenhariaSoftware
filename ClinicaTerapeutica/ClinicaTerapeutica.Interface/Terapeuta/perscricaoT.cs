using ClinicaTerapeutica.Data.Entidades.Decoradores;
using ClinicaTerapeutica.Data.Entidades.Modelos;
using ClinicaTerapeutica.Funcionalidade.Gestores.GestorPrescricoes;
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
        private PrescricaoParaMenu prescricao;

        public PerscricaoT() {}

        public PerscricaoT(Prescricao prescricao)
        {
            GestorPrescricoes gestor = new GestorPrescricoes();
            this.prescricao = gestor.ObterPrestadorDeUtilitarios().ObterDecoradorPrescricaoParaMenu(prescricao);
            InitializeComponent();
            listarPrescricao();
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
            this.Hide();
            AdicionarExercicioT menu = new AdicionarExercicioT(prescricao.ObterPrescricao());
            menu.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdicionarTratamentos menu = new AdicionarTratamentos(prescricao.ObterPrescricao());
            menu.ShowDialog();
            this.Close();
        }

        private void btnAdicionarMedicamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdicionarMedicamento menu = new AdicionarMedicamento(prescricao.ObterPrescricao());
            menu.ShowDialog();
            this.Close();
        }

        private void listarPrescricao()
        {
            richTextBox1.Text = prescricao.ObterDescricao();
        }
    }
}
