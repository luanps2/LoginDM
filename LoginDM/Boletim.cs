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
    public partial class Boletim : Form
    {
        public Boletim()
        {
            InitializeComponent();
        }

        private void Boletim_Load(object sender, EventArgs e)
        {
            try
            {
                DriveInfo din = new DriveInfo(@"M:\");
                DirectoryInfo dirInfo = din.RootDirectory;
                DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*.*");

                foreach (DirectoryInfo d in dirInfos)
                {
                    lblUsuario.Text = d.Name.ToUpper();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Usuário não conectado!");
            }
           
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
