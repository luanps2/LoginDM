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

        int user;

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
            bool DiretorioExiste = Directory.Exists("A:/");
            if (DiretorioExiste == false)
            {
                MessageBox.Show("Entre com seu número de matricula primeiro!");
            }
            else if (true)
            {
                System.Diagnostics.Process.Start("A:/");
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


            user = int.Parse(tbUsuario.Text);



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

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            bool PastaExiste = Directory.Exists("A:\\luan\\" + user.ToString());

            if (PastaExiste == false)
            {
                
            }

            NetworkDrive mapeamento = new NetworkDrive();
            try
            {
                mapeamento.LocalDrive = "A:";
                mapeamento.ShareName = "//luan" + "/" + user.ToString();
                mapeamento.MapDrive();
            }
            catch (Exception erro)
            {
                MessageBox.Show(this, "Erro: " + erro.Message);
                throw;
            }
        }
    }
}
