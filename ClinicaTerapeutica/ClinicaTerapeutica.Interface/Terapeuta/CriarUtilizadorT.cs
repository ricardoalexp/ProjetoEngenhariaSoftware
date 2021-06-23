using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaTerapeutica.Funcionalidade.Gestores.GestorUtilizadores;

namespace ClinicaTerapeutica.Interface.Terapeuta
{
    public partial class CriarUtilizadorT : Form
    {
        private GestorUtilizadores gestorUtilizadores;
        public CriarUtilizadorT()
        {
            InitializeComponent();
            gestorUtilizadores = new();
        }

        private void checkBoxTerapeuta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Volta atrás para o menu inicial do paciente
        {
            //Transita para o menu inicial do paciente
            this.Hide();
            MenuInicialT menu = new MenuInicialT();
            menu.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //Criar o utilizador e (paciente ou terapeuta)
        {
            criarUtilizador();
        }

        public void criarUtilizador()
        {

            if (checkBoxTerapeuta.Checked)
            {
                gestorUtilizadores.ObterRegistadorUtilizadores().RegistarTerapeuta(textBoxUser.Text, textBoxPassword.Text, textBoxDataNasc.Text, textBoxEmail.Text, int.Parse(textBoxTelemovel.Text));

                MessageBox.Show("Terapeuta inserido com sucesso!");
            }
            else
            {
                gestorUtilizadores.ObterRegistadorUtilizadores().RegistarPaciente(textBoxUser.Text, textBoxPassword.Text, textBoxDataNasc.Text, textBoxEmail.Text, int.Parse(textBoxTelemovel.Text));

                MessageBox.Show("Paciente inserido com sucesso!");
            }
        }
    }
}
