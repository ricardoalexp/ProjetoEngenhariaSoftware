using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=teste;";

        public void login()
        {
            string query = "SELECT * FROM pessoa WHERE name = 'Marcos'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Login to form");                       
                    }
                }
                else
                {
                    MessageBox.Show("Oops");
                }

                databaseConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
