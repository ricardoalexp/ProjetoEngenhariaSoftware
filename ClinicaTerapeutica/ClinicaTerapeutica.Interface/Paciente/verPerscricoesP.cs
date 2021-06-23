using ClinicaTerapeutica.Data.Entidades.Modelos;
using ClinicaTerapeutica.Funcionalidade.Gestores.GestorMarcacoes;
using ClinicaTerapeutica.Data.Entidades.Modelos;
using ClinicaTerapeutica.Funcionalidade.Gestores.GestorMarcacoes;using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaTerapeutica.Funcionalidade.Gestores.GestorPrescricoes;

namespace ClinicaTerapeutica.Interface
{
    public partial class VerPerscricoesP : Form
    {
        private int idPaciente;
        public VerPerscricoesP()
        {
            InitializeComponent();
            idPaciente = 2;
            listaPrescricoes();
        }

        private void voltarAtras_Click(object sender, EventArgs e) //Volta atrás para o menu inicial do paciente
        {
            //Transita para o menu inicial do paciente
            this.Hide();
            MenuInicialP menu = new MenuInicialP();
            menu.ShowDialog();
            this.Close();
        }

        private void VerPerscricoesP_Load(object sender, EventArgs e)
        {

        }

        private void listPerscricoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            abrePrescricao();
        }

        private void listaPrescricoes()
        {
            // O código da linha de baixo está errado. Corrigir!!
            GestorPrescricoes gestorPrescricoes = new GestorPrescricoes();
            List<Prescricao> prescricoes = gestorPrescricoes.ObterPesquisadorPrescricoes().ObterPrescricoesPaciente(idPaciente);

            if (prescricoes.Count != 0)
            {
                for (int i = 0; i < prescricoes.Count; i++)
                {
                    listPerscricoes.Items.Add(prescricoes[i].ToString());
                }
            }
            else { MessageBox.Show("Não tem prescições marcadas"); }
        }

        private void abrePrescricao()
        {
            if (listPerscricoes.Items.Count > 0)
            {
                int selectedItem = listPerscricoes.SelectedIndex;
                
                this.Hide();
                PerscricaoP menu = new PerscricaoP(selectedItem);
                menu.ShowDialog();
                this.Close();

                MessageBox.Show("Prescrição " + selectedItem.ToString() + "selecionada");
            }
            else { MessageBox.Show("Não tem prescrições"); }
            

        }

    }
}
