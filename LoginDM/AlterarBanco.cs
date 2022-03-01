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
using LoginDM;

namespace LoginDM
{
    public partial class AlterarBanco : Form
    {
        string server2 = "localhost";
        string user = "root";
        string password = "admin";
        string database = "boletim";

        private MySqlConnection conexao;
        public AlterarBanco()
        {
            InitializeComponent();
        }
        private void AlterarBanco_Load(object sender, EventArgs e)
        {
            txtServer.Text = server2;
            txtUser.Text = user;
            txtPass.Text = password;
            txtDatabase.Text = database;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server2 = txtServer.Text;
            user = txtUser.Text;
            password = txtPass.Text;
            database = txtDatabase.Text;

            try
            {
                conexao = new MySqlConnection("server=" + server2 + " ;user id=" + user + "; password= '" + password + "'; database=" + database + " ; SSL Mode = None");
                MessageBox.Show("Dados Alterados com sucesso!");
            }
            catch (Exception err)
            {

                MessageBox.Show("Erro ao alterar os dados \nERRO: " + err.Message);
            }
            
        }

      
    }
}
