using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGrafSinLine
{
    public partial class Edit : Form
    {
        public double a, b;
        public string DataA
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        public string DataB
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }
        public Edit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                DataA = textBox1.Text;
                DataB = textBox2.Text;
            }
            catch (Exception er)
            {
                MessageBox.Show("При выполнении ввода исходных данных возникла ошибка: \n" + er.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }
    }
}
