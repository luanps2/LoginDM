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
    public partial class SenhaCriarUsuario : Form
    {

        string senha = "1674";

        public SenhaCriarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            if (txtSenha.Text == senha)
            {
                NovoUsuario criaruser = new NovoUsuario();
                criaruser.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha Incorreta", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            senha = txtSenha.Text;
        }
    }
}
