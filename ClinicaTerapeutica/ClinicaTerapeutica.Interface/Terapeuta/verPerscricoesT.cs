﻿using System;
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
    public partial class VerPerscricoesT : Form
    {
        public VerPerscricoesT()
        {
            InitializeComponent();
        }

        private void verPerscricoesT_Load(object sender, EventArgs e)
        {

        }

        private void voltarAtras_Click(object sender, EventArgs e) //Volta atrás para o menu inicial do Terapeuta
        {
            //Transita para o menu inicial do Terapeuta
            this.Hide();
            MenuInicialT menu = new MenuInicialT();
            menu.ShowDialog();
            this.Close();
        }
    }
}
