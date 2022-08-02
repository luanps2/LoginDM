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
    public partial class Regras : Form
    {
        public Regras()
        {
            InitializeComponent();
        }

        private void Regras_Load(object sender, EventArgs e)
        {
            
            txtRegras.ScrollBars = ScrollBars.Both;
            txtRegras.ReadOnly = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRegras_TextChanged(object sender, EventArgs e)
        {
               
        }
    }
}
