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
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;
using LoginDM.Dados;
using Sistema_Dom_Macário_Lib;
using Microsoft.Win32;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace LoginDM
{
    public partial class SistemaDoma : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(
            UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

        private static readonly UInt32 SPI_SETDESKWALLPAPER = 0x14;
        private static readonly UInt32 SPIF_UPDATEINIFILE = 0x01;
        private static readonly UInt32 SPIF_SENDWININICHANGE = 0x02;

        static public void SetWallpaper(String path)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            key.SetValue(@"WallpaperStyle", 0.ToString()); // 2 is stretched
            key.SetValue(@"TileWallpaper", 0.ToString());

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }

        public DadosBanco db { get; set; }

        public MySqlConnection conexao;
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private MySqlDataReader rs;
        private String sql;


        String versaoLocal = File.ReadAllText("C:\\SistemaLoginDm\\versao.txt"); //leitura local 
        String versaoServer = File.ReadAllText("\\\\luan\\SistemaLoginDM\\versao.txt"); //leitura servidor

        //string server2 = "localhost";
        //string user = "root";
        //string password = "admin";
        //string database = "boletim";


        String server = "luan"; //Dom Macário
                                //String server = "luanpc"; //Casa
                                //String diretorio = "";
        DadosBanco dadosbanco = new DadosBanco();






        //bool MapExiste = Directory.Exists("M:/");

        NetworkDrive Mapeamento = new NetworkDrive();

        public void Conectar()
        {

            if (txtUsuario.TextLength < 2)
            {
                MessageBox.Show("Digite um usuário válido!", "Usuário Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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
                                    DialogResult dialogresult = MessageBox.Show("Usuário " + txtUsuario.Text + " não existe, deseja cria-lo?", "Usuário não existe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dialogresult == DialogResult.Yes)
                                    {
                                        string dialogNome = Interaction.InputBox("Digite seu nome completo: ", "Nome", "Nome completo");
                                        DirectoryInfo di = Directory.CreateDirectory(dir + "\\" + dialogNome.ToString());
                                        MessageBox.Show(dialogNome.ToString() + " sua pasta de usuário " + lblUser.Text + " foi criada com sucesso! ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else if (dialogresult == DialogResult.No)
                                    {
                                        MessageBox.Show("Pasta não foi criada! Aguarde alguns segundos...\nErro: LN01");
                                        Application.Restart();
                                    }

                                }
                                catch (Exception erro2)
                                {
                                    MessageBox.Show("Pasta não foi criada! \nErro: LN02 " + erro2.Message);

                                }

                            }

                            //MessageBox.Show(Mapeamento.ShareName);

                            Mapeamento.MapDrive();
                            pbStatus.Image = Properties.Resources.online2;
                            lblStatus.Text = "Status: Conectado!";
                            lblStatus.Location = new Point(275, 4);
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
                                lblUsuario.Text = d.Name.ToUpper();
                                lblUsuario2.Text = d.Name.ToUpper();
                            }

                            System.Diagnostics.Process.Start("M:/");//abre a pasta do usuário após logar


                            tabPage2.Enabled = true;
                            tabPage3.Enabled = true;

                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Não conectado!\nErro: " + erro.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    Mapeamento = null;
                }
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


        public void AtualizarSistema()
        {
            try
            {



                if (Convert.ToDouble(versaoLocal) < Convert.ToDouble(versaoServer))
                {
                    MessageBox.Show("Sistema desatualizado! \nVersão local: " + versaoLocal + "\nVersão servidor: " + versaoServer + "\nAperte OK para atualizar.", "Atualizar Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CopyDirectory(@"\\luan\\SistemaLoginDM\\", @"C:\\SistemaLoginDm\\", true);

                    MessageBox.Show("Sistema Atualizado com sucesso! versão atual: " + versaoServer);

                    versaoLocal = versaoServer;

                }
                else
                {
                    MessageBox.Show("Sistema Atualizado! \nVersão local: " + versaoLocal + "\nVersão do Servidor: " + versaoServer, "Sistema Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.ToString());
            }




        }



        public SistemaDoma()
        {
            InitializeComponent();
            if (rbTarde.Checked == false && rbNoite.Checked == false)
            {
                pbLive.Image = Properties.Resources.live1off;
            }
            else
            {
                pbLive.Image = Properties.Resources.live1;
            }


        }

        public void popularDataGrid()
        {
            try
            {
                //Tabela Boletim
                dgBoletim.DataSource = null;
                adapter = new MySqlDataAdapter("SELECT * FROM usuario WHERE Cod = " + "'" + lblUser.Text + "'", conexao);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgBoletim.DataSource = ds.Tables[0];

                //Tabela Faltas
                dgFaltas.DataSource = null;
                adapter = new MySqlDataAdapter("SELECT Cod, Periodo, Nome, Faltas FROM usuario WHERE Cod = " + "'" + lblUser.Text + "'", conexao);
                DataSet ds2 = new DataSet();
                adapter.Fill(ds2);
                dgFaltas.DataSource = ds2.Tables[0];


            }
            catch (Exception err)
            {

                MessageBox.Show("Query:" + "SELECT * FROM usuario WHERE Cod = '" + lblUser.Text + "' ERRO MySQL: " + err.ToString());
            }
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

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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

        }







        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != txtSenha.Text)
            {
                MessageBox.Show("Senha incorreta! Verifique sua senha e tente novamente.", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Conectar();
            }

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

            Sobre sobre = new Sobre(lblVersao.Text);
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
                pbStatus.Image = Properties.Resources.offline2;
            }
            else if (MapExiste)
            {
                lblStatus.Text = "Status: Conectado!";
                pbStatus.Image = Properties.Resources.online2;
            }
        }





        public void Form1_Load(object sender, EventArgs e)
        {

            string imgWallpaper = @"C:\Windows\Web\Wallpaper\Windows\img0.jpg";

            // verify    
            if (File.Exists(imgWallpaper))
            {

                SetWallpaper(imgWallpaper);//coloca papel de parede padrão
            }



            lblVersao.Text = versaoLocal.ToString();

            //dadosbanco.Server = "localhost";
            dadosbanco.Server = "192.168.15.81";
            dadosbanco.User = "root2";
            dadosbanco.Password = "admin";
            dadosbanco.DataBase = "boletim";


            string server2 = dadosbanco.Server;
            string user = dadosbanco.User;
            string password = dadosbanco.Password;
            string database = dadosbanco.DataBase;

            dadosbanco.conn = "server=" + server2 + " ;user id=" + user + "; password= '" + password + "'; database=" + database + " ;SSL Mode = None";

            //txtServer.Text = db.Server;
            //txtUser.Text = db.User;
            //txtPass.Text = db.Password;
            //txtDatabase.Text = db.DataBase;

            //conexao = new MySqlConnection(dadosbanco.conn);


            conexao = new MySqlConnection("server=" + dadosbanco.Server +
                " ;user id=" + dadosbanco.User + ";" +
                " password= '" + dadosbanco.Password +
                "'; database=" + dadosbanco.DataBase +
                " ;SSL Mode = None");

            //dadosbanco.mysql = new MySqlConnection(dadosbanco.conn);
            //dadosbanco.mysql.Open();
            //dadosbanco.mysql.Close();

            tabPage2.Enabled = false;
            tabPage3.Enabled = false;

            DriveInfo di = new DriveInfo("M");
            bool pronto = di.IsReady;

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



            //if (!pronto)
            //{
            //    lblStatus.Text = "Status: Desconectado";
            //    pbStatus.Image = Properties.Resources.offline;
            //}
            //else
            //{
            //    lblStatus.Text = "Status: Conectado!";
            //    pbStatus.Image = Properties.Resources.online;
            //}

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


        }

        private void rbNoite_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            // Get the subdirectories directly that is under the root.
            // See "How to: Iterate Through a Directory Tree" for an example of how to
            // iterate through an entire tree.
            try
            {
                DriveInfo di = new DriveInfo(@"M:\");
                DirectoryInfo dirInfo = di.RootDirectory;
                DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*.*");

                foreach (DirectoryInfo d in dirInfos)
                {
                    MessageBox.Show(d.Name);

                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("" + erro);
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

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void boletimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriveInfo driverinfo = new DriveInfo("M");
            bool MapExiste = driverinfo.IsReady;

            if (MapExiste)
            {
                Boletim boletim = new Boletim();
                boletim.Show();
            }
            else
            {
                MessageBox.Show("Entre com seu usuário primeiro!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void criarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SenhaCriarUsuario senhacriar = new SenhaCriarUsuario();
            senhacriar.Show();
        }









        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtUsuario.ForeColor = Color.Black;
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtSenha.ForeColor = Color.Black;
        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
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

        private void txtUsuario_Click_1(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtUsuario.ForeColor = Color.Black;
        }

        private void txtSenha_Click_1(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtSenha.ForeColor = Color.Black;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == txtSenha.Text)
            {
                Conectar();
                popularDataGrid();
            }
            else
            {
                MessageBox.Show("Senha Incorreta, Verifique sua senha e tente novamente.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnDesconectar_Click_1(object sender, EventArgs e)
        {
            Desconectar();
        }

        private void imgPasta_Click(object sender, EventArgs e)
        {
            DriveInfo driverinfo = new DriveInfo("M");
            bool MapExiste = driverinfo.IsReady;

            if (MapExiste)
            {
                System.Diagnostics.Process.Start("M:/");
            }
            else
            {
                MessageBox.Show("Entre com seu usuário primeiro!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //popularDataGrid();
        }

        private void rbTarde_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbTarde.Checked)
            {
                pbPeriodo.Image = Properties.Resources.tarde;
                pbLive.Image = Properties.Resources.live1;
            }
        }

        private void rbNoite_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbNoite.Checked)
            {
                pbPeriodo.Image = Properties.Resources.noite;
                pbLive.Image = Properties.Resources.live1;
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://classroom.google.com/h");
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

            if (rbTarde.Checked)
            {
                System.Diagnostics.Process.Start("https://meet.jit.si/tarde");
            }
            else if (rbNoite.Checked)
            {
                System.Diagnostics.Process.Start("https://meet.jit.si/Inform%C3%A1tica");
            }
            else
            {
                MessageBox.Show("Selecione seu periodo primeiro!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/luan-da-costa-oliveira-esp%C3%B3sito-b57705ba/");
        }



        static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            var destino = new DirectoryInfo(destinationDir);
            if (destino.Exists)
            {
                Directory.Delete(destinationDir, true);
                Directory.CreateDirectory("C:\\SistemaDM\\");
                StreamWriter x;
                string ver = "C:\\SistemaDM\\versao.txt";
                x = File.AppendText(ver);
                String versaoServer = File.ReadAllText("\\\\luan\\SistemaLoginDM\\versao.txt"); //leitura servidor
                x.WriteLine(versaoServer);
                x.Close();

            }
            else
            {
                Directory.CreateDirectory("C:\\SistemaDM\\");
                StreamWriter x;
                string ver = "C:\\SistemaDM\\versao.txt";
                x = File.AppendText(ver);
                String versaoServer = File.ReadAllText("\\\\luan\\SistemaLoginDM\\versao.txt"); //leitura servidor
                x.WriteLine(versaoServer);
                x.Close();

            }



            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found // Pasta de origem não encontrada: {dir.FullName}");



            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);

                }
            }
        }

        private void atualizarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarSistema();
            Application.Restart();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void alterarBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AlterarBanco alterarbanco = new AlterarBanco();

            alterarbanco.db = new DadosBanco();



            alterarbanco.db.Server = "localhost";
            alterarbanco.db.User = "root2";
            alterarbanco.db.Password = "admin";
            alterarbanco.db.DataBase = "ABACATE";


            alterarbanco.Show();

        }



        private void button2_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show(dadosbanco.conn.ToString());
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Conectar();
                popularDataGrid();
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            MessageBox.Show(dadosbanco.Server);
        }

        private void dgBoletim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }




    }
}
