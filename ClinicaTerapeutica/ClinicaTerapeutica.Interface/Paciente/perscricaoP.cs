﻿using System;
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
    public partial class PerscricaoP : Form
    {
        public PerscricaoP()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void voltarAtras_Click(object sender, EventArgs e) //Volta atrás para o menu Ver Prescrições
        {
            //Transita para o menu Ver perscrições
            this.Hide();
            VerPerscricoesP menu = new VerPerscricoesP();
            menu.ShowDialog();
            this.Close();
        }
    }
}
