using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoginDM
{
    public partial class CriarUsuario : Form
    {
        string server = "luanpc";
        string periodo = "";
    


        public CriarUsuario()
        {
            InitializeComponent();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cbPeriodo.Text.Equals("Tarde"))
            {
                periodo = "tarde";
            }
            else if (cbPeriodo.Text.Equals("Noite"))
            {
                periodo = "noite";
            }

            String dir = "\\\\" + server + "\\" + periodo + "\\" + txtUsuario.Text;
            bool DiretorioExiste = Directory.Exists(dir);

            if (!DiretorioExiste)
            {
                try
                {
                    DirectoryInfo di = Directory.CreateDirectory(dir);
                    MessageBox.Show("Pasta de usuário" + txtUsuario.Text + "criada com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();

                }
                catch (Exception erro2)
                {
                    MessageBox.Show("Pasta não foi criada! \nErro: " + erro2.Message);

                }

            }
        }
    }
}
