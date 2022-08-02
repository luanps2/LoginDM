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
                adapter = new MySqlDataAdapter("SELECT * FROM usuario WHERE Periodo = '" + periodo + "'", conexao);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgADM.SelectedCells.Count > 0)
            {
                int IndexLinhaSelecionada = dgADM.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgADM.Rows[IndexLinhaSelecionada];
                //string ValorCelula = Convert.ToString(selectedRow.Cells[dgADM.SelectedCells[0].Value.ToString()]);

                string UpdateQuery = "UPDATE usuario SET Periodo = @Periodo, Nome = @Nome, Introducao = @Introducao, Word = @Word, Excel = @Excel, PowerPoint = @PowerPoint, Desenvolvimento = @Desenvolvimento, Tecnico = @Tecnico, Photoshop = @Photoshop, TCC = @TCC, Faltas = @Faltas WHERE Cod = @cod";
                conexao.Open();
                MySqlCommand command = new MySqlCommand(UpdateQuery, conexao);



                command.Parameters.AddWithValue("@Periodo", dgADM.SelectedCells[1].Value.ToString());
                command.Parameters.AddWithValue("@Nome", dgADM.SelectedCells[2].Value.ToString());
                command.Parameters.AddWithValue("@Introducao", dgADM.SelectedCells[3].Value.ToString());
                command.Parameters.AddWithValue("@Word", dgADM.SelectedCells[4].Value.ToString());
                command.Parameters.AddWithValue("@Excel", dgADM.SelectedCells[5].Value.ToString());
                command.Parameters.AddWithValue("@PowerPoint", dgADM.SelectedCells[6].Value.ToString());
                command.Parameters.AddWithValue("@Desenvolvimento", dgADM.SelectedCells[7].Value.ToString());
                command.Parameters.AddWithValue("@Tecnico", dgADM.SelectedCells[8].Value.ToString());
                command.Parameters.AddWithValue("@Photoshop", dgADM.SelectedCells[9].Value.ToString());
                command.Parameters.AddWithValue("@TCC", dgADM.SelectedCells[10].Value.ToString());
                command.Parameters.AddWithValue("@Faltas", dgADM.SelectedCells[11].Value.ToString());
                command.Parameters.AddWithValue("@cod", dgADM.SelectedCells[0].Value.ToString());
                command.ExecuteNonQuery();
                conexao.Close();




                MessageBox.Show("Dados do usuário: " + dgADM.SelectedCells[2].Value.ToString() + " Atualizados com sucesso!" + "Cód: " + dgADM.SelectedCells[0].Value.ToString() + "Periodo: " + dgADM.SelectedCells[1].Value.ToString() + " foram criados com sucesso! ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

            //            UPDATE table_name
            //SET column1 = value1, column2 = value2, ...
            //WHERE condition;


        }
    }
}
