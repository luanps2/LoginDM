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
    public partial class SistemaDoma : Form
    {

        //String server = "luan"; //Dom Macário
        String server = "luanpc"; //Casa
        String diretorio = "";

        bool MapExiste = Directory.Exists("M:/");

        NetworkDrive Mapeamento = new NetworkDrive();

        public void Conectar()
        {
            DriveInfo driverinfo = new DriveInfo("M");
            bool MapExiste = driverinfo.IsReady;

            if (MapExiste)
            {
                Desconectar();

            }

            if (!rbTarde.Checked && !rbNoite.Checked)
            {
                MessageBox.Show("Selecione seu periodo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("Digite seu Usuário!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //if (txtUsuario.TextLength > 0 && gbPeriodo.Controls.Count < 0)
            //{
            //    MessageBox.Show("Selecione seu periodo e \nDigite seu Usuário!");
            //}

            String periodo = "";
            periodo = rbTarde.Checked ? "Tarde" : "Noite";

            //int user = Int32.Parse(txtUsuario.Text);

            if ((rbTarde.Checked || rbNoite.Checked) && (txtUsuario.TextLength > 0))
            {
                try
                {
                    if (!MapExiste)
                    {
                        Mapeamento.Force = true;
                        Mapeamento.Persistent = true;
                        Mapeamento.LocalDrive = "M:";
                        String dir = "\\\\" + server + "\\" + periodo + "\\" + txtUsuario.Text;
                        Mapeamento.ShareName = dir;

                        bool DiretorioExiste = Directory.Exists(dir);

                        if (!DiretorioExiste)
                        {
                            try
                            {
                                DirectoryInfo di = Directory.CreateDirectory(dir);
                                MessageBox.Show("Pasta de usuário" + lblUser.Text + "criada com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception erro2)
                            {
                                MessageBox.Show("Pasta não foi criada! \nErro: " + erro2.Message);

                            }

                        }

                        //MessageBox.Show(Mapeamento.ShareName);

                        Mapeamento.MapDrive();
                        pbStatus.Image = Properties.Resources.online;
                        lblStatus.Text = "Status: Conectado!";
                        lblStatus.Location = new Point(270, 4);
                        btnDesconectar.Image = Properties.Resources.BT2;

                        DriveInfo dinfo = new DriveInfo("M");
                        bool pronto = dinfo.IsReady;

                        if (!pronto)
                        {
                            imgPasta.Image = Properties.Resources.offdir;
                        }
                        else if (pronto)
                        {
                            imgPasta.Image = Properties.Resources.dir;
                        }

                        DriveInfo din = new DriveInfo(@"M:\");
                        DirectoryInfo dirInfo = din.RootDirectory;
                        DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*.*");

                        foreach (DirectoryInfo d in dirInfos)
                        {
                            lblNome.Text = d.Name.ToUpper();

                        }
                        
                        System.Diagnostics.Process.Start("M:/");

                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não conectado!\nErro: " + erro.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Mapeamento = null;
            }
        }

        public void Desconectar()
        {
            DriveInfo driverinfo = new DriveInfo("M");
            bool MapExiste = driverinfo.IsReady;

            if (!MapExiste)
            {
                MessageBox.Show("Não há nenhum usuário conectado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                NetworkDrive Desconectar = new NetworkDrive();
                try
                {
                    Desconectar.Force = true;
                    Desconectar.LocalDrive = "M:";
                    Desconectar.UnMapDrive();

                    //bool ReturnValue = false;
                    System.Diagnostics.Process p = new System.Diagnostics.Process();
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.RedirectStandardOutput = true;

                    p.StartInfo.FileName = "net.exe";
                    p.StartInfo.Arguments = "use * /DELETE /y";
                    p.Start();
                    p.WaitForExit();

                    MessageBox.Show(lblNome.Text + ", sua pasta de usuário " + lblUser.Text + " foi desconectada com sucesso! \naté a próxima aula! :)", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                catch (Exception)
                {

                }
            }


        }

        public SistemaDoma()
        {
            InitializeComponent();
        }




        private void btnEntrar_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bool DiretorioExiste = Directory.Exists("M:/");

            if (!DiretorioExiste)
            {
                MessageBox.Show("Entre com seu número de matricula primeiro!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (DiretorioExiste)
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







        private void btnLogin_Click(object sender, EventArgs e)
        {
            Conectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }




        private void btnDesconectar_Click(object sender, EventArgs e)
        {

            Desconectar();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NetworkDrive Desconectar = new NetworkDrive();
            Desconectar.ShowDisconnectDialog(this);
            Desconectar = null;
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void conectarManualmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NetworkDrive ConnManual = new NetworkDrive();
            ConnManual.ShowConnectDialog(this);
            ConnManual = null;
        }

        public void Status()
        {
            bool MapExiste = Directory.Exists("M:/");
            if (!MapExiste)
            {
                lblStatus.Text = "Status: Desconectado!";
                pbStatus.Image = Properties.Resources.offline;
            }
            else if (MapExiste)
            {
                lblStatus.Text = "Status: Conectado!";
                pbStatus.Image = Properties.Resources.online;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo di = new DriveInfo("M");
            bool pronto = di.IsReady;

            

            if (!pronto)
            {
                imgPasta.Image = Properties.Resources.offdir;
            }
            else if (pronto)
            {
                imgPasta.Image = Properties.Resources.dir;
            }

            NetworkDrive Desconectar = new NetworkDrive();

            try
            {
                Desconectar.Force = true;
                Desconectar.LocalDrive = "M:";
                Desconectar.UnMapDrive();

                //bool ReturnValue = false;
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.UseShellExecute = false;
                //p.StartInfo.CreateNoWindow = true;
                //p.StartInfo.RedirectStandardError = true;
                //p.StartInfo.RedirectStandardOutput = true;

                p.StartInfo.FileName = "net.exe";
                p.StartInfo.Arguments = "use * /DELETE /y";
                p.Start();
                p.WaitForExit();

                lblStatus.Text = "Status: Desconectado";


            }
            catch (Exception)
            {

            }

            if (!pronto)
            {
                lblStatus.Text = "Status: Desconectado";
                pbStatus.Image = Properties.Resources.offline;
            }
            else
            {
                lblStatus.Text = "Status: Conectado!";
                pbStatus.Image = Properties.Resources.online;
            }
            Status();


        }



        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pbPeriodo_Click(object sender, EventArgs e)
        {

        }

        private void gbPeriodo_Enter(object sender, EventArgs e)
        {

        }

        private void gbPeriodo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void txtUsuario_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void rbTarde_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTarde.Checked)
            {
                pbPeriodo.Image = Properties.Resources.tarde;
            }

        }

        private void rbNoite_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoite.Checked)
            {
                pbPeriodo.Image = Properties.Resources.noite;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblUser.Text = txtUsuario.Text;

            if (txtUsuario.TextLength < 2)
            {
                btnLogin.Image = Properties.Resources.BT11;
            }
            else
            {
                btnLogin.Image = Properties.Resources.BT1;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Get the subdirectories directly that is under the root.
            // See "How to: Iterate Through a Directory Tree" for an example of how to
            // iterate through an entire tree.
            DriveInfo di = new DriveInfo(@"M:\");
            DirectoryInfo dirInfo = di.RootDirectory;
            DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*.*");

            foreach (DirectoryInfo d in dirInfos)
            {
                MessageBox.Show(d.Name);

            }

            //DriveInfo di = new DriveInfo("M");
            //bool pronto = di.IsReady;

            //if (pronto)
            //{
            //    MessageBox.Show("Drive está disponivel: \n Drive: " + di.ToString() + "\nbool: " + pronto);
            //}
            //else
            //{
            //    string periodo = "";

            //    if (rbTarde.Checked)
            //    {
            //        periodo = "Tarde";
            //    }
            //    else if (rbNoite.Checked)
            //    {
            //        periodo = "Noite";
            //    }
            //    else
            //    {
            //        periodo = "vazio";
            //    }
            //    MessageBox.Show("Drive não está disponivel! \n Drive: " + di.ToString() + "\nbool: " + pronto + "\ndiretoria a mapear: " + "\\\\" + server + "\\" + periodo + "\\" + txtUsuario.Text);
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Conectar();
            }
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
           
        }
    }

  
}
