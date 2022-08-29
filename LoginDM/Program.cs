using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace LoginDM
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Pega o nome do processo deste programa
            string nomeProcesso = Process.GetCurrentProcess().ProcessName;

            //Busca os processos com este nome que estão em execução
            Process[] processos = Process.GetProcessesByName(nomeProcesso);

            if (processos.Length > 1)
            {
                //Mostra mensagem de erro e finaliza
                MessageBox.Show("Não é possivel abrir duas instânicas do programa. se você já clicou aguarde alguns instantes e o programa será aberto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SistemaDoma());
            }
        }
    }
}
