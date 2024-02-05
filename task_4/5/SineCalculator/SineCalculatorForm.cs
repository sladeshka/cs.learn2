using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SineCalculator
{
    public partial class SineCalculatorForm : Form
    {
        public List<RangePoint> rangePoints = new List<RangePoint>();
        public SineCalculatorForm()
        {
            InitializeComponent();
        }
        private void buttonTransferData_Click(object sender, EventArgs e)
        {
            double lowerBound, upperBound;
            if (!double.TryParse(this.txtLowerBound.Text.Replace(".", ","), out lowerBound)) {
                MessageBox.Show("Enter Valid Double Value");
                return;
            }
            if (!double.TryParse(this.txtUpperBound.Text.Replace(".", ","), out upperBound))
            {
                MessageBox.Show("Enter Valid Double Value");
                return;
            }
            for (double i = lowerBound; i < upperBound; i += 0.1)
            {
                double x = Math.Round(lowerBound + (upperBound - lowerBound) * i / (upperBound - 1), 1);
                double y = Math.Round(Math.Sin(x), 1);
                RangePoint point = new(x, y);
                rangePoints.Add(point);
            }
            this.Close();
        }
    }
}
