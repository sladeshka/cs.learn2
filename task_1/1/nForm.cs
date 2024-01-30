using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class nForm : Form
    {
        private bool nFormClose = false;
        public nForm()
        {
            InitializeComponent();
        }

        private void nForm_Load(object sender, EventArgs e)
        {

        }

        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // if (checkBox1.Checked) return;
            if (nFormClose) return;
            e.Cancel = true;
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nFormClose = true;
            base.Close();
        }
    }
}
