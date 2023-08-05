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
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
            //var Periodo = texto;

        }





        private void Backup_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;

            


            int mes = DateTime.Now.Month;

            //mes <= 6 ? cbSemestre.Text = "1º Semestre" : cbSemestre.Text = "2º Semestre";

            if (DateTime.Now.Month <= 6)
            {
                cbSemestre.Text = "1º Semestre";
            }
            else
            {
                cbSemestre.Text = "2º Semestre";
            }

            dpAno.Format = DateTimePickerFormat.Custom;
            dpAno.CustomFormat = "yyyy";
            dpAno.ShowUpDown = true;
      


        }




        private void GetDirOrigem(string rota1)
        {
            var diretorios1 = Directory.GetDirectories(rota1);


            foreach (string dir1 in diretorios1)
            {

                string caminho = dir1;

                caminho = caminho.Remove(0, 15);
                lbxOrigem.Items.Add(caminho);

            }
        }
        private void GetDirDestino(string rota2)
        {

            var diretorios2 = Directory.GetDirectories(rota2);


            foreach (string dir2 in diretorios2)
            {

                lbxDestino.Items.Add(dir2);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {


            string periodo = !rbNoite.Checked ? "Tarde" : "Noite";



            try
            {

                string rotaOrigem = @"\\server\" + periodo;

                lbxOrigem.Items.Clear();
                lbxDestino.Items.Clear();

                GetDirOrigem(rotaOrigem);


            }
            catch (Exception err)
            {
                tbLogs.Text = "Erro 1 ao listar:" + err.ToString();

            }

            try
            {
                string rotaDestino = @"\\server\Seagate\Backups2\" + dpAno.Text + "\\" + cbSemestre.Text + "\\" + periodo;
                lbxDestino.Items.Clear();
                GetDirDestino(rotaDestino);
            }
            catch (Exception err2)
            {
                tbLogs.Text = "Erro 2 ao listar:" + err2.ToString();

            }





        }

        private void CopiarPasta(string dirOrigem, string dirDestino)
        {
            try
            {
                bool DiretorioExiste = Directory.Exists(dirDestino);

                var arquivos = Directory.GetFiles(dirOrigem);

                if (!DiretorioExiste)
                {
                    DirectoryInfo di = Directory.CreateDirectory(dirDestino);
                }
                else
                {
                    foreach (string ArqOrigem in arquivos)
                    {
                        File.Copy(ArqOrigem, dirDestino);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha:" + ex.Message);
            }

        }

        public static void GetSize(DirectoryInfo source, DirectoryInfo target)
        {
            int maxbytes = 0;
            int copied = 0;
            int total = 0;

            foreach (FileInfo fi in source.GetFiles())
            {
                maxbytes = (int)fi.Length;
            }

        }



        class CopyDir
        {

            static int maxbytes = 0;
            static int copied = 0;
            static int total = 0;
            public static void Copy(Label label1, ProgressBar progressBar1, string Origem, string Destino)
            {

                try
                {
                    bool DiretorioExiste = Directory.Exists(Destino);

                    var arquivos = Directory.GetFiles(Destino);

                    if (!DiretorioExiste)
                    {
                        DirectoryInfo di = Directory.CreateDirectory(Destino);
                    }
                    else
                    {
                        DirectoryInfo diOrigem = new DirectoryInfo(Origem);
                        DirectoryInfo diDestino = new DirectoryInfo(Destino);
                        GetSize(diOrigem, diDestino);
                        maxbytes = maxbytes / 1024;

                        progressBar1.Maximum = maxbytes;
                        CopyAll(label1, progressBar1, diOrigem, diDestino);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Falha:" + ex.Message);
                }


               
            }

            public static void CopyAll(Label label1, ProgressBar progressBar1, DirectoryInfo source, DirectoryInfo target)
            {
                Directory.CreateDirectory(target.FullName);
                foreach (FileInfo fi in source.GetFiles())
                {
                    Console.WriteLine(@"Copying {0}/{1}", target.FullName, fi.Name);
                    fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);

                    total += (int)fi.Length;

                    copied += (int)fi.Length;
                    copied /= 1024;
                    progressBar1.Step = copied;
                    progressBar1.PerformStep();

                    label1.Text = (total / 1024).ToString() + "KB de " + maxbytes.ToString() + "KB Copiado";
                    label1.Refresh();
                }

                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                    CopyAll(label1, progressBar1, diSourceSubDir, nextTargetSubDir);
                }
            }

            public static void GetSize(DirectoryInfo source, DirectoryInfo target)
            {
                foreach (FileInfo fi in source.GetFiles())
                {
                    maxbytes = (int)fi.Length;
                }

            }

        }

        static long GetTotalBytes(string path)
        {
            long total = 0;

            foreach (string file in Directory.GetFiles(path))
            {
                total += new FileInfo(file).Length;
            }

            foreach (string subDir in Directory.GetDirectories(path))
            {
                total += GetTotalBytes(subDir);
            }

            return total;
        }

        static void EfetuarBackup(string origem, string destino, ProgressInfo progressInfo)
        {
            if (!Directory.Exists(destino))
            {
                Directory.CreateDirectory(destino);
            }

            // Obtem a quantidade total de bytes a serem copiados
            long totalBytes = GetTotalBytes(destino);

            // Inicializa variáveis para o progresso
            long copiedBytes = 0;
            int progressPercentage = 0;

            foreach (string arquivo in Directory.GetFiles(origem))
            {
                string fileName = Path.GetFileName(arquivo);
                string targetPath = Path.Combine(destino, fileName);
                File.Copy(arquivo, targetPath, true);

                copiedBytes += new FileInfo(targetPath).Length;

                // Calcula o progresso atual
                int newProgressPercentage = (int)((copiedBytes * 100) / totalBytes);

                // Atualiza a ProgressBar se houver mudança significativa no progresso
                if (newProgressPercentage > progressPercentage)
                {
                    progressPercentage = newProgressPercentage;
                    progressInfo.UpdateProgress(totalBytes, copiedBytes);
                }
            }

            foreach (var subDir in Directory.GetDirectories(origem))
            {
                string subDirName = new DirectoryInfo(subDir).Name;
                string targetSubDir = Path.Combine(destino, subDirName);
                EfetuarBackup(subDir, targetSubDir, progressInfo);
            }
        }

        // Atribui a função de atualização do progresso

        public class ProgressInfo
        {
            public ProgressBar ProgressBar { get; set; }
            public Label ProgressLabel { get; set; }

            public ProgressInfo(ProgressBar progressBar, Label progressLabel)
            {
                ProgressBar = progressBar;
                ProgressLabel = progressLabel;
            }

            public void UpdateProgress(long totalBytes, long copiedBytes)
            {
                int progressPercentage = (int)((copiedBytes * 100) / totalBytes);
                ProgressBar.Value = progressPercentage;
                ProgressLabel.Text = $"Progresso: {progressPercentage}%";

                Application.DoEvents();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string periodo = rbNoite.Checked ? "Tarde" : "Noite";

            string rotaOrigem = @"\\server\" + periodo + "\\";
            string rotaDestino = @"\\server\Seagate\Backups2\" + dpAno.Text + "\\" + cbSemestre.Text + "\\" + periodo + "\\";

            // Cria uma instância de ProgressInfo com os controles encontrados
            ProgressInfo progressInfo = new ProgressInfo(progressBar1, txtProgresso);

            EfetuarBackup(rotaOrigem, rotaDestino, progressInfo);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gpPeriodo_Enter(object sender, EventArgs e)
        {
            var buttons = this.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string periodo = !rbTarde.Checked ? "Tarde" : "Noite";
            string rotaOrigem = @"\\server\" + periodo;
            string rotaDestino = @"\\server\Seagate\Backups2\" + dpAno.Text + "\\" + cbSemestre.Text + "\\" + periodo + "\\";

            CopiarPasta(rotaOrigem, rotaDestino);


            //try
            //{

            //    string periodo = rbTarde.Checked ? "Tarde" : "Noite";
            //    string rotaOrigem = @"\\server\" + periodo;
            //    string rotaDestino = @"\\server\\Seagate\\Backups2\\" + dpAno.Text + "\\" + cbSemestre.Text + "\\" + periodo + "\\";

            //    CopyDir.Copy(txtProgresso, progressBar1, rotaOrigem, rotaDestino);

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string periodo = rbTarde.Checked ? "Tarde" : "Noite";
            string rotaOrigem = @"\\server\" + periodo;
            System.Diagnostics.Process.Start(rotaOrigem);
        }

        private void btnAbrirDestino_Click(object sender, EventArgs e)
        {
            string periodo = rbTarde.Checked ? "Tarde" : "Noite";
            string rotaDestino = @"\\server\Seagate\Backups2\" + dpAno.Text + "\\" + cbSemestre.Text + "\\" + periodo + "\\";
            //System.Diagnostics.Process.Start(rotaDestino);
            MessageBox.Show(rotaDestino);

            try
            {
            System.Diagnostics.Process.Start(rotaDestino);

            }
            catch (Exception ex)
            {

                MessageBox.Show("erro: " + ex);
            }
        }
    }
}
