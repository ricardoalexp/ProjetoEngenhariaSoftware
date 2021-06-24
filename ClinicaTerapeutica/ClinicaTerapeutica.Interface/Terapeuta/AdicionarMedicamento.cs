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
    public partial class AdicionarMedicamento : Form
    {
        private List<Consulta> medicamentos;

        public AdicionarMedicamento()
        {
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

        private void ckListMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            adicionaMedicamentos();
        }

        private void listaMedicamentos()
        {
            //Código da linha de baixo está errado. Corrigir!!
            GestorMarcacoes gestorMarcacoes = new GestorMarcacoes();
            medicamentos = gestorMarcacoes.ObterPesquisadorMarcacoes().ObterConsultasPaciente(2);

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
            //Código da linha de baixo está errado. Corrigir!!
            GestorMarcacoes gestorMarcacoes = new GestorMarcacoes();

            for (int i = 0; i < ckListMedicamentos.Items.Count; i++)
            {
                if (ckListMedicamentos.GetItemChecked(i))
                {
                    //Adicionar medicamentos à prescrição!!

                    MessageBox.Show("Medicamento/s adicionado/s com sucesso");

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
