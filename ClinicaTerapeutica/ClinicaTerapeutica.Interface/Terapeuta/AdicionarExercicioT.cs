using ClinicaTerapeutica.Data.Entidades.Modelos;
using ClinicaTerapeutica.Funcionalidade.Gestores.GestorItens;
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
        private List<Exercicio> exercicios;
        private Prescricao prescricao;

        public AdicionarExercicioT(Prescricao prescricao)
        {
            this.prescricao = prescricao;
            InitializeComponent();
            listaExercicios();
        }

        private void voltarAtras_Click(object sender, EventArgs e) //Volta atrás para o menu Prescrição
        {
            //Transita para o menu Prescrição
            this.Hide();
            PerscricaoT menu = new PerscricaoT();
            menu.ShowDialog();
            this.Close();
        }

        private void btnAdicionarExercicio_Click(object sender, EventArgs e)
        {
            adicionaExercicios();
        }

        //---------------------Métodos-----------------------

        private void listaExercicios()
        {
            GestorItens gestorItens = new GestorItens();
            exercicios = gestorItens.ObterPesquisadorItens().ObterExercicios();
            MessageBox.Show(exercicios.Count.ToString());
            if (exercicios.Count != 0)
            {
                for (int i = 0; i < exercicios.Count; i++)
                {
                    ckListExercicios.Items.Add(exercicios[i].ToString());
                }
            }
            else { MessageBox.Show("Não existem exercicios na lista"); }
        }

        private void adicionaExercicios()
        {
            GestorItens gestorItens = new GestorItens();

            for (int i = 0; i < ckListExercicios.Items.Count; i++)
            {
                if (ckListExercicios.GetItemChecked(i))
                {
                    //Adiciona exercicios à prescrição
                    gestorItens.ObterRegistadorItens().RegistarExerciciosEmPrescricao(prescricao.Id, exercicios[i].Id);
                }
            }

            MessageBox.Show("Exercício/s adicionado/s com sucesso");
            this.Hide();
            PerscricaoT menu = new PerscricaoT(prescricao);
            menu.ShowDialog();
            this.Close();
        }
    }
}
