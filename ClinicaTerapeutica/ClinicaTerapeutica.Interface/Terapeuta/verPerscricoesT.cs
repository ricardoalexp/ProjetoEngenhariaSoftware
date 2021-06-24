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
using ClinicaTerapeutica.Funcionalidade.Gestores.GestorPrescricoes;

namespace ClinicaTerapeutica.Interface.Terapeuta
{
    public partial class VerPerscricoesT : Form
    {
        private int idTerapeuta;
        private List<Prescricao> prescricoes;
        public VerPerscricoesT()
        {
            InitializeComponent();
            idTerapeuta = DadosUtilizador.IdUtilizador;
            listaPrescricoes();            
        }

        private void voltarAtras_Click(object sender, EventArgs e) //Volta atrás para o menu inicial do Terapeuta
        {
            //Transita para o menu inicial do Terapeuta
            this.Hide();
            MenuInicialT menu = new MenuInicialT();
            menu.ShowDialog();
            this.Close();
        }

        private void listPerscricoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            prescricaoSelecionada();
        }

        private void listaPrescricoes()
        {
            // O código da linha de baixo está errado. Corrigir!! mudar para terapeuta
            GestorPrescricoes gestorPrescricoes = new GestorPrescricoes();
            prescricoes = gestorPrescricoes.ObterPesquisadorPrescricoes().ObterPrescricoesTerapeuta(idTerapeuta);

            if (prescricoes.Count != 0)
            {
                for (int i = 0; i < prescricoes.Count; i++)
                {
                    listPerscricoes.Items.Add(prescricoes[i].ToString());
                }
            }
            else { MessageBox.Show("Não tem prescições marcadas"); }
        }

        private void prescricaoSelecionada()
        {

            int indicePrescricaoSelecionada = listPerscricoes.SelectedIndex;

            //Transita para o menu da prescrição selecionada            
            this.Hide();
            PerscricaoT menu = new PerscricaoT(prescricoes[indicePrescricaoSelecionada]);
            menu.ShowDialog();
            this.Close();

        }
    }
}
