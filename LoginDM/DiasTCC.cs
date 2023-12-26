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

        public int TCC()
        {
            DateTime diasrestantes = new DateTime(2024, 06, 05); // (ANO, MÊS, DIA)
            return (int)diasrestantes.Subtract(DateTime.Today).TotalDays; 

        }

        private void DiasTCC_Load(object sender, EventArgs e)
        {
            label1.Text = "" + TCC();
        }
    }
}
