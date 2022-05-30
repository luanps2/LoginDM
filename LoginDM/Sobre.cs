using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Dom_Macário_Lib;

namespace LoginDM
{
    public partial class Sobre : Form
    {
        public Sobre(string versao)
        {
            InitializeComponent();
            lblVersao.Text = versao;
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
                    "Cada 1GB é equivalente a 1024MB",
                "SSD significa Solid State Drive",
            "WWW significa World Wide Web",
                "A primeira câmera do mundo levou oito horas para tirar uma foto",
            "O e-mail foi criado antes da internet",
                "O Facebook paga pelo menos US$ 500 para quem encontrar erros",
                "A primeira página web do mundo continua intacta no ar",
                "Um disco rígido de 5 MB pesava uma tonelada em 1956",
                "a primeira programadora do mundo era uma mulher.",
                "Download é o ato de baixar algum arquivo da internet",
                "Upload é o ato de enviar algum arquivo para a internet",
                "Você pode encontrar empregos no Linkedin"
            };
            lblCuriosidade.Text = (curiosidades[new Random().Next(0, curiosidades.Length)]);


            string[] frases = new string[]
            { "O importante não é vencer todos os dias, mas lutar sempre. Waldemar Valle Martins",
                "Maior que a tristeza de não haver vencido é a vergonha de não ter lutado! Rui Barbosa",
                    "Enquanto houver vontade de lutar haverá esperança de vencer. Santo Agostinho",
                    "O medo de perder tira a vontade de ganhar. Mussum",
                    "Se você pretende ser rico, pense em economizar tanto quanto em ganhar. Benjamin Franklin", 
                "É genial festejar o sucesso, mas é mais importante aprender com as lições do fracasso. Bill Gates", 
            "Se você acha que seu pai ou seu professor são rudes, espere até ter um chefe. Ele não terá pena de você. Bill gates",
            "Tente uma, duas, três vezes e se possível tente a quarta, a quinta e quantas vezes for necessário. Só não desista nas primeiras tentativas, a persistência é amiga da conquista. Se você quer chegar aonde a maioria não chega, faça o que a maioria não faz. Bill Gates",
            "A mãe de quem? Luan Costa", 
                "Arrasta Pra cima ↑",
            "plante seu jardim e decore sua alma, ao invés de esperar que alguém lhe traga flores. Menestrel."};
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

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
