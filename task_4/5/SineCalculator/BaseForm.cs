using System;
using System.Text;

namespace SineCalculator
{
    public partial class BaseForm : Form
    {
        public List<RangePoint> rangePoints = new List<RangePoint>();
        public BaseForm()
        {
            InitializeComponent();
        }

        private void SetIntervalButton_Click(object sender, EventArgs e)
        {
            SineCalculatorForm sineCalculatorForm = new();
            if (sineCalculatorForm.ShowDialog() != DialogResult.OK)
                return;
            rangePoints = sineCalculatorForm.rangePoints;
            StringBuilder sb = new StringBuilder();
            foreach (RangePoint item in rangePoints)
            {
                sb.Append(item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}