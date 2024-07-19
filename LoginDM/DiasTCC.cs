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
    public partial class DiasTCC : Form
    {
        public DiasTCC()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

     

        public string TCC()
        {
            DateTime selectDate = dateTimePicker1.Value; //ANO , MÊS, DIA)
            TimeSpan diasrestantes = selectDate - DateTime.Now; //ANO , MÊS, DIA)
            return diasrestantes.Days.ToString();
        }

        private void DiasTCC_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            DateTime dataFinal = new DateTime(2024, 11, 18);

            dateTimePicker1.Value = dataFinal;
            label1.Text = "" + TCC();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = TCC();
        }
    }
}
