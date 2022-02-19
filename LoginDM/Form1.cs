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
            bool DiretorioExiste = Directory.Exists("C:/");
            if (DiretorioExiste == false)
            {
                MessageBox.Show("Entre com seu número de matricula primeiro!");
            }
            else if (true)
            {
                System.Diagnostics.Process.Start("C:/");
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
            //user = int.Parse(txtUsuario.Text);

            //if (user < 1000)
            //{
            //    MessageBox.Show("Digite um usuário válido!");
            //}
            //txtUsuario.Text = "";

            //if (txtUsuario.TextLength < 4)
            //{
            //    MessageBox.Show("Digite um usuário Válido");
            //}
            //txtUsuario.Text = "";


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
            NetworkDrive oNetDrive = new aejw.Network.NetworkDrive();

            try
            {
                oNetDrive.LocalDrive = "M:";
                oNetDrive.ShareName = "//luan//Tarde/" + txtUsuario.Text;
                oNetDrive.PromptForCredentials = true;
                oNetDrive.MapDrive();
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Error: " + err.Message + "\n" + err.ToString());
            }
            oNetDrive = null;


            //System.Diagnostics.Process.Start("net.exe", "use M: \\luan\\tarde" + txtUsuario.Text);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.MaxLength = 5;
        }

        private void btnTestes_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe");

        }
    }
}
