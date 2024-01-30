using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp6
{
    public partial class Form2 : Form
    {
        Form1 form;
        public Form2()
        {
            InitializeComponent();
            form = new Form1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                form.StartPosition = FormStartPosition.Manual;
                form.Show();
                form.Activate();
            }
            catch (Exception)
            {
                Form1 form = new();
                form.StartPosition = FormStartPosition.Manual;
                form.Show();
                form.Activate();
            }
        }
    }
}
