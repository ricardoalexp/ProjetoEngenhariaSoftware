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
    public partial class AdicionarExercicioT : Form
    {
        private List<Consulta> exercicios;
        public AdicionarExercicioT()
        {
            InitializeComponent();
            listaExercicios();
        }

        private void consultasMarcadas_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarExercicio_Load(object sender, EventArgs e)
        {

        }

        private void voltarAtras_Click(object sender, EventArgs e) //Volta atrás para o menu Prescrição
        {
            //Transita para o menu Prescrição
            this.Hide();
            PerscricaoT menu = new PerscricaoT();
            menu.ShowDialog();
            this.Close();
        }

        private void ckListExercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            adicionaExercicios();
        }

        private void listaExercicios()
        {
            //Código da linha de baixo está errado. Corrigir!!
            GestorMarcacoes gestorMarcacoes = new GestorMarcacoes();
            exercicios = gestorMarcacoes.ObterPesquisadorMarcacoes().ObterConsultasPaciente(2);

            if (exercicios.Count != 0)
            {
                for (int i = 0; i < exercicios.Count; i++)
                {
                    ckListExercicios.Items.Add(exercicios[i].ToString());
                }
            }
            else { ckListExercicios.Items.Add("Não existem exercicios na lista"); }
        }

        private void adicionaExercicios()
        {
            //Código da linha de baixo está errado. Corrigir!!
            GestorMarcacoes gestorMarcacoes = new GestorMarcacoes();

            for (int i = 0; i < ckListExercicios.Items.Count; i++)
            {
                if (ckListExercicios.GetItemChecked(i))
                {
                    //Adicionar exercicios à prescrição!!

                    MessageBox.Show("Exercício/s adicionado/s com sucesso");

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
