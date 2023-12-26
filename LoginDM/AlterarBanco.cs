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
using Sistema_Dom_Macário_Lib;


namespace LoginDM
{
    public partial class AlterarBanco : Form
    {
        public DadosBanco db { get; set; }

        DadosBanco dadosbanco = new DadosBanco();

        SistemaDoma sistemadoma = new SistemaDoma();

        //string server2;
        //string user;
        //string password;
        //string database;
        //string cnx;
        
        public MySqlConnection conexao;

        public AlterarBanco()
        {
            InitializeComponent();

        }
        public void AlterarBanco_Load(object sender, EventArgs e)
        {
            txtServer.Text = db.Server;
            txtUser.Text = db.User;
            txtPass.Text = db.Password;
            txtDatabase.Text = db.DataBase;


            //conexao = new MySqlConnection(dadosbanco.conn);
            dadosbanco.mysql = new MySqlConnection(dadosbanco.conn);

        }

        public void button1_Click(object sender, EventArgs e)
        {
           


            //DadosBanco dadosbanco = new DadosBanco();

            //SistemaDoma sistema = new SistemaDoma();

            //sistema.db = new DadosBanco();

            //try
            //{
            //    //Inserindo dos campos de texto para as classes
            //    dadosbanco.Server = txtServer.Text;
            //    dadosbanco.User = txtUser.Text;
            //    dadosbanco.Password = txtPass.Text;
            //    dadosbanco.DataBase = txtDatabase.Text;
            //    dadosbanco.conn = "server=" + dadosbanco.Server + " ;user id=" + dadosbanco.User + "; password= '" + dadosbanco.Password + "'; database=" + dadosbanco.DataBase + " ;SSL Mode = None";

            //    //inserindo dados da classe para as variaveis
            //    server2 = dadosbanco.Server;
            //    user = dadosbanco.User;
            //    password = dadosbanco.Password;
            //    database = dadosbanco.DataBase;
            //    cnx = dadosbanco.conn;

            //    ////inserindo dados das variaveis locais para as classes
            //    //dadosbanco.Server = server2;
            //    //dadosbanco.User = user;
            //    //dadosbanco.Password = password;
            //    //dadosbanco.DataBase = database;
            //    //dadosbanco.conn = cnx;

             

            //    //passando dados para a janela sistema
            //    sistema.db.Server = server2;
            //    sistema.db.User = user;
            //    sistema.db.Password = password;
            //    sistema.db.DataBase = database;
            //    sistema.db.conn = cnx;


            //    //conexao = new MySqlConnection(dadosbanco.conn);
            //    sistema.db.mysql = new MySqlConnection(dadosbanco.conn);


            //    MessageBox.Show("Dados alterados com sucesso! " + sistema.db.mysql);
                
               
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show("Erro! " + err);

            //}



        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(db.mysql.ToString());
        }
    }
}
