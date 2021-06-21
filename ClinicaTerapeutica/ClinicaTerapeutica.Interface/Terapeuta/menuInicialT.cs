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
    public partial class MenuInicialT : Form
    {
        public MenuInicialT()
        {
            InitializeComponent();
        }

        private void logOut_Click(object sender, EventArgs e) //Logout
        {
            //Transita para o menu Ver perscrições
            this.Hide();
            VerPerscricoesP menu = new VerPerscricoesP();
            menu.ShowDialog();
            this.Close();
        }
    }
}
