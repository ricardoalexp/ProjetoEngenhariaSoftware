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

namespace ClinicaTerapeutica.Interface.Terapeuta
{
    public partial class AdicionarTratamentos : Form
    {
        private List<Consulta> tratamentos;

        public AdicionarTratamentos()
        {
            InitializeComponent();
            listaTratamentos();
        }

        private void voltarAtras_Click(object sender, EventArgs e) //Volta atrás para o menu Prescrição
        {
            //Transita para o menu Prescrição
            this.Hide();
            PerscricaoT menu = new PerscricaoT();
            menu.ShowDialog();
            this.Close();
        }

        private void ckListTratamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            adicionaTratamentos();
        }

        private void listaTratamentos()
        {
            //Código da linha de baixo está errado. Corrigir!!
            GestorMarcacoes gestorMarcacoes = new GestorMarcacoes();
            tratamentos = gestorMarcacoes.ObterPesquisadorMarcacoes().ObterConsultasPaciente(2);

            if (tratamentos.Count != 0)
            {
                for (int i = 0; i < tratamentos.Count; i++)
                {
                    ckListTratamentos.Items.Add(tratamentos[i].ToString());
                }
            }
            else { ckListTratamentos.Items.Add("Não existem tratamentos na lista"); }
        }

        private void adicionaTratamentos()
        {
            //Código da linha de baixo está errado. Corrigir!!
            GestorMarcacoes gestorMarcacoes = new GestorMarcacoes();

            for (int i = 0; i < ckListTratamentos.Items.Count; i++)
            {
                if (ckListTratamentos.GetItemChecked(i))
                {
                    //Adicionar tratamentos à prescrição!!

                    MessageBox.Show("Tratamento/s adicionado/s com sucesso");

                    //Transita para o menu Prescrição
                    this.Hide();
                    PerscricaoT menu = new PerscricaoT();
                    menu.ShowDialog();
                    this.Close();
                }                
            }
        }
    }
}
