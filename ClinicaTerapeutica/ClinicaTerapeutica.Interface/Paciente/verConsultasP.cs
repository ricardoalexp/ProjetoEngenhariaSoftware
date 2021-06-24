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
        private List<Consulta> consultas;

        public VerConsultasP()
        {
            InitializeComponent();
            idPaciente = DadosUtilizador.IdUtilizador;
            listaConsultas();
        }

        private void voltarAtras_Click(object sender, EventArgs e) //Volta atrás para o menu inicial do paciente
        {
            //Transita para o menu inicial do paciente
            this.Hide();
            MenuInicialP menu = new MenuInicialP();
            menu.ShowDialog();
            this.Close();
        }

        private void desmarcarSelecionadas_Click(object sender, EventArgs e)
        {
            desmarcaConsultas();
        }

        //---------------------Métodos----------------------------

        private void listaConsultas()
        {
            GestorMarcacoes gestorMarcacoes = new GestorMarcacoes();
            consultas = gestorMarcacoes.ObterPesquisadorMarcacoes().ObterConsultasPaciente(idPaciente);

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
            GestorMarcacoes gestorMarcacoes = new GestorMarcacoes();

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    int tempId = consultas[i].Id;
                    if (gestorMarcacoes.ObterPesquisadorMarcacoes().PodeEliminarConsulta(tempId))
                    {
                        gestorMarcacoes.ObterEliminadorMarcacoes().EliminarConsulta(tempId);
                    }
                    else { MessageBox.Show("A consulta com ID = '" + tempId + "' já tém uma prescrição associada e não pode ser eliminada."); }
                }
            }

            checkedListBox1.Items.Clear();
            listaConsultas();
        }
    }
}
