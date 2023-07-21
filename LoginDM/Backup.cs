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
            //dpAno.Text = DateTime.Now.Year;

            //cbAno.Text = DateTime.Now.Year.ToString();

            ////marca o diretorio a ser listado
            //DirectoryInfo diretorio = new DirectoryInfo(@"\\server\\");

            ////Executa a função GetDirectories(Lista os diretorios de acordo com o parametro)
            //FileInfo[] Arquivos = diretorio.GetFiles("*.*");
            ////string[] allfiles = Directory.GetFiles(@"\\\\server\", "*.*", SearchOption.AllDirectories);

            ////Listar todos os diretórios
            //foreach (FileInfo fileinfo in Arquivos)
            //{
            //    lbxOrigem.Items.Add(fileinfo.Name);
            //}


        }




        private void GetDirOrigem(string rota1)
        {
            var diretorios1 = Directory.GetDirectories(rota1);


            foreach (string dir1 in diretorios1)
            {

                lbxOrigem.Items.Add(dir1);

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

            
            string periodo = rbTarde.Checked ? "Tarde" : "Noite";

           

            try
            {

                string rotaOrigem = @"\\server\" + periodo;
                lbxOrigem.Items.Clear();
                GetDirOrigem(rotaOrigem);


            }
            catch (Exception err)
            {

               
            }

            try
            {
                string rotaDestino = @"\\server\Seagate\Backups2\" + dpAno.Text + "\\" + cbSemestre.Text + "\\" + periodo;
                lbxDestino.Items.Clear();
                GetDirDestino(rotaDestino);
            }
            catch (Exception err2)
            {
               

            }





        }

        class CopyDir
        {

            static int maxbytes = 0;
            static int copied = 0;
            static int total = 0;
            public static void Copy(Label label1, ProgressBar progressBar1, string Origem, string Destino)
            {
                DirectoryInfo diOrigem = new DirectoryInfo(Origem);
                DirectoryInfo diDestino = new DirectoryInfo(Destino);
                GetSize(diOrigem, diDestino);
                maxbytes = maxbytes / 1024;

                progressBar1.Maximum = maxbytes;
                CopyAll(label1, progressBar1, diOrigem, diDestino);
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


        private void button2_Click(object sender, EventArgs e)
        {
            string periodo = "";
            periodo = rbTarde.Checked ? "Tarde" : "Noite";

            string origem = @"\\luan\\SistemaLoginDM\\";
            string destino = @"C:\SistemaLoginDM\";

            string rotaOrigem = @"\\server\\" + periodo + "\\";
            string rotaDestino = @"\\server\\Seagate\\Backups2\\" + dpAno.Text + "\\" + cbSemestre.Text + "\\" + periodo;

            try
            {
                CopyDir.Copy(txtProgresso, progressBar1, rotaOrigem, rotaDestino);
                lbxOrigem.Items.Clear();
                lbxDestino.Items.Clear();
                GetDirOrigem(rotaOrigem);
                GetDirDestino(rotaDestino);
                MessageBox.Show("Backup do diretório" + rotaOrigem + "para" + rotaDestino + "efetuado com sucesso!");
            }
            catch (Exception)
            {

                MessageBox.Show(e.ToString());
            }



            GetDirOrigem(rotaOrigem);
            GetDirDestino(rotaDestino);

            MessageBox.Show("Origem: " + rotaOrigem + "\n" + "Destino" + rotaDestino);


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
    }
}
