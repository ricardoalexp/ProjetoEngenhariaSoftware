using ClinicaTerapeutica.Data.GestorQueries;
using ClinicaTerapeutica.Data.GestorQueries.Queries;
using MySql.Data.MySqlClient;
using System;
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
    public partial class inicioSessao : Form
    {
        public inicioSessao()
        {
            InitializeComponent();
        }

        public void login()
        {

            MySqlDataReader reader;
            try
            {
                ExecutorQueries query = new ExecutorQueries();
                reader = query.ExecutarQuery(new QueryObterPessoa("Marcos"));

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show(reader.GetString("password"));                       
                    }
                }
                else
                {
                    MessageBox.Show("Oops");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inicioSessao_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
