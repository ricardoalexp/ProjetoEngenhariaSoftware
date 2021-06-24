using ClinicaTerapeutica.Interface.Terapeuta;
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
    public partial class MarcarConsultaT : Form
    {
        public MarcarConsultaT()
        {
            InitializeComponent();
        }

        private void labelUserId_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_marcar_Click(object sender, EventArgs e)
        {
            marcaConsulta();
        }

        private void voltarAtras_Click(object sender, EventArgs e) //Volta atrás para o menu Ver Prescrições
        {
            //Transita para o menu inicial do paciente
            this.Hide();
            MenuInicialT menu = new MenuInicialT();
            menu.ShowDialog();
            this.Close();
        }

        private void listTerapeutas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void marcaConsulta()
        {
            if (textBoxData.Text != null && textBoxHora.Text != null && textBoxIdPaciente.Text != null)
            {
                //marcar consulta
                if (true)// Consulta foi marcada com sucesso?
                {
                    MessageBox.Show("Consulta marcada com sucesso");
                    textBoxData.ResetText();
                    textBoxHora.ResetText();
                    textBoxIdPaciente.ResetText();
                }
                else
                { MessageBox.Show("Erro! Consulta NÃO foi marcada com sucesso"); }

            }
        }
    }
}
