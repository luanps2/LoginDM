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



        
        private void GetDir(string rota1, string rota2)
        {
            var diretorios1 = Directory.GetDirectories(rota1);
            var diretorios2 = Directory.GetDirectories(rota2);

            foreach (string dir1 in diretorios1)
            {
                lbxOrigem.Items.Add(dir1);
                
            }

            foreach (string dir2 in diretorios2)
            {
                lbxDestino.Items.Add(dir2);
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string periodo = "";
            periodo = rbTarde.Checked ? "Tarde" : "Noite";

            string rotaOrigem = @"\\server\" + periodo;
            string rotaDestino = @"\\server\Seagate\Backups\" +  dpAno.Text + "\\" + cbSemestre.Text + "\\" + periodo;

            lbxOrigem.Items.Clear();
            lbxDestino.Items.Clear();
            GetDir(rotaOrigem, rotaDestino);

           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string periodo = "";
            periodo = rbTarde.Checked ? "Tarde" : "Noite";

            string rotaOrigem = @"\\server\" + periodo;
            string rotaDestino = @"\\server\Seagate\Backups\" + dpAno.Text + "\\" + cbSemestre.Text + "\\" + periodo;
            GetDir(rotaOrigem, rotaDestino);
            MessageBox.Show(rotaDestino);
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
