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
using Sistema_Dom_Macário_Lib;


namespace LoginDM
{
    public partial class NovoUsuario : Form
    {
        public MySqlConnection conexao;

        public NovoUsuario()
        {
           
            InitializeComponent();
            DadosBanco dadosbanco = new DadosBanco();

            dadosbanco.Server = "db4free.net";
            dadosbanco.User = "usercedesp";
            dadosbanco.Password = "admin123";
            dadosbanco.DataBase = "boletim";

            conexao = new MySqlConnection("server=" + dadosbanco.Server +
                         " ;user id=" + dadosbanco.User + ";" +
                         " password= '" + dadosbanco.Password +
                         "'; database=" + dadosbanco.DataBase +
                         " ;SSL Mode = None");
        }

        private void NovoUsuario_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {



                string InsertQuery = "INSERT INTO usuario(Cod, Periodo, Nome) VALUES (@cod, @Periodo, @Nome)";
                conexao.Open();
                MySqlCommand command = new MySqlCommand(InsertQuery, conexao);
                command.Parameters.AddWithValue("@cod", txtCod.Text);
                command.Parameters.AddWithValue("@Periodo", gbPeriodo.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text);
                command.Parameters.AddWithValue("@Nome", txtNome.Text);
                command.ExecuteNonQuery();
                conexao.Close();

                


                MessageBox.Show(txtNome.Text + " sua pasta de usuário e seu registro no banco de dados " + txtCod.Text + " foram criados com sucesso! ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

    }
}


