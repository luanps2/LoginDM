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
            DateTime diasrestantes = new DateTime(DateTime.Today.Year, 11, 30);
            return (int)diasrestantes.Subtract(DateTime.Today).TotalDays;

        }

        private void DiasTCC_Load(object sender, EventArgs e)
        {
            label1.Text = "" + TCC();
        }
    }
}
