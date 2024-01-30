using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void Circle_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath shape = new();
            shape.AddEllipse(0, 0, 400, 400);
            this.Region = new Region(shape);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
