﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
            Form1 frm1 = this.Owner as Form1;
            if (frm1 != null)
            {
                frm1.SolData = s;
            }
            this.Close();
        }
    }
}
