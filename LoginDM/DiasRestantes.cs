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
    public partial class DiasRestantes : Form
    {
        public DiasRestantes()
        {
            InitializeComponent();
        }

         public int FinalCurso()
        {
            DateTime diasrestantes = new DateTime(DateTime.Today.Year, 12, 20);
            return (int)diasrestantes.Subtract(DateTime.Today).TotalDays;
        }

       
        private void DiasRestantes_Load(object sender, EventArgs e)
        {

            label1.Text = "" + FinalCurso();
    
            
        }
    }
}
