using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaTerapeutica.Interface.Terapeuta;
using ClinicaTerapeutica.Interface.Paciente;
using ClinicaTerapeutica.Funcionalidade.Autenticador;

namespace ClinicaTerapeutica.Interface
{
    public partial class InicioSessao : Form
    {
        public InicioSessao()
        {
            InitializeComponent();
        }

        public void login()
        {
            Autenticador autenticador = new Autenticador();
            
            if (checkBoxTerapeuta.Checked)
            {              
                if (autenticador.AutenticarTerapeuta(int.Parse(textBoxUser.Text), textBoxPassword.Text)) 
                                {
                    MessageBox.Show("Bem vindo terapeuta!");

                    //Transita para o menu inicial do terapeuta
                    this.Hide();
                    MenuInicialT menu = new MenuInicialT();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Credenciais incorretas!\n" +
                   "Tente outra vez");
                }                
            }
            else
            {
                if (autenticador.AutenticarPaciente(int.Parse(textBoxUser.Text), textBoxPassword.Text))
                {
                    MessageBox.Show("Bem vindo paciente!");

                    //Transita para o menu inicial do paciente
                    this.Hide();
                    MenuInicialP menu = new MenuInicialP();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Credenciais incorretas!\n" +
                    "Tente outra vez");
                }
            }

         }                
        

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inicioSessao_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
