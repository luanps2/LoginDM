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
    public partial class SenhaADM : Form
    {
        public SenhaADM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1674")
            {
                FuncADM funcadm = new FuncADM();
                funcadm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha Incorreta!");
                textBox1.Focus();
            }
        }
    }
}
