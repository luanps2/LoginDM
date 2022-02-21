using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDM
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/luan-da-costa-oliveira-esp%C3%B3sito-b57705ba/");
        }

        private void Sobre_Load(object sender, EventArgs e)
        {

            string[] curiosidades = new string[]
            { "HDD Significa Hard Disk Drive",
                "RAM significa Random Access Memory",
                    "CPU significa Central Processor Unit",
                    "o primeiro nome da Internet era Arphanet",
                    "Cada 1GB é equivalente a 1024MB", "SSD significa Solid State Drive" };
            lblCuriosidade.Text = (curiosidades[new Random().Next(0, curiosidades.Length)]);

            
            string[] frases = new string[]
            { "O importante não é vencer todos os dias, mas lutar sempre. Waldemar Valle Martins",
                "Maior que a tristeza de não haver vencido é a vergonha de não ter lutado! Rui Barbosa",
                    "Enquanto houver vontade de lutar haverá esperança de vencer. Santo Agostinho",
                    "O medo de perder tira a vontade de ganhar. Mussum",
                    "Se você pretende ser rico, pense em economizar tanto quanto em ganhar. Benjamin Franklin" };
            lblFrase.Text = (frases[new Random().Next(0, frases.Length)]);


            //string[] curiosidade = new string[] 
            //{ "HDD Significa Hard Disk Drive", 
            //    "RAM significa Random Access Memory",
            //    "CPU significa Central Processor Unit", 
            //    "o primeiro nome da Internet era Arphanet", 
            //    "Cada 1GB é equivalente a 1024MB", "SSD significa Solid State Drive" };
            //return curiosidade[rnd.Next(0, curiosidade.Length)];

            //lblCuriosidade.Text = curiosidade;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.casadommacario.org.br/");
        }
    }
}
