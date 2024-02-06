using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class EquationDialog : Form
    {
        public double A;
        public double B;
        public double C;
        public EquationDialog()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            A = double.Parse(textBoxA.Text);
            B = double.Parse(textBoxB.Text);
            C = double.Parse(textBoxC.Text);
        }
    }
}
