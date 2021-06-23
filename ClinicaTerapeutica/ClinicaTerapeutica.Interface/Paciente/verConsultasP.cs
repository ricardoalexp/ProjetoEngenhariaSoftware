using ClinicaTerapeutica.Data.Entidades.Modelos;
using ClinicaTerapeutica.Funcionalidade.Gestores.GestorMarcacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaTerapeutica.Interface
{
    public partial class VerConsultasP : Form
    {
        private int idPaciente;
        public VerConsultasP()
        {
            InitializeComponent();
            idPaciente = 2;
            listaConsultas();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void listaConsultas()
        {
            GestorMarcacoes gestorMarcacoes = new GestorMarcacoes();
            List<Consulta> consultas = gestorMarcacoes.ObterPesquisadorMarcacoes().ObterConsultasPaciente(idPaciente);

            if (consultas.Count != 0)
            {
                for (int i = 0; i < consultas.Count; i++)
                {
                    checkedListBox1.Items.Add(consultas[i].ToString());
                }
            }
            else { checkedListBox1.Items.Add("Não tem consultas marcadas"); }
        }

        private void desmarcaConsultas()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    //query que remove o elemento i da lista
                }
            }

            checkedListBox1.Items.Clear();
            listaConsultas();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void desmarcarSelecionadas_Click(object sender, EventArgs e)
        {
            desmarcaConsultas();
        }
    }
}
