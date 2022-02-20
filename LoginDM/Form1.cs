using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aejw.Network;



namespace LoginDM
{
    public partial class Form1 : Form
    {

        String server = "luanpc";
        String diretorio = "teste";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bool DiretorioExiste = Directory.Exists("M:/");
            if (DiretorioExiste == false)
            {
                MessageBox.Show("Entre com seu número de matricula primeiro!");
            }
            else if (true)
            {
                System.Diagnostics.Process.Start("M:/");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://classroom.google.com/h");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.jit.si/Inform%C3%A1tica");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {


            int user = Int32.Parse(txtUsuario.Text);
                


            if (user < 1000)
            {
                MessageBox.Show("Digite um usuário válido!");
            }

            bool existeDiretorio = Directory.Exists("E:\\Sistemas\\Backup");


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.casadommacario.org.br/");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/luan-da-costa-oliveira-esp%C3%B3sito-b57705ba/");
        }

        

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void btnLogin_Click(object sender, EventArgs e)
        {


            if (!rbTarde.Checked && !rbNoite.Checked)
            {
                MessageBox.Show("Selecione seu periodo!");
            }

            String periodo = "";
            periodo = rbTarde.Checked ? "Tarde" : "Noite";
            
        
            
            //int user = Int32.Parse(txtUsuario.Text);

            NetworkDrive Mapeamento = new NetworkDrive();

            try
            {
                Mapeamento.Persistent = true;
                Mapeamento.LocalDrive = "M:";
                String dir = "\\\\" + server + "\\" + diretorio + "\\" + txtUsuario.Text;
                Mapeamento.ShareName =  dir;

                bool existeDiretorio = Directory.Exists(dir);

                if (!existeDiretorio)
                {
                    try
                    {
                        DirectoryInfo di = Directory.CreateDirectory(dir);
                        MessageBox.Show("Pasta de usuário criada com sucesso!");
                    }
                    catch (Exception erro2)
                    {
                        MessageBox.Show("Pasta não foi criada! \nErro: " +  erro2.Message);
                        
                    }
                   
                }

                MessageBox.Show(Mapeamento.ShareName);

                

                Mapeamento.MapDrive();

                System.Diagnostics.Process.Start("M:/");

            }
            catch (Exception erro)
            {
                MessageBox.Show(this, "Não conectado!\nErro: " + erro.Message);
                
            }
            Mapeamento = null;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            NetworkDrive Desconectar = new NetworkDrive();
            try
            {
                Desconectar.Force = true;
                Desconectar.LocalDrive = "M:";
                Desconectar.UnMapDrive();

                MessageBox.Show("Pasta desconectada com Sucesso!");
            }
            catch (Exception erro)
            {

            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NetworkDrive Desconectar = new NetworkDrive();
            Desconectar.ShowDisconnectDialog(this);
            Desconectar = null;
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = new Form;
            form
        }
    }
}
