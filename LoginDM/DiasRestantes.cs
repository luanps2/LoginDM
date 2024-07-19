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

         public string FinalCurso()
        {
            DateTime selectDate = dateTimePicker1.Value; //ANO , MÊS, DIA)
            TimeSpan diasrestantes = selectDate - DateTime.Now; //ANO , MÊS, DIA)
            return diasrestantes.Days.ToString();
        }

       
        private void DiasRestantes_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            DateTime dataFinal = new DateTime(2024, 12, 27);

            dateTimePicker1.Value = dataFinal;
            label1.Text = "" + FinalCurso();
    
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = FinalCurso();
        }
    }
}
