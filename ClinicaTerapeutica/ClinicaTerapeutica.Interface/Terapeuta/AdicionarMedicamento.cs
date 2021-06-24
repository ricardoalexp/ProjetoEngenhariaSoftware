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
    public partial class AdicionarMedicamento : Form
    {
        private List<Medicamento> medicamentos;
        private Prescricao prescricao;

        public AdicionarMedicamento(Prescricao prescricao)
        {
            this.prescricao = prescricao;
            InitializeComponent();
            listaMedicamentos();
        }

        private void voltarAtras_Click(object sender, EventArgs e) //Volta atrás para o menu Prescrição
        {
            //Transita para o menu Prescrição
            this.Hide();
            PerscricaoT menu = new PerscricaoT();
            menu.ShowDialog();
            this.Close();
        }

        private void btnAdicionarMedicamento_Click(object sender, EventArgs e)
        {
            adicionaMedicamentos();
        }

        //---------------------Métodos-----------------------

        private void listaMedicamentos()
        {
            GestorItens gestorItens = new GestorItens();
            medicamentos = gestorItens.ObterPesquisadorItens().ObterMedicamentos();

            if (medicamentos.Count != 0)
            {
                for (int i = 0; i < medicamentos.Count; i++)
                {
                    ckListMedicamentos.Items.Add(medicamentos[i].ToString());
                }
            }
            else { ckListMedicamentos.Items.Add("Não existem medicamentos na lista"); }
        }

        private void adicionaMedicamentos()
        {
            GestorItens gestorItens = new GestorItens();

            for (int i = 0; i < ckListMedicamentos.Items.Count; i++)
            {
                if (ckListMedicamentos.GetItemChecked(i))
                {
                    //Adicionar medicamentos à prescrição!!
                    gestorItens.ObterRegistadorItens().RegistarMedicamentoEmPrescricao(prescricao.Id, medicamentos[i].Id);

                }
            }
            MessageBox.Show("Medicamento/s adicionado/s com sucesso");

            //Transita para o menu Prescrição
            this.Hide();
            PerscricaoT menu = new PerscricaoT();
            menu.ShowDialog();
            this.Close();
        }

    }
}
