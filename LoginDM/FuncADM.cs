﻿using System;
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


    public partial class FuncADM : Form
    {
        

        public FuncADM()
        {
            InitializeComponent();
            
        }

        public MySqlConnection conexao;
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private MySqlDataReader rs;
        private String sql;

       
            string periodo;
            
       

        private void FuncADM_Load(object sender, EventArgs e)
        {
            

            dadosbanco.Server = "db4free.net";
            dadosbanco.User = "usercedesp";
            dadosbanco.Password = "admin123";
            dadosbanco.DataBase = "boletim";


            string server2 = dadosbanco.Server;
            string user = dadosbanco.User;
            string password = dadosbanco.Password;
            string database = dadosbanco.DataBase;

            dadosbanco.conn = "server=" + server2 + " ;user id=" + user + "; password= '" + password + "'; database=" + database + " ;SSL Mode = None";


            conexao = new MySqlConnection("server=" + dadosbanco.Server +
                " ;user id=" + dadosbanco.User + ";" +
                " password= '" + dadosbanco.Password +
                "'; database=" + dadosbanco.DataBase +
                " ;SSL Mode = None");

           

           
            popularDataGridADM();

            //ajusta colunas de acordo com o tamanho necessário
            dgADM.AutoResizeColumns(
               DataGridViewAutoSizeColumnsMode.AllCells);
        }
        DadosBanco dadosbanco = new DadosBanco();

        

     

        void popularDataGridADM()
        {
            try
            {
                //Tabela Boletim
                dgADM.DataSource = null;
                adapter = new MySqlDataAdapter("SELECT * FROM usuario", conexao);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgADM.DataSource = ds.Tables[0];


            }
            catch (Exception err)
            {

                MessageBox.Show("Ocorreu um erro! Erro: " + err.ToString());
            }

        }
        void PesquisarUsuario()
        {

            periodo = rbTarde.Checked ? "Tarde" : "Noite";


            try
            {
                //Tabela Boletim
                dgADM.DataSource = null;
                adapter = new MySqlDataAdapter("SELECT * FROM usuario WHERE Nome LIKE '%" + txtPesquisa.Text + "%' AND Periodo ='" + periodo + "'", conexao);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgADM.DataSource = ds.Tables[0];


            }
            catch (Exception err)
            {

                MessageBox.Show("Ocorreu um erro! Erro: " + err.ToString());
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarUsuario();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (rbTarde.Checked)
            {
                dgADM.DataSource = null;
                adapter = new MySqlDataAdapter("SELECT * FROM usuario WHERE Periodo = '" + periodo + "'", conexao) ;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgADM.DataSource = ds.Tables[0];
            }
        }

        private void rbTarde_CheckedChanged(object sender, EventArgs e)
        {
            PesquisarUsuario();
        }

        private void rbNoite_CheckedChanged(object sender, EventArgs e)
        {
            PesquisarUsuario();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente remover o usuário: " + dgADM.SelectedCells[0].Value.ToString() + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string DeleteQuery = "DELETE from usuario WHERE Cod = @cod";
                    conexao.Open();
                    MySqlCommand command = new MySqlCommand(DeleteQuery, conexao);
                    command.Parameters.AddWithValue("@cod", dgADM.SelectedCells[0].Value.ToString());
                    command.ExecuteNonQuery();
                    conexao.Close();

                    MessageBox.Show("Usuário de código: " + dgADM.SelectedCells[0].Value.ToString() +
                        " \nPeriodo: " + dgADM.SelectedCells[1].Value.ToString() +
                        " \nNome: " + dgADM.SelectedCells[2].Value.ToString() + 
                        " \nexcluído com sucesso!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    popularDataGridADM();


                }
                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro ao excluir o usuário: " + erro);
                }
            }
            else
            {
                MessageBox.Show("Usuário não foi excluido!");
            }

           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
          

        
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoUsuario janela = new NovoUsuario();
            janela.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string InsertQuery = "UPDATE usuario SET Introducao = @Introducao, Nome) VALUES (@cod, @Periodo, @Nome)";
            //conexao.Open();
            //MySqlCommand command = new MySqlCommand(InsertQuery, conexao);
            //command.Parameters.AddWithValue("@cod", txtCod.Text);
            //command.Parameters.AddWithValue("@Periodo", gbPeriodo.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text);
            //command.Parameters.AddWithValue("@Nome", txtNome.Text);
            //command.ExecuteNonQuery();
            //conexao.Close();
        }
    }
}
